using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace GU_DR_CSHRP
{
    class dbConn
    {
        public OleDbCommand cmdGU;
        public OleDbDataReader cmdDR;
        private string dbLocation = "E:\\Ruben\\Programming\\VS Programs\\GUDR\\DB_GUDR.accdb";
        private OleDbConnection connGUDR;

        public bool conn2DB()

        {
            connGUDR = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbLocation + ";");

            if (connGUDR.State == System.Data.ConnectionState.Closed)
            {
                cmdGU = new OleDbCommand();
                cmdGU.Connection = connGUDR;
                connGUDR.Open();

                return true;
            }
            return false;
        }

        public List<Category> ReadandReturnCat(string sql)
        {
            List<Category> returnList = new List<Category>();

            cmdGU.CommandText = sql;
            cmdDR = cmdGU.ExecuteReader();

            while(cmdDR.Read())
            {
                Category item = new Category();

                item.setCatKey(cmdDR.GetInt16(0));
                item.setCatName(cmdDR.GetString(1));

                Category.increaseCatRowCount();
                returnList.Add(item);
            }
            cmdDR.Close();

            return returnList;
        }
        
        public List<SubCategory> ReadAndReturnSubcat(string sql, Category CAT)
        {
            List<SubCategory> returnList = new List<SubCategory>();

            cmdGU.CommandText = sql;
            cmdDR = cmdGU.ExecuteReader();

            while(cmdDR.Read())
            {
                SubCategory item = new SubCategory();

                item.setSubCatKey(CAT.getCatKey());
                item.setCatName(CAT.getCatName());
                item.setSubCatKey(cmdDR.GetInt16(0));
                item.setSubCatName(cmdDR.GetString(1));

                returnList.Add(item);

            }
            cmdDR.Close();

            return returnList;

        }
        public Dictionary<int, string> ReadAndReturnKeyVal(string sql)
        {
            Dictionary<int, string> keyValList = new Dictionary<int, string>();

            cmdGU.CommandText = sql;

            cmdDR = cmdGU.ExecuteReader();

            while(cmdDR.Read())
            {
                keyValList.Add(cmdDR.GetInt32(0), cmdDR.GetString(1));
            }
            cmdDR.Close();

            return keyValList;
        }

        public void closeDB()
        {
            if (connGUDR.State == System.Data.ConnectionState.Open)
            {
                connGUDR.Close();
            }
        }

    }
}
