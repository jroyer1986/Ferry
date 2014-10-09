using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ferry.Models;


namespace Ferry.Test
{
    [TestClass]
    public class BoatTest
    {
        [TestMethod]
        public void BoatCanPickUpLoadable()
        {   
            //arrange
            Boat boat = new Boat();
            Loadable loadable = new Loadable();
            
            //act
            boat.PickUp(loadable);

            //assert
            Assert.AreEqual(1, boat.NumberOfLoads);
        }

        [TestMethod]
        public void BoatCanDropOffLoadable()
        {
            //arrange
            Boat boat = new Boat();
            Loadable load = new Loadable();
            boat.PickUp(load);

            //act
            boat.DropOff(load);

            //test
            Assert.AreEqual(0, boat.NumberOfLoads);
        }

        [TestMethod]
        public void BoatSinksWhenCrashed()
        {
            //arrange
            Boat boat = new Boat();

            //act
            boat.Crash();

            //assert
            Assert.AreEqual(BoatStatus.Sunk, boat.Status);
        }
    }
}
