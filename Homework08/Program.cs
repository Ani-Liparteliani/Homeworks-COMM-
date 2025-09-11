namespace Homework08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*1. დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
            a. a - მინიმალური რიცხვი
            b. b - მაქსიმალური რიცხვი
            c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
            იპოვეთ ყველა რიცხვი a - >b შუალედში რომლის n ხარისხი
            მოთავსებულია ამ ინტერვალში
            Input : 49, 71 , 2 // 7^2 და 8^2 მოთავსდება ამ შუალედში
            Output : 2
            */
            //Console.WriteLine("Enter min number: ");
            //int num1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter max number: ");
            //int num2 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter power: ");
            //int n = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(Numbers(num1, num2, n));
            #endregion
            #region Task2
            /*2. დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
              აღნიშნულია ორი ერთნაირი სიმბოლოთი.
               Input : AA
               Output : 1
              Input : AABBC
              Output : 2
              Input : ABABC
              Output : 2
             * 
             */
            //Console.WriteLine("Enter input: ");
            //string socks = Console.ReadLine();
            //Console.WriteLine(PairsOfSocks(socks));

            #endregion

            #region Task3
            /*
             * 3. დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
                ბოლოსართს ორ სტრინგს შორის .
                   Input : multiplication , substraction
                    Output : tion
                    Input : Some Random Text, It is Some Random Text
                    Output : Some Random Text

             * */
            string input1 = "multiplication";
            string input2 = "substraction";
            Console.WriteLine(LongestCommonSuffix(input1, input2));
            #endregion
            #region Task4
            /*
             * 
             * დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს , შეამოწმებს
            გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ
            ოპერაციებს .
            თუ გადაეცემა სტრინგების ლისტი - დაბეჭდავს ყველა სტრინგს UpperCase-ში
            თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი ( int) - დაითვლის მათ ჯამს
            თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ
            ელემენტს .
             * */
            //List<string> stringList = new List<string> { "hello", "world" };
            //GenericList(stringList);
            //List<int> intList = new List<int> { 1, 2, 3, 4 };
            //GenericList(intList);
            //List<bool> boolList = new List<bool> { true, false, true, true };
            //GenericList(boolList);
            #endregion

            #region Task5
            /*          რეკურსია
                      დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს .
                      Input : 12345
                    Output : 1 - 2 - 3 - 4 - 5
            */
            //int num = 1234;
            //RecursionTask(num);

            #endregion

            #region Task6
            /*
             * 6. დაწერეთ პროგრამა რომელიც შეამოწმებს შეიცავს თუ არა მასივი
              დუბლიკატებს
              Input: nums = [1,2,3,1]
              Output: true
              Input: nums = [1,2,3,4]
              Output: false
             * */
            //int[] arr = { 1, 2, 3, 4, 5, 6,2, 7};
            //Console.WriteLine(DuplicateChecker(arr));
            #endregion
        }
        static int Numbers(int a, int b, int n)
        {
            double rootA = Math.Pow(a, 1.0 / n);
            double rootB = Math.Pow(b, 1.0 / n);
            var result = new List<int>();
            int counter = 0;
            if (a < b)
            {
                int num1 = (int)Math.Ceiling(rootA);
                int num2 = (int)Math.Floor(rootB);
                for (int i = num1; i <= num2; i++)
                {
                    counter++;
                }
            }
            else if (a > b)
            {
                int num1 = (int)Math.Ceiling(rootB);
                int num2 = (int)Math.Floor(rootA);
                for (int i = num1; i <= num2; i++)
                {
                    counter++;
                }
            }
            //else if(a == b)
            //{
            //}
            return counter;
        }

        static int PairsOfSocks(string socks)
        {

            char[] socksArray = socks.ToCharArray();
            var socksss = socksArray.GroupBy(x => x)
                .Select(n => new { Number = n.Key, Count = n.Count() });
            var numberOfPairs = 0;

            foreach (var item in socksss)
            {
                numberOfPairs += item.Count / 2;
            }



            return numberOfPairs;
        }

        static string LongestCommonSuffix(string input1, string input2)
        {
            int minLen = Math.Min(input1.Length, input2.Length);

            for (int len = minLen; len > 0; len--)
            {
                string sub1 = input1.Substring(input1.Length - len);
                string sub2 = input2.Substring(input2.Length - len);

                if (sub1 == sub2)
                {
                    return sub1;
                }
            }
            return null;
        }

        static void GenericList<T>(List<T> list)
        {
            if (typeof(T) == typeof(string))
            {
                foreach (var item in list)
                {
                    Console.WriteLine(((string)(object)item).ToUpper());
                }
            }
            else if (typeof(T) == typeof(int))
            {
                var counter = 0;
                foreach (var item in list)
                {
                    counter += (int)(object)item;
                }
                Console.WriteLine(counter);
            }
            else if (typeof(T) == typeof(bool))
            {
                Console.WriteLine($"first Element is {list[1]},\n last element is {list[^1]}, \n middle element is {list[list.Count / 2]}");
            }


        }

        static void RecursionTask(int number)
        {
            var list = new List<int>();
            if (number < 10)
            {
                Console.Write(number);
                return;
            }
            RecursionTask(number / 10);
            Console.Write($" -   {(number % 10)}");
        }
        static bool DuplicateChecker(int[] array, int acc = 0)
        {
            if (acc + 1 >= array.Length)
            {
                return false;
            }
            for (int i = acc + 1; i < array.Length; i++)
            {
                if (array[i] == array[acc])
                {
                    return true;
                }
            }
            return DuplicateChecker(array, acc + 1);
        }
    }
}
