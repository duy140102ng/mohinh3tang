using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=LAPTOP-3EGD2A3H\SQLEXPRESS;Integrated Security=True");
        }
        //lệnh sql trả về 1 bảng
        public DataTable GetTable(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}