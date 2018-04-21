/*
 https://www.codingame.com/ide/puzzle/horse-racing-duals
 Jade Gorton u3158046
 25xp for 50%
 25xp for 100%

 earned 50xp
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

/*
    Goal for this activity is to find nearest value between two in array
    By sorting the array, you guarantee that closest values are together.
    Then by looping through each item in array once. By comparing each value side by side
    you will only need loop through array once once it sorted.
 */
class Solution
{
    static void Main(string[] args)
    {
        /*
            Activity requires N be an Int for how many entries & lines going include
            and pi is power for each index representing the horses.
            This is pre-generated code with code created hold the results as Horses int[].
        */
        int N = int.Parse(Console.ReadLine());
        int[] Horses = new int[N];
        Console.Error.WriteLine(N);
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            Horses[i] = pi;
        }
        Console.WriteLine(FindClosest(Horses));//Function To return result of int[] and return minimal difference between two elements in the array
    }

    public static int FindClosest(int[] input)
    {
        Array.Sort(input);
        //Sort the array so you can make assumptions where, two closest elements will be next to each other
        int Closest = int.MaxValue;//Set it as maximin value so, that it will always return correct result if it does exist
        //Limitations on input are >= 0 for horse power.
        List<int> HorsesPower = input.ToList();//Convert the Horse Power array into a list so it's easier to manipulate. 
        if (input.Length == 1)//if Input length is only 1 element closest element is itself so distance is 0.
        {
            return 0;
        }

        /* 
         * Set Closest to Max value of an int
         * for each item in array
         *      get Absolute Value difference as distance
         *      if distance is Lower than Closest 
         *          Assign Closest value of distance
         *     if distance equals 0
         *         return Closest
         * end for each
         *   return Closest
         */
        for (int i = 0; i < input.Length - 1; i++)
        {
            int D = Math.Abs(input[i] - input[i + 1]);
            if (D < Closest)//Compare the values if it's smaller than Closest Assign it.
            {
                Closest = D;
            }

            if (D == 0)
                return 0;//if you already found two values that are exact value you can't get any closer so break out of the function and return 0.
        }
        return Closest;
    }
}