using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODLab1Week1
{
    class Band:IComparable
    {
        public enum BandGenre { pop, rock , indie };
        public string BandName { get; set; }

        public int Formed { get; set; }

        public string Members { get; set; }

        public BandGenre bandGenre1;

        public Band(string bandName, int formed, string members, BandGenre bandGenre)
        {
            BandName = bandName;
            Formed = formed;
            Members = members;
            bandGenre1 = bandGenre;
        }

        public override string ToString()
        {
            return $"{BandName }" /*{()}*/;
        }

        public int CompareTo(object obj)
        {
            Band objectThatIAmComparingTo = (Band)obj;

            int returnValue = this.bandGenre1.CompareTo(objectThatIAmComparingTo.bandGenre1);

            //return
            return returnValue;
        }
    }
}
