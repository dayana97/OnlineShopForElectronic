using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Card
    {
        public User User { get; set; }
        private int id;
        public Address Address { get; set; }
        public Product Product { get; set; }

        public Basket Basket { get; set; }

        public Order Order { get; set; }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Card(User user, int id, Address address, Product product, Basket basket, Order order)
        {
            this.User = user;
            this.Id = id;
            this.Address = address;
            this.Product = product;
            this.Basket = basket;
            this.Order = order;
            
        }
    }

}
