using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Trainline_Sim_Windows_Testing
{



    //*************
    //  MAIN CLASS
    //*************



    public partial class mainForm : Form
    {
        //--------------
        //  GLOBAL CODE
        //--------------


        passengerForm passengerForm = new passengerForm();
        //INITIAL GLOBAL VARIABLES
        public static List<Station> stationList = new List<Station>();
        public static List<Track> trackList = new List<Track>();
        public string[,] stationListNodes = { { "Stansted Airport", "1", "2", "4" }, { "Stansted Mountfichett", "1", "1", "2" }, { "Bishops Stortford", "2", "1", "3" }, { "Harlow Mill", "1", "1", "4" }, { "Harlow Town", "2", "2", "5" }, { "Roydon", "1", "1", "2" } };
        DateTime globalClock = new DateTime(2018, 1, 1, 6, 0, 0);

        //FORM CREATION
        public mainForm()
        {
            //Create form
            InitializeComponent();

            loadStations(@"C:\A Level\Computing\NEA\Stations.csv");
            loadTrack(@"C:\A Level\Computing\NEA\Track.csv");

            //Enable double buffering to reduce flickering
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,null, panelTrackDisplay, new object[] { true });
            
        }



        //----------------------------
        //  DISPLAY DRAWING & UPDATES
        //----------------------------



        //DRAWING GLOBAL VARIABLES
        SolidBrush sb = new SolidBrush(Color.FromArgb(40, 40, 40));
        SolidBrush sr = new SolidBrush(Color.Red);
        Pen pen = new Pen(Color.FromArgb(40, 40, 40), 3);
        int nodeDrawX;
        int nodeDrawY;
        Point linePointStart;
        Point linePointEnd;

 

        //DISPLAY CONTROL
        private void panelTrackDisplay_Paint(object sender, PaintEventArgs e)
        {
            //NODE START POINTS
            nodeDrawX = 128 + panelTrackDisplay.AutoScrollPosition.X;
            nodeDrawY = panelTrackDisplay.Height / 2;

            //Tells graphics to offset by scroll amount
            e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            paintStationNorth(e);
            nodeDrawX = 128 + panelTrackDisplay.AutoScrollPosition.X;
            nodeDrawY = panelTrackDisplay.Height / 2 + 16;
            //paintStationSouth(e);
        }

        //DRAW STATIONS NORTH
        public void paintStationNorth(PaintEventArgs e)
        {
            
            //For each station previously loaded 
            foreach(Station station in stationList)
            {

                //If user wants labels drawn
                if (checkBoxDrawLabels.Checked == true)
                {
                    paintLabels(station.name, e);
                }

                //Initial platform drawn
                e.Graphics.FillRectangle(sb, nodeDrawX - 32, nodeDrawY +8, 64, 8);

                //For each platform in the current station
                for (int countPlatforms = 1; countPlatforms < station.platformsNum; countPlatforms++)
                {
                    //New platform drawn
                    e.Graphics.FillRectangle(sb, nodeDrawX - (countPlatforms * 32), nodeDrawY + (countPlatforms * 32) + 16, (countPlatforms * 64), 8);

                    //Smoothing enabled for diagonal lines
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                    //If it is not the first station
                    if (station.ID != 0)
                    {
                        //Left diagonals drawn
                        linePointStart = new Point(nodeDrawX - (countPlatforms * 32), nodeDrawY + (countPlatforms * 32));
                        linePointEnd = new Point(nodeDrawX - (2 * (countPlatforms * 32)), nodeDrawY);
                        e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
                    }

                    Point linePointStore = linePointStart;
                    //If it is not the last station
                    if (station.ID != 19)
                    {
                        //Right diagonals drawn
                        linePointStart = new Point(nodeDrawX + (countPlatforms * 32), nodeDrawY + (countPlatforms * 32));
                        linePointEnd = new Point(nodeDrawX + (2 * (countPlatforms * 32)), nodeDrawY);
                        e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
                    }

                    e.Graphics.DrawLine(pen, linePointStore, linePointStart);
                    //Smoothing disabled
                    e.Graphics.SmoothingMode = SmoothingMode.None;

                }

                paintInterval(station.ID, trackList[station.ID].length, e);

                //Draw tracks
                linePointStart = new Point(128 + panelTrackDisplay.AutoScrollPosition.X, nodeDrawY);
                linePointEnd = new Point(nodeDrawX, nodeDrawY);
                e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
            }


            Label b = new Label();
            b.Location = new Point(nodeDrawX, 0);
            b.Text = "";
            panelTrackDisplay.Controls.Add(b);


        }

        //DRAW STATIONS SOUTH
        public void paintStationSouth(PaintEventArgs e)
        {

            //For each station previously loaded 
            for (int count = 0; count < stationListNodes.GetLength(0); count++)
            {

                //Initial platform drawn
                e.Graphics.FillRectangle(sb, nodeDrawX - 32, nodeDrawY + 8, 64, 8);

                //For each platform in the current station
                for (int countPlatforms = 1; countPlatforms < Convert.ToInt16(stationListNodes[count, 1]); countPlatforms++)
                {
                    //New platform drawn
                    e.Graphics.FillRectangle(sb, nodeDrawX - (countPlatforms * 32), nodeDrawY + (countPlatforms * 32) + 16, (countPlatforms * 64), 8);

                    //Smoothing enabled for diagonal lines
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                    //If it is not the first station
                    if (count != 0)
                    {
                        //Left diagonals drawn
                        linePointStart = new Point(nodeDrawX - (countPlatforms * 32), nodeDrawY + (countPlatforms * 32));
                        linePointEnd = new Point(nodeDrawX - (2 * (countPlatforms * 32)), nodeDrawY);
                        e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
                    }

                    Point linePointStore = linePointStart;
                    //If it is not the last station
                    if (count != stationListNodes.GetLength(0) - 1)
                    {
                        //Right diagonals drawn
                        linePointStart = new Point(nodeDrawX + (countPlatforms * 32), nodeDrawY + (countPlatforms * 32));
                        linePointEnd = new Point(nodeDrawX + (2 * (countPlatforms * 32)), nodeDrawY);
                        e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
                    }

                    e.Graphics.DrawLine(pen, linePointStore, linePointStart);
                    //Smoothing disabled
                    e.Graphics.SmoothingMode = SmoothingMode.None;

                }

                paintInterval(Convert.ToInt16(stationListNodes[count, 3]) + Convert.ToInt16(stationListNodes[count, 1]), count, e);

                //Draw tracks
                linePointStart = new Point(128 + panelTrackDisplay.AutoScrollPosition.X, nodeDrawY);
                linePointEnd = new Point(nodeDrawX, nodeDrawY);
                e.Graphics.DrawLine(pen, linePointStart, linePointEnd);
            }

        }

        //DRAW INTERVALS - Track ID is currently redundant, may be needed later for colour coding
        public void paintInterval(int trackID,int intervalNumber, PaintEventArgs e)
        {
            
            if (checkBoxDrawIntervals.Checked == true)
            {
                //Draw interval 
                e.Graphics.FillEllipse(sb, nodeDrawX-4, nodeDrawY - 4, 8, 8);
            }

            //If there are intervals still to call
            if (intervalNumber >= 0)
            {
                nodeDrawX += 64;
                //Call method again with one less interval 
                paintInterval(trackID, intervalNumber - 1, e);
            }

        }

        //DRAW LABELS
        public void paintLabels(string stationName, PaintEventArgs e)
        {
            //FONT
            FontFamily ff = new FontFamily("Segoe UI");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);

            //TEXT ALLIGNMENT
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            //Station name drawn
            e.Graphics.DrawString(stationName, font, sb, nodeDrawX + 8, panelTrackDisplay.Height - 48, drawFormat);

        }

        //DRAW TRAIN
        public void paintTrain()
        {

        }

        //UPDATE TRACK DISPLAY AFTER SCROLL
        private void panelTrackDisplay_Scroll(object sender, ScrollEventArgs e)
        {
            panelTrackDisplay.Refresh();
        }

        //UPDATE TRACK DISPLAY AFTER INTERVALS ENABLED/DISABLED
        private void checkBoxDrawIntervals_CheckedChanged_1(object sender, EventArgs e)
        {
            panelTrackDisplay.Refresh();
        }

        //UPDATE TRACK DISPLAY AFTER LABELS ENABLED/DISABLED
        private void checkBoxDrawLabels_CheckedChanged(object sender, EventArgs e)
        {
            panelTrackDisplay.Refresh();
        }



        //---------------
        //  DATA LOADING   
        //---------------



        //SELECT STATION DATA PATH 
        private void loadStationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new file selection menu that accepts one csv file as input
            OpenFileDialog stationCSVPathSelect = new OpenFileDialog();
            stationCSVPathSelect.Filter = "Comma Seperated Values (*.csv)|*.csv";
            stationCSVPathSelect.FilterIndex = 1;

            //Once user presses OK button with file selected
            if (stationCSVPathSelect.ShowDialog() == DialogResult.OK)
            {
                //Call loadStations with selected path as argument
                loadStations(stationCSVPathSelect.FileName);
                
            }
            
        }

        //LOAD STATION DATA
        static void loadStations(string stationCSVPath)
        {
            //Open streamreader to read csv
            using (StreamReader sr = new StreamReader(stationCSVPath))
            {

                string[] lineSplit;
                string currentLine;

                //Read one line at a time uintil end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    //Split line into array at commas
                    lineSplit = currentLine.Split(new Char[] { ',' });
                    //Create new instance of Station class
                    Station StationClass = new Station(lineSplit);
                    //Add new instance of Station class to list
                    stationList.Add(StationClass);
                }

            }
        }

        //LOAD TRACK DATA
        static void loadTrack(string trackCSVPath)
        {
            //Open streamreader to read csv
            using (StreamReader sr = new StreamReader(trackCSVPath))
            {

                string[] lineSplit;
                string currentLine;

                //Read one line at a time uintil end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    //Split line into array at commas
                    lineSplit = currentLine.Split(new Char[] { ',' });
                    //Create new instance of Station class
                    Track TrackClass = new Track(lineSplit);
                    //Add new instance of Station class to list
                    trackList.Add(TrackClass);
                }

            }
        }



        //------------------
        //  DYNAMIC UPDATES   
        //------------------



        //TICK UPDATES
        private void tick()
        {

            foreach (Station x in stationList)
            {
                x.NewArrivals(true);
            }
            buttonTimeDisplay.Text = Convert.ToString(globalClock);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Point trackDisplay = new Point(panelTrackDisplay.Size.Width+10, panelTrackDisplay.Size.Height);
            panelTrackDisplay.Location = trackDisplay;
            int newWidth = panelTrackDisplay.Width +200;
            panelTrackDisplay.MaximumSize = new Size(newWidth, panelTrackDisplay.Height);
            panelTrackDisplay.Size = new Size(newWidth, panelTrackDisplay.Height);
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            infoForm about = new infoForm();
            about.Show();
        }



        private void passengerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (passengerInfoToolStripMenuItem.Checked == true)
            {
                passengerForm.Show();
            } else
            {
                passengerForm.Hide();
            }
            toolStripDropDownButton1.ShowDropDown();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            globalClock = globalClock.AddMinutes(1);
            tick();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTrainForm createTrainForm = new createTrainForm();
            createTrainForm.Show();
        }
    }

    //****************
    //  TRAIN CLASS
    //****************

    public class Train
    {
        int ID;
        string name;
        Point Location;
        
    }
}


