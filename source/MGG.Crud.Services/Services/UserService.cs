using System;
using MGG.Crud.Services.Interfaces.IRepository;
using MGG.Crud.Services.Interfaces.IServices;
using MGG.Crud.Services.Models;

namespace MGG.Crud.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public User Read(Guid id)
        {
            return _userRepository.Read(id);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}