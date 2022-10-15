using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Discount
    {
        private int id;
         public Product Product { get; set; }
        //to do metod za procentite namalenie
        private int persentOfDiscount;
        public DateTime start;
        public DateTime end;
        public User User { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int PersentOfDiscount
        {
            get { return persentOfDiscount; }
                set { persentOfDiscount = value; }
        }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        public DateTime End
        {
            get { return end; }
            set
            {
                end = value;
            }
        }

        public Discount(int id, Product product, int persentOfDiscount, DateTime start, DateTime end, User user)
        {
            this.Id = id;
            this.Product = product;
            this.PersentOfDiscount = persentOfDiscount;
            this.Start = start;
            this.End = end;
            this.User = user;
            
        }
    }
}
