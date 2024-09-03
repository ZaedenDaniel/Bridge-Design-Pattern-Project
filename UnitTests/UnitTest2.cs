using System;
using Xunit;
using Individual_Project;

namespace Individual_Project_Tests
{
    public class ArcherTests
    {
        [Fact]
        public void Archer_ShouldRunAndThenSwitchToWalkAndMeleeAttack()
        {
            // Arrange
            IMovePattern run = new Run();
            IAttackPattern rangedAttack = new RangedAttack();
            Character archer = new Archer(run, rangedAttack);

            // Act and Assert
            var moveOutput = CaptureConsoleOutput(() => archer.Move());
            Assert.Equal("Archer is Running", moveOutput);

            var attackOutput = CaptureConsoleOutput(() => archer.Attack());
            Assert.Equal("Archer performs Ranged attack", attackOutput);

            // Change behavior
            IMovePattern walk = new Walk();
            IAttackPattern meleeAttack = new MeleeAttack();
            archer.SetMovePattern(walk);
            archer.SetAttackPattern(meleeAttack);

            moveOutput = CaptureConsoleOutput(() => archer.Move());
            Assert.Equal("Archer is Walking", moveOutput);

            attackOutput = CaptureConsoleOutput(() => archer.Attack());
            Assert.Equal("Archer performs Melee attack", attackOutput);
        }

        private string CaptureConsoleOutput(Action action)
        {
            var originalOut = Console.Out; // Save the original Console.Out
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                action();
                Console.SetOut(originalOut); // Reset Console.Out
                return sw.ToString().Trim();
            }
        }
    }
}
