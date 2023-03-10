namespace Part_5._5_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            double bankAccount = 100.00;
            Console.WriteLine("Dice Betting Game");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("How much do you bet?");
            Console.WriteLine($"Bank Account: ${bankAccount}");          
            string bet1 = Console.ReadLine();
            bet1 = bet1.Replace("$", "");
            if (Int32.TryParse(bet1, out int result))
            {
                double _bet1 = Convert.ToDouble(bet1);
                if (_bet1 > bankAccount)
                {
                    _bet1 = bankAccount;
                    Console.WriteLine($"Max fee reached: Bet set to ${bankAccount}");
                }
                else if (_bet1 < 0)
                {
                    _bet1 = 0;
                    Console.WriteLine($"Invalid Number: Bet set to $0.00");
                }
                Console.WriteLine("Pick One:");
                Console.WriteLine("      (Doubles)           (Not Doubles)       (Even Sum)      (Odd Sum)");
                Console.WriteLine("(Win double your bet)  (Win half your bet)  (Win your bet)  (Win your bet)");
                string optionOne = Console.ReadLine().ToUpper();
                string doubles = "DOUBLES";
                string notDoubles = "NOT DOUBLES";
                string evenSum = "EVEN SUM";
                string oddSum = "ODD SUM";
                if (optionOne == doubles)
                {
                    Console.WriteLine("Press Enter to roll the dice:");
                    Console.ReadLine();
                    Die die1 = new Die();
                    die1.DrawRoll();
                    Die die2 = new Die();
                    die2.DrawRoll();
                    if (die1.Equals(die2))
                    {
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You won: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${(_bet1 * 2) + bankAccount}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no you lost, try again.");
                        Console.WriteLine($"You lost: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${bankAccount - _bet1}");
                    }
                }
                else if (optionOne == notDoubles)
                {
                    Console.WriteLine("Press Enter to roll the dice:");
                    Console.ReadLine();
                    Die die1 = new Die();
                    die1.DrawRoll();
                    Die die2 = new Die();
                    die2.DrawRoll();
                    if (die1.Roll != die2.Roll)
                    {
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You won: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${(_bet1 / 2) + bankAccount}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no you lost, try again.");
                        Console.WriteLine($"You lost: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${bankAccount - _bet1}");
                    }
                }
                else if (optionOne == evenSum)
                {
                    Console.WriteLine("Press Enter to roll the dice:");
                    Console.ReadLine();
                    Die die1 = new Die();
                    die1.DrawRoll();
                    Die die2 = new Die();
                    die2.DrawRoll();
                    int _die1 = Convert.ToInt32(die1.Roll);
                    int _die2 = Convert.ToInt32(die2.Roll);
                    int sumOfDie = _die1 + _die2;
                    if (sumOfDie % 2 == 0)
                    {
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You won: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${_bet1 + bankAccount}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no you lost, try again.");
                        Console.WriteLine($"You lost: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${bankAccount - _bet1}");
                    }
                }
                else if (optionOne == oddSum)
                {
                    Console.WriteLine("Press Enter to roll the dice:");
                    Console.ReadLine();
                    Die die1 = new Die();
                    die1.DrawRoll();
                    Die die2 = new Die();
                    die2.DrawRoll();
                    int _die1 = Convert.ToInt32(die1.Roll);
                    int _die2 = Convert.ToInt32(die2.Roll);
                    int sumOfDie = _die1 + _die2;
                    if (sumOfDie % 2 != 0)
                    {
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You won: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${_bet1 + bankAccount}");
                    }
                    else
                    {
                        Console.WriteLine("Oh no you lost, try again.");
                        Console.WriteLine($"You lost: ${_bet1}");
                        Console.WriteLine($"Bank Account: ${bankAccount - _bet1}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid Input");
            }
            
        }
    }
}