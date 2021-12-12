using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSchemaClassGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Schema Files(*.json;)|*.json;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                var path = open.FileNames[0];
                string schemapath = path;
                SchemaGen gen = new SchemaGen();
               string[] result= gen.genClass(schemapath);
                richTextBox1.Text = result[0];
                richTextBox2.Text = result[1];
            }
        
    }

        ////private void button2_Click(object sender, EventArgs e)
        ////{
        ////    Form3 form = new Form3();
            
        ////    form.ShowDialog();
        ////    this.Close();
        ////}
    }
}
