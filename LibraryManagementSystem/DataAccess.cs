﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    static class DataAccess
    {
        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private static SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        static DataAccess()
        {
            Sqlcon = new SqlConnection("Data Source=DESKTOP-LEQ6NJC\\SQLEXPRESS;Initial Catalog='Library Information';Persist Security Info=True;User ID=sa;Password=zahid123");
            Sqlcon.Open();
        }
        private static void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            try
            {
                QueryText(sql);
                Sda = new SqlDataAdapter(Sqlcom);
                Ds = new DataSet();
                Sda.Fill(Ds);
                return Ds;
            }
            catch(Exception exc)
            {
                return null;
            }
        }

        public static DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                QueryText(sql);
                Sda = new SqlDataAdapter(Sqlcom);
                Ds = new DataSet();
                Sda.Fill(Ds);
                return Ds.Tables[0];
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public static int ExecuteUpdateQuery(string sql)
        {
                QueryText(sql);
                int u = Sqlcom.ExecuteNonQuery();
                return u;
           
        }
    }
}
