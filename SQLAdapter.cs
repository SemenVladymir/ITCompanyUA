using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyUA
{
    internal class SQLAdapter
    {
        readonly string strConn;


        public SQLAdapter(string strConn)
        {
            this.strConn = strConn;

        }

        public DataTable GetSQLDataTable(string SQLTableName)
        {
            string sql = $@"SELECT * FROM [{SQLTableName}]";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, strConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable userTable = ds.Tables[0];
                return userTable;
            }
        }

        public List <ITCompanies> GetITCompanies ()
        {
            List <ITCompanies> list = new List <ITCompanies>();
            DataTable newTable = GetSQLDataTable("Companies");
            foreach (DataRow item in newTable.Rows)
            {
                list.Add(new ITCompanies(item.ItemArray[1].ToString(), Convert.ToInt32(item.ItemArray[2]), item.ItemArray[3].ToString(), item.ItemArray[4].ToString()));
            }
            return list;
        }

        //public void SetSQLDataNewRow(string SQLTableName, ITCompanies company)
        //{
        //    using (SqlConnection conn = new SqlConnection(strConn))
        //    {
        //        conn.Open();
        //        DataTable someTable = GetSQLDataTable(SQLTableName);
        //        DataRow newRow = someTable.NewRow();
        //        newRow["Name"] = company.Name;
        //        newRow["Employees"] = company.Employees;
        //        newRow["Cities"] = company.Cities;
        //        newRow["Lider"] = company.Lider;
        //        someTable.Rows.Add(newRow);
        //        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
        //        adapter.Update(ds);
        //    }
        //}
    }
}
