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
using System.Text.RegularExpressions;

namespace stickyNotes
{
    public partial class NoteForm : Form
    {
        string workingDirectory;
        string fileName;

        public NoteForm(string noteName)
        {
            InitializeComponent();
            workingDirectory = AppDomain.CurrentDomain.BaseDirectory; //Next to .exe

            if (noteName != "new")
            {
                //Find matching note
                fileName = noteName;
                string raw = File.ReadAllText(workingDirectory + fileName);
                textBox.Text = Regex.Replace(raw, @" ?\<.*?\>", string.Empty); //Removes everything within the brackets
            }
            else
            {
                //Create new note
                //loop through variations of "note#" # being increased each loop until unused # is found
                //By doing this we can fill in deleted slots
                bool foundNumber = false;
                int number = 0;
                while (!foundNumber)
                {
                    System.Diagnostics.Debug.WriteLine("File name attempt: note" + number);
                    System.Diagnostics.Debug.WriteLine("At location: " + workingDirectory + "note" + number + ".txt");
                    if(File.Exists(workingDirectory+"note" + number+".txt"))
                    {
                        number++;
                    }
                    else
                    {
                        foundNumber = true;
                    }
                }

                File.WriteAllText("note" + number+".txt", "<100,100>\n");
                fileName = "note" + number + ".txt";
            }
        }
        //Variables for form dragging
        private int mouseStartX, mouseStartY;
        private int formStartX, formStartY;
        private bool isDragging = false;

        private void NoteForm_Load(object sender, EventArgs e)
        {
            //Have Form place self to coords in file
            string raw = File.ReadAllText(workingDirectory + fileName);
            string cleanerRaw = raw.Substring(raw.IndexOf('<')+1, raw.IndexOf('>') - raw.IndexOf('<')-1); //Seperates <bracketed> info from rest and gets rid of brackets
            System.Diagnostics.Debug.WriteLine("Cleaner Raw: " + cleanerRaw);
            int wantedY = Convert.ToInt32(cleanerRaw.Remove(cleanerRaw.IndexOf(','))); //Cut it off at the comma, giving the first number
            int wantedX = Convert.ToInt32(cleanerRaw.Remove(0, cleanerRaw.IndexOf(',')+1)); //Cut off anything before the comma, giving the last number
            System.Diagnostics.Debug.WriteLine("X:" + wantedX + " Y:" + wantedY);
            this.Location = new Point(wantedX, wantedY);


            //Set controls to clear. Mouse shouldn't start over it and a re-hover would show them
            newBox.Image = Properties.Resources.clear;
            closeBox.Image = Properties.Resources.clear;

        }

        private void middleBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStartX = MousePosition.X;
            mouseStartY = MousePosition.Y;
            formStartX = this.Location.X;
            formStartY = this.Location.Y;
            isDragging = true;
        }

        private void middleBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //Move Form
                this.Location = new Point(formStartX + MousePosition.X - mouseStartX, formStartY + MousePosition.Y - mouseStartY);
            }
        }

        private void middleBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            //Update text file to reflect location
            string raw = File.ReadAllText(workingDirectory + fileName);
            string text = Regex.Replace(raw, @" ?\<.*?\>", string.Empty); //Removes everything within the brackets

            File.WriteAllText(workingDirectory + fileName, "<" + this.Location.Y + "," + this.Location.X + ">" + text);
        }

        private void newBox_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm("new");
            noteForm.Show();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            File.Delete(workingDirectory + fileName);
            this.Hide();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(workingDirectory + fileName, "<"+this.Location.Y + "," + this.Location.X+">" + textBox.Text); //Write textbox.text to file with location info
        }
        








        private void NoteForm_MouseEnter(object sender, EventArgs e)
        {
            ShowControls();
        }

        private void NoteForm_MouseLeave(object sender, EventArgs e)
        {
            HideControls();
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            ShowControls();
        }

        private void middleBox_MouseEnter(object sender, EventArgs e)
        {
            ShowControls();
        }

        private void closeBox_MouseEnter(object sender, EventArgs e)
        {
            ShowControls();
        }

        private void newBox_DragEnter(object sender, DragEventArgs e)
        {
            ShowControls();
        }

        private void ShowControls()
        {
            closeBox.Image = Properties.Resources.close;
            newBox.Image = Properties.Resources._new;
        }
        private void HideControls()
        {
            closeBox.Image = Properties.Resources.clear;
            newBox.Image = Properties.Resources.clear;
        }
    }
}
