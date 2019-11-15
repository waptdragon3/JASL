using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASL.Objects
{
    public class JType
    {
        public string Name;
        public JType[] FieldTypes;

        public JType(string name, JType[] fieldTypes)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FieldTypes = fieldTypes ?? throw new ArgumentNullException(nameof(fieldTypes));
        }

        public static List<JType> JTypes;

        public static JType GetType(string Name)
        {
            foreach (var type in JTypes)
            {
                if (type.Name == Name) return type;
            }
            return null;
        }

        static JType()
        {
            JTypes = new List<JType>();
            JTypes.Add(new JType("int", new JType[0]));
            JTypes.Add(new JType("float", new JType[0]));
            JTypes.Add(new JType("string", new JType[0]));
            JTypes.Add(new JType("bool", new JType[0]));
        }
    }
}
