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
    public partial class frmAddUser : Form
    {
        public string password { get; set; } //sets some public variables to be used throughout the code 
        public int company_ID { get; set; }
        public int user_type_ID { get; set; }
        public frmAddUser(int companyID, string defaultPassword, int userType)
        {
            InitializeComponent();
            company_ID = companyID; //sets the variables that have been passed into the form as parameters 
            password = defaultPassword;
            user_type_ID = userType;
        }

        private void btnAddUSer_Click(object sender, EventArgs e) //when the 'Add User' button is clicked 
        {
            string email, firstName, surname, houseNameNo, postcode; //defines the required variables 
            int nestID, companyID;
            clsDBConnector dbConnector = new clsDBConnector();
            DateTime dateOfBirth, dateJoined;

            if (txtEmail.Text != "" && txtFirstName.Text != "" && txtSurname.Text != "" && txtHouseNo.Text != "" && txtPostcode.Text != "" && nudNestID.Value != 0) //makes sure nothing is null 
            {
                email = txtEmail.Text; //sets all the variables to the required values 
                firstName = txtFirstName.Text; 
                surname = txtSurname.Text;
                houseNameNo = txtHouseNo.Text;
                postcode = txtPostcode.Text;
                nestID = Convert.ToInt32(nudNestID.Value); 
                dateOfBirth = dtpDOB.Value;
                companyID = company_ID;
                dateJoined = DateTime.Now;
                
                string sqlStr = "INSERT INTO tblUser (email, [password], firstName, surname, companyID, dateOfBirth, nestID, postcode, houseName, dateJoined, userTypeID) " +
                        "VALUES ('" + email + "' , '" + password + "', '" + firstName + "', '" + surname + "', " + 
                        companyID + ", '" + dateOfBirth + "', " + nestID + ", '" + postcode + "', '" + houseNameNo + "', '" + dateJoined + "', " + user_type_ID + ")"; //this writes the SQL string 
                dbConnector.Connect();
                dbConnector.DoDML(sqlStr); //this executes the SQL string 
                dbConnector.close();

                MessageBox.Show("New user added."); //alters the user that it has been successful 
                this.Close(); //closes at the end to avoide adding the same person twice. 
            }

            else
            {
                MessageBox.Show("Please fill in all the sections."); //throws an error message if not all sections are completed 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
