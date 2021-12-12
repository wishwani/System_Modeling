using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToClass
{
    public partial class Form2 : Form
    {
        public class Employee
        {

            public string empID;
            public string empName;
            public string gender;
            public string Role;
            public string address1;
            public string address2;
            public string address3;
            public string telephone;
            public string email;
            public dateOfBirth dob;
            public string qualification;
            public string Type;
        }

        public class dateOfBirth
        {
            public int year;
            public int month;
            public int date;

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
