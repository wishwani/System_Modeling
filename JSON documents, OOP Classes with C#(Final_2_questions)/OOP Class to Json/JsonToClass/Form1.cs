using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web.Script.Serialization;

namespace JsonToClass
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string a = @"
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
";
            richTextBox2.Text = a;
        }
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
            public dateOfBirth dateOfBirth;
            public string qualification;
            public string Type;
        }

        public class dateOfBirth
        {
            public int year;
            public int month;
            public int date;

        }

    
        

    
        private void button1_Click(object sender, EventArgs e)
        {
            var employee= new Employee
            {
                empID = "Markoff",
                empName = "Jhon",
                address1= "address1de",
                address2= "city",
                address3= "street",
                email = "someemp@gmail.com",
                dateOfBirth = new dateOfBirth
                {
                    year = 1993,
                    month = 4,
                    date = 30
                },
                gender="Male",
                Role="Software developer",
                Type="Permenant"
            };


            var json = new JavaScriptSerializer().Serialize(employee);

            richTextBox1.Text = json;
            Console.WriteLine(json);
        }
    }
}
