using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
   public class SecretNumber
    {
        private int _count;
        private int _number;
        private int _guessesLeft;
        public static int MaxNumberOfGuesses = 7;
        
        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
             Random random = new Random();
            _number = random.Next(0, 100);
            _guessesLeft = 7;
            _count = 0;            
        }

        public bool MakeGuess(int number)
        {
       
            if (_count > 6)
            {
               throw new ApplicationException();
            }
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException("Gissningen måste vara från 1 till 100");
            }
            if (number < _number)
            {
                _guessesLeft--;
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.",
                    number, _guessesLeft);
                _count++;                
                return false;
            }
            if (number > _number)
            {
                _guessesLeft--;
                Console.WriteLine("{0} är för högt. du har {1} gissningar kvar.",
                    number, _guessesLeft);
                _count++;
                return false;
            }

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count);
                return true;
            }

            // vill ej visas!?. Går inte placera längre upp utan error.
            if (_guessesLeft < 2)
            {
                Console.WriteLine("DU GISSADE FEL. Det hemliga talet är {0}", _number);
                return true;
            }
      
            else
            {
                return false;
            }

        }  
    }
}
