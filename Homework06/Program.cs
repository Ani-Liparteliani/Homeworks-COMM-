namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01:
            /*დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
             რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
             ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .
            */

            //Console.WriteLine("Enter array length: ");
            //var input = Console.ReadLine();
            //var isInt = int.TryParse(input, out var size);
            //int[] array = new int[size];



            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = i + 1;
            //}

            //var evenNumbers = new List<int>();
            //var oddNumbers = new List<int>();
            //for(int i =0; i< array.Length; i++)
            //{
            //    if (array[i]%2 == 0)
            //    {
            //        evenNumbers.Add(array[i]);
            //    }
            //    else
            //    {
            //        oddNumbers.Add(array[i]);
            //    }
            //}
            //int[] array1 = evenNumbers.ToArray();
            //int[] array2 = oddNumbers.ToArray();


            //Console.WriteLine("Array1: ");
            //foreach(var item in array1)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine("\nArray2: ");
            //foreach (var item in array2)
            //{
            //    Console.Write($" {item} ");
            //}
            #endregion

            #region Task02:
            /* შექმენით კონტაქტების აპლიკაცია რომელსაც ექნება კონტაქტის დამატების,
             *  წაშლის და განახლების ფუნქციონალი ( გამოიყენეთ Dictionary)
            */
            // var contacts = new Dictionary<string, int>
            // {
            //    {"Elon", 123456 },
            //    {"John Smith", 234567 }
            // };

            //Console.WriteLine("1. Add a new contact.\n" +
            //                  "2.Delete contact.\n" +
            //                  "3. edit contact");
            //Console.WriteLine("Choose desired service number: ");
            //var num1 = Console.ReadLine();
            //var isInt = int.TryParse(num1, out var num);

            //if (isInt)
            //{
            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter name: ");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Enter phone number: ");
            //            int number = Convert.ToInt32(Console.ReadLine());

            //            contacts.Add(name, number); ;
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter contact name: ");
            //            string conName = Console.ReadLine();
            //            foreach(KeyValuePair <string, int> item in contacts)
            //            {
            //                if (item.Key.Equals(conName)){
            //                    contacts.Remove(item.Key);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Contact not found!");
            //                }
            //            }

            //            break;
            //        case 3:
            //            Console.WriteLine("Enter contact name: ");
            //            string conName1 = Console.ReadLine();
            //            foreach (KeyValuePair<string, int> item in contacts)
            //            {
            //                if (item.Key.Equals(conName1))
            //                {
            //                    Console.WriteLine("Enter new phone number: ");
            //                    var newPhoneNumber = Convert.ToInt32(Console.ReadLine());
            //                    contacts[item.Key] = newPhoneNumber;
            //                    Console.WriteLine("Updated!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Contact not found!");
            //                }
            //            }


            //            break;
            //    }

            //    foreach(KeyValuePair<string,int> item in contacts)
            //    {
            //        Console.WriteLine($"contact info: {item.Key}\n {item.Value}");
            //    }
            //}
            #endregion


            #region Task03:
            //var massive = new int[5] { 1, 1, 2, 3, 3 };

            //var random = massive.GroupBy(x => x)
            //    .ToDictionary(x => x.Key, x => new { Count = x.Count(), Sum = x.Sum() });



            //foreach(var item in random)
            //{
            //    Console.WriteLine($"{item.Key} appears {item.Value.Count} times, sum {item.Value.Sum}");
            //}
            #endregion

            #region Task04:
            /*
             *დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ n მონაწილის შედეგს . მაგ (1 2 3 4 5 6 7 8 9 10)
                a. Input:
                 2
                 Output
                9 10

            */
            int[] scores = { 1, 2, 3, 4, 8, 2, 1023, 1 };
            Console.WriteLine("Enter a number: ");
            var num1 = Console.ReadLine();
            var isInt = int.TryParse(num1, out var n);
            if (isInt && n <= scores.Length)
            {
                var topResults = scores.OrderByDescending(score => score)
                                .Take(n);

                Console.WriteLine($"Top results are: ");
                foreach (var result in topResults)
                {
                    Console.Write($" {result} ");
                }
            }

            #endregion
        }
    }
}
