using MyLib.Models;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Presenters
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUserView view_;
        private IUserCard card_;

        public UserPresenter(IUsersModel model, IUserView view, IUserCard card)
        {
            model_ = model;
            view_ = view;
            card_ = card;

            model_.SuccessLoadedUsers += Model__SuccessLoadedUsers;
            model_.LoadInfoUsers();

            card_.SuccessUpdateEdit += Card__SuccessUpdateEdit;
        }

        private void Card__SuccessUpdateEdit()
        {
            throw new NotImplementedException();
        }

        public void FilterUsers(string field, string name)
        {
            model_.FilterUsers(field, name);
        }

        public void ClearFilterUsers()
        {
            model_.ClearUsersFilter();
        }

        private void Model__SuccessLoadedUsers()
        {
            view_.Show(model_.GetUsers());
        }

        public User SelectUser(int index)
        {
            return model_.GetUser(index);
        }
    }
}
