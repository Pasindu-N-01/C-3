// See https://aka.ms/new-console-template for more information

using System;
public class Exercise8  
{ 
    public static void Main()
{
    Console.Write("Find the largest of three numbers:\n");
    Console.Write("\n\n");
    Console.Write("Input the 1st number :");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the  2nd number :");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the 3rd  number :");
    int number3 = Convert.ToInt32(Console.ReadLine());
 
    if (number1>number2 && number1>number3){
        Console.Write("The 1st Number is the greatest among three. \n\n");
    }
    else if(number2>number1 && number2>number3){
        Console.Write("The 2nd Number is the greatest among three. \n\n");
    }
    else{
        Console.Write("The 3rd Number is the greatest among three \n\n");
         }
}
}