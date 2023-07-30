using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS.Classes
{
    public static class declerations
    {

        public static int userId;
        public static string userFullName;
        public static Dictionary<string, object> systemOptions;
        public static List<modelPermission> permissions;
    }

    public class modelPermission
    {
        public string mainScreen { get; set; }
        public string permission { get; set; }
        public bool theCase { get; set;  }
    }
}
