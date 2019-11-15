using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JASL.Util;

namespace JASL.Structure
{
    public abstract class Statement : Executable
    {
        public abstract void Execute();
    }
}
