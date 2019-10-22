using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    // create a class with two fields, one a string and the other an int.
    // the class implements the IComparable interface.
    class MyClass
    {

        // fields
        private string mcStr;

        // properties to access private members


        public int CompareTo(object obj)
        {
            // cast obj to MyClass type
            MyClass mc = obj as MyClass;

            // if cast successful make comparisons
            if (mc != null)
            {
                // return value corresponding to comparison
                if (String.Compare(this.mcStr, mc.mcStr) < 0) return -1;
                if (String.Compare(this.mcStr, mc.mcStr) > 0) return 1;
                else
                {
                    if (this.McInt < mc.McInt) return -1;
                    if (this.McInt > mc.McInt) return 1;
                    else return 0;
                }
            }
            else
                throw new ArgumentException("Parameter is not a MyClass object");
        }

        // override ToString so can print object
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
