using Code360.Manager;
using Code360.Model;
using Code360.View;
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

namespace Code360
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Code360Manager Code360Manager;

        public MainWindow()
        {
            InitializeComponent();
            Code360Manager = new Code360Manager();

            DataContext = this;
            Code360Manager.StudentDatagrid = this.studentGrid;


        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new NewStudent(Code360Manager);
            var student= new Student() { FirstName = firstName.Text, LastName = lastName.Text, Email = email.Text, Phone = phonenumber.Text, Amount = Convert.ToDecimal(amount.Text) };

            Code360Manager.AddStudent(student);

            firstName.Clear();
            lastName.Clear();
            email.Clear();
            phonenumber.Clear();
            amount.Clear();
            //MessageBox.Show("This is to test the firstname", Code360Manager());
        }
    }

   
}
