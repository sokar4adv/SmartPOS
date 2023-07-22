using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS.Classes
{
    public class comboItem
    {
        public comboItem(string _id, string _DES)
        {
            Id = _id;
            DES = _DES;
        }

        public string Id { get; set; }
        public string DES { get; set; }

        public override string ToString()
        {
            return DES;
        }


    }
}
