using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace HoTroBenhNhanThan.Source
{
    internal class LogControler
    {
        static string logFolder = "LOG";
        static string fileName = "hospitalManagermanet_";
        static string currentDir = /*Directory.GetCurrentDirectory()*/"C:\\"+logFolder;
        static string folderName = DateTime.Now.ToString("yyyyMMdd");
        static string fullpath = currentDir + "\\"+folderName;
        static Mutex LogMutex = new Mutex(false);

        static public void WriteLog(string log)
        {
            if(!Directory.Exists(currentDir))
            {
                  Directory.CreateDirectory(currentDir);

            }
            if(!Directory.Exists(fullpath))
            {
                Directory.CreateDirectory(fullpath);
            }
            string filePath = fullpath + "\\" + fileName + DateTime.Now.ToString("yyMMdd") + ".txt";
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
                else
                {
                    string header = DateTime.Now.ToString("HH:mm:ss");
                    sw.WriteLine(header + ',' + log);
                }
            }
        }
        static public void WriteLog(string procedure, Hashtable ht)
        {
            if (Data.WorkingDataInstance.UseLog == 0)
            {
                return;
            }
            string log = procedure + "___";
            if(ht.Count > 0)
            {
                foreach (DictionaryEntry entry in ht)
                {
                    log += $"{entry.Key}: {entry.Value}, ";
                }
            }
            if (!Directory.Exists(currentDir))
            {
                Directory.CreateDirectory(currentDir);

            }
            if (!Directory.Exists(fullpath))
            {
                Directory.CreateDirectory(fullpath);
            }
            string filePath = fullpath + "\\" + fileName + DateTime.Now.ToString("yyMMdd") + ".txt";
            bool newfile = false;
            if (!File.Exists(filePath))
            {
                newfile = true;
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                if (newfile)
                {
                    cleanLog();
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                    string verson = fileVersionInfo.ProductVersion;
                    sw.WriteLine("===============Hospital System==============");
                    sw.WriteLine(verson);
                    sw.WriteLine("=============================================");
                    string header = DateTime.Now.ToString("HH:mm:ss");
                    sw.WriteLine(header + ',' + log);
                }
                else
                {
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
