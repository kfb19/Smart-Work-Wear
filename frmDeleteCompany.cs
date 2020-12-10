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
    public partial class frmDeleteCompany : Form
    {
        public frmDeleteCompany()
        {            
            InitializeComponent();
        }

        private void frmDeleteCompany_Load(object sender, EventArgs e)
        {
            setUpPage();
        }

        private void setUpPage()
        {
            int i = 0; //defines all required variables 
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT companyID, companyName " +
               "FROM tblCompany "; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                Button btn = new Button(); //creates a button for each company 
                btn.BackColor = Color.DarkOrange;
                btn.ForeColor = Color.White;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[1].ToString(); ;
                btn.Name = "btn_ " + i;
                i++;
                btn.Click += btn_Click;
                flpCompanies.Controls.Add(btn);
            }

            dr.Close();
            dbConnector.close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            deleteCompany(sender);
        }

        private void deleteCompany(object sender)
        {
            if (Convert.ToInt32((sender as Button).Tag) == 1) //cannot delete Vision270 as it is the owner company 
            {
                MessageBox.Show("You cannot delete this company.");
            }
            else if (MessageBox.Show("Do you want to delete this company?", "Delete Options", MessageBoxButtons.YesNo) == DialogResult.Yes) //lets the user delete the selected company 
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblCompany " +
                    "WHERE (companyID = " + Convert.ToInt32((sender as Button).Tag) + ")";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.close();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page            
        }
    }
}
