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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private int current = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(student);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

            current = students.Count - 1;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            current++;
            current = (current >= students.Count) ? students.Count - 1 : current;
            SetText();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            current--;
            current = (current < 0) ? 0 : current;
            SetText();
        }

        private void SetText()
        {
            txtFirstName.Text = students[current].FirstName;
            txtLastName.Text = students[current].LastName;
            txtCity.Text = students[current].City;
        }
    }
}
