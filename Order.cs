using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Order
    {
        private int id;
        public User User { get; set; }

        public Product Product { get; set; }

        public DateTime orderTime { get; set; }

        //to do
        //private string paymentCode;

        //to do id na poruchkata

        public Card Card { get; set; }

        public int Id
        {
             get { return id; }
             set { id = value; }
        }
       /* public string PaymentCode
        {
            get { return paymentCode; }
            set { paymentCode = value; }

        }*/

        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }

        public Order(int id, User user, Product product, DateTime orderTime, Card Card)
        {
            this.Id = id;
            this.User = user;
            this.Product = product;
            this.OrderTime = orderTime;
            //this.PaymentCode = paymentCode;
            this.Card = Card;
           
        }
        
        //to do -> 1 do 10000(рандом метод) za poruchka -> ид то да е различно за всеки потребител,метод в юзъра за ид и поредността.
        public void OrderId(int id)
        {
            Order order = new Order(45673,"Alex","mouse", DateTime.Now, "info za kartata");
            if()
        }


    }
}
