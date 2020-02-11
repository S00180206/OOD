using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new DirectoryInfo("c:\\windows").GetFiles();

            var query = from f in files
                        where f.Length > 10000
                        orderby f.Length, f.Name
                        select new MyFileInfo
                        {
                            Name = f.Name,
                            Length = f.Length,
                            CreationTime = f.CreationTime
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }

        public override string ToString()
        {
            return $"Name of file is {Name}"; 
        }
    }
}
