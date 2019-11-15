using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASL.Objects
{
    public class JObject
    {
        public JType Type;
        public JObject[] JObjects;
    }

    public class JInt : JObject
    {
        public int Value;

        public JInt(int value)
        {
            Type = JType.GetType("int");
            Value = value;
        }
    }
    public class JFloat : JObject
    {
        public float Value;

        public JFloat(float value)
        {
            Type = JType.GetType("float");
            Value = value;
        }
    }
    public class JString : JObject
    {
        public string Value;

        public JString(string value)
        {
            Type = JType.GetType("string");
            Value = value;
        }
    }
    public class JBool : JObject
    {
        public bool Value;

        public JBool(bool value)
        {
            Type = JType.GetType("bool");
            Value = value;
        }

        public readonly static JBool True = new JBool(true);
        public readonly static JBool False = new JBool(false);
    }

}
