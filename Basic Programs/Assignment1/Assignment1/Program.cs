using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment1 as_obj = new Assignment1();
            //as_obj.print();

            //Assignment2 as_obj = new Assignment2();
            //as_obj.print();

            //Assignment3 as_obj = new Assignment3();
            //as_obj.convertToFahrenheit();

            //Assignment4 as_obj = new Assignment4();
            //as_obj.findLongestWord();

            //Assignment5 as_obj = new Assignment5();
            //as_obj.findSum();

            //Assignment6 as_obj = new Assignment6();
            //as_obj.findSum();

            //Assignment7 as_obj = new Assignment7();
            //as_obj.stringReverse();

            //Assignment8 as_obj = new Assignment8();
            //as_obj.findLeapYear();

            //Assignment9 as_obj = new Assignment9();
            //as_obj.findLargest();

            //Assignment10 as_obj = new Assignment10();
            //as_obj.print();

            //Assignment11 as_obj = new Assignment11();
            //as_obj.check();

            //Assignment12 as_obj = new Assignment12(123,"Subramani",208);
            //as_obj.printBill();

            //Assignment13 as_obj = new Assignment13();
            //as_obj.calculator();

            //Assignment14 as_obj = new Assignment14();
            //as_obj.print();

            Assignment15 as_obj = new Assignment15();
            as_obj.cubes();


            Console.Read();
        }
    }
    
    class Assignment1
    {
        public void print()
        {
            int number;
            Console.WriteLine("Enter the number to be printed");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("{0}\t{0}\t{0}\t{0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);
                Console.WriteLine("{0}\t{0}\t{0}\t{0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);
            }
            else Console.WriteLine("Invalid Input");

           
        }
    }

    class Assignment2
    {
        public void print()
        {
            int number;
            Console.WriteLine("Enter the number to be printed");
            if (int.TryParse(Console.ReadLine(), out number) && number < 10 )
            {
               for(int i = 1; i <= 5; i++)
                {
                    if (i == 1 || i == 5)
                        Console.WriteLine("{0} {0} {0}", number);
                    else
                        Console.WriteLine("{0}   {0}", number);
                }
            }
            else Console.WriteLine("Invalid Input");
        }
    }//class ends

    class Assignment3
    {
        public void convertToFahrenheit()
        {
            double deg_number;
            double fah_number;
            Console.WriteLine("Enter the number temperature in celsius");
            if (double.TryParse(Console.ReadLine(), out deg_number))
            {
                fah_number = deg_number;
                fah_number = fah_number * 1.80;
                fah_number = fah_number + 32;
                Console.WriteLine("Celsius is {0}\nFahrenheit is {1}", deg_number, fah_number);
            }
            else Console.WriteLine("Invalid Input");
        }
    }//class ends

    class Assignment4
    {
        public void findLongestWord()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            var input_processing = input.Split(' ').Distinct(StringComparer.CurrentCultureIgnoreCase).OrderByDescending(x=>x.Length);
  
            foreach (string s in input_processing)
            {
                Console.Write("Maximum Length Word is {0}",s);
                break;
            }
        }
    }//class ends

    class Assignment5
    {

        public bool checkprime(double number)
        {
            if(number%2==0)
            {
                return false;
            }
            else
            {
                for(int i=3;i<number/2;i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
           
        }
        public void findSum()
        {
           double sum = 0;
           int count = 0;
           for(double i=2;count<=1000;i++)
            {
                if(checkprime(i))
                {
                    sum = sum + i;
                    Console.WriteLine("Count {0} Number {1} ", count, i);
                    count++;
                    
                }
            }
            Console.WriteLine("Sum of the First 500 prime numbers is {0} ", sum);
        }
    }//class ends

    class Assignment6
    {
        public void findSum()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int input_integer;
            int sum = 0;
            for(int i=0; i <= (input.Length-1);i++)
            {
                input_integer = input[i] - '0';
                sum = sum + input_integer;
            }
            Console.WriteLine("Sum is {0}",sum);
            

          
        }
    }//class ends

    class Assignment7
    {
        public void stringReverse()
        {
            Console.WriteLine("Enter a string");
            List<string> input_processing = new List<string>(Console.ReadLine().Split(' '));
            input_processing.Reverse();
            foreach (string s in input_processing)
            {
                Console.Write(s);
                Console.Write(" ");
            }
        }
    }//class ends

    class Assignment8
    {
        public void findLeapYear()
        {
            Console.WriteLine("Enter the Year in the Format YYYY");
            string input = Console.ReadLine();
            int year = (input[input.Length-2] - '0') * 10 + (input[input.Length - 1] - '0');
            if (year % 4 == 0)
                Console.WriteLine("Its a Leap Year");
            else
                Console.WriteLine("Its not a Leap Year");
        }
    }

    class Assignment9
    {

        public void findLargest()
        {
            Console.WriteLine("Enter 3 Numbers");
            int largest = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (largest < b) largest = b;
            int c = int.Parse(Console.ReadLine());
            if (largest < c) largest = c;

            Console.WriteLine("Largest of the three numbers is {0} ", largest);
        }
    }
    
    class Assignment10
    {
        public void print()
        {

            int temp=int.Parse(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            if(temp>=0 && temp <10)
                Console.WriteLine("Very Cold weather");
            if(temp>=10 && temp<20)
                Console.WriteLine("Cold weather");
            if (temp>=20 && temp<30)
                Console.WriteLine("Normal weather");
            if (temp >= 30 && temp < 40)
                Console.WriteLine("Hot weather");
            if (temp>=40)
                Console.WriteLine("Very Hot weather");

        }
    }
    class Assignment11
    {

        public void check()
        {
            Console.WriteLine("Enter a alphabet");
            string input = Console.ReadLine();
            char alphabet = input[0];
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if(vowels.Contains(alphabet))
                Console.WriteLine("Its a Vowel");
            else
                Console.WriteLine("Its a Consonant");

        }
    }

    class Assignment12
    {
        int cust_id;
        string cust_name;
        double units_consumed;
        double bill_amount = 100;
        double surcharge = 0;
        public Assignment12(int id,string name,double units)
        {
            cust_id = id;
            cust_name = name;
            units_consumed = units;
        }

        public void printBill()
        {
            Console.WriteLine("Customer ID : {0}", cust_id);
            Console.WriteLine("Customer Name : {0}", cust_name);
            if (units_consumed <= 199)
            {
                if (bill_amount < units_consumed * 1.20) bill_amount = units_consumed * 1.20;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit: {0}", bill_amount);

                if (bill_amount > 400)
                {
                    surcharge = bill_amount * 0.15;
                    Console.WriteLine("Surcharge Amount: {0}", surcharge);
                }
                Console.WriteLine("Net Amount: {0}", (bill_amount + surcharge));
            }
            if (units_consumed >= 200 && units_consumed < 400)
            {
                bill_amount = units_consumed * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit: {0}", bill_amount);
                if (bill_amount > 400)
                {
                    surcharge = bill_amount * 0.15;
                    Console.WriteLine("Surcharge Amount: {0}", surcharge);
                }
                Console.WriteLine("Net Amount: {0}", (bill_amount+surcharge));

            }
            if (units_consumed >= 400 && units_consumed < 600)
            {
                bill_amount = units_consumed * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit: {0}", bill_amount);
                if (bill_amount > 400)
                {
                    surcharge = bill_amount * 0.15;
                    Console.WriteLine("Surcharge Amount: {0}", surcharge);
                }
                Console.WriteLine("Net Amount: {0}", (bill_amount + surcharge));
            }
            if (units_consumed > 600)
            {
                bill_amount = units_consumed * 2.00;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit: {0}", bill_amount);
                if (bill_amount > 400)
                {
                    surcharge = bill_amount * 0.15;
                    Console.WriteLine("Surcharge Amount: {0}", surcharge);
                }
                Console.WriteLine("Net Amount: {0}", (bill_amount + surcharge));
            }
       }
    }

    class Assignment13
    {
        public void calculator()
        {
            char[] operators = {'*', '+', '-', '/'};
            char choice;
            if(char.TryParse(Console.ReadLine(),out choice))
            {
                if(operators.Contains(choice))
                {
                    Console.WriteLine("Enter two numbers");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    double answer=0;
                    switch(choice)
                    {
                        case '+':answer = a + b;break;
                        case '-': answer = a - b; break;
                        case '/': answer = a / b; break;
                        case '*': answer = a * b; break;
                    }
                    Console.WriteLine("RESULT IS {0}", answer);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }  
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class Assignment14
    {

    public void print()
        {
            int value = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int levels = width;
            int current_level = 0;
            for(int i=0;i<=width && current_level<=width;i++)
            {
                if(i<(width-current_level))
                Console.Write("{0}", value);

                else
                {
                    current_level++;
                    i = -1;
                    Console.WriteLine("");
                }
            }

        }
    }

    class Assignment15
    {
        public void cubes()
        {
            Console.WriteLine("Enter the number of cubes");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                int cube = i * i * i;
                Console.WriteLine("CUBE OF {0} is {1}", i,cube);
            }
        }
    }

    


