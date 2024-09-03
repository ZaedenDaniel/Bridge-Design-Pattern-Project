using Individual_Project;

class Program
{
    static void Main(string[] args)
    {
        IMovePattern walk = new Walk();
        IMovePattern run = new Run();
        IAttackPattern meleeAttack = new MeleeAttack();
        IAttackPattern rangedAttack = new RangedAttack();

        Character warrior = new Warrior(walk, meleeAttack);
        warrior.Move();
        warrior.Attack();

        Character archer = new Archer(run, rangedAttack);
        archer.Move();
        archer.Attack();

        warrior.SetMovePattern(run);
        warrior.SetAttackPattern(rangedAttack);
        warrior.Move();
        warrior.Attack();
    }
}

