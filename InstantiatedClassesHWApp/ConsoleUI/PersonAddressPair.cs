using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonAddressPair
    {
        public PersonModel Person { get; set; } = new PersonModel();
        public AddressModel Address { get; set; } = new AddressModel();
    }
}
