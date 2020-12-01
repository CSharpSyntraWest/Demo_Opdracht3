using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WpfApp_HookingUpViewModel.Model;

namespace WpfApp_HookingUpViewModel.ViewModel
{
    public class StudentViewModel
    {

        public StudentViewModel()
        {
            LoadStudents();
        }

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }
    }
}
