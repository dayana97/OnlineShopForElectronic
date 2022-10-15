using OnlineShopForElectronic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopForElectronic
{

    //to do -> kato e gotov skeleta, da izgradim produktite da ne samo definirani, za da mojem da nasledim potrebitelite
    public class Product 
    {
        private string pr_id;
        private string pr_name;
        //сряда to do logicheski ifove za nalichnost i dostavka
        private int pr_availabel;
        private int pr_delivered;
        private string pr_info;
        private string pr_photo;
        private int pr_price;
        private string pr_category;
        private int pr_payment;
        public User pr_user;
        public string PR_id
        {
            get { return pr_id; }
            set { pr_id = value; }
        }
        public string PR_name
        {
            get { return pr_name; }
            set { pr_name = value; }
        }
        public int PR_availabel
        {
            get { return pr_availabel; }
            set { pr_availabel = value; }
        }
        public int PR_delivered
        {
            get { return pr_delivered; }
            set { pr_delivered = value; }
        }
        public string PR_info
        {
            get { return pr_info; }
            set { pr_info = value; }
        }
        public string PR_photo
        {
            get { return pr_photo; }
            set { pr_photo = value; }
        }
        public int PR_price
        {
            get { return pr_price; }
            set { pr_price = value; }
        }
        public string PR_category
        {
            get { return pr_category; }
            set { pr_category = value; }
        }
        public int PR_payment
        {
            get { return pr_payment; }
            set { pr_payment = value; }
        }
        public string User
        {
            get;
            set;
        }
        public Product(string pr_id, string pr_name, int pr_availabel, int pr_delivered, string pr_info, string pr_photo, int pr_price, string pr_category, int pr_payment, string pr_user)
        {
            this.PR_id = pr_id;
            this.PR_name = pr_name;
            this.PR_availabel = pr_availabel;
            this.PR_delivered = pr_delivered;
            this.PR_info = pr_info;
            this.PR_photo = pr_photo;
            this.PR_price = pr_price;
            this.PR_category = pr_category;
            this.PR_payment = pr_payment;
            this.User = pr_user;
        }
    }
}