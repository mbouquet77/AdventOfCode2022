﻿using AOC2022Day5;
using NFluent;
using Xunit;

namespace AOC2022TestProject
{
    public class MovingCratesTests
    {
        private readonly List<string> _input = new List<string>
            {
                "    [D]    ",
                "[N] [C]    ",
                "[Z] [M] [P]",
                " 1   2   3 "
            };
        private readonly List<string> _instructions = new List<string>
            {
                "move 1 from 2 to 1",
                "move 3 from 1 to 3",
                "move 2 from 2 to 1",
                "move 1 from 1 to 2"
            };
        private readonly MovingCrates _movingCrates = new MovingCrates();

        [Fact]
        public void GetMyInputListTest()
        {
            var expectedInput = new List<List<string>>()
            {
                new List<string>()
                {
                    "Z", "N"
                },
                new List<string>()
                {
                    "M", "C", "D"
                },
                new List<string>()
                {
                    "P"
                }
            };

            var myInput = _movingCrates.GetMyInputList(_input);
            Check.That(myInput).IsEqualTo(expectedInput);

            expectedInput = new List<List<string>>()
            {
                new List<string>()
                {
                    "Z", "N", "D"
                },
                new List<string>()
                {
                    "M", "C"
                },
                new List<string>()
                {
                    "P"
                }
            };
            
            var newImput = _movingCrates.ApplyInstruction(myInput, _instructions[0]);
            Check.That(newImput).IsEqualTo(expectedInput);

            expectedInput = new List<List<string>>()
            {
                new List<string>()
                {
                },
                new List<string>()
                {
                    "M", "C"
                },
                new List<string>()
                {
                    "P", "D", "N", "Z"
                }
            };
            
            newImput = _movingCrates.ApplyInstruction(newImput, _instructions[1]);
            Check.That(newImput).IsEqualTo(expectedInput);
        }

        [Fact]
        public void RearrangementTest()
        {
            var expectedInput = new List<List<string>>()
            {
                new List<string>()
                {
                    "C"
                },
                new List<string>()
                {
                    "M"
                },
                new List<string>()
                {
                    "P", "D", "N", "Z"
                }
            };

            var lastInput = _movingCrates.Rearrangement(_input, _instructions);
            Check.That(lastInput).IsEqualTo(expectedInput);
        }

        [Fact]
        public void GetMessage()
        {
            var message = _movingCrates.GetMessage(_input, _instructions);
            Check.That(message).IsEqualTo("CMZ");
        }
   }
}
