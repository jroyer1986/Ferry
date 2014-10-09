using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferry.Models
{
    public class Boat
    {
        #region Properties

        public int NumberOfLoads { get; set; }
        public BoatStatus Status { get; set; }
        #endregion

        public void PickUp(Loadable load)
        {
            NumberOfLoads++;
        }       

        public void DropOff(Loadable load)
        {
            NumberOfLoads--;
        }

        public void Crash()
        {
            Status = BoatStatus.Sunk;
        }
    }
}
