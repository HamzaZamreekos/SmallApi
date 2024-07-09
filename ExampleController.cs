using SmallApi.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallApi
{
    public class ExampleController
    {
        [Route("/myEndpoint")]
        public string TryMe()
        {
            throw new NotImplementedException();
        }
    }
}
