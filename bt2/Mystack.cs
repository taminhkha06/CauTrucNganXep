using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    public class Mystack
    {
        // Các thao tác trên cấu trúc ngăn xếp 
        // Push : Thêm một đối tượng mới vào ngăn xếp.
        // Pop : lấy một đối tượng ra khỏi ngăn xếp 
        // isEmpty : Kiểm tra ngăn xếp có rỗng hay không ? 
        // IsFull : kiểm tra ngăn xếp có đầy hay không ? 
        private Node top; // Đỉnh top của các phần tử trong ngăn xếp 

        // tạo ngắn xếp rỗng 
        public Mystack()
        {
            top = null;
        }
        // phương thức isEmpty => kiểm tra phương thức rỗng hay không ? 
        public bool IsEmpty()
        {
            if (top == null)// đỉnh top == null => ngăn xếp rỗng 
            {
                return true;
            }
            return false;
        }
        // Phương thức Push => thêm các phần tử vào ngăn xếp 
        public void Push(int y)
        {
            Node p = new Node(y);
            if (top == null)
            {
                top = p;
            }
            else
            {
                p.Next = top;//Liên kết đơn giữa Node và đỉnh top hiện tại 
                top = p; // cập nhật top mới 
            }
        }

       // Phương thức Push => thêm các phần tử vào ngăn xếp
       public int Pop()
        {
            if (top!=null)// nếu ngăn xếp không rỗng 
            {
                int y = top.data;// lấy các phần tử của đỉnh top 
                top = top.Next;// Top đi xuống kế tiếp các phần tử khác 
                return y;// trả dữ liệu vừa thực thi 
            }
            return -1; // đỉnh top rỗng trả về = -1
        }
        
    }  
}
