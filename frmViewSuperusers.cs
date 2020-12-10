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
    public partial class frmViewSuperusers : Form
    {
        public string email { get; set; } //sets the public variables to be used throughout the code 
        public frmViewSuperusers(string e_Mail)
        {
            InitializeComponent();
            email = e_Mail; //sets the email to be the passed-through parameter 
        }

        private void frmViewSuperusers_Load(object sender, EventArgs e)
        {
            setUpPage();
        }

        private void setUpPage()
        {
                int i = 0; //sets all the required variables 
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;

                dbConnector.Connect();

                sqlStr = "SELECT email, firstName, surname " +
                   "FROM tblUser " +
                   "WHERE  (userTypeID = 1)"; //writes out the SQL string 

                dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

                while (dr.Read())
                {
                    Button btn = new Button(); //creates buttons for each superuser 
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
            if ((sender as Button).Tag.ToString() == email)
            {
                MessageBox.Show("Returning to homepage."); //returns to homepage if the user clicks on themself 
                this.Close();
            }
            else
            {
                MessageBox.Show("Access Denied"); //does not let a user click on another superuser 
            }          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }
    }
}
