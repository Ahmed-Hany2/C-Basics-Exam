namespace C__Basics_Exam
{

    //   Questions[ 1, 2, 3, 4, 5, 7, 8, 10 ]    =====> solved
    //   Questions [ 6, 8 ]                      =====> not solved
    internal class Program
    {
        #region Question (2)
        public static double Calculator(int a, int b, char op) 
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Operator isnot valid");
                    break;
            }
            return result;

        }
        #endregion

        #region Question (3)
        public static void MultiTable(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
                Console.WriteLine("--------------------------");
            }
        }
        #endregion

        #region Question (4)
        public static int PrimeNumbers(int[] array) 
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] >= 2)
                {
                    bool isPrime = true;
                    for (int j = array[i]-1; j>1; j--)
                    {
                        if (array[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                        sum ++;
                    
                }      
            }
            return sum;
        }
        #endregion

        #region Question (5)
        public static void MaxInArray(int[] numbers)
        {
            int max = numbers[0];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    index = i;
                }
            }
            Console.WriteLine($"The maximum number in the array is: {max}");
            Console.WriteLine($"and the index is: {index}");
        }
        #endregion

        #region Question (7)
        public static void DivideNotNull(int? a, int? b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not possible");
            }
            else if(a == null || b == null)
            {
                Console.WriteLine("the result is null");
            }
            else
                Console.WriteLine ($"The result of division is: { (double)a / b }");
        }
        #endregion

        #region Question (8)
        public static int SumEvenNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        #endregion

        #region Question (10)
        public static void ScoresAverage(int?[] scores) 
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i].HasValue)
                {
                    sum += scores[i].Value;
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("the Average is null");
            else
                Console.WriteLine ($" The average of NOT-NULL values is: { (double) sum / count }");

        }
        #endregion
        static void Main(string[] args)
        {
            #region Question (1)
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your nationality: ");
            string nationality = Console.ReadLine();
            if(age >= 18 && nationality == "Egyptian")
                Console.WriteLine("eligible to vote");
            else
                Console.WriteLine("not eligible");
            #endregion

            #region Question (2)
            int num1, num2;
            char op;
            double result= 0;
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator from (+, -, *, /) only: ");
            op = char.Parse(Console.ReadLine());
            if (num2 == 0 && op == '/')
                Console.WriteLine("Division by zero isnot possible");

            else if(op != '+' && op != '-' && op != '*' && op != '/')
                Console.WriteLine("Operator isnot valid");

            else
            {
                result = Calculator(num1, num2, op);
                Console.WriteLine($"The result of {num1} {op} {num2} is: {result}");
            }
            #endregion

            #region Question (3)
            int num;
            Console.WriteLine("Enter a number to print the multiplication table: ");
            num = int.Parse(Console.ReadLine());
            MultiTable(num);

            #endregion

            #region Question (4)
            int[] array = [ 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];   // ( 2, 3, 5, 7, 11, 13 ) 
            int primeCount = PrimeNumbers(array);
            Console.WriteLine($"number of prime numbers in the array is: {primeCount}");
            #endregion

            #region Question (5)
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            MaxInArray(numbers);
            #endregion

            #region Question (7)
            int? a = 10, b = null;  
            DivideNotNull(a, b);
            #endregion

            #region Question (8)
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int sum = SumEvenNumbers(nums);
            Console.WriteLine($"The sum of even numbers in the array is: {sum}");
            #endregion

            #region Question (10)
            int?[] scores = { 85, null, 90, 78, null, 88, 92 };
            ScoresAverage(scores);
            #endregion


        }
    }
}
