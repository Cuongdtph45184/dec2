using dec_2;
using System;
using System.Text;

 namespace dec_2

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
            Console.ReadKey();
        }
        private static void Menu()
        {
            string str;
            Service cn = new Service();
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("1,Nhập danh sách");
                Console.WriteLine("2,Xuất danh sách");
                Console.WriteLine("3,Đọc File và Lưu File");
                Console.WriteLine("4,Xoá đối tượng theo ID");
                Console.WriteLine("0,Thoát");
                Console.WriteLine("Vui lòng chọn chức năng");
                Console.WriteLine("-------------------------");
                str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                switch (str)
                {
                    case "1":
                        {
                            cn.Nhap();
                            break;
                        }
                    case "2":
                        {
                            cn.Xuat();
                            break;
                        }
                    case "3":
                        {
                            cn.ReadAndSave();
                            break;
                        }
                    case "4":
                        {
                            cn.MaID();
                            break;
                        }
                    case "5":
                        {
                            cn.Delete();
                            break;
                        }
                }
            } while (true);
        }
    }
}
