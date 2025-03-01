using System;
using System.Collections.Generic;

namespace MyLib.Models
{
    public interface IUsersModel
    {
        event Action SuccessLoadedUsers;

        List<User> GetUsers();

        User GetUser(int index);

        void LoadInfoUsers();

        void ClearUsersFilter();

        void FilterUsers(string field, string input);
    }
}
