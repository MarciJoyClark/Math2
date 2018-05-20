using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Math_fnc
    {
            public Math_fnc()
            {          
                try
                {
                    Console.WriteLine("Pick a positive whole number.");
                    int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberAdd = numberOne + 13;                
                    Console.WriteLine("That number + 13 is " + numberAdd +  ". Pick a decimal, please.");
                    string ans = Console.ReadLine();
                    Double numberTwo = Convert.ToDouble(ans);
                    Double quotient = numberTwo / 12.5;
                    Console.WriteLine("If I divide your number by 12.5, it's: " + quotient.ToString() +". How about one more positive whole number for the road?");
                    int numberThree = Convert.ToInt32(Console.ReadLine());
                    int numberFour = numberAdd + numberThree;
                    Console.WriteLine(numberAdd + " plus " + numberThree + " is " + numberFour + ". Pretty cool, huh? Your computer asks that you maybe don't high-five it in the face, this time . . .");

                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                    return;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Don't give me a \"0\", please!");
                }
                catch (Exception)
                {
                    Console.WriteLine("You messed something up! Try again!");
                }
                finally
                {
                    Console.ReadLine();
                }
            }
    }
}
