using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    public class RestServiceImpl : IRestServiceImpl
    {
        public string XMLData(string id)
        {
            return "You requested " + id;
        }

        public string JSONData(string id)
        {
            return "You have requested " + id;
        }
    }
}
