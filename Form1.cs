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
    public partial class Form1 : Form
    {
        public int counter { get; set; }
        public int angle { get; set; }
        public bool plus { get; set; }
        public bool minus { get; set; }
        public Form1() //displays some basic information about the application and provides a link to the login page 
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin(); //loads the login page when you click the button 
            loginForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loads the form
        }
    }
}
