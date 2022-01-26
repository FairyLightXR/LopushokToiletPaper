using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using LopushokToiletPaper.Entities;

namespace LopushokToiletPaper.Utilities
{
    internal class Transition
    {
        public static Frame Mainframe { get; set; }
        private static LopushokDBEntities datacontext;
        public static LopushokDBEntities Datacontext
        {
            get
            {
                if (datacontext == null)
                    datacontext = new LopushokDBEntities();
                return datacontext;
            }
        }
    }
}
