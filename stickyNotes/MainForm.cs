using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.IO;

namespace stickyNotes
{
    public partial class MainForm : Form
    {
        string workingDirectory;

        public MainForm()
        {
            InitializeComponent();

            workingDirectory = AppDomain.CurrentDomain.BaseDirectory; //Next to .exe
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm("new");
            noteForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(workingDirectory);
            FileInfo[] Files = dInfo.GetFiles("*.txt");

            foreach(FileInfo file in Files)
            {
                System.Diagnostics.Debug.WriteLine(file.Name);
                NoteForm noteForm = new NoteForm(file.Name);
                noteForm.Show();
            }
        }

        private void addNewStickyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm("new");
            noteForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
