using GraphAPIExample.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";
            Field(_ => _.Id).Description("User's Id.");
            Field(_ => _.FirstName).Description
            ("First name of the user");
            Field(_ => _.LastName).Description
            ("Last name of the user");
            Field(_ => _.PhoneNumber).Description
            ("Phone number of the user");
        }
    }
}
