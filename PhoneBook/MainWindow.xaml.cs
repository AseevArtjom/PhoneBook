using PhoneBook.Domain;
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

namespace PhoneBook
{
    public partial class MainWindow : Window
    {
        UsersList list;
        public MainWindow()
        {
            
            InitializeComponent();
         
            list = new UsersList();
            list.AddUser(new User("https://yt3.googleusercontent.com/ytc/AOPolaSeLDK084vbP9thlHaCPMDX8VBjdQr1PJ7e5jO4fQ=s900-c-k-c0x00ffffff-no-rj", "Зубенко Михаил Петрович", "California St.Avenue 254", "+380960987482"));
            list.AddUser(new User("https://get.pxhere.com/photo/person-people-portrait-facial-expression-hairstyle-smile-emotion-portrait-photography-134689.jpg", "Александр Козлов", "ул. Ленина, д. 15, Санкт-Петербург", "+7(999)987-65-43"));
            list.AddUser(new User("https://cdn1.flamp.ru/df271521a12773528a59498632d7ba6a.jpg", "Максим Сидоров", "ул. Гагарина, д. 5, Минск", "+375(29)525-16-47"));
            list.AddUser(new User("https://s1.1zoom.ru/big7/866/Leonardo_DiCaprio_Men_490253.jpg", "Леонардо Дикаприо", "1600, Pennsylvania Avenue", "+375(29)555-66-77"));
            list.AddUser(new User("https://get.pxhere.com/photo/person-girl-woman-hair-photography-portrait-model-youth-fashion-blue-lady-hairstyle-smile-long-hair-face-dress-eye-head-skin-beauty-blond-photo-shoot-brown-hair-portrait-photography-108386.jpg", "София Петрова", "ул.Лесная, д.20, Киев", "+380(67)111-22-33"));
            LVMain.ItemsSource = list.users;

        }

        private void Phone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{list.SelectedUser.Number},{list.SelectedUser.Adress}");
        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LVMain.SelectedItem != null)
            {
                list.SelectedUser = (User)LVMain.SelectedItem;
            }
        }
    }
}
