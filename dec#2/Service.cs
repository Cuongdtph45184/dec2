using dec_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace dec_2
{
    internal class Service
    {
        List<Bike> listbike = new List<Bike>();
        internal void Nhap()
        {
            string str;
            int step;
            Console.Write("Nhập bước nhảy:");

            step = Convert.ToInt32(Console.ReadLine());
            do
            {
                Bike bi = new Bike();
                bi.ID = GenerateID(step);
                bi.nhap();
                if (IsDuplicated(bi.ID))
                {
                    listbike.Add(bi);
                }
                Console.WriteLine("Nhập y để tiếp tục");
                str = Console.ReadLine();
                if (str != "y")
                {
                    break;
                }
            } while (true);

        }
        internal void Xuat()
        {
            Console.WriteLine("Danh sách :");
            foreach (Bike bi in listbike)
            {
                bi.show();
            }
        }
        internal void ReadAndSave()
        {
            string path = @"\testc#2\ma\bike.txt";
            File.WriteAllText(path, "");
            foreach (Bike bi in listbike)
            {
                string Id = bi.ID.ToString();
                string a = Id + " | " + bi.TEN + " | " + bi.HSX + "\n";
                File.AppendAllText(path, a);
            }
            var filer = File.ReadAllLines(path);
            foreach (var read in filer)
            {
                Console.WriteLine(read);
            }
        }
        internal void MaID()
        {
            Console.WriteLine("Nhap ID Bike:");
            int id = int.Parse(Console.ReadLine());

            if (listbike.Exists(x => x.ID == id))
            {
                Console.WriteLine("ID da ton tai");
                return;
            }
            Bike bi = new Bike();
            bi.ID = id;
            bi.nhap();
            listbike.Add(bi);
        }
        private bool IsDuplicated(int IDforCheck)
        {
            if (listbike.Exists(x => x.ID == IDforCheck))
            {
                Console.WriteLine("ID da ton tai");
                return false;
            }
            else
            {
                return true;
            }
        }
        private int GenerateID(int stepNumber)
        {
            if (!listbike.Any())
            {
                return stepNumber;
            }
            else
                return listbike.Last().ID + stepNumber;
        }
        internal void Delete()
        {
            Console.WriteLine("Nhập ID muốn xóa:");
            int IDi = Convert.ToInt32(Console.ReadLine());
            int x = listbike.FindIndex(b => b.ID == IDi);
            listbike.RemoveAt(x);
        }
    }
}
