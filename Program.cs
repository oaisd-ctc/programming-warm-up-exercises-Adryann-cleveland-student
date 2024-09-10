using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            //Add is adding the 20 and 50 together
            //
            Add(20, 50);

            //2
            //typeing in a number to have it checked if its even or odd
            //if even it returns true, if odd it returns false
            Console.Write("Enter a number: ");
            int number;
            number = int.Parse(Console.ReadLine());
            IsEven(number);
            //3 
            //the code goes through the three numbers and outputs the max number out of the three, which would be 60
            MaxOfThree(10, 15, 60);

            //4
            //string length reads the string and counts how many char/letters are in each word and putting out a number.
            //the number should be 11
            StringLength("Hello World");
            //5
            //you write a sentice or a word, if it starts with hello (lowercase or upper case) it will put out true, if you type hi or something else it will put out false.
            Console.WriteLine("Input a sentice that sarts with hello: ");
            string input;
            input = Console.ReadLine();
            StartsHello(input);

            //6
            //Reverse string takes the sentice or word written below and flips it backwards.
            string reverse = ReverseString("WHAAT im backwords");
            Console.WriteLine(reverse);
            //7
            // factorial of n is the prodict of all the descending intergers.
            //it would take the number 4 and multiply it by its decending numbers
            //4*3*2*1 it would output 24
            int num = 4;
            Console.WriteLine("Factorial of " + num + " | " + Factorial(num));
            //8
            //you enter whataever number you want and it checks if it is prime, if the number is prime it will output the number and tell you its prime. 
            //if its not prime it will tell you its not and is false.
            //some prime numbers: 2, 3, 5, 7, 11, 13
            Console.WriteLine("Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine(n + " Is Prime");
            }
            else
            {
                Console.WriteLine(n + " Not Prime");
            }

            //9
            //fibonacci takes whatever number is entered below wich is 9, and calculates by repeatedly calling itself to sum the prevuous two numbers.
            //it will continue until it reaches the cases 0 or 1.
            //the fiboncci of 9 is 34
            Console.WriteLine(Fibonacci(9));

            //10
            //the code goes through the number array checking each number until it finds the largest
            //the largest number is 9 so it will output 9.
            int[] array = { 1, 2, 5, 6, 3, 9 };
            LargestInArray(array);

            //11
            //you can write a palindrom word wich is a word that when spelled backwords it is the same word like, level, civic, tacocat.
            //if it is a palidrom word it will out put true
            //but if the word is not a palindrom then it will output false.
            Console.WriteLine("Write a palindrom word: ");
            string Pal = Console.ReadLine();
            Console.WriteLine(IsPalindrome(Pal));
            //12
            //it takes all the numbers from the given int array and adds them all together.
            //outputting the sum of the numbers.
            int[] sumarr = { 1, 2, 3, 4, 9 };
            Console.WriteLine(ArraySum(sumarr));
            //13
            //Char count uses the char O and goes through the string to count how many O's are in that string.
            //it should output 6 O's
            string stCount = "HELLLO WOOOOORLD";
            char chCount = 'O';
            int count = CharCount(stCount, chCount);
            Console.WriteLine($"The Character '{chCount}' string count '{count}'");
            //14
            //it takes the two strings that are given and connects them into one line, so it will ouput AceHello.
            ConcatenateStrings("Ace", "Hello");
            //15
            //it takes whatever word that it is given and swaps the first and last letter of the word, so Cool would now spell looc.
            SwapEnds("Cool");
            // Use the Main method to test your functions.
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            //takes the two int of a and b adding them togeather and outputting the sum of both numbers.
            int total;
            total = a + b;
            // TODO: Implement this method.
            Console.WriteLine(total);
            return total;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            //checks the number that is written, if the number is a remainder of 2 then its even
            //if it is not a remainder then its odd
            // TODO: Implement this method.
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " Even");
                return true;
            }
            else
            {
                Console.WriteLine(number + " Odd");
                return false;
            }

        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            //Math.max takes each number a.b.c and checks which is the highest number, whatever is the highest in outputed to the terminal.
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int math = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(math);
            return math;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            //takes the string, counts how many letters/char are in the string and outputs the number of how long it is.
            // TODO: Implement this method.
            Console.WriteLine(s + ": " + s.Length);
            return 0;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            //s.StartsWith checks if the string of whatever word that someone writes.
            //if the sentice starts with hello it will output true, if it isnt hello it will output false.
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            if (s.StartsWith("Hello") || s.StartsWith("hello") || s.StartsWith("HELLO"))
            {
                Console.WriteLine("true");
                return true;

            }
            else
            {
                Console.WriteLine("false");
                return false;
            }


        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            //takes the string and changes it into a char array, then the char array is reversed, outputting the the backwards sentice or word.
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);
            // TODO: Reverse the charArray.
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            //takes in what number it is given and multiplys it by its decsending numbers
            if (n == 0) return 1;
            // TODO: Calculate the factorial.
            return n * Factorial(n - 1);
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            //takes in whatever number is given by the user, checks if the number is prime or not prime.
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            // TODO: Return the correct boolean value.
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            //calculates by repeatedly calling itself to sum the prevuous two numbers
            if (n <= 1) return n;

            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            // TODO: Calculate the nth Fibonacci number.

        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            //takes in the array that is given, it goes through the array checking seeing if it is bigger then 1.
            //then it takes the piggest number and checks if number[1] is larger then number[0] and procecesd to output the largest number in the array.
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine(largest);
            return largest;

        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            //takes in whatever word that is typed by the user, checks if the word is palindrome, if it isnt it will return as false.
            // TODO: Determine if the string is a palindrome.
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            //adds all the numbers in the array together
            int sum = numbers.Sum();
            // TODO: Calculate the sum of the array's elements.


            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            //uses the char that it is given and reads through the string counting how many of that char there is in the string.
            int count = s.Count(f => f == c);

            // TODO: Count how many times character c appears in string s.
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            //takes the two seperate strings and connects them togeather into one line.
            // TODO: Concatenate the two strings with a space in between.
            string name = string.Concat(str1, str2);
            Console.WriteLine(name);
            return str1 + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            //takes in whatever word that it is given, then takes the first char of the word and the last and swaping the places of both.
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string middlepart = s.Substring(1, s.Length - 2);
            Console.WriteLine(lastChar + middlepart + firstChar);
            // TODO: Swap the first and last characters and return the modified string.
            return lastChar + middlepart + firstChar;
        }
    }
}
