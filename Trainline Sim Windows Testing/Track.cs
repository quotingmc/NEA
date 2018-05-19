using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainline_Sim_Windows_Testing
{
    public class Track
    {
        public int length;
        public int lines = 2;

        //MANUAL CONSTRUCTOR (DEBUG)
        public Track(int _length, int _lines, int _speedLimit)
        {
            length = _length;
            lines = _lines;
            int[] speedLimit = new int[lines];
            bool[] isObstructed = new bool[lines];
            for (int count = 0; count < _speedLimit; count++)
            {
                isObstructed[count] = false;
                speedLimit[count] = _speedLimit;
            }
        }

        //CSV CONSTRUCTOR
        public Track(string[] trackCSV)
        {
            length = Convert.ToInt16(trackCSV[0]);
            lines = Convert.ToInt16(trackCSV[1]);
        }

    }
}
