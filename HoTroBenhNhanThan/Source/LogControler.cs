using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HoTroBenhNhanThan.Source
{
    internal class LogControler
    {
        static string logFolder = "LOG";
        static string fileName = "hospitalManagermanet_";
        public static string shareLogPath { get; set; }
        static string currentDir = Directory.GetCurrentDirectory()+"\\"+logFolder;
        static Mutex LogMutex = new Mutex(false);

        static public void WriteLog(string log)
        {
            if(!Directory.Exists(currentDir))
            {
                                           Directory.CreateDirectory(currentDir);

            }
            string filePath = currentDir + "\\" + fileName + DateTime.Now.ToString("yyMMDD") + ".txt";
            bool newfile = false;
            if(!File.Exists(filePath))
            {
                newfile = true;
            }
            using(StreamWriter sw = File.AppendText(filePath))
            {
                if(newfile)
                {
                    cleanLog();
                    Assembly assembly= Assembly.GetExecutingAssembly();
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                    string verson = fileVersionInfo.ProductVersion;
                    sw.WriteLine("===============Hospital System==============");
                    sw.WriteLine(verson);
                    sw.WriteLine("=============================================");
                    string header = DateTime.Now.ToString("HH:mm:ss");
                    sw.WriteLine(header + ',' + log);
                }
            }
        }   
        static void cleanLog()
        {

        }
    }
}
