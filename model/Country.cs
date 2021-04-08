using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combo_pro.model
{
    class Country
    {
        private String _name;
        private String _key;

        public Country(string name, string key)
        {
            _name = name;
            _key = key;
        }

        public String Name
        {

            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public String Key
        {

            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }


        /*public String toString()
        {
            return _name;
        }*/
    }
}
