using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsChallenges
{
    class Phone
    {
        //Bronze
        public Phone(string phoneMake, string phoneModel)
        {
            this.PhoneMake = phoneMake;
            this.PhoneModel = phoneModel;
        }

        public string PhoneMake { get; set; }
        public string PhoneModel { get; set; }
    }
}
