using System;
using Xunit;
using System.Collections.Generic;

namespace Advent2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent Day 1:");
            var advent = new Advent2017();
            var puzzleInput1 = @"3893445835429722678558456317563893861752455542588369533636585887178232467588827193173595918648538852463974393264428538856739259399322741844613957229674619566966921656443476317729968764183945899765294481327998956154956571467872487576314549468261122281384513266834769436913544431258253346374641589492728885222652146158261225296144835682556133922436438188211288458692217737145834468534829945993366314375465767468939773939978272968388546791547526366348163672162245585168892858977723516752284597322176349412485116173844733679871253985762643852151748396593275274582481295864991886985988427966155944392352248314629138972358467959614279553511247863869663526823326467571462371663396188951696286916979923587358992127741723727623235238531991996999181976664226274715591531566495345212849683589582225465555847312199122268773923175183128124556249916458878785361322713513153175157855597289482439449732469754748544437553251412476225415932478849961897299721228198262823515159848941742786272262236888514421279147329383465929358896761449135917829473321834267122759371247338155787774952626616791265889922959653887288735233291968146648533754958199821789499914763279869931218136266492627818972334549751282191883558361871277375851259751294611921756927694394977764633932938573132221389861617195291742156362494769521829599476753198422283287735888197584327719697758442462886311961723849326959213928195182293316227334998926839139915138472514686689887874559367524254175582135318545912361877139367538434683933333264146289842238921989275112323681356256979576948644489986951538689949884787173194457523474156229389465725473817651516136514446513436419126533875125645855223921197481833434658264655912731133356464193251635637423222227273192628825165993827511625956856754776849919858414375874943572889154281862749595896438581889424559988914658387293414662361364793844213298677236787998677166743945812899526292132465751582925131262933636228593134861363493849168168765261647652342891576445292462341171477487223253795935253493869317616741963486473";
            Console.WriteLine("The sum is: {0}", advent.Day1(puzzleInput1));
            
            Console.WriteLine("Advent Day 2:");
            var puzzleInput2 = new List<string> {
                @"1919 2959 82 507 3219 239 3494 1440 3107 259 3544 683 207 562 276 2963",
                @"587 878 229 2465 2575 1367 2017 154 152 157 2420 2480 138 2512 2605 876",
                @"744 6916 1853 1044 2831 4797 213 4874 187 6051 6086 7768 5571 6203 247 285",
                @"1210 1207 1130 116 1141 563 1056 155 227 1085 697 735 192 1236 1065 156",
                @"682 883 187 307 269 673 290 693 199 132 505 206 231 200 760 612",
                @"1520 95 1664 1256 685 1446 253 88 92 313 754 1402 734 716 342 107",
                @"146 1169 159 3045 163 3192 1543 312 161 3504 3346 3231 771 3430 3355 3537",
                @"177 2129 3507 3635 2588 3735 3130 980 324 266 1130 3753 175 229 517 3893",
                @"4532 164 191 5169 4960 3349 3784 3130 5348 5036 2110 151 5356 193 1380 3580",
                @"2544 3199 3284 3009 3400 953 3344 3513 102 1532 161 143 2172 2845 136 2092",
                @"194 5189 3610 4019 210 256 5178 4485 5815 5329 5457 248 5204 4863 5880 3754",
                @"3140 4431 4534 4782 3043 209 216 5209 174 161 3313 5046 1160 160 4036 111",
                @"2533 140 4383 1581 139 141 2151 2104 2753 4524 4712 866 3338 2189 116 4677",
                @"1240 45 254 1008 1186 306 633 1232 1457 808 248 1166 775 1418 1175 287",
                @"851 132 939 1563 539 1351 1147 117 1484 100 123 490 152 798 1476 543",
                @"1158 2832 697 113 121 397 1508 118 2181 2122 809 2917 134 2824 3154 2791",
            };
            Console.WriteLine("The checksum is: {0}", advent.Day2(puzzleInput2));
            Console.WriteLine("The dividend checksum is: {0}", advent.Day2Part2(puzzleInput2));
            
            var start = 325489;
            Console.WriteLine("Advent Day 3:");
            Console.WriteLine("The number of steps are: {0}", advent.Day3(start));
        }
    }
    
    class Advent2017 {
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
        
        // Day 3, Part 2, Result: 
        public int Day3Part2(int puzzleInput) {
            var sum = 1;
            
            // {x, y}
            var coords = new int[] {0, 0};
            var i = 1;
            var n = 1;
            var count = 1;
            var direction = Direction.North;
            var spiral = new Dictionary<string, int>{};
            
            while (sum <= puzzleInput) {
                Console.WriteLine("Adding coord: {0},{1}={2}", coords[0], coords[1], sum);
                //Console.WriteLine("sum: {0}", sum);
                spiral.Add(coords[0].ToString() + "," + coords[1].ToString(), getAdjacentSum(coords, spiral));
                
                Console.WriteLine("n, i, count: {0} {1}", n, i, count);
                
                // move to next cell
                if (n > 1 && i == count) {
                    i = 0;
                    if (direction == Direction.East) {
                        direction = Direction.North;
                    } else {
                        direction++;
                    }
                    Console.WriteLine("setting direction to: {0}", direction);
                }
                // reset at end of square
                
                if (n == count * count) {
                    direction = Direction.North;
                    coords[0]++;
                    count += 2;
                    n = 1;
                    i = 1;
                }
                else {
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
                    
                    n++;
                    i++;
                }
                
                //Console.WriteLine("r, root, direction: {0}, {1}, {2}", r, root, direction);
                //sum += getAdjacentSum(coords, spiral);
                //sum++;
            }
            
            foreach (var item in spiral) {
                Console.WriteLine("key/value: {0}/{1}", item.Key, item.Value);
            }
            
            return getAdjacentSum(coords, spiral);
        }
        
        enum Direction {
            North = 1,
            West = 2,
            South = 3,
            East = 4,
        };
        
        int getAdjacentSum(int[] coords, Dictionary<string, int> spiral) {
            // Console.WriteLine("--Spiral--");
            // foreach (var item in spiral) {
            //     Console.WriteLine("key/value: {0}/{1}", item.Key, item.Value);
            // }
            
            if (coords[0] == 0 && coords[1] == 0) {
                return 1;
            }
            
            var sum = 0;
            for (var x = coords[0] - 1; x < coords[0] + 1; x++) {
                for (var y = coords[1] - 1; y < coords[1] + 1; y++) {
                    var coord = x.ToString() + "," + y.ToString();
                    
                    //Console.WriteLine("Checking coord: {0}", coord);
                    
                    if (coord != coords[0] + "," + coords[1] && spiral.ContainsKey(coord)) {
                        //Console.WriteLine("Found a value at {0}: {1}", coord, spiral[coord]);
                        sum = spiral[coord];
                    }
                }
            }
            return sum;
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
        public void Day3SpiralSumTest() {
            var advent = new Advent2017();
            Assert.Equal(11, advent.Day3Part2(10));
        }
    }
}
