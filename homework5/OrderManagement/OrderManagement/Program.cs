using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{

    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            while(true)
            {
                Console.WriteLine("请选择功能:1.添加订单；2.删除订单；3.查找订单；4.修改订单；5.退出系统");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        List<OrderItem> orderItems = new List<OrderItem>();
                        while(true)
                        { 
                            Console.WriteLine("请输入商品名称:");
                            string ItemName = Console.ReadLine();
                            Console.WriteLine("请输入商品数量:");
                            int ItemNumber = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入商品单价:");
                            int ItemPrice = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入客户名:");
                            string ConsumerName = Console.ReadLine();
                            Console.WriteLine("继续购物？：y/n");
                            string flag = Console.ReadLine();
                            if (flag == "y")
                            {
                                orderItems.Add(new OrderItem(ItemPrice, ItemName, ItemNumber));
                            }
                            else
                            {
                                orderItems.Add(new OrderItem(ItemPrice, ItemName, ItemNumber));
                                service.addOrder(ConsumerName, orderItems);
                                break;
                            }
                        }
                        break;
                    case "2":
                        while(true)
                        {
                            Console.WriteLine("请输入订单号！");
                            int ID = Int32.Parse(Console.ReadLine());
                            service.deleteOrder(ID);
                            Console.WriteLine("是否继续删除:y/n");
                            string flag = Console.ReadLine();
                            if(flag=="y")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case "3":
                        while(true)
                        {
                            Console.WriteLine("请输入查找模式:1.按订单号查找；2.按商品名查找；3.按客户名查找");
                            string mod = Console.ReadLine();
                            if (mod == "1")
                            {
                                Console.WriteLine("请输入订单号！");
                                int ID = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(service.searchByOrderID(ID));
                            }
                            else if(mod=="2")
                            {
                                Console.WriteLine("请输入商品名！");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.searchByItemName(name));
                            }
                            else if(mod=="3")
                            {
                                Console.WriteLine("请输入客户名！");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.searchByConsumer(name));

                                Console.WriteLine("是否继续查找:y/n");
                                string flag= Console.ReadLine();
                                if(flag=="y")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }
                        break;
                    case "4":
                        while(true)
                        {
                            Console.WriteLine("请输入订单号！");
                            int preOrderId = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入修改后的订单号！");
                            int OrderID= Int32.Parse(Console.ReadLine());
                            service.setOrderID(preOrderId,OrderID);
                            Console.WriteLine("是否继续修改:y/n");
                            string flag = Console.ReadLine();
                            if (flag == "y")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("无效输入");
                        break;
                }
                

            }
        }
    }
}
