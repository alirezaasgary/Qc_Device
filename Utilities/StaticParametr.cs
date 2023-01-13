using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qc_Lab.Utilities
{
    public class StaticParametr
    {
        public static string UserName;
        public static string testsPName1 = "spPaging";
       
        //public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =D:\Qc_LabProject\Qc_Lab\bin\Debug\test_4.accdb;Persist Security Info=False";
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\test_4.accdb;Persist Security Info=False";
        public static int UserId = 3;
        //Data Source = ..\..\..\DataFolder\SparesDatabase.accdb
    }
}
