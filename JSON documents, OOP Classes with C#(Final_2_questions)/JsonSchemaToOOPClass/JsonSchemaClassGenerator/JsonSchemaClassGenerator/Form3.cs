using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cvent.SchemaToPoco.Core;
using NJsonSchema.CodeGeneration;
using Newtonsoft.Json.Schema;
using NJsonSchema.CodeGeneration.CSharp;
using NJsonSchema.Converters;
using System.Text.RegularExpressions;
namespace JsonSchemaClassGenerator
{
    public partial class Form3 : Form
    {
        class Person
        {
            public int id { get; set; }
            public string name { get; set; }

            public string empID { get; set; }
            public string empName { get; set; }
            public string gender { get; set; }
            public string Role { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string telephone { get; set; }
            public string email { get; set; }

        }
        public Form3()
        {
            InitializeComponent();
            CenterToScreen();

            string clas = @" class Person
        {
            public int id { get; set; }
            public string name { get; set; }

            public string empID { get; set; }
            public string empName { get; set; }
            public string gender { get; set; }
            public string Role { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string telephone { get; set; }
            public string email { get; set; }

        }";
            richTextBox1.Text = clas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jsonSchemaGenerator = new JsonSchemaGenerator();
            var myType = typeof(Person);
            var schema = jsonSchemaGenerator.Generate(myType);
            schema.Title = myType.Name;
            
            richTextBox2.Text=schema.ToString();
        }
    }
}
