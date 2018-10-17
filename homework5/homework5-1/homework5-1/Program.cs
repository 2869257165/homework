using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_1
{
    class Order
    {
        private int ID;
        private string CName;
        public List<OrderDetail> Corderds = new List<OrderDetail>();
        public Order(int x, string y)
        {
            ID = x;
            CName = y;
        }
        public void adddetail(OrderDetail p)
        {
            Corderds.Add(p);
        }
        public int getID
        {
            get
            {
                return ID;
            }
        }
        public string getname
        {
            get
            {
                return CName;
            }
        }
        public void showorder()
        {
            Console.WriteLine("订单号：" + ID);
            Console.WriteLine("客户名：" + CName);
            var m = from n in Corderds where n != null select n;
            foreach (var i in m)
            {
                Console.WriteLine("商品名：" + i.getGName);
                Console.WriteLine("商品数目" + i.getGNum);
                Console.WriteLine("商品价格" + i.getGPri);
            }
        }
    }
    //订单信息
    class OrderDetail
    {
        private string GName;
        private int GNum;
        private double GPri;
        public OrderDetail(string gname, int gnum, int gpri)
        {
            GName = gname;
            GNum = gnum;
            GPri = gpri;
        }
        public string getGName
        {
            get
            {
                return GName;
            }
        }
        public int getGNum
        {
            get
            {
                return GNum;
            }
        }
        public double getGPri
        {
            get
            {
                return GPri;
            }
        }
    }
    public class MyOrderException : ApplicationException

    {
        private string information;
        public MyOrderException(string message, string information) : base(message)
        {
            this.information = information;
        }
        public string getInformation()
        {
            return information;
        }
    }
    //订单服务
    class OrderService
    {
        private List<Order> orders = new List<Order>();
        //初始化并储存订单信息
        public OrderService()
        {
            Order mike = new Order(0, "mike");
            mike.adddetail(new OrderDetail("adsf", 1000, 1));
            mike.adddetail(new OrderDetail("jkl;", 2000, 2));
            add(mike);
            Order peter = new Order(1, "peter");
            peter.adddetail(new OrderDetail("adsd", 3000, 5));
            add(peter);
            Order hh = new Order(2, "Tom");
            hh.adddetail(new OrderDetail("adsf", 500, 6));
            hh.adddetail(new OrderDetail("fgo", 700, 8));
            hh.adddetail(new OrderDetail("uu", 900, 7));
            add(hh);
        }
        //展示订单信息
        public void showlist()
        {
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                i.showorder();
            }
        }
        //新增订单
        public void add(Order p)
        {
            orders.Add(p);
        }
        public void Addorder()
        {
            Console.Write("订单号：");
            int id = int.Parse(Console.ReadLine());
            Console.Write("客户名：");
            string name = Console.ReadLine();
            Console.Write("商品名称：");
            string gname = Console.ReadLine();
            Console.Write("商品数目：");
            int num = int.Parse(Console.ReadLine());
            Console.Write("商品价格：");
            int pri = int.Parse(Console.ReadLine());
            OrderDetail temp = new OrderDetail(gname, num, pri);
            Order torder = new Order(id, name);
            torder.adddetail(temp);
            orders.Add(torder);
        }
        //按订单号删除订单
        public void deleteorder(int number)
        {
            bool t = false;
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                if (i.getID == number)
                {
                    t = true;
                    orders.Remove(i);
                    break;
                }
            }
            if (t == false)
            {
                throw new MyOrderException("The order doesn't exit, you have to input a new ordernumber.", "remove wrong");
            }
        }
        //按订单号修改订单
        public void changeorders(int changeID, OrderDetail details)
        {
            bool t = false;
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                if (i.getID == changeID)
                {
                    t = true;
                    orders[changeID - 1].adddetail(details);
                }
            }
            if (t == false)
            {
                throw new MyOrderException("The order doesn't exit, you have to input a new ordernumber.", "changeorder wrong");
            }
        }
        //按订单号查询订单
        public void finbyID(int number)
        {
            bool t = false;
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                if (i.getID == number)
                {
                    t = true;
                    i.showorder();
                }
            }
            if (t == false)
            {
                throw new MyOrderException("The order doesn't exit, you have to input a new ordernumber.", "findByNumber wrong");
            }
        }
        //按客户名查询订单号
        public void findbyname(string name)
        {
            bool t = false;
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                if (i.getname == name)
                {
                    t = true;
                    i.showorder();
                }
            }
                if (t == false)
                {
                    throw new MyOrderException("The order doesn't exit, you have to input a new ordernumber.", "findByName wrong");
                }           
        }
        public void output()
        {
            double tottalprice=0;
            var m = from n in orders where n != null select n;
            foreach (var i in m)
            {
                var n = from j in i.Corderds where i.Corderds != null select j;
                foreach(var k in n)
                {
                    tottalprice += (k.getGNum * k.getGPri);
                }
                if(tottalprice>=10000)
                {
                    i.showorder();
                }
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("初始订单为");
            OrderService ptem = new OrderService();
            ptem.showlist();
            Console.WriteLine("其中订单总金额超过10000的为：");
            ptem.output();
            Console.WriteLine("输入需要删除的订单号：");
            int i = int.Parse(Console.ReadLine());
            try
            {
                ptem.deleteorder(i);
            }
            catch (MyOrderException e)
            {
                Console.WriteLine(e.getInformation());
            }
            Console.WriteLine("删除后为");
            ptem.showlist();
            Console.WriteLine("输入要查询的订单号");
            i = int.Parse(Console.ReadLine());
            try
            {
                ptem.finbyID(i);
            }
            catch (MyOrderException e)
            {
                Console.WriteLine(e.getInformation());
            }
            Console.WriteLine("输入要查询的客户名：");
            string pname = Console.ReadLine();
            try
            {
                ptem.findbyname(pname);
            }
            catch (MyOrderException e)
            {
                Console.WriteLine(e.getInformation());
            }
            Console.WriteLine("新增订单");
            ptem.Addorder();
            ptem.showlist();
            Console.WriteLine("输入需要修改的订单号：");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("输入修改后的商品名：");
            pname = Console.ReadLine();
            Console.WriteLine("输入商品数目");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("输入修改后的商品单价");
            int p = int.Parse(Console.ReadLine());
            OrderDetail x = new OrderDetail(pname, s, p);
            ptem.changeorders(i, x);
            ptem.showlist();
        }
    }
}
