using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grid_lesson_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            char[] arr = { '!', '@', '*', '_', '?', '.' };
            string ran = arr.ToString();

            if (pswBox.Password.Length < 8 && !pswBox.Password.Contains(ran))
            {
                MessageBox.Show("You have not fulfilled one or more password requirements. Try again.","Error",MessageBoxButton.OKCancel,MessageBoxImage.Error);

            }

            else if(txtFirstName.Text=="" || TxtLasName.Text=="" || txtUsername.Text=="")
            {
                MessageBox.Show("You cannot leave Username, Last Name and FirstName empty. Try again.", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

            else if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Your email should contain the '@' symbol. Try again.", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            else
            {
                #region
               // TaskDialog task = new TaskDialog();
               // task.Text = txtFirstName.Text;
                #endregion

                MessageBox.Show($"Success. Your username is: \t{txtUsername.Text} and your password is:\t {pswBox.Password}");
            }

        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void clearFn(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
        }

        private void EmailClear(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void ClearLastName(object sender, RoutedEventArgs e)
        {
            TxtLasName.Text = "";
        }
    }
}
