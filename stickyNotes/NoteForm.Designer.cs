namespace stickyNotes
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.middleBox = new System.Windows.Forms.PictureBox();
            this.newBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(10, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(225, 200);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.MouseEnter += new System.EventHandler(this.textBox_MouseEnter);
            // 
            // closeBox
            // 
            this.closeBox.Image = global::stickyNotes.Properties.Resources.close;
            this.closeBox.Location = new System.Drawing.Point(210, 10);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(25, 25);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBox.TabIndex = 1;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseEnter += new System.EventHandler(this.closeBox_MouseEnter);
            // 
            // middleBox
            // 
            this.middleBox.Image = global::stickyNotes.Properties.Resources.middleBar;
            this.middleBox.Location = new System.Drawing.Point(35, 10);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(175, 25);
            this.middleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.middleBox.TabIndex = 1;
            this.middleBox.TabStop = false;
            this.middleBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.middleBox_MouseDown);
            this.middleBox.MouseEnter += new System.EventHandler(this.middleBox_MouseEnter);
            this.middleBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.middleBox_MouseMove);
            this.middleBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.middleBox_MouseUp);
            // 
            // newBox
            // 
            this.newBox.Image = global::stickyNotes.Properties.Resources._new;
            this.newBox.Location = new System.Drawing.Point(10, 10);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(25, 25);
            this.newBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.newBox.TabIndex = 1;
            this.newBox.TabStop = false;
            this.newBox.Click += new System.EventHandler(this.newBox_Click);
            this.newBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.newBox_DragEnter);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(245, 245);
            this.ControlBox = false;
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.newBox);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteForm";
            this.ShowInTaskbar = false;
            this.Text = "NoteForm";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.MouseEnter += new System.EventHandler(this.NoteForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NoteForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.PictureBox newBox;
        private System.Windows.Forms.PictureBox middleBox;
        private System.Windows.Forms.PictureBox closeBox;
    }
}