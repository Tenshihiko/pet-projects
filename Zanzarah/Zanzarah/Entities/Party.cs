using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zanzarah.Entities
{
    public class Fairy
    {
        public Element Element { get; set; }
    }

    public class Party : List<Fairy>
    {
    }
}
