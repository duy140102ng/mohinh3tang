using System.Data;
using System.Data.SqlClient;
using DTO; 
using DAL;
namespace BUS
{
    public class Lop_BUS
    {
        //da xoa comment
        Data da = new Data();
        Lop_DTO L = new Lop_DTO();
        //Hàm lấy thông tin lớp đó ra 1 datagridview
        public DataTable ShowLop()
        {
            string sql = "select * form Lop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLop(string ml, string tl, int ssv)
        {
            string sql = "insert lop values(N'" + ml + "', N'" + ssv + "')";
            //Lệnh thực hiện không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdateLop(string ml, string tl, int ssv)
        {
            string sql = "uodate lop set Tenlop = N'" + tl + "', Sosv = N'" + ssv + "' where Malop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteLop(string ml)
        {
            string sql = " delete lop where Malop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookLop(string dk)
        {
            string sql = "select * from lop where Malop like N%" + dk + "%' OR Tenlop like N%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}