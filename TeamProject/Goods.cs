using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Goods
    {
        public Goods() {
            Clear();
        }

        public string name   { get { return name_ ;  } }
        public    int price  { get { return price_;  } }
        public    int stock  { get { return stock_;  } }
        public string detail { get { return detail_; } }
        public string type   { get { return type_;   } }

        public void SetName(string name) {
            name_ = name;
        }
        public void SetPrice(int price) {
            price_ = price;
        }
        public void SetStock(int stock) {
            stock_ = stock;
        }
        public void SetDetail(string detail) {
            detail_ = detail;
        }
        public void SetType(string type) {
            type_ = type;
        }
        public void Clear() {
            name_ = ""; price_ = 0; stock_ = 0; detail_ = ""; type_ = "";
        }
      
  
// ----------------------------------------------------------------------   Private

        private string name_ ;
        private int price_ ;
        private int stock_ ;              // 庫存
        private string detail_ ;          // 說明
        private string type_ ;            // 類別
    
    }



}
