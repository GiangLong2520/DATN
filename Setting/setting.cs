using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace HoTroBenhNhanThan
{
    public class setting
    {
        public static void createFile(string file, int status, string ds, string db, string user = null, string password = null)
        {
            string s="";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;
            if (!File.Exists(path))
            {
                if (status == 1)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + "Intergrated Sercurity=true;MultipleActiveResultSets=true;";

                }
                else if (status == 0)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + password + ";MultipleActiveResultSets=true;";
                }
                File.WriteAllText(path, s);
                MainClass.showMessage("Settings Saved Successfully.", "success");
            }
          
        }
    }
}
