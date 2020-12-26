using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace prt2.AppCode
{
    public class EmpData
    {
        String strCon = "Data Source=(localdb)\\ProjectV13;Inital" +
            "Catalog=MyDB;Integrated Security=true";

        public DataSet GetEmployee()
        {
            DataSet dataSet = new DataSet();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = "Select * FROM Employee";

            //  SqlAdapter를 초기화 하기
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dataSet);

            conn.Close();
            return dataSet;
        }
    }
}