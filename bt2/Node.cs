using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    class Node
    {
        public Node Next;// biến Node lưu giá trị 
        public int data;//con trỏ tiếp theo của Node

        // tạo hàm contructor để khởi tạo Node với giá trị Y
        public Node(int y)
        {
            data = y;
            Next = null;
        }
    }
}
