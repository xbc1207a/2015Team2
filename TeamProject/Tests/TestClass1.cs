using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestGoods()
        {
            Goods good = new Goods();
            Assert.That(good.name, Is.EqualTo(""));
            good.SetName("Apple");
            good.SetPrice(30);
            good.SetStock(100);
            good.SetType("Fruit");
            good.SetDetail("Just an apple");

            Assert.That(good.name, Is.EqualTo("Apple"));
            Assert.That(good.price, Is.EqualTo(30));
            Assert.That(good.stock, Is.EqualTo(100));
            Assert.That(good.type, Is.EqualTo("Fruit"));
            Assert.That(good.detail, Is.EqualTo("Just an apple"));
            
        }
    }
}
