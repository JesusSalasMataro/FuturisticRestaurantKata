using FuturisticRestaurantKataTDD;
using FuturisticRestaurantKataTDD.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FuturisticRestaurantKataTDDUnitTests
{
    [TestClass]
    public class Given_A_Table
    {
        [TestMethod]
        public void WHEN_Gets_Ocuppied_THEN_Waiter_Service_Activates()
        {
            // ARRANGE
            Mock<IWaiterService> waiter = new Mock<IWaiterService>();
            Table table = new Table(waiter.Object);            

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            waiter.Verify(w => w.activate(), Times.Once);
        }
    }
}
