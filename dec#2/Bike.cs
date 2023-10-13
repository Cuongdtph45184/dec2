using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec_2
{
    internal class Bike
    {
        private int id;
        private string ten;
        private string hsx;
        public Bike()
        {

        }
        public Bike(int id, string ten, string hsx)
        {
            ID = id;
            TEN = ten;
            HSX = hsx;
        }
        public int ID { get => id; set => id = value; }
        public string TEN { get => ten; set => ten = value; }
        public string HSX { get => hsx; set => hsx = value; }

        public virtual void show()
        {
            Console.WriteLine("mã xe: {0}", ID);
            Console.WriteLine("tên xe: {0}", TEN);
            Console.WriteLine("HSX xe: {0}", HSX);
        }
        public void nhap()
        {
            Console.WriteLine("Nhập tên xe:");
            TEN = Console.ReadLine();
            Console.WriteLine("Nhập hsx xe:");
            HSX = Console.ReadLine();
        }
    }
}
