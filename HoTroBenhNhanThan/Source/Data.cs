using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroBenhNhanThan.Source
{
    internal class Data
    {
        public class WorkingData
        {
            public int UseLog { get; set; }
            public string name { get; set; }
            public string role{ get; set; }
            public  int nameID { get; set; }
            public int roleID { get; set; }
        }

        private static WorkingData _workingDataInstance;

        public static WorkingData WorkingDataInstance
        {
            get
            {
                if (_workingDataInstance == null)
                {
                    _workingDataInstance = new WorkingData();
                }
                return _workingDataInstance;
            }
        }
    }
}
