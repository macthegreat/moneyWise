
decimal balance = 1000.00m;

Console.WriteLine("Welcome to MoneyWise!");
bool exit = false;
while (!exit)
{
    Console.WriteLine("1.Check your balance");
    Console.WriteLine("2.Deposit money");
    Console.WriteLine("3.Withdraw money");
    Console.WriteLine("4.Exit");

    Console.WriteLine("Please select an option (1-4): ");
    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Console.WriteLine($"Your balance is: ${balance}");
    }
    else if (userInput == "2")
    {
        Console.WriteLine("Enter the amount to deposit: ");

        decimal depositAmount = decimal.Parse(Console.ReadLine());

        if (depositAmount is decimal && depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine($"You have deposited ${depositAmount} and your new balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("You can not enter string value. Invalid deposit amount. Please enter a positive number.");
        }
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Enter the amount to withdraw: ");
        decimal withdrawAmount = decimal.Parse(Console.ReadLine());

      

        if(withdrawAmount is decimal && withdrawAmount > 0)
        {
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Please try again.");
            }
            else
            {
                balance -= withdrawAmount;

                Console.WriteLine($"You have withdrawn ${withdrawAmount} and your new balance is: ${balance}");
            }
        }
        else
        {
            Console.WriteLine("You can not enter string value. Invalid withdraw amount. Please enter a positive number.");
        }
    }

   
    else if (userInput == "4")
    {
        Console.WriteLine("Thank you for using MoneyWise!");
            exit = true;
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
