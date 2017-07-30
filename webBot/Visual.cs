using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webBot
{
    public class Visual
    {
        public string SetIndicator(bool validator)
        {
            string validLabel = string.Empty;
            if (validator == true)
                {
                    validLabel = "✓";
                }
            else
                {
                    validLabel = "X";
                }
            return validLabel;
        }

        /* tests the bool's status of a pass or fail (determined by one of the Validate() methods
         * in the QuickReport class. True indicated a pass and results in tick. */
        

        /* public string SetIndicator(List<bool> validators)
        {
            string validLabel = string.Empty;
            foreach (bool valid in validators)
                if (valid == true)
                {
                    validLabel = "✓";
                    return validLabel;
                }
                else
                {
                    validLabel = "X";
                    return validLabel;
                }
            return validLabel;
        } */

        /* attempt to use a list of bools (validators) and for each item, sets its value to tick or cross
         * rather than calling the method each time in the Form class */

    }
}
