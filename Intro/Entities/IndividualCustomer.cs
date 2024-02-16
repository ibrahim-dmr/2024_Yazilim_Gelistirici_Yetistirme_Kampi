using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    public class IndividualCustomer : BaseCustomer     //Bireysel müşteri
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

    }
}
