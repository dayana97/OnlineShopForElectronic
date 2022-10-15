using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
    public class Category
    {
        private int id;
        private string name;
        private int item;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Item
        {
            get { return item; }
            set
            {
                item = value;
            }
        }

        public Category(int id, string name, int item)
        {
            this.Id = id;
            this.Name = name;
            this.Item = item;
            
        }
    }
}
