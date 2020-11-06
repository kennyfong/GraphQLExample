using GraphAPIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Repository
{
    public class UserRepository
    {
        private readonly List<User> users = new List<User>();
        private readonly List<Call> calls = new List<Call>();

        public UserRepository()
        {
            User user1 = new User
            {
                Id = 1,
                FirstName = "Kenny",
                LastName = "Fong",
                PhoneNumber = "+441612242268"
            };
            User user2 = new User
            {
                Id = 2,
                FirstName = "Steve",
                LastName = "Smith",
                PhoneNumber = "+441611234567"
            };
            Call call1 = new Call
            {
                Id = 1,
                 Duration = 128,
                StartTime = new DateTime(2020,11,4,11,23,23),
                 RecordingUri= "http://content/url/3.mp3",
                 From = user1,
                 To = user2,
                 CurrentCallState = State.Finished,
                 DirectionOfCall = Direction.Inbound
            };
            Call call2 = new Call
            {
                Id = 2,
                Duration = 0,
                StartTime = new DateTime(2020, 11, 4, 11, 00, 14),
                From = user1,
                To = user2,
                CurrentCallState = State.MissCall,
                DirectionOfCall = Direction.Inbound
            };
            calls.Add(call1);
            calls.Add(call2);
            users.Add(user1);
            users.Add(user2);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            return users.Where(user => user.Id == id).FirstOrDefault();
        }

        public List<Call> GetCallsByUser(int id)
        {
            return calls.Where(call => call.From.Id == id || call.To.Id == id).ToList();
        }
    }
}
