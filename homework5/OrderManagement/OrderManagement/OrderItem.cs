using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderItem
    {
        public double price;
        public string name;
        public int amount;
        public double money;

        public OrderItem(double price, string name, int amount)
        {
            this.price = price;
            this.name = name;
            this.amount = amount;
            this.money = amount*price;
        }

        public override string ToString()
        {
            return "name" + name + "/t" + "price" + price + "/t" + "amount" + amount + "/t" + "money" + money;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = (OrderItem)obj;
            return orderItem!=null&&orderItem.name==name&&orderItem.price==price&&orderItem.amount==amount&&orderItem.money==money;
        }
    }

   
}
