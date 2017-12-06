using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var advent = new Advent2017();
            
            Console.WriteLine("Advent Day 1:");
            Console.WriteLine("The sum is: {0}", advent.Day1(PuzzleInputs.Day1));
            
            Console.WriteLine("Advent Day 2:");
            Console.WriteLine("The checksum is: {0}", advent.Day2(PuzzleInputs.Day2));
            Console.WriteLine("The dividend checksum is: {0}", advent.Day2Part2(PuzzleInputs.Day2));
            
            var start = 325489;
            Console.WriteLine("Advent Day 3:");
            Console.WriteLine("The number of steps are: {0}", advent.Day3(start));
            Console.WriteLine("The first adjacent sum larger than the input is: {0}", advent.Day3Part2(start));
            
            Console.WriteLine("Advent Day 4:");
            Console.WriteLine("The number of valid passphrases is: {0}", advent.Day4(PuzzleInputs.Day4));
            Console.WriteLine("The number of valid passphrases without anagrams is: {0}", advent.Day4(PuzzleInputs.Day4, true));
            
            Console.WriteLine("Advent Day 5:");
            Console.WriteLine("The number of steps to exit the maze are: {0}", advent.Day5(PuzzleInputs.Day5));
            Console.WriteLine("the number of steps to exit the strange maze are: {0}", advent.Day5(PuzzleInputs.Day5, true));
        }
    }
    
    class Advent2017 : AdventDay5 {
        // Day 1
        // Part 1 Result: 637
        // Part 2 Result: 1060
        public int Day1(string puzzleInput) {
            var sum = 0;
            
            // for part 2, only go around the circle half way, since we're also checking the opposite side
            for (var i = 0; i < puzzleInput.Length / 2; i++) {
                var thisElement = Int32.Parse(puzzleInput[i].ToString());
                // part 1
                //var nextElement = Int32.Parse(i == puzzleInput.Length - 1 ? puzzleInput[0].ToString() : puzzleInput[i + 1].ToString());
                // part 2
                var nextElement = getOppositeElement(i, puzzleInput);
                
                // if elements are same, add that value to sum
                if (thisElement == nextElement) {
                    // part 2, double the element since we're only visiting half of them
                    sum += thisElement * 2;
                }
            }
            
            return sum;
        }
        
        // gets the element on the opposite side of the circle
        int getOppositeElement(int thisIndex, string puzzleInput) {
            var opposite = thisIndex + puzzleInput.Length / 2;
            if (opposite > puzzleInput.Length - 1) {
                opposite -= puzzleInput.Length - 1;
            }
            return Int32.Parse(puzzleInput[opposite].ToString());
        }
        
        // Day 2, Result: 53978
        public int Day2(List<string> puzzleInput) {
            var sum = 0;
            for (var i = 0; i < puzzleInput.Count; i++) {
                sum += getCheckSum(puzzleInput[i]);
            }
            return sum;
        }
        
        // Day 2, Part 2, Result: 314
        public int Day2Part2(List<string> puzzleInput) {
            var sum = 0;
            for (var i = 0; i < puzzleInput.Count; i++) {
                sum += getDivisibleChecksum(puzzleInput[i]);
            }
            return sum;
        }
        
        int getCheckSum(string row) {
            var cells = row.Split(null);
            var min = Int32.MaxValue;
            var max = Int32.MinValue;
            
            for (var i = 0; i < cells.Length; i++) {
                var cell = Int32.Parse(cells[i].Trim());
                
                if (cell < min) {
                    min = cell;
                }
                if (cell > max) {
                    max = cell;
                }
            }
            
            return max - min;
        }
        
        int getDivisibleChecksum(string row) {
            var cells = row.Split(null);
            for (var i = 0; i < cells.Length; i++) {
                var c = Int32.Parse(cells[i].Trim());
                
                for (var j = 0; j < cells.Length; j++) {
                    var d = Int32.Parse(cells[j].Trim());
                    
                    if (i != j && c > d && c % d == 0) {
                        return c / d;
                    }
                }
            }
            
            return 0;
        }
        
        // Day 3, Result: 552
        public int Day3(int start) {
            // each bottom right corner of the spiral is represented by the square of n + 2
            // i.e.: 1^2, 3^2, 5^2 sets each bottom corner at 1, 9 and 25
            // each bottom right corner coordinate increments by 1
            // i.e.: 0,0 1,1 2,2
            // so we need to determine the closest corner, then traverse back to 1^2
            // then work forward to our corner coordinate
            
            var root = Int32.Parse(Math.Floor(Math.Sqrt(start)).ToString()) + 1; // if 23, sqrt is 4.x, so add 1
            
            var diff = 1;
            
            for (var i = root; i > 1; i -= 2) {
                diff++;
            }
            
            var coord = root - diff;
            
            var coords = new int[] {coord, coord};
            
            // now I need to determine the plane I'm on
            // i.e.: 23 is on the lower plane, so is easy to figure out coords (0,2)
            
            var horizontal = true;
            for (var i = (root * root) - 1; i >= start; i--) {
                // starting at 2,2, subtrack 1 from x until we hit mod 0, then subtrack from y
                
                if (horizontal) {
                    coords[0]--;
                }
                else {
                    coords[1]--;
                }
                
                if (i % root == 0) {
                    horizontal = !horizontal;
                }
            }
            
            var steps = Math.Abs(coords[0]) + Math.Abs(coords[1]);
            
            return steps;
        }
        
        // Day 3, Part 2, Result: 330785
        public int Day3Part2(int puzzleInput) {
            var spiral = new Dictionary<string, int>{};
            
            var coords = new int[] {0,0};
            var sum = 0; // value to be stored in cell
            var n = 1; // value to be stored in cell
            var c = 1; // increment as we spiral each square
            var d = 1; // depth of square we're spiralling
            var e = c; // keeps track of when to change direction
            
            var direction = Direction.East;
            
            while (sum < puzzleInput) {
                sum = getAdjacentSum(coords, spiral);
                spiral.Add(coords[0].ToString() + "," + coords[1].ToString(), sum);
                
                if (n == d * d) {
                    c = 0;
                    d += 2;
                    e = 0;
                    direction = Direction.North;
                    coords[0]++; // move to next spiral
                }
                else if (e == d - 1) {
                    direction++;
                    e = 0;
                }
                
                if (c != 0) {
                    switch (direction) {
                        case Direction.North: {
                            coords[1]++;
                            break;
                        }
                        case Direction.East: {
                            coords[0]++;
                            break;
                        }
                        case Direction.South: {
                            coords[1]--;
                            break;
                        }
                        case Direction.West: {
                            coords[0]--;
                            break;
                        }
                    }
                }
                
                n++;
                c++;
                e++;
            }
            
            return sum;
        }
        
        enum Direction {
            North = 1,
            West = 2,
            South = 3,
            East = 4,
        };
        
        public int getAdjacentSum(int[] coords, Dictionary<string, int> spiral) {
            if (coords[0] == 0 && coords[1] == 0) {
                return 1;
            }
            
            var sum = 0;
            for (var x = coords[0] - 1; x <= coords[0] + 1; x++) {
                for (var y = coords[1] - 1; y <= coords[1] + 1; y++) {
                    var coord = x.ToString() + "," + y.ToString();
                    if (spiral.ContainsKey(coord)) {
                        sum += spiral[coord];
                    }
                }
            }
            return sum;
        }
        
        // Day 4, Result: 451
        // Day 4, Part 2 Result: 223
        public int Day4(List<string> passphrases, bool preventAnagrams = false) {
            var v = 0;
            for (var i = 0; i < passphrases.Count; i++) {
                var passphraseWords = passphrases[i].Split(null);
                
                var valid = true;
                for (var j = 0; j < passphraseWords.Length; j++) {
                    for (var k = 0; k < passphraseWords.Length; k++) {
                        if (j != k && (!preventAnagrams ? passphraseWords[j] == passphraseWords[k] : areAnagrams(passphraseWords[j], passphraseWords[k]))) {
                            valid = false;
                            break;
                        }
                    }
                    if (!valid) {
                        break;
                    }
                }
                
                if (valid) {
                    v++;
                }
            }
            return v;
        }
        
        public bool areAnagrams(string word1, string word2) {
            return String.Concat(word1.OrderBy(c => c)) == String.Concat(word2.OrderBy(c => c));
        }
    }
    
    public class Advent2017Tests {
        List<string> spreadsheet = new List<string> {@"5 1 9 5", @"7 5 3", @"2 4 6 8"};
        
        List<string> spreadsheet2 = new List<string> {@"5 9 2 8", @"9 4 7 3", @"3 8 6 5"};
        
        // List<string> spiral = new List<string> {
        //     @"17 16 15 14 13",
        //     @"18 5 4 3 12",
        //     @"19 6 1 2 11",
        //     @"20 7 8 9 10",
        //     @"21 22 23 24 25",
        // };
        
        [Fact]
        public void Day2ChecksumTest() {
            var advent = new Advent2017();
            Assert.Equal(18, advent.Day2(spreadsheet));
        }
        
        [Fact]
        public void Day2DivisibleChecksumTest() {
            var advent = new Advent2017();
            Assert.Equal(9, advent.Day2Part2(spreadsheet2));
        }
        
        [Fact]
        public void Day3SpiralTest() {
            var advent = new Advent2017();
            Assert.Equal(2, advent.Day3(23));
        }
        
        [Fact]
        public void Day3AdjacentSumTest() {
            var advent = new Advent2017();
            
            var spiral = new Dictionary<string, int> {
                {"0,0", 1},
                {"1,0", 1},
                {"1,1", 2},
                {"0,1", 4},
            };
            
            Assert.Equal(5, advent.getAdjacentSum(new int[] {-1, 1}, spiral));
        }
        
        [Fact]
        public void Day3SpiralSumTest() {
            var advent = new Advent2017();
            Assert.Equal(747, advent.Day3Part2(730));
        }
        
        List<string> passphrases = new List<string> {
            @"aa bb cc dd ee",
            @"aa bb cc dd aa",
            @"aa bb cc dd aaa",
        };
        
        List<string> passphraseAnagrams = new List<string> {
            @"abcde fghij",
            @"abcde xyz ecdab",
            @"a ab abc abd abf abj",
            @"iiii oiii ooii oooi oooo",
            @"oiii ioii iioi iiio",
        };
        
        [Fact]
        public void Day4Test() {
            var advent = new Advent2017();
            Assert.Equal(2, advent.Day4(passphrases));
        }
        
        [Fact]
        public void Day4AnagramTest() {
            var advent = new Advent2017();
            Assert.Equal(3, advent.Day4(passphraseAnagrams, true));
        }
    }
}
