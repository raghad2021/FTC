using FTC.Core.Dto;
using FTC.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FTC.Service.Service.UserServices
{
    public interface IUserService
    {
        List<UserViewModel> GetUsers();
        Task<bool> Create(CreateUserDto dto);
        void Update(UpdateUserDto dto);
        void Delete(string Id);

    }
}
