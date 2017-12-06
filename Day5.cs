using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    class AdventDay5
    {
        // Day 5, Result: 343467
        // Part 2, Result: 24774780
        public int Day5(List<int> input, bool strange = false) {
            int i = 0;
            int instruction = 0;
            int steps = 0;
            
            while (i < input.Count) {
                instruction = input[i];
                if (strange && instruction >= 3) {
                    input[i]--;
                } else {
                    input[i]++;
                }
                i += instruction;
                steps++;
            }
            
            return steps;
        }
    }
    
    public class AdventDay5Tests {
        // (0) 3  0  1  -3  - before we have taken any steps.
        // (1) 3  0  1  -3  - jump with offset 0 (that is, don't jump at all). Fortunately, the instruction is then incremented to 1.
        //  2 (3) 0  1  -3  - step forward because of the instruction we just modified. The first instruction is incremented again, now to 2.
        //  2  4  0  1 (-3) - jump all the way to the end; leave a 4 behind.
        //  2 (4) 0  1  -2  - go back to where we just were; increment -3 to -2.
        //  2  5  0  1  -2  - jump 4 steps forward, escaping the maze.
        
        [Fact]
        public void Day5Test() {
            var puzzleInput = new List<int> {0, 3, 0, 1, -3};
            
            var advent = new Advent2017();
            Assert.Equal(5, advent.Day5(puzzleInput));
        }
        
        [Fact]
        public void Day5Part2Test() {
            var puzzleInput = new List<int> {0, 3, 0, 1, -3};
            
            var advent = new Advent2017();
            Assert.Equal(10, advent.Day5(puzzleInput, true));
        }
        
    }
}
