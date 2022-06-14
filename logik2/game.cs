using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logik2
{
    public class game
    {
        public List<Attempt> Attempts { get; set; }
        public Attempt ActualAttempt = new Attempt();
        public game()
        {
            Attempts = new List<Attempt>();
            ActualAttempt = new Attempt();

        }
        public void EvaluateActualAttempt()
        {

        }
        
    }   
}

