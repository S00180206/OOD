using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };
        }
        public class MyFileInfo
        {
            public string Name { get; set; }
            public long Length { get; set; }
            public DateTime CreationTime { get; set; }

            public override string ToString()
            {
                return string.Format("{0,-30}{1:F0} MB\t{2}", Name, Length / 1000, CreationTime);
            }
        }
}
