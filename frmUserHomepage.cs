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
    public partial class frmUserHomepage : Form
    {
        public string email { get; set; } //defines public variables to use throughout the code 
        public string name { get; set; }
        public frmUserHomepage(string user_email)
        {
            InitializeComponent();
            email = user_email; //sets the passed-in parameters          
        }

        private void getName()
        {
            clsDBConnector dbConnector = new clsDBConnector(); //finds all they relevant information needed about the company 
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT firstName, surname " +
               "FROM tblUser " +
               "WHERE (email = '" + email + "')"; //writes SQL code 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                name = dr[0].ToString() + " " + dr[1].ToString(); //sets the name 
            }

            dr.Close();
            dbConnector.close();           
        }

        private void tsChangeDetails_Click(object sender, EventArgs e) //lets the user change their details 
        {
            frmChangeMyDetails changeMyDetailsForm = new frmChangeMyDetails(email);
            changeMyDetailsForm.Show();
        }

        private void tsViewStatistics_Click(object sender, EventArgs e) //lets the user view their own statistics 
        {
            frmSelectMACStatistics selectMACForm = new frmSelectMACStatistics(email);
            selectMACForm.Show();
        }

        private void tsAddGarment_Click(object sender, EventArgs e) //lets the users add new garments 
        {
            frmAddGarment addGarmentForm = new frmAddGarment(email);
            addGarmentForm.Show();
        }

        private void tsHelpAndSupport_Click(object sender, EventArgs e) //shows the user where to get technical help 
        {
            MessageBox.Show("1. Please try refreshing the page. \n 2. Make sure you are connected to " +
                "the database. \n 3. For technical support, please email help@vision270.com. \n 4. If your details are " +
                "incorrect and you cannot change them, please ask your company to do so. \n 5. If you are leaving your company, they will delete you from their systems.", "HELP AND SUPPORT");
        }

        private void tsLogOut_Click(object sender, EventArgs e) //lets the user log out 
        {
            if (MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmUserHomepage_Load(object sender, EventArgs e) //loads the homepage and enbles the timer to show the time 
        {
            setUpPage();            
        }

        private void setUpPage()
        {
            timer1.Enabled = true; //enables the timers 
            timer2.Enabled = true;
            getName(); //finds out the user's name 
            lblLoggedInTime.Text = "Logged in at " + Convert.ToString(DateTime.Now); //sets the on-screen display 
            lblOnlineTime.Text = "0";
            lblUserName.Text = "Hi, " + name;
        }

        private void timer1_Tick(object sender, EventArgs e) //displays the time to a screen 
        {
            lblDate.Text = Convert.ToString(DateTime.Now);
        }

        private void timer2_Tick(object sender, EventArgs e) //displays the minutes online to the screen 
        {
            int counter = Convert.ToInt32(lblOnlineTime.Text);
            counter = counter + 1;
            lblOnlineTime.Text = counter.ToString();
        }
    }
}
