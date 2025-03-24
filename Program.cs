using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautrucngaxep
{
    // Cài đặt cấu trúc ngăn xếp bằng mảng một chiều lưu giá trị số nguyên 
    class MyStack
    {
        // Khai báo có 2 thành phần 
        private int[] data; // lưu trữ dữ liệu của các phân tử trong ngăn xếp 
        private int top; // lưu thông tin đỉnh của ngăn xếp 

        // Phương thức khởi tạo ngăn xếp  
        public MyStack()
        {
            data = new int[100];
            top = -1;
        }
        public MyStack(int size)
        {
            data = new int[size];
            top = -1;
        }


        // Các thao tác trên cấu trúc ngăn xếp 
        // Push : Thêm một đối tượng mới vào ngăn xếp.
        // Pop : lấy một đối tượng ra khỏi ngăn xếp 
        // isEmpty : Kiểm tra ngăn xếp có rỗng hay không ? 
        // IsFull : kiểm tra ngăn xếp có đầy hay không ? 
         
        // Phương thức isEmpty kiểm tra rỗng 
        public bool isEmpty()
        {
            if (top == -1) 
                return true;
            return false;
        }

        // phương thức isFull kiểm tra đầy 
        public bool isFull()
        {
            if (top == data.Length - 1)
                return true;
            return false;
        }

        // Phương thức thêm phần tử vào ngăn xếp 
        public void Push(int x)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (!isFull())
            {
                data[++top] = x;
            }
            else
            {
                Console.WriteLine("Ngăn xếp đầy không thể thêm phần tử ");
            } 
        }
        // Phương thức thêm phần tử vào ngăn xếp 
        public int Pop()
        {
            int kq = 0;
            if (!isEmpty())
            {
                kq = data[top];
                top--; // Giảm chỉ số khi lấy phần tử ra 
            }
            return kq;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // in ra tiếng việt cho người dùng 
            Console.OutputEncoding = Encoding.UTF8;
            // Ứng dụng cấu trúc ngăn xếp Stack chuyển đổi hệ số 10 -> 2
            MyStack s = new MyStack();
            Console.Write("Nhập hệ số nguyên N (hệ thập phân) : ");
            int N = int.Parse(Console.ReadLine());
            int so = N;
            while (so>0)
            {
                s.Push(so % 2);
                so = so / 2;
            }
            string kq = "";
            while(!s.isEmpty())
            {
                kq += s.Pop();
            }
            Console.WriteLine("Nhập hệ số nguyên {0} (10) = {1} (2)", N, kq);
            Console.ReadLine();
        }
    }
}
