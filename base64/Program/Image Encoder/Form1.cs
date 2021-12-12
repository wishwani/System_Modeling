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

namespace Image_Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen(); //setting form to center of the screen

            label1.Text = @"Please select a PNG image. After successfully  encoded base64 string, " + Environment.NewLine + @"you requested to select a file path to store encoded strig";
            label2.Text = @"Please select a base 64 text file. After successfully decoded base64 string to image file," + Environment.NewLine + @" you requested to select a file path to store decoded image";
        }

        // Image encoding to text
        private void button1_Click(object sender, EventArgs e)
        {
            string imgBase64String = "";
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
               
                var path= open.FileNames[0];
                 string imagePath = path;
                 imgBase64String = GetBase64StringForImage(imagePath);
                 using (var fbd = new FolderBrowserDialog())
                 {
                     MessageBox.Show("Select a location to store converted text file");
                     DialogResult result = fbd.ShowDialog();

                     if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                     {
                         var x = fbd.SelectedPath;
                         string destinationImgPath = x + "\\base64String.txt";
                         System.IO.File.WriteAllText(destinationImgPath, imgBase64String);
                         MessageBox.Show("Text File Created Successfully");
                     }
                 }
            }
        }

        //encoding byte to base64
        protected  string GetBase64StringForImage(string imgPath)  
        {  
              byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);  
              string base64String = Convert.ToBase64String(imageBytes);  
              return base64String;  
        }
        
        public void SaveImageFile(string filename, string base64Image)
        {
            MessageBox.Show("Select a location to store decoded image file");
                        using(var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            var x=fbd.SelectedPath;
                
                             string destinationImgPath = x+"\\"+filename+".png";
                   
                            var bytes = Convert.FromBase64String(base64Image);
                            using (var imageFile = new FileStream(destinationImgPath, FileMode.Create))
                            {
                                imageFile.Write(bytes, 0, bytes.Length);
                                imageFile.Flush();
                                imageFile.Close();
                                MessageBox.Show("Image successfully created");
                            }
                        }
                    }
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // text file to image decoding function 
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.txt; )|*txt;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                var path = open.FileNames[0];

                //string imagePath = @"E:\images\sample.png";
                string textFile = path;

                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);

                SaveImageFile("convertedImage", text);
            }
        }
    }
}
