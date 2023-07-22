using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SmartPOS.Classes
{
    public class Helper
    {

        public static Byte[] ImageToByte(Image img)
        {
            Byte[] bResult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                bResult = ms.ToArray();

            }
            return bResult;
        }

        public static Image ByteToImage(object bObj)
        {
            Byte[] myImg = (Byte[])bObj;
            Image image = null;
            using(MemoryStream ms = new MemoryStream(myImg, 0,myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }
            return image;
        }

        public static string getComboItemVal(ComboBox combo, string key)
        {
            string x = string.Empty;
            foreach(var item in combo.Items)
            {
                comboItem cItem = (comboItem)item;
                if (cItem.Id == key)
                {
                    x = cItem.DES;
                }

            }
            return x;
        }

        public static void fillComboBox(ComboBox combo, string selectTxt)
        {
            SqlCommand sqlcm = new SqlCommand(selectTxt, adoClass.sqlCn);
            SqlDataReader reader = null;
            try
            {
                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                combo.Items.Clear();
                reader = sqlcm.ExecuteReader();
                while (reader.Read())
                {
                    comboItem item = new comboItem(
                        reader[0].ToString(),
                        reader[1].ToString());
                    combo.Items.Add(item);
                }
                combo.Items.Add(new comboItem("", ""));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCn.Close();
            }
        }


        public static void loadPermissions(Control.ControlCollection controls, string mainScreen)
        {
            foreach (Control control in controls)
            {
                modelPermission model = declerations.permissions.Where(x => x.mainScreen == mainScreen &&
                                                                            x.permission == control.AccessibleName).FirstOrDefault();
                if (model != null)
                {
                    control.Enabled = model.theCase;
                }
                if (control.Controls.Count > 0)
                {
                    loadPermissions(control.Controls, mainScreen);
                }
            }
        }
    }
}
