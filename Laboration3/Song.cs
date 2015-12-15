using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    struct Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public override string ToString()
        {
            return $"Name: {Name},Duration: {Duration}.";
        }
    }
}
