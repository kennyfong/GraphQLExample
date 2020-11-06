using GraphAPIExample.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Types
{
    public class CallType : ObjectGraphType<Call>
    {
        public CallType()
        {
            Name = "Call";
            Field(_ => _.Id, type:
            typeof(IdGraphType)).Description
           ("The Id of the Call.");
            Field<StringGraphType>("State", resolve: _ => _.Source.CurrentCallState.ToString()).Description = "Current state of the call.";
            Field(_ => _.Duration).Description
            ("Duration of the call in seconds.");
            Field<UserType>("From").Description = "User who initiated the call.";
            Field<UserType>("To").Description = "User who received the call.";
            Field(_ => _.RecordingUri).Description
            ("URL of the call recording.");
            Field(_ => _.StartTime).Description
            ("Date and time of the start of the call.");
            Field<StringGraphType>("Direction", resolve: _ => _.Source.DirectionOfCall.ToString()).Description = "Direction of the call.";
        }
    }
}
