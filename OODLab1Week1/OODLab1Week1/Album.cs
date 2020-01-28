using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODLab1Week1
{
    class Album
    {
        public string AlbumName { get; set; }

        public DateTime Released { get; set; }

        public double Sales { get; set; }

        public Album(string albumName, DateTime released, double sales)
        {
            AlbumName = albumName;
            Released = released ;
            Sales = sales;
        }



        public override string ToString()
        {
            return $"{AlbumName}\t{Released}\t{Sales}";
        }
    }
}
