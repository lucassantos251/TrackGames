using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackGames
{
    internal class StringDB
    {
        private static string stringDB = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";

        public static string GetDB()
        {
            return stringDB;
        }

        public static void SetDB(string newDB)
        {
            if (stringDB != newDB && newDB != null && newDB != "")
            {
                stringDB = newDB;
            }
        }
    }
}
