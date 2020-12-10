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
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
        }

        private void btnAddCompany_Click(object sender, EventArgs e) //when the add company button is clicked 
        {
            string companyName, postcode, default_password, company_email, company_password; //sets all the variables needed 
            clsDBConnector dbConnector = new clsDBConnector();

            if (txtCompanyName.Text != "" && txtPostcode.Text != "" && txtDefaultPassword.Text != "" && txtPassword.Text != "" && txtCompanyEmail.Text != "") //makes sure nothing is null 
            {
                companyName = txtCompanyName.Text; //sets all the variables to the chosen values 
                postcode = txtPostcode.Text; 
                default_password = txtDefaultPassword.Text;
                company_email = txtCompanyEmail.Text;
                company_password = txtPassword.Text;

                string sqlStr = "INSERT INTO tblCompany (hqPostcode, companyName, [defaultPassword], companyEmail, companyPassword) " +
                        "VALUES ('" + postcode + "' , '" + companyName + "', '" + default_password  + "', '" + company_email + "', '" + company_password + "')"; //this is the SQL code required 
                dbConnector.Connect();
                dbConnector.DoDML(sqlStr); //completes the SQL statement 
                dbConnector.close();

                MessageBox.Show("New company added."); //alerts the user that it has been successful 
                this.Close(); //closes at the end to avoid adding the same company twice
            }

            else
            {
                MessageBox.Show("Please fill in all fields."); //throws an error message if not all sections are completed 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
