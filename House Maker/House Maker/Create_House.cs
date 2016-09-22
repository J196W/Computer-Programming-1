using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Maker
{
    class Create_House
    {
        //Variables
        int bathrooms;
        int bedrooms;
        public Create_House(int be, int ba)
        {
            bathrooms = ba;
            bedrooms = be;
        }

        //Accessors
        public int getBathrooms()
        {
            return bathrooms;
        }

        public int getBedrooms()
        {
            return bedrooms;
        }

    }
}
