using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampFundamentalWeek1Projects
{
    class Users
    {
        string _name;
        string _type;
        double _unitConsumed;

        // Default Constructor
        public Users()
        {
            this._name = "";
            this._type = "";
            this._unitConsumed = 0;
        }

        // Perametarized Constructor
        public Users(string n, string t, double uc)
        {
            this._name = n;
            this._type = t;
            this._unitConsumed = uc;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string UserType
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public double UnitConsumed
        {
            get { return this._unitConsumed; }
            set { this._unitConsumed = value; }
        }
    }
}
