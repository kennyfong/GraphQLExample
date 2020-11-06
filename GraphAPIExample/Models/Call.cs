using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Models
{
    public class Call
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public string RecordingUri { get; set; }
        public State CurrentCallState { get; set; }
        public Direction DirectionOfCall { get; set; }

    }

    public class StateEnumType : EnumerationGraphType<State>
    {
        public StateEnumType()
        {
            Name = "State";
        }
    }

    public enum State
    {
        InProgress = 1,
        MissCall = 2,
        Finished =3,
        Ringing=4
    }

    public class DirectionEnumType : EnumerationGraphType<State>
    {
        public DirectionEnumType()
        {
            Name = "Direction";
        }
    }
    public enum Direction
    {
        Inbound,
        Oubound
    }
}
