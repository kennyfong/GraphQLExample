using GraphAPIExample.Services;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Types
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(UserService userService)
        {
            int id = 0;
            Field<ListGraphType<UserType>>(
            name: "users", resolve: context =>
            {
                return userService.GetAllUsers();
            });
            Field<UserType>(
                name: "user",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return userService.GetUserById(id);
                }
            );
            Field<ListGraphType<CallType>>(
                name: "calls",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return userService.GetCallsByUser(id);
                }
            );
        }
    }
}
