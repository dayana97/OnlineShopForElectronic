using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopForElectronic
{
   public class User
    {
        string userName;
        private int id;
        private string email;
        private string firstName;
        private string lastName;
        private string address;
        private string bankStatement;
        private string password;
        private object addressTwo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
         get { return lastName; }
         set{lastName = value; }   
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }

        public string BankStatement
        {
            get { return bankStatement; }
            set { bankStatement = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public object moreInformation { get; private set; }

        public User(int id, string userName,string email, string firstName, string lastName, string address, string bankStatement, string password)
        {
            this.UserName = userName;
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BankStatement = bankStatement;
            this.Password = password;
            this.Id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BankStatement = bankStatement;
            this.Password = password;
        }
        // za sled izpita da vi naycha
       // [HttpPost("detailsAboutUserAfterRegistration")]
        //[Authorize]
        //public async Task<List<User>> GetCurrentUserDetails([FromBody] User )
      
        public void AdressInformation(string address)
        {
            List<string> adresses = new List<string>();
            adresses.Add(address);
            adresses.Add((string)addressTwo);
            adresses.Add((string)moreInformation);
            //to do adresa kum userName i id
            // suobshtenie koeto da izvestqva potrebitelq za prazno pole
            if (address != null)
            {
                Console.WriteLine("da se kunektva kum order classa");
            }else if(address == null)
            {
                Console.WriteLine("da izgradim suobshtenie za potrebilelq popUp");
            }

            if (addressTwo != null)
            {
                Console.WriteLine("da se kunektva kum order classa");
            }
            

            if (moreInformation != null)
            {
                Console.WriteLine("da se kunektva kum order classa");
            }
            

            //to do 

            string userDetails = userDetailsRepository.GetDetailsForUsers(user.Id).ToList();
        }
     
    }

}
