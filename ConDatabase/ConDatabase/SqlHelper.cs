using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConDatabase
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        
        private string connString = "Data Source=.;Initial Catalog=DemoDatabase;Integrated Security=True;Pooling=False";

        public SqlHelper()
        {
            sqlConnection = new SqlConnection(connString);
            if(sqlConnection.State==System.Data.ConnectionState.Closed)
               sqlConnection.Open();//create connection to the DB

            Console.WriteLine("Connection is Open");
        }
       
        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
            return sqlCommand.ExecuteReader();
        }
        public string ExecuteScalar(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandText = sqlQuery;
            //sqlCommand.Connection = sqlConnection;
            return sqlCommand.ExecuteScalar().ToString();
        }
        public bool ExecuteNonQuery(string sqlQuery)
        {
            var result = false;
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }
        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery,connString);
            sqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];
        }
        public void update(string sqlQuery,int student_id,string name)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(sqlQuery, connString);
            SqlCommandBuilder sb = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(ds, "student");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = student_id;
            dt.Rows[0][1] = name;
            sqlDataAdapter.Update(dt);
        }

    }
}
