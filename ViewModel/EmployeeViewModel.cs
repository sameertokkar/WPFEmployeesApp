using EmployeesDemoApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Input;

namespace EmployeesDemoApp.ViewModel
{
    public class EmployeeViewModel
    {
       
        public IList<Employee> _EmployeeList;

        //Code to read the json file
        //string _path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Employees.json");
        public EmployeeViewModel()
        {

            #region code to read json file
            //string jsonFromFile;

            //using (var reader = new StreamReader(_path))
            //{
            //    jsonFromFile = reader.ReadToEnd();
            //}

            //var employeesFromJson = JsonConvert.DeserializeObject<Employee>(jsonFromFile);
            #endregion


            #region Employee List Object
            _EmployeeList = new List<Employee>
            {
                new Employee{EmployeeId = 12345, EmployeeName = "Derek", Department = "IT", Salary= 55000.34M },

                new Employee{EmployeeId = 383848, EmployeeName = "Mark", Department = "HR", Salary= 61000 },

                new Employee{EmployeeId = 2828383, EmployeeName = "Lisa", Department = "IT", Salary= 59999.99M },

                new Employee{EmployeeId = 607075, EmployeeName = "James", Department = "Operations", Salary= 80000 },
            };

            #endregion
        }

        public IList<Employee> Employees
        {
            get { return _EmployeeList; }
            set { _EmployeeList = value; }
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
