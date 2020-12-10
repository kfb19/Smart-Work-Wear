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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) 
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }

        private void btnLogin_Click(object sender, EventArgs e) //when the 'Login' button is clicked 
        {
            string input_email, input_password; //declares all variables needed 
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr, drCompany;
            string sqlStr; 

            bool loggedin = false; //this is to decide whether the user has or hasn't logged in so it knows whether to display an error message or not 

            input_email = txtEmail.Text; //takes the user inputs      
            input_password = txtPassword.Text;     
            
            dbConnector.Connect();

            if (rbSuperuser.Checked == true || rbUser.Checked == true) //works out the type of user logging in 
            {
                sqlStr = "SELECT email, [password], userTypeID FROM tblUser"; //states the sql statement

                dr = dbConnector.DoSQL(sqlStr);//executes the SQL statement 

                while (dr.Read())
                {
                    if (input_email == dr[0].ToString() && input_password == dr[1].ToString()) //checks to see if the login credentials are correct 
                    {
                        loggedin = true;
                        int userType = Convert.ToInt32(dr[2].ToString());

                        if (userType == 1) //opens the superuser homepage 
                        {
                            frmSuperuserHomepage superuserHomepageForm = new frmSuperuserHomepage(input_email);
                            superuserHomepageForm.Show();
                        }

                        else if (userType == 2) //opens the ordinary user homepage 
                        {
                            frmUserHomepage userHomepageForm = new frmUserHomepage(input_email);
                            userHomepageForm.Show();
                        }

                        this.Close();
                    }
                }

                dr.Close();
                dbConnector.close();
            }

            else if (rbCompany.Checked == true) 
            {
                sqlStr = "SELECT companyEmail, companyPassword FROM tblCompany"; //states the sql statement

                drCompany = dbConnector.DoSQL(sqlStr); //executes the SQL statement 

                while (drCompany.Read())
                {
                    if (input_email == drCompany[0].ToString() && input_password == drCompany[1].ToString()) //checks to see if the login credentials are correct 
                    {
                        loggedin = true;

                        frmCompaniesHomepage companyHomepageForm = new frmCompaniesHomepage(input_email); //opens the companies homepage 
                        companyHomepageForm.Show();

                        this.Close();
                    }
                }
            }

            if (!loggedin) //if they have not been logged in, an error message will show in the form of a message box 
            {
                MessageBox.Show("Email, password or user type is incorrect. Please try again.");
                txtEmail.Clear();
                txtPassword.Clear();
            }
            
           dbConnector.close();
        }

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            rbUser.Checked = true; //so a radio button is already selected as default (one HAS to be selected) 
        }
    }
}
