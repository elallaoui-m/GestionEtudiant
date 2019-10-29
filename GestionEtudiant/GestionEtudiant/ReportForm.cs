using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class ReportForm : Form
    {
        String connectionString = "Server = localhost\\SQLEXPRESS; Database = gestion_etudiant ; Integrated Security = True;";
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader myReader;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AllStudents cr = new AllStudents();
            string sql = "SELECT * FROM Etudiant ";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);

            adapter.Fill(ds, "Etudiant");
            DataTable dt = ds.Tables["Etudiant"];

            cr.SetDataSource(ds.Tables["Etudiant"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
