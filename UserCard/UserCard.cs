using MyLib;
using MyLib.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserCard
{
    public partial class UserCard: UserControl, IUserCard
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public void Show(User user)
        {
            nameTextBox.Text = user.name;
            surnameTextBox.Text = user.surname;
            
            emailTextBox.Text = user.email;

            avatar.Image = Image.FromFile(user.avatarPath);
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            

        }
    }
}
