using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace Game1D {
	public class Game {
		private string man1 = 
							"  O" + "\n" +
							" /|\\" + "\n" +
							"  |" + "\n" +
							" / \\" + "\n";
		private string man2 =   
								"\\  \\" + "\n" +
								" ----o" + "\n" +
								"/  /" + "\n";

		private int userInput { get; set; }
		private int randomNumber { get; set; }

		private int count { get; set; }

		public Game() {
			Console.Title = "Guess or Die";
			Console.ForegroundColor = ConsoleColor.Gray;
			//Console.SetWindowSize(600, 400);
			randomNumber = ConsoleFunc.GetIntRand(10);
			count = 3;
		}

		public void Run() {
			bool quit = false;
			do {
				Console.Clear();
				WelcomeMessage();

				while (true) {
					Console.WriteLine(man1);
					GetUserInput();
					if (!CheckInput()) {
						Console.WriteLine("You lost a chance.");
						count--;
					}
					else {
						ExitGame(true);
						break;
					}

					if (count == 0) {
						ExitGame(false);
						Console.WriteLine(man2);
						break;
					}
				}
				// Exit Section
				count = 3;
				Console.WriteLine("Do you Want to quit. (Yes/No)");
				string choice = Console.ReadLine();

				if (("no").Equals(choice.ToLower())) {
					quit = true;
				}
			} while (quit != true);	
		}
		
		private void GetUserInput() {
			userInput = ConsoleFunc.GetInt();
		}

		private bool CheckInput() {
			return ( userInput == randomNumber );
		}

		private void WelcomeMessage() {
			Console.WriteLine("....Welcome to the game of death...." +
							"\nYou have only 3 chances to live the life.\n\nGame Start");
			Console.WriteLine("Guess the Number within the range of 10");
			
		}

		private void ExitGame(bool status) {
			Console.WriteLine("You " + ( (status == true) ? "Win" : "Lose" ));
		}

	}
}
