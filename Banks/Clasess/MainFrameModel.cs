using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Banks.Clasess
{
    internal  static class MainFrameModel
    {
        public static Frame thisframe;
    }
    
    internal static class DatabaseModel
    {
        public static Banks.Database.BanksEntities db = new Database.BanksEntities();
    }
}
