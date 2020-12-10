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
using System.Drawing.Printing;

namespace Coursework
{
    public partial class frmCompanyStatistics : Form
    {
        class garmentStatus
        {
            public DateTime dateAndTime { get; set; }
        }
        public int companyID { get; set; }
        public string header { get; set; }
        public string stringToPrint { get; set; }
        public string documentContents { get; set; }
        public frmCompanyStatistics(int IDOfCompany)
        {
            InitializeComponent();
            companyID = IDOfCompany;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {         
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page              
        }

        private void btnPrintGraph_Click(object sender, EventArgs e)
        {
            // Create new PrintDocument 
            header = string.Format("{0,-50}{1,-25}{2,-25}{3,-25}", "Email", "Angle", "Event ID", "Event Type") + "\n";
            stringToPrint = GetData(Convert.ToDateTime(cmbGarmentStatuses.SelectedValue));
            documentContents = stringToPrint;
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.DocumentName = "User Analysis Report";
            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();
            pd.Dispose();
        }

        private void cmbGarmentStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUpData(Convert.ToDateTime(cmbGarmentStatuses.SelectedValue)); //changes the displayed data for that date
            setUpListBox(Convert.ToDateTime(cmbGarmentStatuses.SelectedValue));
        }

        private void frmCompanyStatistics_Load(object sender, EventArgs e)
        {
            setUpPage();           
        }

        private void setUpListBox(DateTime selectedDate)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblUser.email, tblUser.firstName, tblUser.surname, tblGarmentStatus.angle, tblEvents.eventID, tblTypeOfEvent.eventName " +
                        "FROM (((tblGarmentBirthCertificate INNER JOIN " +
                        "tblUser ON tblGarmentBirthCertificate.userEmail = tblUser.email) INNER JOIN " +
                        "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) INNER JOIN " +
                        "(tblEvents INNER JOIN " +
                        "tblTypeOfEvent ON tblEvents.typeOfEventID = tblTypeOfEvent.typeOfEventID) ON tblGarmentStatus.garmentStatusID = tblEvents.garmentStatusID) " +
                        "WHERE (tblUser.companyID = " + companyID + ") AND (tblGarmentStatus.[dateTime] >= #" + selectedDate.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (selectedDate.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";
            dr = dbConnector.DoSQL(sqlStr);
            lstEvents.Items.Clear();
            while (dr.Read())
            {
                lstEvents.Items.Add(dr[0].ToString());
                lstEvents.Items[lstEvents.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstEvents.Items[lstEvents.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstEvents.Items[lstEvents.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstEvents.Items[lstEvents.Items.Count - 1].SubItems.Add(dr[4].ToString());
                lstEvents.Items[lstEvents.Items.Count - 1].SubItems.Add(dr[5].ToString());
            }
            dr.Close();
            dbConnector.close();
        }

        private void setUpPage() //sets up the combo box for a list of dates 
        {
            List<garmentStatus> garmentList = new List<garmentStatus>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Format(tblGarmentStatus.[dateTime], 'Short Date') AS Expr1 " +
                "FROM (((tblCompany INNER JOIN " +
                "tblUser ON tblCompany.companyID = tblUser.companyID) INNER JOIN " +
                "tblGarmentBirthCertificate ON tblUser.email = tblGarmentBirthCertificate.userEmail) INNER JOIN " +
                "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) " + 
                "WHERE (tblCompany.companyID = " + companyID + ") " +
                "GROUP BY Format(tblGarmentStatus.[dateTime], 'Short Date')";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                garmentList.Add(new garmentStatus { dateAndTime = Convert.ToDateTime(dr[0]) });
            }
            dr.Close();
            dbConnector.close();

            cmbGarmentStatuses.DisplayMember = "dateAndTime";
            cmbGarmentStatuses.ValueMember = "dateAndTime";
            cmbGarmentStatuses.DataSource = garmentList;
        }
        private void setUpData(DateTime dateTime)
        {
            int criticalEvents, mildEvents, totalEvents, highestAngle, lowestAngle, averageAngle;

            criticalEvents = getEvents(dateTime, "Critical");
            mildEvents = getEvents(dateTime, "Mild");
            totalEvents = criticalEvents + mildEvents;

            highestAngle = getHighestAngle(dateTime); //finds out the correct angle data 
            lowestAngle = getLowestAngle(dateTime);
            averageAngle = getAverageAngle(dateTime);

            lblCriticalEventNo.Text = criticalEvents.ToString(); //sets all the labels on the display 
            lblMildEventNo.Text = mildEvents.ToString();
            lblTotalEventNo.Text = totalEvents.ToString();
            lblHighestAngleNo.Text = highestAngle.ToString();
            lblLowestAngleNo.Text = lowestAngle.ToString();
            lblAverageAngleNo.Text = averageAngle.ToString();
        }

        private int getAverageAngle(DateTime dateTime) //finds the average angle 
        {
            int averageAngle = 0;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT AVG(tblGarmentStatus.angle) AS Expr1 " +
                "FROM (((tblCompany INNER JOIN " +
                "tblUser ON tblCompany.companyID = tblUser.companyID) INNER JOIN " +
                "tblGarmentBirthCertificate ON tblUser.email = tblGarmentBirthCertificate.userEmail) INNER JOIN " +
                "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) " +
                "HAVING (tblCompany.companyID = " + companyID + ") AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                averageAngle = Convert.ToInt32(dr[0]);
            }

            dr.Close();
            dbConnector.close();

            return averageAngle;
        }

        private int getLowestAngle(DateTime dateTime) //finds the lowest angle 
        {
            int lowestAngle = 0;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT MIN(tblGarmentStatus.angle) AS Expr1 " +
                "FROM (((tblCompany INNER JOIN " +
                "tblUser ON tblCompany.companyID = tblUser.companyID) INNER JOIN " +
                "tblGarmentBirthCertificate ON tblUser.email = tblGarmentBirthCertificate.userEmail) INNER JOIN " +
                "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) " +
                 "HAVING (tblCompany.companyID = " + companyID + ") AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                lowestAngle = Convert.ToInt32(dr[0]);
            }

            dr.Close();
            dbConnector.close();

            return lowestAngle;
        }

        private int getHighestAngle(DateTime dateTime) //finds the highest angle
        {
            int highestAngle = 0;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT MAX(tblGarmentStatus.angle) AS Expr1 " +
                "FROM (((tblCompany INNER JOIN " +
                "tblUser ON tblCompany.companyID = tblUser.companyID) INNER JOIN " +
                "tblGarmentBirthCertificate ON tblUser.email = tblGarmentBirthCertificate.userEmail) INNER JOIN " +
                "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) " +
                 "HAVING (tblCompany.companyID = " + companyID + ") AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                highestAngle = Convert.ToInt32(dr[0]);
            }

            dr.Close();
            dbConnector.close();

            return highestAngle;
        }

        private int getEvents(DateTime dateTime, string eventType) //finds the number of critical events 
        {
            int noOfEvents = 0;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT COUNT(tblTypeOfEvent.eventName) AS Expr1 " +
                "FROM ((((tblUser INNER JOIN " +
                "tblCompany ON tblUser.companyID = tblCompany.companyID) INNER JOIN " +
                "tblGarmentBirthCertificate ON tblUser.email = tblGarmentBirthCertificate.userEmail) INNER JOIN " +
                "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) INNER JOIN " +
                "(tblTypeOfEvent INNER JOIN " +
                "tblEvents ON tblTypeOfEvent.typeOfEventID = tblEvents.typeOfEventID) ON tblGarmentStatus.garmentStatusID = tblEvents.garmentStatusID) " +
                "HAVING (tblCompany.companyID = " + companyID + ") AND (tblTypeOfEvent.eventName = '" + eventType + "') AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                noOfEvents = Convert.ToInt32(dr[0]);
            }

            dr.Close();
            dbConnector.close();

            return noOfEvents;
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //creates the report varibales 
            string criticalEvents = lblCriticalEventNo.Text;
            string mildEvents = lblMildEventNo.Text;
            string totalEvents = lblTotalEventNo.Text;
            string highAngle = lblHighestAngleNo.Text;
            string lowAngle = lblLowestAngleNo.Text;
            string average = lblAverageAngleNo.Text;
            // Create and initialize print font 
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10);
            int y = ev.MarginBounds.Y;
            ev.Graphics.DrawString("Company Analysis Report " + cmbGarmentStatuses.Text, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString(" ", printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Number of Mild Events: " + mildEvents, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Number of Critical Events: " + criticalEvents, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Total Number of Events: " + totalEvents, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Highest Angle Recorded: " + highAngle, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Lowest Angle Recorded: " + lowAngle, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Average Angle Recorded: " + average, printFont, Brushes.Black, ev.MarginBounds.X, y);
            y = y + 20;
            ev.Graphics.DrawString("Company Analysis Report ", printFont, Brushes.Black, 10, 10);
            y = y + 20;
            ev.Graphics.DrawString(" ", printFont, Brushes.Black, ev.MarginBounds.X, y);
            int charactersOnPage = 0;
            int linesPerPage = 0;
            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            ev.Graphics.MeasureString(stringToPrint, printFont, ev.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            // Draws the string within the bounds of the page.
            ev.Graphics.DrawString(stringToPrint, printFont, Brushes.Black, ev.MarginBounds.X, y, StringFormat.GenericTypographic);
            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);
            // Check to see if more pages are to be printed.
            ev.HasMorePages = (stringToPrint.Length > 0);
            // If there are no more pages, reset the string to be printed.
            if (!ev.HasMorePages)
            {
                stringToPrint = documentContents;
            }
            else
            {  // print the header as new page
                stringToPrint = header + stringToPrint;
            }

        }
        private string GetData(DateTime selectedDate)
        {
            string dataToPrint = "";
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblUser.email, tblGarmentStatus.angle, tblEvents.eventID, tblTypeOfEvent.eventName " +
                         "FROM (((tblGarmentBirthCertificate INNER JOIN " +
                         "tblUser ON tblGarmentBirthCertificate.userEmail = tblUser.email) INNER JOIN " +
                         "tblGarmentStatus ON tblGarmentBirthCertificate.masterMACAddress = tblGarmentStatus.masterMACAddress) INNER JOIN " +
                         "(tblEvents INNER JOIN " +
                         "tblTypeOfEvent ON tblEvents.typeOfEventID = tblTypeOfEvent.typeOfEventID) ON tblGarmentStatus.garmentStatusID = tblEvents.garmentStatusID) " +
                         "WHERE (tblUser.companyID = " + companyID + ") AND (tblGarmentStatus.[dateTime] >= #" + selectedDate.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (selectedDate.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";
            dr = dbConnector.DoSQL(sqlStr);
            lstEvents.Items.Clear();
            dataToPrint = header;
            while (dr.Read())
            {
                dataToPrint = dataToPrint + string.Format("{0,-50}{1,-10}{2,-25}{3,-25}", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()) + "\n";
            }
            return dataToPrint;
        }

    }
}
