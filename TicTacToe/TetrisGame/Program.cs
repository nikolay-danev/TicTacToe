using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace TetrisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName;
            string secondPlayerName;
            string turn = "player1";
            bool isWinner = false;
            string selection;

            Console.Title = "TicTacToe";
            Console.WriteLine("Welcome in TicTacToe , press any key to continue!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("First player name: ");
            firstPlayerName = Console.ReadLine();
            Console.WriteLine("Second player name: ");
            secondPlayerName = Console.ReadLine();
            Console.Clear();

            //GridMatrix 
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            Start:
            // Player 1
            if (turn == "player1")
            {
                turn = "player2";
                Console.Clear();
                Console.WriteLine("It's " + firstPlayerName+ " turn");
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("Make your selection (1-9):");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "X";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }

                if (A == B && B == C)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }

                }
                if (D == E && E == F)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (G == H && H == I)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (A == D && D == G)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (B == E && E == H)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (C == F && F == I)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (A == E && E == I)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (G == E && E == C)
                {
                    isWinner = true;
                    Console.WriteLine(firstPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }



            }
            // Player 2
            if (turn == "player2")
            {
                turn = "player1";
                Console.Clear();
                Console.WriteLine("It's " + secondPlayerName + " turn");
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("Make your selection (1-9):");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }
                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                    }
                    else
                    {
                        Console.WriteLine("This place is taken!");
                    }
                }

                if (A == B && B == C)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }

                }
                if (D == E && E == F)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (G == H && H == I)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (A == D && D == G)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (B == E && E == H)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (C == F && F == I)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (A == E && E == I)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }
                if (G == E && E == C)
                {
                    isWinner = true;
                    Console.WriteLine(secondPlayerName + " wins!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        turn = "player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the game!");
                        return;
                    }

                }



            }
            if (A != "1"
                                && B != "2"
                                && C != "3"
                                && D != "4"
                                && E != "5"
                                && F != "6"
                                && G != "7"
                                && H != "8"
                                && I != "9")
            {
                Console.WriteLine("No winner!");
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? Y/N");
                selection = Console.ReadLine();
                if (selection == "Y")
                {
                    turn = "player1";
                    A = "1";
                    B = "2";
                    C = "3";
                    D = "4";
                    E = "5";
                    F = "6";
                    G = "7";
                    H = "8";
                    I = "9";
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }

            }
            goto Start;
        }
    }
}



