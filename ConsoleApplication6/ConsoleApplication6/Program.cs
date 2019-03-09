// C# HashTable, Dictionary<T> 제너릭을 이용하여 장바구니
//CartNo 상품코드  상품명 단가 수량 합계금액
//------------------------------------------------------------- 
//1      1001      볼펜    1000      2      2000 
//2      1002      연필      500      3      1500 
//3      1003      딸기      6000    2      12000 
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }

        public Cart(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
        }
    }

    class CartTest
    {
        static void Main()
        {
            //여기를 채우세요....               
           
            Goods g1 = new Goods(1001, "볼펜", 1000);
            Goods g2 = new Goods(1002, "연필", 500);
            Goods g3 = new Goods(1003, "딸기", 6000);

            SortedList<int, Cart> carts = new SortedList<int, Cart>();
            carts.Add(1, new Cart(g1, 2));
            carts.Add(2, new Cart(g2, 3));
            carts.Add(3, new Cart(g3, 2));

            foreach (KeyValuePair<int, Cart> cart in carts)
            {
                Console.WriteLine(cart.Key + " : " + cart.Value);
            }


        }
    }
}

//CartNo 상품코드  상품명 단가 수량 합계금액
//------------------------------------------------------------- 
//1      1001      볼펜    1000      2      2000 
//2      1002      연필      500      3      1500 
//3      1003      딸기      6000    2      12000 