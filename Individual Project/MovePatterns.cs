using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public interface IMovePattern
    {
        void Move();
    }

    public class Walk : IMovePattern
    {
        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }

    public class Run: IMovePattern
    {
        public void Move()
        {
            Console.WriteLine("Running");
        }
    }

}
