using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCoding
{
    public class OddNumberCalculator
    {
        public static int SumOfOddNumbers(int[] numbers) //This targets the int numbers array and here we're creating the method
        {
            int sum = 0;

            foreach(int number in numbers)
            { //if 'number' is '5', then '5 % 2' is '1' because '5' divided by '2' leaves a remainder off '1' , since '1' is not equal to '0' the condition is true .
                if(number % 2 != 0) //number % 2, we're calculating the remainder when 'number' is divided by 2. If the remainder is '0' it means that the 'number' is even bc it is divisible evenly by 2.  
                { //If the remainder is not'0', It means that 'number' is an odd number. If the conition is true, the code inside the 'if' statement is executed and the 'number' will be added to the 'sum' variable.
                    sum += number;
                }
            } //So if the context of the method 'SumOfOddNumbers', the line 'if(number % 2 != 0)' checks if the current number is odd, and if so, it adds to the 'sum' variable.
            return sum;
        }
    }
}
