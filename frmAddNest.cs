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
    public partial class frmAddNest : Form
    {
        public int companyID { get; set; } //sets the companyID variable so it can be used throughout 
        public frmAddNest(int company_ID)
        {
            InitializeComponent();
            companyID = company_ID; //sets the companyID variable to the value passed in when the page is called 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }

        private void btnAddNest_Click(object sender, EventArgs e) //happens when the 'Add Nest' button is clicked 
        {
            DateTime dateAdded; //defines the required variables 
            string postcode, whatThreeWords;
            clsDBConnector dbConnector = new clsDBConnector();

            if (txtNestPostcode.Text != "" && txtWhatThreeWords.Text != "") //makes sure nothing is null 
            {
                postcode = txtNestPostcode.Text; //sets the variables to the selected values 
                whatThreeWords = txtWhatThreeWords.Text;
                dateAdded = DateTime.Now;

                string sqlStr = "INSERT INTO tblNestBirthCertificate (postcode, dateAdded, companyID, whatThreeWords) " +
                        "VALUES ('" + postcode + "', '" + dateAdded + "', " + companyID + ", '" + whatThreeWords + "')"; //the SQL statement is written 

                dbConnector.Connect();
                dbConnector.DoDML(sqlStr); //the SQL statement is executed 
                dbConnector.close();

                MessageBox.Show("New nest added."); //alerts the user that it has been successful 
                this.Close(); //closes at the end to avoide adding the same nest twice 
            }
            else
            {
                MessageBox.Show("Please fill in all the sections."); //throws an error message if not all sections are completed 
            }
        }
    }
}
