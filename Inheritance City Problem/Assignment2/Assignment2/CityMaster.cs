using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CityMaster : AreaMaster
    {
        public override AreaTypeEnum AreaType
        {
            get
            {
                return AreaTypeEnum.City;
            }

            set
            {
                AreaType = AreaTypeEnum.City;
            }
        }
    }
}
