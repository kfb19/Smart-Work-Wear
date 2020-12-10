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
    public partial class frmUserStatistics : Form
    {
        class garmentStatus
        { 
            public DateTime dateAndTime { get; set; }
        }
        public string MACAddress { get; set; }

        public string email { get; set; }

        public frmUserStatistics(string eMail, string mACAddress)
        {
            InitializeComponent();
            email = eMail;
            MACAddress = mACAddress;
        }

        private void frmUserStatistics_Load(object sender, EventArgs e)
        {
            setUpPage(); //sets up the page 
        }

        private void setUpPage() //sets up the combo box for a list of dates 
        {
            List<garmentStatus> garmentList = new List<garmentStatus>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Format(tblGarmentStatus.[dateTime], 'Short Date') AS Expr1 " +
                "FROM ((tblGarmentStatus INNER JOIN " +
                "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) INNER JOIN " +
                "tblUser ON tblGarmentBirthCertificate.userEmail = tblUser.email) " +
                "WHERE ((tblGarmentBirthCertificate.MasterMACAddress = '" + MACAddress + "') AND (tblUser.email = '" + email + "')) " +
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

        private void setUpGraph(DateTime chosenDate)
        {
            chart1.Series.Clear(); //draws a graph corresponding to the date and garment 
            chart1.Series.Add("Angles");
            chart1.Series["Angles"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;

            dbConnector.Connect();

            sqlStr = "SELECT tblGarmentStatus.angle, tblGarmentStatus.[dateTime] " +
                "FROM (tblGarmentStatus INNER JOIN " +
                 "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) " +
                "WHERE (tblGarmentBirthCertificate.userEmail = '" + email + "') AND (tblGarmentStatus.masterMACAddress = '" + MACAddress + "')"; 

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                DateTime theTime = Convert.ToDateTime(dr[1]);
                if (theTime.Date == chosenDate)
                {
                    chart1.Series["Angles"].Points.AddXY(theTime.ToString("HH:mm:ss"), dr[0]);
                }                
            }

            dr.Close();
            dbConnector.close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //when the 'Back' button is clicked, the page closes so you return to the previous page      
        }

        private void cmbGarmentStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUpGraph(Convert.ToDateTime(cmbGarmentStatuses.SelectedValue)); //changes the graph for that date 
            setUpData(Convert.ToDateTime(cmbGarmentStatuses.SelectedValue)); //changes the displayed data for that date
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
                "FROM (tblGarmentStatus INNER JOIN " +
                "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) " +
                "HAVING (tblGarmentBirthCertificate.masterMACAddress = '" + MACAddress + "') AND (tblGarmentBirthCertificate.userEmail = '" + email + "') AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

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
                "FROM (tblGarmentStatus INNER JOIN " +
                "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) " +
                "HAVING (tblGarmentBirthCertificate.masterMACAddress = '" + MACAddress + "') AND (tblGarmentBirthCertificate.userEmail = '" + email + "') AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

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
                "FROM (tblGarmentStatus INNER JOIN " +
                "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) " +
                "HAVING (tblGarmentBirthCertificate.masterMACAddress = '" + MACAddress + "') AND (tblGarmentBirthCertificate.userEmail = '" + email + "') AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";


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
                "FROM (((tblGarmentStatus INNER JOIN " +
                "tblGarmentBirthCertificate ON tblGarmentStatus.masterMACAddress = tblGarmentBirthCertificate.masterMACAddress) INNER JOIN " +
                "tblEvents ON tblGarmentStatus.garmentStatusID = tblEvents.garmentStatusID) INNER JOIN " +
                "tblTypeOfEvent ON tblEvents.typeOfEventID = tblTypeOfEvent.typeOfEventID) " +
                "HAVING (tblGarmentBirthCertificate.masterMACAddress = '" + MACAddress + "') AND (tblTypeOfEvent.eventName = '" + eventType + "') AND (tblGarmentBirthCertificate.userEmail = '" + email + "') AND (tblGarmentStatus.[dateTime] >= #" + dateTime.ToString("MM/dd/yyyy 00:00:00") + "#) AND (tblGarmentStatus.[dateTime] < #" + (dateTime.AddDays(1).ToString("MM/dd/yyyy 00:00:00")) + "#)";

            dr = dbConnector.DoSQL(sqlStr);

            while (dr.Read())
            {
                noOfEvents = Convert.ToInt32(dr[0]);
            }

            dr.Close();
            dbConnector.close();

            return noOfEvents;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            //prints a report on the selected day's data
        }

        private void btnPrintGraph_Click(object sender, EventArgs e) //prints a report 
        {
            // Create new PrintDocument 
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.DocumentName = "User Analysis Report";
            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();
            pd.Dispose();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Rectangle myRec;
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
            ev.Graphics.DrawString("User Analysis Report " + cmbGarmentStatuses.Text, printFont, Brushes.Black, ev.MarginBounds.X, y);
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
            ev.Graphics.DrawString("User Analysis Report " + email, printFont, Brushes.Black, 10, 10);
            // Create Rectangle structure, used to set the position of the chart Rectangle 
            myRec = new System.Drawing.Rectangle(100, y, 500, 500);
            chart1.Printing.PrintPaint(ev.Graphics, myRec);
        }

    }
}
