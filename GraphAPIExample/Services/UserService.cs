using GraphAPIExample.Models;
using GraphAPIExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPIExample.Services
{
    public class UserService
    {
        private readonly UserRepository _callRepository;

        public UserService(UserRepository callRepository)
        {
            _callRepository = callRepository;
        }
        public List<User> GetAllUsers()
        {
            return _callRepository.GetAllUsers();
        }
        public User GetUserById(int id)
        {
            return _callRepository.GetUserById(id);
        }
        public List<Call> GetCallsByUser(int id)
        {
            return _callRepository.GetCallsByUser(id);
        }
    }
}
