using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 重命名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path_text.Text;
                DirectoryInfo dir = new DirectoryInfo(path);
                List<FileInfo> tempTaskFile = new List<FileInfo>();
                Comparison<FileInfo> comp = new Comparison<FileInfo>(Compare);
                tempTaskFile.AddRange(dir.GetFiles("*." + suffix_text.Text));

                FileInfo[] taskFile = tempTaskFile.ToArray();
                Array.Sort(taskFile, comp);

                foreach (FileInfo fi in taskFile)
                {
                    string filename = fi.Name.Split('.')[0];
                    if (fi.Name.Split('.').Length == 2)
                    {
                        File.Move(fi.FullName, Path.Combine(dir.FullName, filename + ".xml"));
                    }
                    else
                    {
                        File.Move(fi.FullName, Path.Combine(dir.FullName, filename + "."+stuffix_after.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Compare(Object x, Object y)
        {
            FileInfo fi1 = x as FileInfo;
            FileInfo fi2 = y as FileInfo;
            return fi1.CreationTime.CompareTo(fi2.CreationTime);
        }
    }
}
