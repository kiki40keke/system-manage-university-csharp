using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class ServiceReseau
    {
        private String Rmi;



        public ServiceReseau()
        {
            this.Rmi = "127.0.0.1";
        }

        public String getRmi()
        {
            return Rmi;
        }

        public void setRmi(String Rmi)
        {
            this.Rmi = Rmi;
        }
    }
}
