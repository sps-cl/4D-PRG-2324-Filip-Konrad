using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konrad_OOP
{
    interface IMoveable
    {
        void Move();
        Vector Position { get; set; }
        Vector Speed { get; set; }
    }
}