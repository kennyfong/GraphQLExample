﻿using GraphAPIExample.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Controllers
{
    public class GraphQLDemoSchema:Schema, ISchema
    {
        public GraphQLDemoSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
        }
    }
}
