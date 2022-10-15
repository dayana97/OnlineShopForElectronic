using OnlineShopForElectronic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Basket
    {
        private int id;
        public User User { get; set; }
        public Product Product { get; set; }

        public DateTime addProduct { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Basket(int id, User user, Product product, DateTime addProduct)
        {
            this.Id = id;
            this.User = user;
            this.Product = product;
            this.addProduct = addProduct;
            
        }
    }
}
