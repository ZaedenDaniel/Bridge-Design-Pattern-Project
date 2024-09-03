using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public interface IAttackPattern
    {
        void Attack();
    }
    public class MeleeAttack : IAttackPattern // function to execute melee attack
    {
        public void Attack()
        {
            Console.WriteLine("Melee attack");
        }
    }

    public class RangedAttack : IAttackPattern //Function to execute Ranged attack 
    {
            public void Attack()
            {
                Console.WriteLine("Ranged attack ");
            }
    }

}
