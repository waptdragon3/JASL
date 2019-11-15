using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JASL.Objects;

namespace JASL.Structure
{
    public abstract class Expression
    {
        public JType ReturnType;
        public abstract JObject Evaluate();
    }
}
