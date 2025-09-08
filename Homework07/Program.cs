using System;

namespace Homework07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*1. მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში
            ჩახატულია კიდევ ერთი სხვა კვადრატი .
            დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
            ფართობებს შორის .           
            */
            //int R = Convert.ToInt32(Console.ReadLine());
            //var S2 = Math.Pow(2 * R, 2);
            //var S1 = Math.Pow(R * Math.Sqrt(2), 2);

            //Console.WriteLine($"area of large square is{S2}, and of small one is {S1}");
            #endregion

            #region Task2

            //string[] massive = { "@", "@", "b" };
            //bool equality = false;
            //for (int i = 0; i < massive.Length - 1; i++)
            //{
            //    if (massive[i] == massive[i + 1])
            //    {
            //        equality = true;
            //    }
            //    else equality = false;
            //}

            //if (equality)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Task3
            /*დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა
            საფეხბურთო გუნდმა
            a. მოგება - 3
            b. ფრე = 1
            c. წაგება = 0

            Input : [მოგება - 3,ფრე - 1,წაგება -1]
            Output : 10
            */
            //Console.WriteLine("Enter number of matches won: ");
            //var winScore = Convert.ToInt32(Console.ReadLine())*3;
            //Console.WriteLine("Enter number of loss matches: ");
            //var lossScore = Convert.ToInt32(Console.ReadLine()) * 0;
            //Console.WriteLine("Enter number of drawn matches: ");
            //var drawScore = Convert.ToInt32(Console.ReadLine()) * 1;

            //var totalScore = winScore + lossScore + drawScore;
            //Console.WriteLine($"Total number of points is: {totalScore}");
            #endregion
            #region Task4
            /*დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
            კვირის განმავლობაში .
            გაითვალისწინეთ
            a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
            b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
            c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს

             Input : 8, 8, 8, 8, 8, 8, 0
             Output : 560
             Input : 5,8,8,8,8,8,8
             Output : 690
            */
            //Console.WriteLine();
            //var dailyHours = new int[]
            //{5,8,8,8,8,8,8};
            //var weeklyIncome = 0;

            //for(int i =0; i < dailyHours.Length; i++)
            //{
            //    if (dailyHours[i] <= 8 && i < 5)
            //    {
            //        weeklyIncome += (10 * dailyHours[i]);
            //    } else if (dailyHours[i] > 8 && i < 5)
            //    {
            //        weeklyIncome += (8 * 10 + (dailyHours[i] - 8) * 15);

            //    } 
            //    else if (dailyHours[i] <= 8 && i >= 5)
            //    {
            //        weeklyIncome += (2* (10 * dailyHours[i]));
            //    }
            //    else if (dailyHours[i] > 8 && i >= 5)
            //    {
            //        weeklyIncome += 2 *  (8 * 10 + (dailyHours[i] - 8) * 15);
            //    }
            //}
            //Console.WriteLine($"Income is { weeklyIncome}");
            #endregion

            #region Task5
            /*
             * გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
            .შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
            დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.

            Input : 5, 8, 8, 9,10
            Output : 3
            Input : 5,5,5,5
            Output: 0
            */
            //var dailyExercise = new List<int>
            //{
            //    3,4,5,6,6,6
            //};
            //var progress = 0;
            //for(int i = 0; i< dailyExercise.Count-1; i++)
            //{
            //    if (dailyExercise[i] < dailyExercise[i + 1])
            //    {
            //        progress++;
            //    }
            //}
            //Console.WriteLine($"progress: {progress}");
            #endregion
            #region Task6
            /*დაწერეთ პროგრამა რომელიც ამობეჭდავს N სიგრძის მქონდე ელემენტს
            მასივიდან
            Input : N = 7
            „Hello”, “World” , “Programming”, “communication”
            Output : Programming, “communication”
            Input : N = 15
            „Hello”, “World” , “Programming”, “communication”
            Output : No elements found
            */
            var stringArray = new string[]
            {
             "Hello","house", "Programming", "communication"
            };
            Console.WriteLine("Enter the length of an element: ");
            var N = Convert.ToInt32(Console.ReadLine());

            var element = stringArray.Where(x => x.Length == N).ToList();
            foreach(var item in element)
            {
                Console.WriteLine(item);
            }

         #endregion
        }
    }
}
