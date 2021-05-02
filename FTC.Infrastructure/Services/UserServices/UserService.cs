/*
using FTC.Core.Dto;
using FTC.Core.ViewModel;
using FTC.Data;
using FTC.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC.Service.Service.UserServices 
{
    public class UserService : IUserService
    {
        private FtcDbContext _DB;
        private UserManager<UserDbEntity> _userManager;

        public UserService(FtcDbContext DB, UserManager<UserDbEntity> userManager)
        {
            _DB = DB;
            _userManager = userManager;
        }
        public List<UserViewModel> GetUsers()
        {
            var users = _DB.Users.Where(x => !x.IsDelete).Select(x => new UserViewModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                DOB = x.DOB
            }).ToList();

            return users;
        }

        public async Task<bool> Create(CreateUserDto dto)
        {
            var user = new UserDbEntity();
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.PhoneNumber = dto.PhoneNumber;
            user.DOB = dto.DOB;
            
            user.UserName = dto.PhoneNumber;

            var result = await _userManager.CreateAsync(user, Guid.NewGuid().ToString());
            return result.Succeeded;

        }

        public void Update(UpdateUserDto dto)
        {
            var user = _DB.Users.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.PhoneNumber = dto.PhoneNumber;
            user.DOB = dto.DOB;
            

            _DB.Users.Update(user);
            _DB.SaveChanges();

        }

      

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }
   }
    }
*/ 