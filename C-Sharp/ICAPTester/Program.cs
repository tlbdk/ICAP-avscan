using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootpath = Path.GetFullPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "../../../../../");
            try
            {
                ICAPNameSpace.ICAP icap = new ICAPNameSpace.ICAP("192.168.1.5", 1344, "avscan");
                
                bool result = icap.scanFile(rootpath + "eicar.txt");
                Console.WriteLine("Scan eicar test sample:" + result);

                result = icap.scanFile(rootpath + "README.md");
                Console.WriteLine("Scan eicar test sample:" + result);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not scan file " + ex);
            }

            Console.ReadKey();
        }
    }
}
