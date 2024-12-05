using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace Assignment5._3._2
{
    internal class Program
    {
        //You are climbing a staircase. It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        //Example 1:
        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps
        //Example 2:
        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steps:");
            int n = int.Parse(Console.ReadLine());

            int ways = ClimbStairs(n);
            Console.WriteLine($"There are {ways} different ways to climb {n} stairs.");
        }

        static int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;

            int previousStep = 1;
            int currentStep = 2;

            for (int i = 3; i <= n; i++)
            {
                int nextStep = previousStep + currentStep; 
                previousStep = currentStep;       
                currentStep = nextStep;  
            }

            return currentStep;
        }
    }
}