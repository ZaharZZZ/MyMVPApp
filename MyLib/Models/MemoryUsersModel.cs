using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {   
        public List<User> users_ { get; set; }
        public List<User> filteredUsers_ { get; set; }
        public event Action SuccessLoadedUsers;
        public event Action SuccessUpdateEdit;

        public List<User> GetUsers()
        {
            return filteredUsers_;
        }

        public User GetUser(int index)
        {
            return users_[index];
        }

        public void LoadInfoUsers()
        {
            users_ = new List<User>() {
                new User() { login="Top1PvpSng", password = "4dUdsDn8Gx9zi@", name = "Савелий", surname = "Стариков", birthDate = new DateTime(2002, 5, 13), email = "staricov123@gmail.com", avatarPath = "D:\\П-30\\475eb1as-960.jpg" },
                new User() { login="HelloWorld", password = "tDaJRAct$B3$BL", name = "Алина", surname = "Васильева", birthDate = new DateTime(2007, 4, 21), email = "fellado@gmail.com", avatarPath = "D:\\П-30\\475eb1as-960.jpg" },
                new User() { login="YukiteruAmano", password = "*#7S%5jVF#&zjb", name = "Андрей", surname = "Курчаков", birthDate = new DateTime(2006, 12, 31), email = "andeyruw@gmail.com", avatarPath = "D:\\П-30\\475eb1as-960.jpg" }
            };
            filteredUsers_ = users_;
            SuccessLoadedUsers.Invoke();
        }

        public void ClearUsersFilter()
        {
            filteredUsers_ = users_;
            SuccessLoadedUsers.Invoke();
        }

        public void FilterUsers(string field, string input)
        {
            filteredUsers_ = users_.Where(user => GetPropertyValue(user, field).ToString().Contains(input)).ToList();
            SuccessLoadedUsers.Invoke();
        }

        private object GetPropertyValue(User user, string field)
        {
            switch (field.ToLower())
            {
                case "login":
                    return user.login;
                case "password":
                    return user.password;
                case "name":
                    return user.name;
                case "surname":
                    return user.surname;
                case "email":
                    return user.email;
                default:
                    return user.birthDate;
            }
        }
    }
}
