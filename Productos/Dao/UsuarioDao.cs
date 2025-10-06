using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Productos.Dao
{
    public class UsuarioDao
    {

        public String[] users = { "admin", "dominick", "oscar", "engels" };
        public String[] pws = { "182501", "147", "159", "123" };

        public Boolean Validar(String user, String pw)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if ((users[i] == user) && (pws[i]==pw))
                {
                    return true;
                }
                
            }return false;
        }

    }
}
