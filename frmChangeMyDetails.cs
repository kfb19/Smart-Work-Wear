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
    public partial class frmChangeMyDetails : Form
    {
        public string email { get; set; } //defines a public variable 
        public frmChangeMyDetails(string user_email)
        {
            InitializeComponent();
            email = user_email; //sets the email that has been passed into the form as a parameter 
        }

        private void frmChangeMyDetails_Load(object sender, EventArgs e)
        {
            setUpPage(); //calls the setUpPage function 
        }

        private void setUpPage() //sets the text boxes to what the user's current details are 
        {
            clsDBConnector dbConnector = new clsDBConnector(); //defines the required variables 
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();

            sqlStr = "SELECT [password], firstName, surname, dateOfBirth, nestID, postcode, houseName " +
               "FROM tblUser " +
               "WHERE (email = '" + email + "')"; //writes the SQL string
            
            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                txtPassword.Text = dr[0].ToString(); //sets the text boxes as required 
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

        private void btnSaveChanges_Click(object sender, EventArgs e) //when the 'Save Changes' button is clicked, this updates the database for any information that's been changed 
        {
            clsDBConnector dbConnector = new clsDBConnector(); //defines required variables 
            OleDbDataReader dr; 
            string sqlStr;
            string newFirstName, newSurname, newHouseNameNo, newPostcode, newPassword;
            int newNestNo;
            DateTime newDOB;

            newFirstName = txtFirstName.Text; //sets required variables 
            newSurname = txtSurname.Text;
            newHouseNameNo = txtHouseNo.Text;
            newPostcode = txtPostcode.Text;
            newPassword = txtPassword.Text;
            newNestNo = Convert.ToInt32(nudNestID.Value);
            newDOB = dtpDOB.Value;

            dbConnector.Connect();
            sqlStr = "UPDATE tblUser " +
               "SET [password] = '" + newPassword + "', firstName = '" + newFirstName + "', surname = '" + newSurname + "', dateOfBirth = '" + newDOB + 
               "', nestID = " + newNestNo + ", postcode = '" + newPostcode + "', houseName = '" + newHouseNameNo + "'" +
               " WHERE (tblUser.email = '" + email + "')";  //writes the SQL string 
            dr = dbConnector.DoSQL(sqlStr); //executes the SQL 
            dr.Close();
            dbConnector.close();

            MessageBox.Show("Changes made."); //alerts the user that the changes have been made 
            this.Close(); //closes the form to avoid trying to make the same changes twice 
        }
    }
}
