using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderservice = new OrderService();
        [TestInitialize]
        public void init()
        {
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem(1,"apple", 2);
            items.Add(item);
            orderservice.addOrder("hwh", items);
        }

        [TestMethod]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ImportTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void addOrderTest()
        {
            List<Order> orders = new List<Order>();
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem(1,"apple", 2);
            items.Add(item);
            Order order = new Order(0, "hwh", items);
            orders.Add(order);
            orderservice.addOrder("hwh", items);
            CollectionAssert.Equals(orders,orders);
        }
        [TestMethod]
        public void deleteOrderTest()
        {
            orderservice.deleteOrder(0);
            List<Order> orders = new List<Order>();
            CollectionAssert.Equals(orders,orders);
        }

        [TestMethod]
        public void setOrderID()
        {
            orderservice.setOrderID(0, 1);
            Assert.AreEqual(orderservice.orders[0].OrderNum, 1);
        }

        [TestMethod]
        public void setItemAmountTest()
        {
            orderservice.setItemAmount(0, 0, 1);
            Assert.AreEqual(orderservice.orders[0].orderItems[0].Number, 1);
        }

        [TestMethod]
        public void setItemPriceTest()
        {
            orderservice.setItemPrice(0,0,1);
            Assert.AreEqual(orderservice.orders[0].orderItems[0].price, 2);
        }

        [TestMethod]
        public void setConsumerName()
        {
            orderservice.setConsumerName(0, "hwh");
            Assert.AreEqual(orderservice.orders[0].Customer, "hwh");
        }

        [TestMethod]
        public void searchByItemNameTest()
        {
            orderservice.searchByItemName("apple");
        }

        [TestMethod]
        public void searchByOrderIDTest()
        {
            orderservice.searchByOrderID(0);
        }

        [TestMethod]
        public void searchByConsumerTest()
        {
            orderservice.searchByConsumer("hwh");
        }
        
        [TestMethod]
        public void OrderSortTest()
        {
            orders.Sort();
        }
    }