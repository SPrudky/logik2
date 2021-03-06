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
            bool[] flag = new bool[4];
            for (int i = 0; i < pattern.Length; i++)
            {
                if(pattern [i] == pins[i])
                {
                    flag [i] = false;
                    result.Add (true);
                }
                else
                {
                    flag [i]= true;
                }
                //flag [i] = pattern[i]!=pins[i];
            }
           

            
            for(int i = 0; i < pattern.Length; i++)
            {
               if (flag[i])
                {
                    for (int j = 0; j < pattern.Length; j++) 
                    {
                        if(flag[j])
                        {
                            if (pins [i] == pattern[j])
                            {
                                result.Add(false);
                                break;
                            }
                        }
                    }
                }
            }

            return new List<bool>();
        }
    }
}
