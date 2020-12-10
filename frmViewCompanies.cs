using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Coursework
{
    public partial class frmViewCompanies : Form
    {
        public frmViewCompanies()
        {
            InitializeComponent();
        }

        private void frmViewCompanies_Load(object sender, EventArgs e)
        {
            setUpPage();
        }

        private void setUpPage()
        {            
            int i = 0; //defines all required variables 
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT companyID, companyName " +
               "FROM tblCompany "; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                Button btn = new Button(); //creates a button for each company 
                btn.BackColor = Color.DarkOrange;
                btn.ForeColor = Color.White;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[1].ToString(); ;
                btn.Name = "btn_ " + i;
                i++;
                btn.Click += btn_Click;
                flpCompanies.Controls.Add(btn);
            }

            dr.Close();
            dbConnector.close();
        }

        void btn_Click(object sender, EventArgs e)
        {
            frmSuperuserViewCompanies superuserViewCompaniesForm = new frmSuperuserViewCompanies(Convert.ToInt32((sender as Button).Tag), (sender as Button).Text); //loads the superuser page 
            superuserViewCompaniesForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
