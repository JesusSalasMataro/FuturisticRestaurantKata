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
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Table table = new Table(waiter.Object, menu.Object);            

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            waiter.Verify(w => w.activate(), Times.Once);
        }

        [TestMethod]
        public void WHEN_Gets_Ocuppied_THEN_Electronic_Menu_Service_Activates()
        {
            // ARRANGE
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Table table = new Table(waiter.Object, menu.Object);

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            menu.Verify(m => m.activate(), Times.Once);
        }
    }
}
