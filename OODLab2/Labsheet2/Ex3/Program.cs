using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousQuery();
        }
        private static void AnonymousQuery()
        {
            var files = new DirectoryInfo("c:\\windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new 
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0}\t{1} bytes,\t{2}",
                    item.Name, item.Length, item.CreationTime);
            }
            Console.ReadLine();
        }
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
