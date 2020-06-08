using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoLibrary;

namespace MexicanTrainDominos
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    Console.WriteLine("TESTING MEXICAN TRAIN CLASS.");
                                    Train mt = new MexicanTrain(3);
                                    Hand h = new Hand();
                                    h.AddDomino(new Domino(0,2));
                                    Console.WriteLine("Trains engine value should be 3 and is: " + mt.EngineValue.ToString());
                                    Console.WriteLine("Trying to add a 2:0 to the train, we should catch an exception");
                                    try
                                    {
                                                mt.Play(h, h.Discard(0));
                                    }
                                    catch(Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    h.AddDomino(new Domino(1,3));
                                    Console.WriteLine("Adding a 1:3 domino to the train, it should work and it should be flipped.");
                                    try
                                    {
                                                mt.Play(h, h.Discard(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    Console.WriteLine("Let's look at the train right now, we should have one domino be a 3:1 as it was flipped: " + mt.ToString());
                                    Console.WriteLine("MEXICAN TRAIN DONE! \n \n \n");
                                    Console.WriteLine("TESTING PLAYER TRAIN CLASS.");
                                    //
                                    //
                                    //
                                    //
                                    //
                                    PlayerTrain player1 = new PlayerTrain(5);
                                    PlayerTrain player2 = new PlayerTrain(5);
                                    player1.Open();
                                    player2.Open();
                                    Hand playerHand1 = new Hand();
                                    Hand playerHand2 = new Hand();
                                    playerHand1.AddDomino(new Domino(5, 2));
                                    playerHand1.AddDomino(new Domino(2, 3));
                                    playerHand1.AddDomino(new Domino(3, 8));

                                    playerHand2.AddDomino(new Domino(5, 2));
                                    playerHand2.AddDomino(new Domino(2, 3));
                                    playerHand2.AddDomino(new Domino(3, 8));
                                    Console.WriteLine("Both player trains have an engine value of 5 and we've assigned hands, let's have the players try to mess with each other's trains.");
                                    player1.m_Hand = playerHand1;
                                    player2.m_Hand = playerHand2;
                                    try
                                    {
                                                Console.WriteLine("Player 1 is fiddling with player 2's train, should get an exception.");
                                                player1.Play(playerHand2, playerHand2.GetDomino(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    try
                                    {
                                                Console.WriteLine("Player 2 is fiddling with player 1's train, should get an exception.");
                                                player2.Play(playerHand1, playerHand1.GetDomino(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    Console.WriteLine("Closing player 1's train.");
                                    player1.Close();
                                    try
                                    {
                                                Console.WriteLine("Player1 is attempting to add a domino to his clsoed train, we should get an exception.");
                                                player1.Play(playerHand1, playerHand1.GetDomino(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    Console.WriteLine("Player 2 will add dominos in the correct order for his train, he should not get any exceptions.");
                                    try
                                    {
                                                Console.WriteLine("First domino | Should not get an exception...");
                                                player2.Play(playerHand2, playerHand2.Discard(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    try
                                    {
                                                Console.WriteLine("Second domino | Should not get an exception...");
                                                player2.Play(playerHand2, playerHand2.Discard(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    try
                                    {
                                                Console.WriteLine("Third domino | Should not get an exception...");
                                                player2.Play(playerHand2, playerHand2.Discard(0));
                                    }
                                    catch (Exception e)
                                    {
                                                Console.WriteLine("CAUGHT EXCEPTION: " + e.Message);
                                    }
                                    Console.WriteLine("Showing the chain of dominos: " + player2.ToString());
                                    Console.WriteLine("Closing player 2 and opening player 1.");
                                    if (player2.IsOpen)
                                                player2.Close();
                                    if (!player1.IsOpen)
                                                player1.Open();
                                    Console.WriteLine("Player 2 should be closed and is: " + ( (player2.IsOpen) ? "NOT CLOSED" : "CLOSED"));
                                    Console.WriteLine("Player 1 should be open and is: " + ( (player1.IsOpen) ? "OPEN" : "NOT OPEN"));
                                    Console.WriteLine("PLAYER TRAIN DONE! \n \n \n");
                        }
            }
}
