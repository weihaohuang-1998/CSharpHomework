using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        public int OrderID { set; get; }
        public double OrderCost;
        public string consumerName { set; get; }
        public List<OrderItem> orderItems;
      
        public Order(int OrderID,string consumerName,List<OrderItem> orderItems)
        {
            this.consumerName =consumerName;
            this.orderItems = orderItems;
        }
        public double TotalPrice()
        {
            foreach (var item in orderItems)
            {
                this.OrderCost += item.money;
            }
            return this.OrderCost;
        }

        public override string ToString()
        {
            return "OrderID"+OrderID+"/t"+"consumerName"+consumerName+"/t"+"OredrCost"+OrderCost;
        }

        public override bool Equals(object obj)
        {
            Order order = (Order)obj;
            return order != null && order.OrderID == OrderID && order.consumerName == consumerName && order.OrderCost == OrderCost;
        }
    }
}
