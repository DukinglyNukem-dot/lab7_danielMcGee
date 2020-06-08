using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoLibrary;

namespace InterfaceTesting
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    List<Domino> dominos = new List<Domino>();
                                    dominos.Add(new Domino(1,1));
                                    dominos.Add(new Domino(3,4));
                                    dominos.Add(new Domino(2,2));
                                    dominos.Add(new Domino(5,6));
                                    dominos.Add(new Domino(0,1));
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
