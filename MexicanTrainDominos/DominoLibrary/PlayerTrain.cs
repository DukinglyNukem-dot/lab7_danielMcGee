using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoLibrary
{
            public class PlayerTrain : Train
            {
                        private Hand hand;
                        private bool isOpen;

                        // Properties VVV

                        public bool IsOpen
                        {
                                    get
                                    {
                                                return isOpen;
                                    }
                        }

                        public Hand m_Hand
                        {
                                    get
                                    {
                                                return hand;
                                    }
                                    set
                                    {
                                                hand = value;
                                    }
                        }

                        // Methods VVV

                        public void Close()
                        {
                                    isOpen = false;
                        }

                        public void Open()
                        {
                                    isOpen = true;
                        }

                        protected override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
                        {
                                    mustFlip = false;
                                    // If there is no hand and its open then just initialize.
                                    if (hand == null && isOpen)
                                    {
                                                hand = h;
                                    }
                                    // If not our hand or its closed then no.
                                    if (h != hand || !isOpen)
                                    {
                                                return false;
                                    }
                                    // The original isplayable.
                                    return IsPlayable(d, out mustFlip);
                        }

                        public PlayerTrain() : base() { }

                        public PlayerTrain(int engineValue) : base(engineValue) { }

            }
}
