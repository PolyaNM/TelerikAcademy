using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class OffsiteCourse
    {
        private string town;

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.AppendFormat("; Town = {0}", this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }


}
