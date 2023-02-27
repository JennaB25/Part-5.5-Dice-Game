namespace Part_5._5_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            double bankAccountNum = 100.00;
            Console.WriteLine("Dice Betting Game");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("How much do you bet?");
            Console.WriteLine($"Bank Account: {bankAccountNum}");          
            string bet1 = Console.ReadLine();
            bet1 = bet1.Replace("$", "");
            double _bet1 = Convert.ToDouble(bet1);

        }
    }
}