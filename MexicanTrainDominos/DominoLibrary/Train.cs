using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoLibrary
{
            public abstract class Train
            {
                        // Fields VVV

                        private List<Domino> dominos;
                        private int engineValue;

                        // Properties VVV

                        public int Count
                        {
                                    get
                                    {
                                                return dominos.Count;
                                    }
                        }

                        public int EngineValue
                        {
                                    get
                                    {
                                                return engineValue;
                                    }
                                    set
                                    {
                                                engineValue = value;
                                    }
                        }

                        public bool IsEmpty
                        {
                                    get
                                    {
                                                return Count == 0;
                                    }
                        }

                        public Domino LastDomino
                        {
                                    get
                                    {
                                                if (Count > 0)
                                                            return dominos[Count - 1];
                                                return null;
                                    }
                        }

                        public int PlayableValue
                        {
                                    get
                                    {
                                                return this[0].BottomDots;
                                    }
                        }

                        public Domino this[int index]
                        {
                                    get
                                    {
                                                if (index < 0 || index >= Count)
                                                            throw new IndexOutOfRangeException();
                                                return dominos[index];
                                    }
                        }

                        // Methods VVV

                        public void Add(Domino d)
                        {
                                    dominos.Add(d);
                        }

                        public bool IsPlayable(Domino d, out bool mustFlip)
                        {
                                    mustFlip = true;
                                    return true;
                        }

                        public abstract bool IsPlayable(Hand h, Domino d, out bool mustFlip);

                        public void Play(Hand h, Domino d)
                        {
                                    bool mustFlip = false;
                                    if(IsPlayable(h,d,out mustFlip))
                                    {
                                                if (mustFlip) d.Flip();
                                                Add(d);
                                    } else
                                    {
                                                throw new Exception("Domino " + d.ToString() + " does not match last domino in the train and cannot be played.");
                                    }
                        }

                        public override string ToString()
                        {
                                    string s = "";
                                    int num = 0;
                                    foreach(Domino d in dominos)
                                    {
                                                s += "#" + (++num).ToString() + "[" + d.TopDots.ToString() + "," + d.BottomDots.ToString() + "] | ";
                                    }
                                    return s;
                        }

                        public Train()
                        {
                                    dominos = new List<Domino>();
                        }

                        public Train(int engineValue)
                        {
                                    dominos = new List<Domino>();
                                    EngineValue = engineValue;
                        }

            }
}
