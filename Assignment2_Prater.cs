/* Brie Prater
CIS 353
Professor Cain
06/13/2020
Assignment 2.2 */

using System;
public class Accounts
{
	private int[] accountNum = new int[5]; // create array to hold account numbers
	private double[] balance = new double[5]; // create array to hold account balances
	private string[] lastName = new string[5]; // create array to hold customer last names
	int userSearch; // variable to hold account number user input
	double totalBal; // variable to hold average of all 5 accounts
	int tally; // variable to avoid returning invalid during for loop

	public void fillAccounts()
	{
		for (int x = 0; x < 5; x++) // for loop to fill all array indexes
		{
			Console.WriteLine("Please enter the integer account number: ");
			accountNum[x] = Convert.ToInt32(Console.ReadLine()); // sets x index to user input in accountNum array
			Console.WriteLine("Please enter the account balance: ");
			balance[x] = Convert.ToDouble(Console.ReadLine()); // sets x index to user input in balance array
			Console.WriteLine("Please enter the acccount holder's last name: ");
			lastName[x] = Console.ReadLine(); // sets x index to user input in lastName array
		}
	}
	public void searchAccounts()
	{
		Console.WriteLine("Enter an account number to search for: "); // asks user to input account number
		userSearch = Convert.ToInt32(Console.ReadLine());
		for (int y = 0; y < accountNum.Length; y++) // for loop to search through all indexes in accountNum array
		{
			if (accountNum[y] == userSearch) // if user input is found, returns account info
			{
				Console.WriteLine("Account number {0} has a balance of ${1} for customer {2}.", accountNum[y], balance[y], lastName[y]);
			}
			else if (accountNum[y] != userSearch && tally == 4) // if user input is not found, returns invalid
			{
				Console.WriteLine("You have entered an invalid account number.");
			}
			else
			{
				tally++; // keeps count to only display invalid after all indexes have been checked
			}
		}

	}
	public void averageAccounts()
	{
		totalBal = ((balance[0] + balance[1] + balance[2] + balance[3] + balance[4]) / balance.Length); // calculates average of all balances
		Console.WriteLine("The average dollar amount for all accounts is ${0}", totalBal); // returns average of balances
	}
}
public class assignment3
{
	public static void Main(string[] args) // main method
	{
		string userInput; // variable to hold user selection from menu
		Accounts N = new Accounts(); // instantiates Accounts class
		N.fillAccounts(); // calls fillAccounts method
		Console.WriteLine("*****************************************");
		Console.WriteLine("Enter an a or A to search account numbers");
		Console.WriteLine("Enter a b or B to average the accounts");
		Console.WriteLine("Enter an x or X to exit program");
		Console.WriteLine("*****************************************");
		Console.WriteLine("Please Enter an option: ");
		userInput = Console.ReadLine(); // stores user selection from menu
		while (true) // while loop until terminated
		{
			if (userInput == "a" || userInput == "A") // selects A from options
			{
				N.searchAccounts(); // calls searchAccounts method
				Console.WriteLine("*****************************************");
				Console.WriteLine("Enter an a or A to search account numbers");
				Console.WriteLine("Enter a b or B to average the accounts");
				Console.WriteLine("Enter an x or X to exit program");
				Console.WriteLine("*****************************************");
				Console.WriteLine("Please Enter an option: ");
				userInput = Console.ReadLine(); // stores user new selection from menu
			}
			else if (userInput == "b" || userInput == "B") // selects B from options
			{
				N.averageAccounts(); // calls averageAccounts method
				Console.WriteLine("*****************************************");
				Console.WriteLine("Enter an a or A to search account numbers");
				Console.WriteLine("Enter a b or B to average the accounts");
				Console.WriteLine("Enter an x or X to exit program");
				Console.WriteLine("*****************************************");
				Console.WriteLine("Please Enter an option: ");
				userInput = Console.ReadLine(); // stores user new selection from menu
			}
			else if (userInput == "x" || userInput == "X") // selects X from options
			{
				Console.WriteLine("Good Bye!");
				return; // terminates program
			}
			else
			{
				Console.WriteLine("The option you have entered is invalid."); // informs user that their selection was not found
				Console.WriteLine("*****************************************");
				Console.WriteLine("Enter an a or A to search account numbers");
				Console.WriteLine("Enter a b or B to average the accounts");
				Console.WriteLine("Enter an x or X to exit program");
				Console.WriteLine("*****************************************");
				Console.WriteLine("Please Enter an option: ");
				userInput = Console.ReadLine(); // stores user new selection from menu
			}
		}
	}
}
