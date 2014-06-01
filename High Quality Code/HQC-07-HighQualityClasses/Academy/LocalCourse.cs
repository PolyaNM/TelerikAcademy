using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class LocalCourse
    {
        private string lab;

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.AppendFormat("; Lab = {0}", this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
