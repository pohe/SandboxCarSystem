using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class User
    {

        #region Instancefields 

        private string _name;
        private string _email;
        private int _mobile;
        private string _address;
        private int _reputation = 0;

        #endregion

        
        #region Propertys 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Reputation
        {
            get { return _reputation; }
        }



        #endregion



        #region Constructors 



        public User(string name, string email, int mobile, string address)
        {
            _name = name;
            _email = email;
            _mobile = mobile;
            _address = address;

        }



        #endregion



        #region Methods 



        public void PrintAll()

        {

            Console.WriteLine($"The user is named {_name} and can be contacted via email: {_email} or phone: {_mobile}. Their address is {_address} and their reputation is {_reputation}");

        }



        #endregion

    }
}
