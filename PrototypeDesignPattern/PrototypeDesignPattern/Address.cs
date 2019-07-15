using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class Address
    {
        private int _streetNumber;
        private string _streetName;
        private string _suburb;

        public Address(int streetNumber, string streetName, string suburb)
        {
            _streetNumber = streetNumber;
            _streetName = streetName;
            _suburb = suburb;
        }

        public int StreetNumber
        {
            get
            {
                return _streetNumber;
            }
            set
            {
                _streetNumber = value;
            }
        }
        public string StreetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
            }
        }
        public string Suburb
        {
            get
            {
                return _suburb;
            }
            set
            {
                _suburb = value;
            }
        }
    }
}
