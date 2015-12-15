using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Member : Person
    {
        public InstrumentType Instrument { get; set; }

        public Member(string firstName, string lastName, InstrumentType instrument) : base(firstName, lastName)
        {
            Instrument = instrument;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Instrument: {Instrument}";
        }
    }
}
