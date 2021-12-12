using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Program
{
    enum studentType
    {
        Graduate_Local_Student,
        Undergraduate_Local_Student,
        Graduate_International_Student,
        Undergraduate_International_Student,
    }
    enum departmentType
    {
        Computer_Science,
        Medicine,
        Art,
        Engineering,
        Management,
        Administrative,
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Random random = new Random();
           
            using (var fbd = new FolderBrowserDialog())
                 {
                     MessageBox.Show("Select a location to store CSV file");
                     DialogResult result = fbd.ShowDialog();
                   
                     if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                     {
                         var x = fbd.SelectedPath;
                         string destinationImgPath = x + "\\newfile.csv";

                         studentType stdEnum;
                         departmentType dptEnum;

                         using (StreamWriter writer = new StreamWriter(new FileStream(destinationImgPath,
                         FileMode.Create, FileAccess.Write)))
                         {
                             writer.WriteLine("Student No, Student Name, Department, Student Type, DOB, Telephone No");
                            
                             for (int i = 0; i < 10; i++)
                             {
                                 Enum.TryParse<studentType>("" + random.Next(0, 4) + "", out stdEnum);
                                 Enum.TryParse<departmentType>("" + random.Next(0, 6) + "", out dptEnum);
                                 
                                 var col = random.Next(101, 888);
                                 var col1= "Randika";
                                 var col2= dptEnum.ToString();
                                 var col3= stdEnum.ToString();
                                 var col4= random.Next(12224, 2000000);
                                 var col5= random.Next(12224, 2000000); ;
                                 var line= String.Format("{0},{1},{2},{3},{4},{5}", col, col1, col2, col3, col4, col5);
                                 writer.WriteLine(line);
                             }
                            
                         }
                     }
                 }
            
        }

        private void btn_close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Read(object sender, EventArgs e)
        {
           
            string imgBase64String = "";
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.csv; )|*.csv; ";
            if (open.ShowDialog() == DialogResult.OK)
            {

                var path = open.FileNames[0];
                using (var reader = new StreamReader(path))
                {
                    string textLine = "";
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        textLine =textLine + line;
                        textLine += Environment.NewLine;
                        textLine += Environment.NewLine;
                        
                        
                    }

                    
                }
            
            }

                
        }

 
    }
}
