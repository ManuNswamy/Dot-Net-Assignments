using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StateMaster : AreaMaster
    {
        public override AreaTypeEnum AreaType
        {
            get
            {
                return AreaTypeEnum.State;
            }

            set
            {
                AreaType = AreaTypeEnum.State;
            }
        }
    }
}
