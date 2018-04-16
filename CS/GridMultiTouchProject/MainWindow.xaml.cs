using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace GridMultiTouchProject {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ListPerson = new List<Person>();
            CreatePerson();
            DataContext = this;
        }
      public List<Person> ListPerson { get; set; }
        void CreatePerson() {
            for(int i = 0; i < 50; i++) {
                ListPerson.Add(new Person(i));
            }
        }
    }
    public class Person {
        public Person(int i) {
            FirstName = string.Format("FirstName - {0}", i);
            LastName = string.Format("LastName - {0}", i);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
    }

}
