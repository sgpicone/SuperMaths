using SuperMathDifficulty;
using SuperMathProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMath
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI());
            bool adult = false;
            Difficulty diff = Difficulty.EASY;
            Problem p = new Problem(diff);
            string input;
            int points = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(diff.DifficultyToString(adult) + ": " + p + " = " + p.Answer);
                Console.Write("Answer: ");
                input = Console.ReadLine();
                while (!p.CheckAnswer(Convert.ToDouble(input)))
                {
                    Console.WriteLine("Try again.");
                    Console.Write("Answer: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Good job. You earned " + p.PossiblePointEarnings() + " points.");
                points += p.PossiblePointEarnings();

                diff = Difficulty.NORMAL;
                p = new Problem(diff);
                Console.WriteLine(diff.DifficultyToString(adult) + ": " + p + " = " + p.Answer);
                Console.Write("Answer: ");
                input = Console.ReadLine();
                while (!p.CheckAnswer(Convert.ToDouble(input)))
                {
                    Console.WriteLine("Try again.");
                    Console.Write("Answer: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Good job. You earned " + p.PossiblePointEarnings() + " points.");
                points += p.PossiblePointEarnings();

                diff = Difficulty.HARD;
                p = new Problem(diff);
                Console.WriteLine(diff.DifficultyToString(adult) + ": " + p + " = " + p.Answer);
                Console.Write("Answer: ");
                input = Console.ReadLine();
                while (!p.CheckAnswer(Convert.ToDouble(input)))
                {
                    Console.WriteLine("Try again.");
                    Console.Write("Answer: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Good job. You earned " + p.PossiblePointEarnings() + " points.");
                points += p.PossiblePointEarnings();

                diff = Difficulty.VERY_HARD;
                p = new Problem(diff);
                Console.WriteLine(diff.DifficultyToString(adult) + ": " + p + " = " + p.Answer);
                Console.Write("Answer: ");
                input = Console.ReadLine();
                while (!p.CheckAnswer(Convert.ToDouble(input)))
                {
                    Console.WriteLine("Try again.");
                    Console.Write("Answer: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Good job. You earned " + p.PossiblePointEarnings() + " points.");
                points += p.PossiblePointEarnings();

                diff = Difficulty.IMPOSSIBLE;
                p = new Problem(diff);
                Console.WriteLine(diff.DifficultyToString(adult) + ": " + p + " = " + p.Answer);
                Console.Write("Answer: ");
                input = Console.ReadLine();
                while (!p.CheckAnswer(Convert.ToDouble(input)))
                {
                    Console.WriteLine("Try again.");
                    Console.Write("Answer: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Good job. You earned " + p.PossiblePointEarnings() + " points.");
                points += p.PossiblePointEarnings();

                diff = Difficulty.EASY;
                p = new Problem(diff);
                adult = !adult;
                Console.WriteLine("\n");
            }

            Console.WriteLine("You earned " + points + " points.");

            //Console.WriteLine("RUN\tFREQ\tOP\tDIFFICULTY");
            //diff = Difficulty.EASY;
            //pluses = 0; minuses = 0; mults = 0; divs = 0;
            //for(int i = 0; i < 100; i++)
            //{
            //    freq = r.NextDouble();
            //    Operator op = ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(diff, freq);
            //    switch (op)
            //    {
            //        case Operator.PLUS: pluses++;
            //            break;
            //        case Operator.MINUS: minuses++;
            //            break;
            //        case Operator.MULT: mults++;
            //            break;
            //        case Operator.DIV: divs++;
            //            break;
            //    }
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",
            //                                       i,
            //                                       freq,
            //                                       op,
            //                                       DifficultyExtensions.DifficultyToString(diff, false)
            //                                       )
            //    );
            //}
            //Console.WriteLine("PLUSES\tMINUSES\tMULTS\tDIVS");
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", pluses, minuses, mults, divs);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("RUN\tFREQ\tOP\tDIFFICULTY");
            //diff = Difficulty.NORMAL;
            //pluses = 0; minuses = 0; mults = 0; divs = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    freq = r.NextDouble();
            //    Operator op = ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(diff, freq);
            //    switch (op)
            //    {
            //        case Operator.PLUS: pluses++;
            //            break;
            //        case Operator.MINUS: minuses++;
            //            break;
            //        case Operator.MULT: mults++;
            //            break;
            //        case Operator.DIV: divs++;
            //            break;
            //    }
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",
            //                                       i,
            //                                       freq,
            //                                       op,
            //                                       DifficultyExtensions.DifficultyToString(diff, false)
            //                                       )
            //    );
            //}
            //Console.WriteLine("PLUSES\tMINUSES\tMULTS\tDIVS");
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", pluses, minuses, mults, divs);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("RUN\tFREQ\tOP\tDIFFICULTY");
            //diff = Difficulty.HARD;
            //pluses = 0; minuses = 0; mults = 0; divs = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    freq = r.NextDouble();
            //    Operator op = ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(diff, freq);
            //    switch (op)
            //    {
            //        case Operator.PLUS: pluses++;
            //            break;
            //        case Operator.MINUS: minuses++;
            //            break;
            //        case Operator.MULT: mults++;
            //            break;
            //        case Operator.DIV: divs++;
            //            break;
            //    }
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",
            //                                       i,
            //                                       freq,
            //                                       op,
            //                                       DifficultyExtensions.DifficultyToString(diff, false)
            //                                       )
            //    );
            //}
            //Console.WriteLine("PLUSES\tMINUSES\tMULTS\tDIVS");
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", pluses, minuses, mults, divs);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("RUN\tFREQ\tOP\tDIFFICULTY");
            //diff = Difficulty.VERY_HARD;
            //pluses = 0; minuses = 0; mults = 0; divs = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    freq = r.NextDouble();
            //    Operator op = ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(diff, freq);
            //    switch (op)
            //    {
            //        case Operator.PLUS: pluses++;
            //            break;
            //        case Operator.MINUS: minuses++;
            //            break;
            //        case Operator.MULT: mults++;
            //            break;
            //        case Operator.DIV: divs++;
            //            break;
            //    }
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",
            //                                       i,
            //                                       freq,
            //                                       op,
            //                                       DifficultyExtensions.DifficultyToString(diff, false)
            //                                       )
            //    );
            //}
            //Console.WriteLine("PLUSES\tMINUSES\tMULTS\tDIVS");
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", pluses, minuses, mults, divs);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("RUN\tFREQ\tOP\tDIFFICULTY");
            //diff = Difficulty.IMPOSSIBLE;
            //pluses = 0; minuses = 0; mults = 0; divs = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    freq = r.NextDouble();
            //    Operator op = ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(diff, freq);
            //    switch (op)
            //    {
            //        case Operator.PLUS: pluses++;
            //            break;
            //        case Operator.MINUS: minuses++;
            //            break;
            //        case Operator.MULT: mults++;
            //            break;
            //        case Operator.DIV: divs++;
            //            break;
            //    }
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}",
            //                                       i,
            //                                       freq,
            //                                       op,
            //                                       DifficultyExtensions.DifficultyToString(diff, false)
            //                                       )
            //    );
            //}
            //Console.WriteLine("PLUSES\tMINUSES\tMULTS\tDIVS");
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", pluses, minuses, mults, divs);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("TESTING PROBLEM GENERATION");
            //Console.ReadKey();
            //Console.WriteLine("EASY PROBLEMS:");
            //diff = Difficulty.EASY;

            //for (int i = 0; i < 10; i++)
            //{
            //    p = new Problem(diff);
            //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, p.ToString(), p.Answer.ToString(), diff);
            //    p = null;
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("NORMAL PROBLEMS:");
            //diff = Difficulty.NORMAL;
            //for (int i = 0; i < 10; i++)
            //{
            //    p = new Problem(diff);
            //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, p.ToString(), p.Answer.ToString(), diff);
            //    p = null;
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("HARD PROBLEMS:");
            //diff = Difficulty.HARD;
            //for (int i = 0; i < 10; i++)
            //{
            //    p = new Problem(diff);
            //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, p.ToString(), p.Answer.ToString(), diff);
            //    p = null;
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("VERY HARD PROBLEMS:");
            //diff = Difficulty.VERY_HARD;
            //for (int i = 0; i < 10; i++)
            //{
            //    p = new Problem(diff);
            //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, p.ToString(), p.Answer.ToString(), diff);
            //    p = null;
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("IMPOSSIBLE PROBLEMS:");
            //diff = Difficulty.IMPOSSIBLE;
            //for (int i = 0; i < 10; i++)
            //{
            //    p = new Problem(diff);
            //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", i, p.ToString(), p.Answer.ToString(), diff);
            //    p = null;
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();
            //Console.Clear();
            //DifficultyScheme easy = new DifficultyScheme(Difficulty.EASY);
            //DifficultyScheme donk = new DifficultyScheme(Difficulty.EASY, Difficulty.EASY, Difficulty.IMPOSSIBLE, Difficulty.EASY, Difficulty.VERY_HARD);

            //Console.WriteLine("Try and answer this: (EasyVal, ImpRng, EasyOp, HardAns)");
            //p = new Problem(donk);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");


            //Console.WriteLine("Try and answer this: (EasyVal, EasyRng, EasyOp, EasyAns)");
            //p = new Problem(easy);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");

            //Console.WriteLine("Try and answer this: (NORMAL)");
            //p = new Problem(easy);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");

            //Console.WriteLine("Try and answer this: (HARD) ");
            //p = new Problem(easy);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");

            //Console.WriteLine("Try and answer this: (VERY HARD)");
            //p = new Problem(easy);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");

            //Console.WriteLine("Try and answer this: (IMPOSSIBLE)");
            //p = new Problem(easy);
            //Console.WriteLine(p.ToString());
            //Console.Write("Answer: ");
            //input = Console.ReadLine();
            //while (!p.CheckAnswer(Convert.ToDouble(input)))
            //{
            //    Console.WriteLine("Try again.");
            //    Console.Write("Answer: ");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Good job.");

            
            Console.ReadKey();
            
        }
    }
}
