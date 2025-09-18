namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            TxtFile textFile = new TxtFile(128);
            textFile.Read();
            textFile.Write();
            textFile.Edit();
            textFile.Delete();


            #endregion
            #region Task2
            //var bank1 = new Bank();
            //if (bank1.CheckUserHistory())
            //{
            //    var total = bank1.CalculateLoanPercent(6, 200);
            //    Console.WriteLine($"Total amount of money that you should pay: {total}");
            //}
            //else Console.WriteLine("Loan denied!");

            //Console.WriteLine(new string('-',50));
            //var microFinanace = new MicroFinance();
            //if (microFinanace.CheckUserHistory())
            //{
            //        var total = microFinanace.CalculateLoanPercent(6, 200);
            //        Console.WriteLine($"Total amount of money that you should pay: {total}");
            //}
            //    else Console.WriteLine("Loan denied!");
            #endregion
        }
  
    }
}
