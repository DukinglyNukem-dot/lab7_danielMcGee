using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
            class Domino : IComparable<Domino>
            {
                        public int Score { get; set; }

                        public int CompareTo(Domino other)
                        {
                                    if (this.Score < other.Score)
                                    {
                                                return 1;
                                    }
                                    else if (this.Score > other.Score)
                                    {
                                                return -1;
                                    }
                                    else
                                    {
                                                return 0;
                                    }
                        }
                        public override string ToString()
                        {
                                    return "Score: " + this.Score.ToString();
                        }
            }
            class Program
            {
                        static void Main(string[] args)
                        {
                                    List<Domino> dominos = new List<Domino>();
                                    dominos.Add(new Domino() { Score = 1 });
                                    dominos.Add(new Domino() { Score = 6 });
                                    dominos.Add(new Domino() { Score = 2 });
                                    dominos.Add(new Domino() { Score = 3 });
                                    dominos.Add(new Domino() { Score = 4});
                                    dominos.Sort();
                                    Console.WriteLine("Testing IComparable, dominos should be sorted.");
                                    foreach(Domino d in dominos)
                                    {
                                                Console.WriteLine(d.Score);
                                    }
                                    Console.WriteLine("Testing IComparable, dominos should be sorted.");
                        }
            }
}
