namespace Vazquez_OOPBank
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int startingAmount = 1000;

            Bank Twinstar = new Bank(startingAmount);
            bool bankActive = true;
            do
            {
                Console.WriteLine("Your balance is " + Twinstar.GetBalance().ToString("C") + ", what would you like to do?");
                Console.WriteLine("Your options are: 1.Deposit  2.Withdrawl  3.Check balance  4.Quit");
                string answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    string addinput = Console.ReadLine();
                    int addamount = int.Parse(addinput);
                    Twinstar.add(addamount);
                }
                else if (answer == "2")
                {
                    Console.WriteLine("How much would you like to withdrawl?");
                    string subtractinput = Console.ReadLine();
                    int subtractamount = int.Parse(subtractinput);
                    Twinstar.subtract(subtractamount);
                }
                else if (answer == "3")
                {
                    Console.WriteLine("Your current balance is " + Twinstar.GetBalance());
                }
                else if (answer == "4")
                {
                    bankActive = false;
                }
            } while (bankActive);
        }
    }
}
