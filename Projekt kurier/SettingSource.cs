using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kurier
{
    public class SettingSource
    {
        public PackageState State { get; set; }

        public SettingSource(PackageState setting)
        {
            State = setting;
        }
    }
}
