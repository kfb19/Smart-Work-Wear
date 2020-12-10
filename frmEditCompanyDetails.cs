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
    public partial class frmEditCompanyDetails : Form
    {
        public int companyID { get; set; } //defines a public variable 

        public frmEditCompanyDetails(int company_ID)
        {
            InitializeComponent();
            companyID = company_ID; //sets the public varibale to the parameter that has been passed through 
        }

        private void frmEditCompanyDetails_Load(object sender, EventArgs e)
        {
            setUpPage(); //calls the setUpPage function          
        }

        private void setUpPage()
        {
            clsDBConnector dbConnector = new clsDBConnector(); //sets the text boxes to what the company's current details are 
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "SELECT companyName, hqPostcode, defaultPassword, companyEmail, companyPassword " +
               "FROM tblCompany " +
               "WHERE (companyID = " + companyID + ")"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                txtCompanyName.Text = dr[0].ToString(); //sets the variables to what they need to be 
                txtPostcode.Text = dr[1].ToString();
                txtDefaultPassword.Text = dr[2].ToString();
                txtCompanyEmail.Text = dr[3].ToString();
                txtPassword.Text = dr[4].ToString();
            }

            dr.Close();
            dbConnector.close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) //when the 'Save Changes' button is clicked, it updates the database for any information that's been changed 
        {
            clsDBConnector dbConnector = new clsDBConnector(); //defines any variables needed 
            OleDbDataReader dr;
            string sqlStr;
            string newCompanyName, newPostcode, newDefaultPassword, newCompanyEmail, newPassword;

            newCompanyName = txtCompanyName.Text; //sets the variables as required 
            newPostcode = txtPostcode.Text;
            newDefaultPassword = txtDefaultPassword.Text;
            newCompanyEmail = txtCompanyEmail.Text;
            newPassword = txtPassword.Text;

            dbConnector.Connect();

            sqlStr = "UPDATE tblCompany " +
               "SET companyName = '" + newCompanyName + "', hqPostcode = '" + newPostcode + "', defaultPassword = '" + newDefaultPassword + "', companyEmail = '" + newCompanyEmail + "', companyPassword = '" + newPassword + "'" +
               " WHERE (tblCompany.CompanyID = " + companyID + ")"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            dr.Close();
            dbConnector.close();

            MessageBox.Show("Changes made."); //alerts the user of any changes made 
            this.Close(); //closes the form so no accidental changes can be made 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
