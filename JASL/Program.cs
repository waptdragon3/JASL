using JASL.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASL
{
    class Program
    {
        public Block[] Blocks;
        static void Main(string[] args)
        {
        }

        public void Run()
        {
            foreach (var block in Blocks)
            {
                block.Execute();
            }
        }
    }
}
