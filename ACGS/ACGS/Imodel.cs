using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACGS
{
    public interface Imodel
    {
        bool login(string name, string password);
        void tearDown();
       /* List<IUser> UserList { get; }
        List<IOrder> OrderList { get; set; }*/
    }
}
