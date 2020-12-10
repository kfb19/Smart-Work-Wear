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
    public partial class frmEditUserDetails : Form
    {
        public string email { get; set; } //defines a public variable 
        public frmEditUserDetails(string user_email) 
        {      
            InitializeComponent();
            email = user_email; //sets the email to the passed-in parameter 
        }

        private void frmEditUserDetails_Load(object sender, EventArgs e) 
        {
            setUpPage();
        }

        private void setUpPage()
        {
            clsDBConnector dbConnector = new clsDBConnector(); //sets any variables needed 
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT [password], firstName, surname, dateOfBirth, nestID, postcode, houseName " +
               "FROM tblUser " +
               "WHERE (email = '" + email + "')"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL 

            while (dr.Read())
            {
                txtEmail.Text = email; //sets the text box values as required 
                txtPassword.Text = dr[0].ToString();
                txtFirstName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                dtpDOB.Value = Convert.ToDateTime(dr[3]);
                nudNestID.Value = Convert.ToInt32(dr[4]);
                txtPostcode.Text = dr[5].ToString();
                txtHouseNo.Text = dr[6].ToString();
            }

            dr.Close();
            dbConnector.close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector(); //defines any variables that are needed 
            OleDbDataReader dr;
            string sqlStr;
            string newEmail, newFirstName, newSurname, newHouseNameNo, newPostcode, newPassword;
            int newNestNo;
            DateTime newDOB;

            newEmail = txtEmail.Text; //sets the varibales to the required values 
            newFirstName = txtFirstName.Text;
            newSurname = txtSurname.Text;
            newHouseNameNo = txtHouseNo.Text;
            newPostcode = txtPostcode.Text;
            newPassword = txtPassword.Text;
            newNestNo = Convert.ToInt32(nudNestID.Value);
            newDOB = dtpDOB.Value;

            dbConnector.Connect();

            sqlStr = "UPDATE tblUser " +
               "SET email = '" + newEmail + "', [password] = '" + newPassword + "', firstName = '" + newFirstName + "', surname = '" + newSurname + "', dateOfBirth = '" + newDOB + "', nestID = " + newNestNo + ", postcode = '" + newPostcode + "', houseName = '" + newHouseNameNo + "'" +
               " WHERE (tblUser.email = '" + email + "')"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            dr.Close();
            dbConnector.close();

            MessageBox.Show("Changes made."); //alerts the user that the changes have been made 
            this.Close(); //closes the form once changes are made 
        }
    }
}
