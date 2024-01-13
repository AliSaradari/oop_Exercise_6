using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    internal interface Interface1
    {
        void AddBook(string name, int type, int count, int price);
        void RemoveBook(string bookName);
        void ShowBookDetail();
    }
}
