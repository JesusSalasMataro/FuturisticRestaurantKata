using FuturisticRestaurantKataTDD;
using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using FuturisticRestaurantKataTDD.Implementations;
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
            int tableNumber = 1;
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Table table = new Table(tableNumber: tableNumber, isVip: false);
            table.Attach(waiter.Object);
            table.Attach(menu.Object);

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            waiter.Verify(w => w.activate(It.IsAny<Event>()), Times.Once);
        }

        [TestMethod]
        public void WHEN_Gets_Ocuppied_THEN_Electronic_Menu_Service_Activates()
        {
            // ARRANGE
            int tableNumber = 1;
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Table table = new Table(tableNumber: tableNumber, isVip: false);
            table.Attach(waiter.Object);
            table.Attach(menu.Object);

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            menu.Verify(m => m.activate(It.IsAny<Event>()), Times.Once);
        }

        [TestMethod]
        public void WHEN_Is_Not_Vip_And_Gets_Ocuppied_THEN_Metre_Service_Not_Activates()
        {
            // ARRANGE
            int tableNumber = 1;
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Mock<MetreService> metre = new Mock<MetreService>();
            Table table = new Table(tableNumber: tableNumber, isVip: false);
            table.Attach(waiter.Object);
            table.Attach(menu.Object);
            table.Attach(metre.Object);

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            metre.Verify(m => m.activate(It.IsAny<Event>()), Times.Never);
        }

        [TestMethod]
        public void WHEN_Is_Vip_And_Gets_Ocuppied_THEN_Metre_Service_Activates()
        {
            // ARRANGE
            int tableNumber = 1;
            Mock<Observer> waiter = new Mock<Observer>();
            Mock<Observer> menu = new Mock<Observer>();
            Mock<MetreService> metre = new Mock<MetreService>();
            Table table = new Table(tableNumber: tableNumber, isVip: true);
            table.Attach(waiter.Object);
            table.Attach(menu.Object);
            table.Attach(metre.Object);

            // ACT
            table.Status = TableStatusEnum.Occupied;

            // ASSERT
            metre.Verify(m => m.activate(It.IsAny<Event>()), Times.Once);
        }

    }
}
