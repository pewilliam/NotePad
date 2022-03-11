using System;
using System.IO;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Untitled";
        }

        private void ClickNew(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txbWindow.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save it first?", "New file", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClickSave(sender, e);
                    this.txbWindow.Text = string.Empty;
                    this.Text = "Untitled";
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.txbWindow.Text = string.Empty;
                    this.Text = "Untitled";
                }
            }
            else
            {
                this.txbWindow.Text = string.Empty;
                this.Text = "Untitled";
            }
        }

        private void ClickOpen(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txbWindow.Text = File.ReadAllText(OpenFileDialog.FileName);
                this.Text = OpenFileDialog.FileName;
            }
        }

        private void ClickSave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txbWindow.Text))
            {
                if(this.Text == "Untitled")
                {
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFileDialog.FileName, this.txbWindow.Text);
                        this.Text = SaveFileDialog.FileName;
                    }
                } else
                {
                    File.WriteAllText(this.Text, this.txbWindow.Text);
                }
            }
            else
            {
                MessageBox.Show("The file is empty!");
            }
        }

        private void ClickSaveAs(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txbWindow.Text))
            {
                if (SaveFileAsDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(SaveFileAsDialog.FileName, this.txbWindow.Text);
                    this.Text = SaveFileAsDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("The file is empty!");
            }
        }

        private void ClickExit(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txbWindow.Text))
            {
                MessageBox.Show("You need to save first!");
            }
            else
            {
                Application.Exit();
            }
        }

        private void ClickFont(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txbWindow.Font = fontDialog1.Font;
            }
        }

        private void ClickAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por Pedro William\n\nPequeno projeto para pôr alguns conhecimentos em prática\n\nObrigado por usar!");
        }
    }
}
