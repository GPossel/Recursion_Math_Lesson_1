using System;

namespace Recursion_Math_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MyProgram();
        }

        public void MyProgram()
        {
            Assingment_1();
            Console.WriteLine();
            Assingment_2();
            Console.WriteLine();
            Assingment_3();
            Console.WriteLine();
            Assingment_4();
            Console.WriteLine();
            Assingment_5();
            Console.WriteLine();
            Assingment_6();
            Console.WriteLine();
            Assingment_7();
            Console.WriteLine();
            Assingment_8();
        }


        public void Assingment_1()
        {
            Console.WriteLine("Calculate: (1) Pn = 5 * P(n-1) -3, n > 2 (2) P1 = 3");
            int[] row = new int[5] { 5, 4, 3, 2, 1 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignment_1(n));
            }

            Console.WriteLine();
        }
        public int Calculate_Assignment_1(int n)
        {
            if (n == 1)
                return 3;

            return 5 * (Calculate_Assignment_1(n - 1)) - 3;
        }


        public void Assingment_2()
        {
            Console.WriteLine("Calculate: (1) Pn = n * q(n-1), n > 1 (2) P0 = 5");
            int[] row = new int[6] { 5, 4, 3, 2, 1, 0 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignment_2(n));
            }

            Console.WriteLine();
        }
        public int Calculate_Assignment_2(int n)
        {
            if (n == 0)
                return 5;

            return n * (Calculate_Assignment_2(n - 1)); 
        }

        public void Assingment_3()
        {
            Console.WriteLine("Determine a recursive definition for sequence: 6, 7, 9, 12, 16, 21, ...");
            Console.WriteLine("(1) Qn = Q(n-1) + n, n > 0 (2) Q0 = 6");
            int[] row = new int[6] { 5, 4, 3, 2, 1, 0 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignemt_3(n));
            }

            Console.WriteLine();
        }
        public int Calculate_Assignemt_3(int n)
        {
            if (n == 0)
                return 6;

            return Calculate_Assignemt_3(n -1) + n;
        }

        public void Assingment_4()
        {
            Console.WriteLine("Determine a recursive definition for sequence: 1, 2, 7, 32, 157");
            Console.WriteLine("(1) Qn = Q(n-1) * 5 + 3, n > 1 (2) Q0 = 1");
            int[] row = new int[5] { 5, 4, 3, 2, 1 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignemt_4(n));
            }

            Console.WriteLine();
        }
        public int Calculate_Assignemt_4(int n)
        {
            if (n == 1)
                return 1;

            return Calculate_Assignemt_4(n - 1) * 5 - 3;
        }

        public void Assingment_5()
        {
            Console.WriteLine("Determine a recursive definition for sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...");
            Console.WriteLine("(1) Qn = Q(n-1) + Q(n-2), n > 0 (2) Q0 = 0");
            int[] row = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignemt_5(n));
            }

            Console.WriteLine();
        }
        public int Calculate_Assignemt_5(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Calculate_Assignemt_5(n - 2) + Calculate_Assignemt_5(n - 1);
        }

        public void Assingment_6()
        {
            Console.WriteLine("Determine a recursive definition for An: the number of dots of n dice (n ≥ 1). Give an explanation.");
            Console.WriteLine("(1) Qn = A(n-1) + 21, n > 1 (2) Q0 = 0");
            int[] row = new int[6] { 5, 4, 3, 2, 1, 0 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignemt_6(n));
            }

            Console.WriteLine("Explanation: the dots on 1 dice are in total 21. Each dice added will contain: (1) the sum of all the dices dots together previously (2) plus the new 21.");
            Console.WriteLine("Explanation: the dots on one dice = 6 + 5 + 4 + 3 + 2 + 1 = 21");
            Console.WriteLine();
        }
        public int Calculate_Assignemt_6(int n)
        {
            if (n == 0)
                return 0;

            return Calculate_Assignemt_6(n - 1) + 21;
        }

        public void Assingment_7()
        {
            Console.WriteLine(@"At a checkers tournament (Dutch: damtoernooi), there are n players. The playing schedule is as follows: each player will play twice against every other player(once with white and once with black).
                                Determine a recursive definition for Pn: the number of games that will be played in total by n players. Give an explanation.");
            Console.WriteLine("(1) Qn = A(n-1) + ((n-1) * 2), n > 2");
            int[] row = new int[5] { 6, 5, 4, 3, 2 };

            foreach (int n in row)
            {
                Console.Write("| {0} |", Calculate_Assignemt_7(n));
            }

            Console.WriteLine(@"Explanation: Foreach player added: 
                                we take the already existing total number of games + ( A(n-1) )
                                total number of players already in the tournament, ( n - 1 )
                                then we play 2 matches to each of those player ( * 2 ).
                                We start at n=2, (two players) because then there will be 2 matches. (One with white, one with black)");

            Console.WriteLine("In other words: foreach player we add, we have to calculate the new matches added of this person by getting all the other players vs him times two. We add these new matches, to the ones already calculated.");
            Console.WriteLine("For a visualisation of the problem I created a picture (see attatchment) and a excersize for myself, containing dots, shapes and connecting lines. ");
            Console.WriteLine("This I made as an extra assignment in Assingment_8");
            Console.WriteLine();
        }
        public int Calculate_Assignemt_7(int n)
        {
            if (n == 2)
                return 2;

            return Calculate_Assignemt_7(n - 1) + ( (n - 1) * 2);
        }

        public void Assingment_8()
        {
            Console.WriteLine(@"Based on the previously solved question on the dam tournement. 
                                I created a serie of connecting dots between an 'n' amount of points. 
                                If you visualize each point as a 'player' and turn them into a shapes to help us connecting them all to eachother. 
                                I.e. 
                                      3 player is a trangle, will result in 3 lines to connect all dots
                                      4 players is a square with an X inside, will result in 6 lines to connect all the dots
                                      5 players will be a pentagonal with a pentagram, will result in 10 lines to connect all the dots
                                      6 players will be a hexagon with many lines in between, will result into 15 lines to connect all the dots
                                (See picture added to solution)

                                n = 2  | 3 | 4 | 5  | 6  | ..
                                    1  | 3 | 6 | 10 | 15 | ..

                                The lines needed to connect each dots varies, but we can use the same sequence to get the result.
                                Visual: Foreach dot we add to the shape, we'll draw lines to each existing point in the shape. 
                                Therefore we can make a recursive pattern by reusing the already n number of existing patterns, as the new lines we need to add.
                                
                                Pn = A(n-1) + (n-1)

                                In the previous 'damtoernooi', each line is not counted as 1, but 2, because each connected player plays twice.

                                (1) Qn = A(n-1) + (n-1), n > 2
");

            int[] row = new int[5] { 2, 3, 4, 5, 6 };

            Console.WriteLine("The sequence of connecting lines between n number of dots goes as follows:");
            Console.Write(@"                         n = ");
            foreach (int n in row)
            {
                Console.Write(@" | {0} |", n);
            }
            Console.WriteLine();
            Console.Write(@"number of lines to connect = ");
            foreach (int n in row)
            {
                Console.Write(@" | {0} |", Calculate_Assignemt_8(n));
            }


            Console.WriteLine(@"

                                        -----------        -----------
                                        |    o    |        |  oxxxo  |
                                        |   x x   |        |  x x x  |     See picture in project... 
                                        |  oxxxo  |        |  oxxxo  |
                                        -----------        -----------
                                          n  =  3,           n  =  4,
Number of lines to connect all dots:         3                  6
                               ");

            Console.WriteLine();
        }
        public int Calculate_Assignemt_8(int n)
        {
            if (n == 2)
                return 1;

            int previousNum = n - 1;

            return Calculate_Assignemt_8(previousNum) + (previousNum);
        }


    }
}
