
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
    
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
    }
}
