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
                                    Console.WriteLine("Testing IEnumerable, dominos should be sorted.");
                                    Train mt = new MexicanTrain(4);
                                    Hand h = new Hand();
                                    h.AddDomino(new Domino(1,2));
                                    h.AddDomino(new Domino(1,4));
                                    h.AddDomino(new Domino(1,4));
                                    h.AddDomino(new Domino(6,1));
                                    h.AddDomino(new Domino(4,6));
                                    mt.Play(h,h.Discard(h.NumDominos - 1));
                                    mt.Play(h,h.Discard(h.NumDominos - 1));
                                    mt.Play(h,h.Discard(h.NumDominos - 1));
                                    mt.Play(h,h.Discard(h.NumDominos - 1));
                                    mt.Play(h,h.Discard(h.NumDominos - 1));
                                    foreach(Domino d in mt)
                                    {
                                                Console.WriteLine(d.ToString());
                                    }
                        }
            }
}
