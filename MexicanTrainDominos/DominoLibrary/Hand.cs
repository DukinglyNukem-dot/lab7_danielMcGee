using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoLibrary
{
            public class Hand
            {
                        protected List<Domino> dominos;

                        public Hand()
                        {
                                    dominos = new List<Domino>();
                        }

                        public Hand(Boneyard by, int numDominos)
                        {
                                    dominos = new List<Domino>();
                                    // Draw dominos.
                                    for (int i = 0; i < numDominos; i++)
                                    {
                                                dominos.Add(by.Draw());
                                    }
                        }

                        // readable-only
                        public int NumDominos
                        {
                                    get
                                    {
                                                return dominos.Count;
                                    }
                        }

                        // Add a card to the cards.
                        public void AddDomino(Domino c)
                        {
                                    dominos.Add(c);
                        }

                        // Discard a card by index, this will check if it's out of bounds.
                        public Domino Discard(int index)
                        {
                                    if (index == -1 || index >= NumDominos)
                                                return null;
                                    Domino temp = dominos[index];
                                    dominos.Remove(dominos[index]);
                                    return temp;
                        }

                        // Get a card by index, this will check if it's out of bounds.
                        public Domino GetDomino(int index)
                        {
                                    if (index == -1 || index >= NumDominos)
                                                return null;
                                    return dominos[index];
                        }

                        // Uses the indexof method in this class.
                        public bool HasDomino(Domino c)
                        {
                                    return dominos.IndexOf(c) != -1;
                        }

                        // This will take value.
                        public bool HasDomino(int v)
                        {
                                    return IndexOf(v) != -1;
                        }

                        // This will take a value and a suit.
                        public bool HasDomino(int v, int s)
                        {
                                    return IndexOf(v, s) != -1;
                        }

                        // Just a puppet for the List.IndexOf() method.
                        public int IndexOf(Domino c)
                        {
                                    return dominos.IndexOf(c);
                        }

                        // Index of card but takes a value.
                        public int IndexOf(int topDot)
                        {
                                    for (int i = 0; i < dominos.Count; i++)
                                    {
                                                if (dominos[i].TopDots == topDot)
                                                            return i;
                                    }
                                    return -1;
                        }

                        // Same as the last but will also take a suit.
                        public int IndexOf(int topDot, int bottomDot)
                        {
                                    for (int i = 0; i < dominos.Count; i++)
                                    {
                                                if (dominos[i].TopDots == topDot && dominos[i].BottomDots == bottomDot)
                                                            return i;
                                    }
                                    return -1;
                        }

                        // Retrieves all of the cards in the hand and returns a string containing the statistics.
                        public override string ToString()
                        {
                                    string result = "\n";
                                    for (int i = 0; i < dominos.Count; i++)
                                    {
                                                result += dominos[i].ToString() + "\n";
                                    }
                                    return result;
                        }
            }
}
