using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachingTest
{
    class Coaching
    {
        //1. IV - private var - associated with Implemented Properties
        private int playersCount;

        //2. Auto-Implemented Properties - Do Not require VALIDATION
        public string CoachingType { get; set; }
        public string ClassTiming { get; set; }
        public double Charges { get; set; }

        //3. Implemented Properties - Require Validation
        public int PlayersCount
        {
            get
            {
                return playersCount;
            }
            set
            {
                if (value > 0)
                {
                    playersCount = value;
                }
            }
        }
        

        //4. Parameterised Constructor - publicCoaching (Properties)
        public Coaching(string type, string timing, double charges, int players)
        {
            CoachingType = type;
            ClassTiming = timing;
            PlayersCount = players;
            Charges = charges;
        }


        //5. Methods
        public void Details()
        {
            Console.WriteLine($"The charges are: {Charges:C} \n" +
                $"The number of players is: {PlayersCount}");
        }


    }
}
