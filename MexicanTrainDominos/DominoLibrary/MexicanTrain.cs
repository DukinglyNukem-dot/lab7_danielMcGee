using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoLibrary
{
            public class MexicanTrain : Train
            {
                        // Override for the isplayable method, the hand parameter does nothing.
                        protected override bool IsPlayable(Hand h, Domino d,out bool mustFlip)
                        {
                                    return IsPlayable(d,out mustFlip);
                        }

                        // Base default.
                        public MexicanTrain() : base() { }

                        // Base overloaded paramters. 
                        public MexicanTrain(int engineValue) : base(engineValue) { }
            }
}
