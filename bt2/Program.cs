using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ngăn xếp dược khởi tạo 
            Mystack stack = new Mystack();
            string choice;
            do
            {
                Console.WriteLine("Nhap he so n (he thap phan):");
                int n = int.Parse(Console.ReadLine());
                int so = n;// lưu giá trị N

                // chuyển các hệ từ hệ nhị phân sang hệ thập phân và lục thập phân (2, 10,16)
                Console.WriteLine("Nhap he so y can chuyen sang he (2,10,16):");
                int y = int.Parse(Console.ReadLine());

                //Kiểm tra các số n hợp lệ hay không 
                if (y == 2 || y == 10 || y == 16)
                    while ( n > 0)
                    {
                    // chuyển đổi sang hệ cơ số khác số sẽ tương ứng và lưu vào Stack
                    stack.Push(n % y);// đẩy phần dư vào ngăn xếp 
                    n = n / y;
                    }
                else
                {
                    Console.WriteLine("doi he so khong hop le!");
                    return; // thoát chương trình nếu không hợp lệ 
                }
                string kq = "";
                string dinhdanghe16 = "0123456789ABCDEF";

                //lấy cá phần tử của ngăn xếp để tạo kq cuối cùng 
                while (!stack.IsEmpty())
                {
                    int a = stack.Pop();// lấy phần tử của ngăn xếp 
                    if (y == 16)
                    {
                        kq += dinhdanghe16[a];
                    }
                    else
                    {
                        kq += a; // thêm số vào chuỗi kq 
                    }
                }
                // in ra kết quả 
                Console.WriteLine($"so {so} chuyen sang he {y} la : {kq}");
                // cho người thực thi thoải mái nếu k dùng thì thoát 
                Console.WriteLine("tiep tuc chuong trinh doi he so khong ? (Y/N)");
                choice = Console.ReadLine();
            } while (choice.ToUpper()
                     == "Y");// lặp lại nếu ng dùng nhập Y

            Console.ReadLine();
        }

    }
}
