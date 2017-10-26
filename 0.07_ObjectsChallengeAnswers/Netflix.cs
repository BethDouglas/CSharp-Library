using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallengeAnswers
{
    class Netflix
    {
        //Properties
        public String Name { get; set; }
        public String Genre { get; set; }
        public Double Rating { get; set; }

        //Methods

        public void GetSuggestion()
        {
            if (this.Rating > 3.5)
            {
                Console.WriteLine("This is a good show");
            }
            else
            {
                Console.WriteLine("Don't waste your time.");
            }
            
        }


    }
}
