using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtnEtn
{
    class DBConnection
    {
        public static CarSalonEntities Entities { get; } = new CarSalonEntities();
    }
}
