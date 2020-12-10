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
    public partial class frmAddGarment : Form
    {
        public string email { get; set; }
        public frmAddGarment(string eMail)
        {
            InitializeComponent();
            email = eMail;
        }

        private void frmAddGarment_Load(object sender, EventArgs e)
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

            sqlStr = "SELECT masterMACAddress " +
               "FROM tblGarmentBirthCertificate " +
               "WHERE userEmail = '" + email + "'"; //writes the SQL string 

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                Button btn = new Button(); //creates a button for each company 
                btn.BackColor = Color.DarkOrange;
                btn.ForeColor = Color.White;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Text = dr[0].ToString(); ;
                btn.Name = "btn_ " + i;
                i++;
                btn.Click += btn_Click;
                flpExistingGarments.Controls.Add(btn);
            }

            dr.Close();
            dbConnector.close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            deleteGarment(sender); //lets the user delete the selected garment 
        }

        private void deleteGarment(object sender)
        {
            if (MessageBox.Show("Do you want to delete this garment?", "Delete Options", MessageBoxButtons.YesNo) == DialogResult.Yes) //lets the user delete the selected garment
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblGarmentBirthCertificate " +
                    "WHERE (masterMACAddress = '" + (sender as Button).Text + "')";
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

        private void btnAddGarment_Click(object sender, EventArgs e)
        {
            string masterMAC, LLMAC, LUMAC, RLMAC, RUMAC, garmentType; //defines the required variables 
            int garmentTypeID = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            DateTime dateAdded;

            if (txtMasterMAC.Text != "" && txtLLMAC.Text != "" && txtLUMAC.Text != "" && txtRUMAC.Text != "" && txtRLMAC.Text != "" && dudGarmentType.Text != "") //makes sure nothing is null 
            {
                masterMAC = txtMasterMAC.Text; //sets all the variables to the required values 
                LLMAC = txtLLMAC.Text;
                LUMAC = txtLUMAC.Text;
                RLMAC = txtRLMAC.Text;
                RUMAC = txtRUMAC.Text;
                garmentType = dudGarmentType.Text;
                dateAdded = DateTime.Now;

                if (garmentType == "Trousers") //works out the garmentTypeID 
                {
                    garmentTypeID = 1;
                }
                else if (garmentType == "Shirt")
                {
                    garmentTypeID = 2;
                }
                else if (garmentType == "Jacket")
                {
                    garmentTypeID = 3;
                }

                string sqlStr = "INSERT INTO tblGarmentBirthCertificate (garmentID, masterMACAddress, macAddressLU, macAddressLL, macAddressRU, macAddressRL, dateAdded, userEmail) " +
                        "VALUES (" + garmentTypeID + ", '" + masterMAC + "' , '" + LUMAC + "', '" + LLMAC + "', '" + RUMAC + "', '" +
                        RLMAC + "', '" + dateAdded + "', '" + email + "')"; //this writes the SQL string 
                dbConnector.Connect();
                dbConnector.DoDML(sqlStr); //this executes the SQL string 
                dbConnector.close();

                MessageBox.Show("New garment added."); //alters the user that it has been successful 
                this.Close(); //closes at the end to avoide adding the same garment twice. 
            }

            else
            {
                MessageBox.Show("Please fill in all the sections."); //throws an error message if not all sections are completed 
            }
        }
    }
}
