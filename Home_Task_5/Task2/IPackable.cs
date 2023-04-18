using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IPackable
    {
        string Name { get; }
        double Width { get; }
        double Height { get; }
        double Length { get; }

    }
}
