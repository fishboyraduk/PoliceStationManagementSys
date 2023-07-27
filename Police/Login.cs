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

namespace Police
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\PoliceStationDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string OffName;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role!");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                //Admin Selected
                if (UsernameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name And Password!");
                }
                else if (UsernameTb.Text == "Admin" && PasswordTb.Text == "Password")
                {
                    Criminals Obj = new Criminals();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin Name Or Password!");
                    UsernameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
            else
            {
                //Officer Selected
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PoliceTable where EmpName='" + UsernameTb.Text + "' and EmpPas='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    OffName = UsernameTb.Text;
                    Criminals Obj = new Criminals();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Officer Name Or Password!");
                    UsernameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
