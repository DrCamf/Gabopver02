using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;
using System.Data;


namespace Gabopver02
{
    public class DbConn
    {
       
        string connectionString = @"Data Source= SDE-02364; Initial Catalog= Gabop_DATA;Integrated Security=true;";



        public SqlConnection cnn;

        public DbConn()
        {
           cnn = new SqlConnection(connectionString);
           
        }

        public void DBObO() {
            cnn.Open();
        }

        public void DbObC()
        {

            cnn.Close();
        }

        public void DbSql(string sqlQuery_)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery_, cnn);
            cmd.ExecuteNonQuery();
            
        }

        public void DbSqlInd(string sqlQuery_)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sqlQuery_, cnn);
            adapter.InsertCommand = new SqlCommand(sqlQuery_, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

        }

        public void DbsqlDisp()
        {
            
        }

        public SqlDataReader DbReader(string sqlQuery_)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery_, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public object DbSdIgView(string sqlQuery_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(sqlQuery_, cnn);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
