using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logik2
{
    public class Attempt
    {
        public pin[] pins { get; internal set; }

        public Attempt()
        {
            pins = new pin[4];
        }

        public List<bool> Evaluate(pin[] pattern)
        {
            List<bool> result = new List<bool>();
            List<pin> patternCopy = pattern.ToList();
            int i = 0;
            while (i < patternCopy.Count)
            {
                if(pins[i] == patternCopy[i])
                {
                    result.Add(true);
                    patternCopy.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return new List<bool>();
        }
    }
}
