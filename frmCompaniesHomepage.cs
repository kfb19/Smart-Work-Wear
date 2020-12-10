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
    public partial class frmCompaniesHomepage : Form
    {
        public int company_ID { get; set; } //defines a collection of variables so that they can be used throughout the code 
        public string company_name { get; set; }
        public string default_password { get; set; }
        public string company_email { get; set; }
        public frmCompaniesHomepage(string companyEmail)
        {
            InitializeComponent();
            company_email = companyEmail; //sets the variable to the value of the passed-in parameter 
           
        }

        private void frmCompaniesHomepage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //enables the two timers 
            timer2.Enabled = true;
            setUpPage(); //calls the setUpPage function      
        }

        private void setUpPage()
        {
            clsDBConnector dbConnector = new clsDBConnector(); //finds all they relevant information needed about the company 
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "SELECT companyID, companyName, defaultPassword " +
               "FROM tblCompany " +
               "WHERE (companyEmail = '" + company_email + "')"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                company_ID = Convert.ToInt32(dr[0]); //sets the required variables 
                company_name = dr[1].ToString();
                default_password = dr[2].ToString();
            }

            dr.Close();
            dbConnector.close();

            lblCompanyName.Text = company_name; //sets the page up 
            lblLoggedInTime.Text = "Logged in at " + Convert.ToString(DateTime.Now);
            lblOnlineTime.Text = "0";
        }     

        private void tsViewEmployees_Click(object sender, EventArgs e) //opens the form that shows a list of that company's employees 
        {
            frmViewEmployees viewEmployeesForm = new frmViewEmployees(company_ID, company_name);
            viewEmployeesForm.Show();
        }

        private void tsViewStatistics_Click(object sender, EventArgs e) //shows a form with the company statistics 
        {
            frmCompanyStatistics companyStatisticsForm = new frmCompanyStatistics(company_ID);
            companyStatisticsForm.Show();
        }

        private void tsAddEmployees_Click(object sender, EventArgs e) //allows the company to add an employee to their system 
        {
            frmAddUser addUserForm = new frmAddUser(company_ID, default_password, 2); //companies can only add basic users 
            addUserForm.Show();
        }

        private void tsEditEmployees_Click(object sender, EventArgs e) //allows the company to edit/delete their employees 
        {
            frmEditEmployees editEmployeesForm = new frmEditEmployees("Argo", 3); //doesn't work 
            editEmployeesForm.Show();
        }

        private void tsChangeDetails_Click(object sender, EventArgs e) //allows the company to edit their own details 
        {
            frmEditCompanyDetails editCompanyDetailsForm = new frmEditCompanyDetails(company_ID);
            editCompanyDetailsForm.Show();
        }

        private void tsLogOut_Click(object sender, EventArgs e) //lets the company log out 
        {
            if (MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); //closes the form 
            }
        }     

        private void tsAddNest_Click(object sender, EventArgs e) //lets the company add a new nest 
        {
            frmAddNest addNestForm = new frmAddNest(company_ID);
            addNestForm.Show();
        }

        private void tsViewNests_Click(object sender, EventArgs e) //lets the company view all their nests 
        {
            frmViewNests viewNestsForm = new frmViewNests(company_ID, company_name);
            viewNestsForm.Show();
        }
        private void tsDeleteUser_Click(object sender, EventArgs e) //lets the company delete one of their users 
        {
            frmDeleteUser deleteUserForm = new frmDeleteUser(company_name, company_ID);
            deleteUserForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(DateTime.Now); //displays the current date and time 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int counter = Convert.ToInt32(lblOnlineTime.Text); //works out the amount of minutes the user has been online for 
            counter = counter + 1;
            lblOnlineTime.Text = counter.ToString();
        }

       
    }
}
