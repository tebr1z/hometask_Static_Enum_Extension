using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_Static_Enum_Extension.Interface
{

    public interface IAccount
    {
        string Email { get; }
        string Password { get; }
        string Role { get; }
    }

}
