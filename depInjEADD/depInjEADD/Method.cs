using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depInjEADD
{
    public class Client3
    {
        private IService _service;
        public void Start(IService service)
        {
            service.Serve();
        }
    }
}
