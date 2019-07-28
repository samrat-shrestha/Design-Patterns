using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depInjEADD
{
    public class Client1
    {
        private IService _service;
        public Client1(IService service)
        {
            this._service = service;
        }
        public void ServeMethod() { this._service.Serve(); }
    }
}
