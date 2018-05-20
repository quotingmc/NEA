using System;
using System.Drawing;

namespace Trainline_Sim_Windows_Testing
{
    public class Station
    {
        //CLASS PROPERTIES
        public int ID;
        public string name;
        string sCode;
        int usage;
        public int platformsNum;
        int platformsFree;
        double passNewChance;
        int passNewCertain;
        public int passWaiting = 0;
        Point Location;
        Random r = new Random();

        //MANUAL CONSTRUCTOR (DEBUG)
        public Station(string _ID, string _name, string _sCode, string _platformsNum, string _usage)
        {
            ID = Convert.ToInt16(_ID);
            name = _name;
            usage = Convert.ToInt16(_usage);
            sCode = _sCode;
            platformsNum = Convert.ToInt16(_platformsNum);
            platformsFree = Convert.ToInt16(_platformsNum);
            passNewCertain = usage / 262800;
            passNewChance = ((double)usage / 262800) - passNewCertain;
        }

        //CSV CONSTRUCTOR
        public Station(string[] stationCSV)
        {
            ID = Convert.ToInt16(stationCSV[0]);
            name = stationCSV[1];
            sCode = stationCSV[2];
            platformsNum = Convert.ToInt16(stationCSV[3]);
            usage = Convert.ToInt32(stationCSV[4]);
            platformsFree = platformsNum;
            passNewCertain = usage / 262800;
            passNewChance = ((double)usage / 262800) - passNewCertain;
        }

        //NEW PASSENGERS ARRIVING AT STATION
        public void NewArrivals(bool isPeak)
        {
            passWaiting += passNewCertain;
            if (r.NextDouble() <= passNewChance)
            {
                passWaiting += 1;
            }
        }

    }
}
