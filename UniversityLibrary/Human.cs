using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public abstract class Human:Live
    {
        public int Age { get; set; }
        public virtual string Parent { get; set; }
        protected int Height { get; set; }
        public int Weight { get; set; }
        public abstract bool IsMale { get; set; }
    }
}
