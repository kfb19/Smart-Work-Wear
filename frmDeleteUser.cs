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
    public partial class frmDeleteUser : Form
    {
        public string company_name { get; set; } //sets public variables to be used throughout the code 
        public int company_ID { get; set; }
        public frmDeleteUser(string companyName, int companyID)
        {
            InitializeComponent();
            company_name = companyName; //sets variables to the passed-in parameters 
            company_ID = companyID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page 
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {
            setUpPage(); //calls the setUpPage function 
        }

        private void setUpPage()
        {
            lblCompanyName.Text = company_name + " Employees"; //sets the title 
            int i = 0;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            string sqlStr;
            dbConnector.Connect();

            sqlStr = "SELECT tblUser.email, tblUser.firstName, tblUser.surname " +
               "FROM (tblCompany INNER JOIN " +
               "tblUser ON tblCompany.companyID = tblUser.companyID) " +
               "WHERE (tblCompany.companyID = " + company_ID + ")"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr); //executes the SQL string 

            while (dr.Read())
            {
                Button btn = new Button(); //creates a Flow Layout Pannel with a button for each employee 
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

        private void btn_Click(object sender, EventArgs e)
        {
            deleteUser(sender);            
        }

        private void deleteUser(object sender) //deletes the selected user from the database 
        {
            if (MessageBox.Show("Do you want to delete this employee?", "Delete Options", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblUser " +
                    "WHERE (email = '" + ((sender as Button).Tag).ToString() + "')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.close();
                this.Close();
            }
        }
    }

} 
