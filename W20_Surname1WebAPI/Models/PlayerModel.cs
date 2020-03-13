using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace W20_Surname1WebAPI.Models
{
    public class PlayerModel
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _nickName;
        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _birthday;
        public DateTime BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private DateTime _connectedSince;
        public DateTime ConnectedSince
        {
            get { return _connectedSince; }
            set { _connectedSince = value; }
        }


    }
}