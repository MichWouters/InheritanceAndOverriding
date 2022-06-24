using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{

    // Composition: X has an Y and a Z -  relationship
    internal class Foobar
    {
        public Dog Dog { get; set; }

        public Cat Cat { get; set; }
    }
}
