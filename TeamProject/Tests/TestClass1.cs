using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        [Test]
        public void TestGoodsDB()
        {
            GoodsDB db = new GoodsDB();
            Assert.That(db.num, Is.EqualTo(0));

            Goods good = new Goods();
            db.Add(good);
            Assert.That(db.num, Is.EqualTo(1));

            db.Clear();
            Assert.That(db.num, Is.EqualTo(0));
        }












        Goods AGood(string name, int pri, int amount)
        {
            Goods g = new Goods();
            g.SetName(name);
            g.SetPrice(pri);
            g.SetStock(amount);
            return g;
        }

        [Test]
        public void TestRefunds()
        {
            Refunds r = new Refunds();
            Goods[] g = new Goods[] {
                AGood("good1",100,1),
                AGood("good2",50,2) };
            r.Add(g);
            Assert.That(r.Result(), Is.EqualTo("退費明細\n" + "\n" +
            "項次	:品名	:價格	x	數量	=	金額\n" +
            "1	:good1	:100	x	1	=	100\n" +
            "2	:good2	:50	x	2	=	100\n" + "\n" +
            "小記:200"));


        }









    }
}
