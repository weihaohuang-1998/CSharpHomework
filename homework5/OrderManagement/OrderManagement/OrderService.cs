using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderService
    {
        List<Order> orders = new List<Order>();

        public void addOrder(string consumerName, List<OrderItem> orderItems)
        {
            int n = 0;
            foreach (var order in orders)
            {
                n++;
            }
            orders.Add(new Order(n,consumerName,orderItems));
        }

        public void deleteOrder(int OrderID)
        {
            Order order = searchByOrderID(OrderID);
            orders.Remove(order);
        }
        //设置订单号
        public void setOrderID(int preOrderID,int OrderID)
        {
            if(searchByOrderID(OrderID)!=null)
            {
                Console.WriteLine("此订单号已存在！");
            }
            else
            {
                Order order = searchByOrderID(preOrderID);
                order.OrderID = OrderID;
                Console.WriteLine("更改 "+preOrderID+" 订单的编号为 "+OrderID);
            }
        }

        //设置商品数量
        public void setItemAmount(int ID,int Item,int amount)
        {
            Order order = searchByOrderID(ID);
            order.orderItems[Item].amount = amount;
        }

        //设置商品价格
        public void setItemPrice(int ID,int Item,int ItemPrice)
        {
            Order order = searchByOrderID(ID);
            order.orderItems[Item].price = ItemPrice;
        }

        //设置顾客名称
        public void setConsumerName(int ID,string name)
        {
            Order order = searchByOrderID(ID);
            order.consumerName = name;
        }
        //通过商品名称查询
        public Order[] searchByItemName(string name)
        {
            var order = orders.Where(or => or.orderItems.Contains(new OrderItem(0, name, 0)))
                                .OrderBy(or=>or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if(ods.Length==0)
            {
                Console.WriteLine("此订单不存在在！");
                return null;
            } 
            else
            {
                foreach (var item in ods)
                {
                    Console.WriteLine(item);
                   
                }
                return ods;
            }
            
        }
        //通过客户名查询
        public Order[] searchByConsumer(string consumer)
        {
            var order = orders.Where(or=>or.consumerName==consumer)
                                .OrderBy(or=>or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if(ods.Length==0)
            {
                Console.WriteLine("此订单不存在！");
                return null;
            }
            else
            {
                foreach (var item in ods)
                {
                    Console.WriteLine(item);
                }
                return ods;
            }
        }
        //通过订单号查询
        public Order searchByOrderID(int ID)
        {
            var order = orders.Where(or=>or.OrderID==ID);
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
            {
                Console.WriteLine("此订单不存在！");
                return null;
            }
            else
            {
                return ods[0];
            }

            
        }

        public void OrderSort()
        {
            orders.Sort();
        }
    }
}
