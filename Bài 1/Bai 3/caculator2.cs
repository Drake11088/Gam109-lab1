using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bai3
{
    public partial class caculator
    {
        public int Cong()
        {
            return a + b;
        }
        public int Tru()
        {
            return a - b;
        }
        public int Nhan()
        {
            return a * b;
        }
        public double Chia()
        {
            if (b == 0)
            {
                Console.WriteLine("phuong trinh khong tinh duoc!");
            }
            return a / b;
        }
    }
}