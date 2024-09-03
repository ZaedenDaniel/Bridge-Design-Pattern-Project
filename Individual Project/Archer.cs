using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    //Archer Character Class
    public class Archer : Character
    {
        public Archer(IMovePattern movePattern, IAttackPattern attackPattern) : base("Archer" ,movePattern, attackPattern)  
        {
        }
    }
}
