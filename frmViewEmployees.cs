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
    public partial class frmViewEmployees : Form
    {
        public int company_ID { get; set; } //defines public variables to be used throughout the code 
        public string company_name { get; set; }
        public frmViewEmployees(int companyID, string companyName)
        {
            InitializeComponent();
            company_ID = companyID; //sets the passed-in parameters 
            company_name = companyName;
        }

        private void frmViewEmployees_Load(object sender, EventArgs e) 
        {
            setUpPage();           
        }

        private void setUpPage() //uses dynamic controls to view the names and ID's of all employees 
        {
            lblCompanyName.Text = company_name + " Employees"; //sets the title of the page 

            int i = 0; //defines all the required variables 
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT tblUser.email, tblUser.firstName, tblUser.surname " +
               "FROM (tblCompany INNER JOIN " +
               "tblUser ON tblCompany.companyID = tblUser.companyID) " +
               "WHERE (tblCompany.companyID = " + company_ID + ")"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                Button btn = new Button(); //sets up a button for each user 
                btn.BackColor = Color.DarkOrange;
                btn.ForeColor = Color.White;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[1].ToString() + " " + dr[2].ToString();
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
            frmUserDetails userDetailsForm = new frmUserDetails((sender as Button).Tag.ToString()); //loads the User Details form 
            userDetailsForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
