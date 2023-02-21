using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Практика_8._6
{
    internal class SystemDrive: Drive
    {
        public int ReservedSpace { get; set; }          //Создам класс SystemDrive, добавлю наследование от Drive, добавлю недостающее свойство ReservedSpace
    }
}
