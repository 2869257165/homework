using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6_2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void showlistTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addTest()
        {
            OrderService pordser = new OrderService();
            Order p = new Order(5,"make");
            pordser.add(p);
            Assert.AreEqual("make",pordser.orders[3].getname);
        }

        [TestMethod()]
        public void AddorderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        //测试删除订单
        public void deleteorderTest1()
        {
            OrderService pordser = new OrderService();
            string name = pordser.orders[1].getname;
            pordser.deleteorder(0);
            Assert.AreEqual(name,pordser.orders[0].getname);
        }

        [TestMethod()]
        public void changeordersTest()
        {
            OrderService pordser = new OrderService();
            OrderDetail p = new OrderDetail("happy", 5, 6);
            pordser.changeorders(1, p);
            Assert.AreEqual(p.getGName, pordser.orders[1].Corderds[2].getGName);
        }

        [TestMethod()]
        public void finbyIDTest()
        {
            OrderService pordser = new OrderService();
            bool m=pordser.finbyID(1);
            Assert.AreEqual(true, m);
        }

        [TestMethod()]
        public void findbynameTest()
        {
            OrderService pordser = new OrderService();
            Order p = pordser.findbyname("mike");
            Assert.AreEqual(p.getname, pordser.orders[0].getname);

        }

        
        
        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void XmlDeserializeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void XmlSerializeTest()
        {
            Assert.Fail();
        }
    }
}