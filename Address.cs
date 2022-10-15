using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Address
    {
        public User User { get; set; }
        private string AdressOne;
        private string AdressTwo;
        private string moreInfo;

        public string AddressOne
        {
            get { return AdressOne; }
            set { AdressOne = value; }
        }

        public string AddressTwo
        {
            get { return AdressTwo; }
                
            set { AdressTwo = value; }
        }

        public string MoreInfo
        {
            get { return moreInfo; }
            set { moreInfo = value; }
        }

        public Address(User user, string adressOne, string adressTwo, string moreInfo)
        {
            this.User = user;
            this.AdressOne = adressOne;
            this.AdressTwo = adressTwo;
            this.MoreInfo = moreInfo;
         
        }
    }
}
