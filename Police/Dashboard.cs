using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Police
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountOfficers();
            CountCases();
            CountCriminals();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountOfficers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PoliceTable", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OffLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountCases()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from CaseTable", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CaseLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountCriminals()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from CriminalTable", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CriminalLbl.Text = dt.Rows[0][0].ToString();
            CrLbl.Text = dt.Rows[0][0].ToString() + " Arrested";
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Polices Obj = new Polices();
            Obj.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Criminals Obj = new Criminals();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Cases Obj = new Cases();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Charges Obj = new Charges();
            Obj.Show();
            this.Hide();
        }
    }
}
