namespace MaskON
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data;
    using System.Windows.Forms;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Datum> Data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\MaskOn_Database.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        private string data1 = "";
        private string data2= "";
        private int sum1;
        private int sum2;
        private int total1;
        private int total2;
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public DataTable ReadData()
        {
            DataTable table = new DataTable();
            openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT N95, Surgery, Lokasi FROM Data", connection);
            adapter.Fill(table);
            return table;
        }

        public void UpdateN95(int donate, string lokasi)
        {
            SqlCommand get = new SqlCommand("SELECT N95 FROM Data WHERE Lokasi=@lokasi", connection);
            get.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            using (SqlDataReader reader = get.ExecuteReader())
            {
                while (reader.Read())
                {
                    data1 = reader["N95"].ToString();
                }
            }
            sum1 = Convert.ToInt32(data1);
            total1 = sum1 - donate;
            SqlCommand update = new SqlCommand("UPDATE Data SET N95 = @jumlah WHERE Lokasi=@lokasi", connection);
            update.Parameters.Add("@jumlah", SqlDbType.Int).Value = total1;
            update.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            update.ExecuteNonQuery();
            closeConnection();
        }

        public void UpdateSurgery(int donate, string lokasi)
        {
            SqlCommand get = new SqlCommand("SELECT Surgery FROM Data WHERE Lokasi=@lokasi", connection);
            get.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            using (SqlDataReader reader = get.ExecuteReader())
            {
                while (reader.Read())
                {
                    data2 = reader["Surgery"].ToString();
                }
            }
            sum2 = Convert.ToInt32(data2);
            total2 = sum2 - donate;
            SqlCommand update = new SqlCommand("UPDATE Data SET Surgery = @jumlah WHERE Lokasi=@lokasi", connection);
            update.Parameters.Add("@jumlah", SqlDbType.Int).Value = total2;
            update.Parameters.Add("@lokasi", SqlDbType.NVarChar).Value = lokasi;
            openConnection();
            update.ExecuteNonQuery();
            closeConnection();
        }
    }
}
