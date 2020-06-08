using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoLibrary
{
            public class Domino : IComparable<Domino>
            {
                        private int topDots;
                        private int bottomDots;

                        public int TopDots
                        {
                                    get
                                    {
                                                return topDots;
                                    }
                        }

                        public int BottomDots
                        {
                                    get
                                    {
                                                return bottomDots;
                                    }
                        }

                        public int Score
                        {
                                    get
                                    {
                                                return TopDots + BottomDots;
                                    }
                        }

                        public Domino(int t = 0, int b = 0)
                        {
                                    topDots = t;
                                    bottomDots = b;
                        }

                        public void Flip()
                        {
                                    int temp = TopDots;
                                    topDots = BottomDots;
                                    bottomDots = temp;
                        }

                        public bool IsDouble
                        {
                                    get
                                    {
                                                return TopDots == BottomDots;
                                    }
                        }

                        public override string ToString()
                        {
                                    return "Top dots: " + TopDots.ToString() + ", bottom dots: " + BottomDots.ToString();
                        }

                        public override int GetHashCode()
                        {
                                    return new { TopDots, BottomDots }.GetHashCode();
                        }

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

            }
}
