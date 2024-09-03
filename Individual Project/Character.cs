using System;

namespace Individual_Project
{
    public abstract class Character
    {
        public string Type { get; private set; } //Shows 
        protected IMovePattern movePattern;
        protected IAttackPattern attackPattern;

        protected Character(string type,IMovePattern movePattern, IAttackPattern attackPattern)
        {
            Type = type;
            this.movePattern = movePattern;
            this.attackPattern = attackPattern;
        }
        public void Move() //Functions that executes move behaviour
        {
            Console.Write($"{Type} is ");
            movePattern.Move();
        }

        public void SetMovePattern(IMovePattern MovePattern) //Updates movement behaviour
        {
            movePattern = MovePattern;
        }

        public void Attack() //Function which executes Attack Pattern
        {
            Console.Write($"{Type} performs ");
            attackPattern.Attack();
        }

        public void SetAttackPattern(IAttackPattern AttackPattern) //Updates attack behaviour
        {
            attackPattern = AttackPattern;
        }

    }
}
