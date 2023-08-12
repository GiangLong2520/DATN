using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroBenhNhanThan.API
{
    public class LibSetting
    {
        public static void createFile(string file, int status, string ds, string db, string user = null, string password = null)
        {
            string s = "";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;
            if (!File.Exists(path))
            {
                if (status == 1)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";Integrated Security=True;Trust Server Certificate=true";

                }
                else if (status == 0)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + password + ";Trust Server Certificate=true";
                }
                File.WriteAllText(path, s);
                LibMainClass.LibMainClass.showMessage("Settings Saved Successfully.", "success");
            }
            else
            {
                if (status == 1)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";Integrated Security=True;Trust Server Certificate=true";

                }
                else if (status == 0)
                {
                    s = "Data Source = " + ds + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + password + ";Trust Server Certificate=true";
                }
                File.WriteAllText(path, s);
                LibMainClass.LibMainClass.showMessage("Settings Saved Successfully.", "success");
            }

        }
    }
}
