using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject_S00180206
{
    public enum GenreType { ActionAdventure, Crime, Fantacy, Horror, Drama, Comedy}
    class Comic_FranchiseShows:IComparable
    {
        public string ShowName { get; set; }

        public DateTime DateOfRelease { get; set; }

        public int AverageViews { get; set; }

        public string LeadCharacters { get; set; }




        public int CompareTo(object obj)
        {
            Comic_FranchiseShows that = obj as Comic_FranchiseShows;
            return this.DateOfRelease.CompareTo(that.DateOfRelease);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", ShowName, DateOfRelease.ToShortDateString());
        }



    }
}
