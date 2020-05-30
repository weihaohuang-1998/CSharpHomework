using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string ClientName  { get; set; }
        public string GoodsName { get; set; }

        public Order(int ordernumber, string clientname, string goodsname)
        {
            OrderNumber = ordernumber;
            ClientName=clientname;
            GoodsName = goodsname;
        }
    }
}
