using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public interface IPerson
    {
        public bool IsActive { get; set; }
        public string GetFullName()
        {

            return $"a - b";
        }

    }
}
