using System;
using Xunit;
using Individual_Project;

namespace Individual_Project_Tests
{
    public class WarriorTests
    {
        [Fact]
        public void Warrior_ShouldWalkAndMeleeAttack()
        {
            // Arrange
            IMovePattern walk = new Walk();
            IAttackPattern meleeAttack = new MeleeAttack();
            Character warrior = new Warrior(walk, meleeAttack);

            // Act and Assert
            var moveOutput = CaptureConsoleOutput(() => warrior.Move());
            Assert.Equal("Warrior is Walking", moveOutput);

            var attackOutput = CaptureConsoleOutput(() => warrior.Attack());
            Assert.Equal("Warrior performs Melee attack", attackOutput);
        }

        private string CaptureConsoleOutput(Action action)
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString().Trim();
            }
        }
    }
}
