using System.Data.SqlClient;
using System.Data;
using System.Web.Http;

namespace reyes.sql
{
    public partial class sql : ApiController
    {
        sqlconecction conn = new sqlconecction("Data Source=KENDRY\\SQLEXPRESS;Initial Catalog=MantEquipos;Integrated Security=True");

        public sql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarData();
        }
        private void cargarData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from WebDB",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSourse = dt;
        }
    }
}