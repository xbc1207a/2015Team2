using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Refunds
    {
        List<Goods> gdb = new List<Goods>();
        public void Add(Goods g)
        {
            gdb.Add(g);
        }

        public void Add(Goods[] ga)
        {
            foreach (Goods g in ga)
                Add(g);
        }

        public string Result()
        {
            int money = 0;
            string s = "";
            s += "退費明細\n" +
                 "\n";
            int count = 1;
            s += string.Format("{0}\t:{1}\t:{2}\tx\t{3}\t=\t{4}\n", "項次", "品名", "價格", "數量", "金額");
            foreach (Goods g in gdb)
            {
                int m = g.price * g.stock;
                s += string.Format("{0}\t:{1}\t:{2}\tx\t{3}\t=\t{4}\n", count, g.name, g.price, g.stock, m);
                ++count;
                money += m;
            }
            s += "\n";
            s += string.Format("小記:{0}", money);

            return s;
        }




    }
}
