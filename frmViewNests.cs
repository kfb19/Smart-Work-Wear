using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Coursework
{
    public partial class frmViewNests : Form
    {
        public int companyID { get; set; } //defines public variables to be used throughout the code 
        public string companyName { get; set; }
        public frmViewNests(int company_ID, string company_name)
        {
            InitializeComponent();
            companyID = company_ID; //sets the passed-in parameters 
            companyName = company_name;
        }

        private void frmViewNests_Load(object sender, EventArgs e) 
        {
            setUpPage();          
        }

        private void setUpPage() //click on a nest ID to see its details & most recent status 
        {
            lblCompanyName.Text = companyName + " Nests"; //sets the page title 

            int i = 0; //defines all required variables 
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT tblNestBirthCertificate.NestID " +
               "FROM (tblCompany INNER JOIN " +
               "tblNestBirthCertificate ON tblCompany.companyID = tblNestBirthCertificate.companyID) " +
               "WHERE (tblCompany.companyID = " + companyID + ")"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the sql string 

            while (dr.Read())
            {
                Button btn = new Button(); //sets up buttons to show each nest 
                btn.BackColor = Color.DarkOrange;
                btn.ForeColor = Color.White;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[0].ToString();
                btn.Name = "btn_ " + i;
                i++;
                btn.Click += btn_Click;
                flpEmployees.Controls.Add(btn);
            }

            dr.Close();
            dbConnector.close();
        }

        void btn_Click(object sender, EventArgs e)
        {
            frmNestStatus nestStatusForm = new frmNestStatus(Convert.ToInt32((sender as Button).Tag)); //opens the nest status form 
            nestStatusForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
