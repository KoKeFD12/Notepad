using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {
        
        private String textToFind = String.Empty;
        private bool alreadySaved = false;
        private String filePath = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            this.mainTextBox.SelectionStart = 0;
            this.mainTextBox.SelectionLength = 0;
            this.mainTextBox.WordWrap = false;
            this.mainTextBox.ScrollBars = ScrollBars.Both;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            MessageBox.Show("This is a beta version of the software. It may contain errors and occur crashes. Take this into account while using this software.\n\nThank you for colaborating in the testing program.","Message from the developer:",MessageBoxButtons.OK, icon);
            
        }

        private void setFormTitle(String title)
        {
            String[] nameArray = title.Split('\\');
            this.Text = nameArray[nameArray.Length - 1] + " - Notepad";
        }

        private void findWord(object sender, EventArgs e)
        {
            FindForm newFind = new FindForm(mainTextBox.Text);
            if (newFind.ShowDialog() == DialogResult.OK)
            {
                textToFind = newFind.getText();
                mainTextBox.SelectionStart = mainTextBox.Text.IndexOf(textToFind);
                mainTextBox.SelectionLength = textToFind.Length;
            }
        }

        private void findNext(object sender, EventArgs e)
        {
            if (!textToFind.Equals(String.Empty))
            {
                try
                {
                    if (mainTextBox.Text.IndexOf(textToFind, mainTextBox.SelectionStart + 1) != -1)
                    {
                        mainTextBox.SelectionStart = mainTextBox.Text.IndexOf(textToFind, mainTextBox.SelectionStart + 1);
                        mainTextBox.SelectionLength = textToFind.Length;
                    }
                    else
                    {
                        MessageBox.Show("Cannot find \"" + textToFind + "\"");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Cannot find \"" + textToFind + "\""); }
            }
            else
            {
                MessageBox.Show("Cannot find \"" + textToFind + "\"");
            }

        }

        private void setFont(object sender, EventArgs e)
        {
            FontForm fontForm = new FontForm(this.mainTextBox.Font);
            if (fontForm.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.ForeColor = fontForm.GetColor();
                mainTextBox.Font = fontForm.getFont();
            }
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectAll(object sender, EventArgs e)
        {
            mainTextBox.SelectionStart = 0;
            mainTextBox.SelectionLength = mainTextBox.Text.Length;
        }

        private void cut(object sender, EventArgs e)
        {
            this.mainTextBox.Cut();
        }

        private void copy(object sender, EventArgs e)
        {
            this.mainTextBox.Copy();
        }

        private void paste(object sender, EventArgs e)
        {
            this.mainTextBox.Paste();
        }

        private void delete(object sender, EventArgs e)
        {
            this.mainTextBox.SelectedText = String.Empty;
        }

        private void undo(object sender, EventArgs e)
        {
            this.mainTextBox.Undo();
        }

        private void insertDateTime(object sender, EventArgs e)
        {
            this.mainTextBox.Text += DateTime.Now.ToString();
        }

        private void toggleWordWrap(object sender, EventArgs e)
        {
            ToolStripMenuItem checkOption = (ToolStripMenuItem)sender;
            if (checkOption.Checked)
            {
                this.mainTextBox.WordWrap = true;
                this.mainTextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                this.mainTextBox.WordWrap = false;
                this.mainTextBox.ScrollBars = ScrollBars.Both;
            }
            
        }

        private void saveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                this.alreadySaved = true;
                setFormTitle(saveFileDialog.FileName);
            }
        }

        private void save(object sender, EventArgs e)
        {
            if (this.alreadySaved)
            {
                File.WriteAllText(this.filePath, mainTextBox.Text);
            } 
            else
            {
                saveAs(this, EventArgs.Empty);
            }
        }

        private void open(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    this.mainTextBox.Text = reader.ReadToEnd();
                }
                setFormTitle(this.filePath);
                alreadySaved = true;
            }

        }

        private void newFile(object sender, EventArgs e)
        {
            alreadySaved = false;
            setFormTitle("Untitled");
            mainTextBox.Text = String.Empty;
        }

        private void about(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

    }
}
