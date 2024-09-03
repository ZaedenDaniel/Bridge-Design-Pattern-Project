using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    //Warrior Character Class
    public class Warrior : Character 
    {
        public Warrior(IMovePattern movePattern, IAttackPattern attackPattern) : base("Warrior", movePattern, attackPattern)
        {
        }
    }
}
