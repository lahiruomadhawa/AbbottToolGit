using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace AbbottTool
{
    public partial class Form1 : Form
    {

        private string sourcePath = string.Empty;
        private string savePathdel = @"C:\Users\Lahiru\Desktop\TestSet\del";
        private string savePathAdd = @"C:\Users\Lahiru\Desktop\TestSet\add";

        public Form1()
        {
            InitializeComponent();
        }

        private void SourcePathBrowse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog openFile = new FolderBrowserDialog();
                
                if(openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SoursePath_textBox.Text = openFile.SelectedPath;                    
                    sourcePath = openFile.SelectedPath;                    
                }
            }
            catch (Exception ex){}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string [] files = Directory.GetFiles(SoursePath_textBox.Text, "*.xml", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    var doc = XDocument.Load(file);
                    var result = doc.Descendants("action").Any(action => Convert.ToString(action.Value) == "DELETE");

                    if(result == true)
                    {
                        var dir = Path.GetDirectoryName(file);
                        var fileName = Path.GetFileName(file);

                        Directory.CreateDirectory(dir + @"\Delete");
                        Directory.CreateDirectory(dir + @"\Ignore");
                        Directory.CreateDirectory(dir + @"\EA - CA Add");
                        Directory.CreateDirectory(dir + @"\CA - PL Add");

                        File.Move(dir+@"\"+fileName, dir + @"\Delete\" + fileName.Replace("SOM_AGGREGATE_UPDATE_DL-TL", "SOM_UPDATE_DL-TL"));
                    }
                    else
                    {
                        var dir = Path.GetDirectoryName(file);
                        var fileName = Path.GetFileName(file);


                        if (doc.Descendants("parentID").Any(a => a.Value.Contains("4605095")))
                        {
                            File.Move(dir + @"\" + fileName, dir + @"\Ignore\" + fileName.Replace("SOM_AGGREGATE_UPDATE_DL-TL", "SOM_UPDATE_DL-TL"));
                        }
                        else
                        {

                            if (doc.Descendants("epc").Any(a => a.Value.Length == 34))
                            {
                                File.Move(dir + @"\" + fileName, dir + @"\CA - PL Add\" + fileName.Replace("SOM_AGGREGATE_UPDATE_DL-TL", "SOM_UPDATE_DL-TL"));
                            }
                            else
                            {
                                File.Move(dir + @"\" + fileName, dir + @"\EA - CA Add\" + fileName.Replace("SOM_AGGREGATE_UPDATE_DL-TL", "SOM_UPDATE_DL-TL"));
                            }
                        }

                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
