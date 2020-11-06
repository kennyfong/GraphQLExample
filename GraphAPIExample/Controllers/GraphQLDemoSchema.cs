using GraphAPIExample.Types;
using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace GraphAPIExample.Controllers
{
    public class GraphQLDemoSchema:Schema, ISchema
    {
        public GraphQLDemoSchema(IServiceProvider provider):base(provider)
        {
            Query = provider.GetRequiredService<UserQuery>();
        }
    }
}
