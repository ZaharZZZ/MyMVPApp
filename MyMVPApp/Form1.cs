using MyLib;
using MyLib.Models;
using MyLib.Presenters;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMVPApp
{
    public partial class Form1 : Form, IUserView
    {
        private UserPresenter presenter_;
        private List<string> userFields = new List<string>() 
        { 
            "login", "password", "name", "surname", "birthDate", "email"
        };

        public Form1()
        {
            InitializeComponent();
            userFilterFields.DataSource = userFields;
            userFilterFields.SelectedIndex = 2;
            presenter_ = new UserPresenter(new MemoryUsersModel(), this);
        }

        public void Show(List<User> users)
        {
            usersData.DataSource = null;
            usersData.DataSource = users;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string selectedFilter = userFields[userFilterFields.SelectedIndex];
            presenter_.FilterUsers(selectedFilter, filterTextBox.Text);
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            presenter_.ClearFilterUsers();
        }

        private void usersData_SelectionChanged(object sender, EventArgs e)
        {
            if (usersData.SelectedCells.Count > 0) {
                int index = usersData.SelectedCells[0].RowIndex;
                usersData.Rows[index].Selected = true;
                User user = presenter_.SelectUser(index);
                userCard1.Show(user);
            }
        }
    }
}
