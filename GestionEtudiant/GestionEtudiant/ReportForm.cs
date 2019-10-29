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
        String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["gestion_etudiantConnectionString"].ToString();


        public ReportForm()
        {
            InitializeComponent();
        }



        private void CrystalReportViewer1_Load(object sender, EventArgs e)
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
    }
}
