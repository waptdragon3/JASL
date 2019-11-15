using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JASL.Util;
using JASL.Objects;
namespace JASL.Structure
{
    public abstract class Block:Executable
    {
        public Statement[] Statements;

        public abstract void Execute();
    }

    public class ForBlock : Block
    {
        public Statement Initialize, Increment;
        public Expression Test;
        public override void Execute()
        {
            if (Test.ReturnType != JType.GetType("bool"))
                throw new Exception("Invalid Test expression return type");
            Initialize.Execute();
            while (Test.Evaluate().Equals(JBool.True))
            {
                foreach (var statement in Statements)
                {
                    statement.Execute();
                }
                Increment.Execute();
            }
        }
    }
    public class WhileBlock : Block
    {
        public Expression Test;
        public override void Execute()
        {
            if (Test.ReturnType != JType.GetType("bool"))
                throw new Exception("Invalid Test expression return type");
            while (Test.Evaluate().Equals(JBool.True))
            {
                foreach (var statement in Statements)
                {
                    statement.Execute();
                }
            }
        }
    }
}
