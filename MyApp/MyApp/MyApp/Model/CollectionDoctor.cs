using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Entities;

namespace MyApp.Model
{
    public class CollectionDoctor : BaseModel
    {
        private string _ranking;
        private string _street;
        private string _state;
        private string _city;
        private string _postcode;
        private string _phone;
        private string _email;
        private string _name;
        private string _image;
        public string ranking
        {
            get { return _ranking; }
            set { SetValue(ref _ranking, value); }
        }

        public string street
        {
            get { return _street; }
            set { SetValue(ref _street, value); }
        }

        public string state
        {
            get { return _state; }
            set { SetValue(ref _state, value); }
        }

        public string city
        {
            get { return _city; }
            set { SetValue(ref _city, value); }
        }

        public string postcode
        {
            get { return _postcode; }
            set { SetValue(ref _postcode, value); }
        }

        public string phone
        {
            get { return _phone; }
            set { SetValue(ref _phone, value); }
        }

        public string email
        {
            get { return _email; }
            set { SetValue(ref _email, value); }
        }

        public string name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        public string image
        {
            get { return _image; }
            set { SetValue(ref _image, value); }
        }
    }
}
