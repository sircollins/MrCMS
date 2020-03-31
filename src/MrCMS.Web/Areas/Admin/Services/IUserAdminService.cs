﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MrCMS.Entities.People;
using MrCMS.Web.Areas.Admin.Models;

namespace MrCMS.Web.Areas.Admin.Services
{
    public interface IUserAdminService
    {
        Task<int> AddUser(AddUserModel addUserModel);
        UpdateUserModel GetUpdateModel(User user);
        Task<User> SaveUser(UpdateUserModel model, List<int> roles);
        Task DeleteUser(int id);
        Task<User> GetUser(int id);
        Task<bool> IsUniqueEmail(string email, int? id);
        Task SetPassword(int id, string password);
        Task<IList<string>> GetUserRoles(User user);
    }
}