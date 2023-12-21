using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FontForm : Form
    {

        //this.mainTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        System.Drawing.Font font;
        String familyName;
        float emSize;
        System.Drawing.FontStyle style;
        System.Drawing.GraphicsUnit unit = System.Drawing.GraphicsUnit.Point;
        System.Drawing.Color color = Color.Black;


        public FontForm(System.Drawing.Font mainFont)
        {
            InitializeComponent();
            font = mainFont;
            familyName = font.Name;
            emSize = font.Size;
            style = font.Style;
            unit = font.Unit;
            fontTextBox.Text = font.Name;
            fontStyleTextBox.Text = font.Style.ToString();
            fontSizeTextBox.Text = font.Size.ToString();
            updateCollections();
            updateSampleFont();
        }

        private void updateCollections()
        {
            InstalledFontCollection fontCollection = new InstalledFontCollection();
            for (int i = 0; i <= fontCollection.Families.Length - 1; i++)
            {
                fontListBox.Items.Add(fontCollection.Families[i].Name);
            }
            for (int i = 1; i <= 50; i++)
            {
                fontSizeListBox.Items.Add(i.ToString());
            }

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFontTextBox(object sender, EventArgs e)
        {
            if (!fontListBox.Text.Equals(String.Empty))
            {
                fontTextBox.Text = fontListBox.Text;
                familyName = fontListBox.Text;
                updateSampleFont();
            }
        }

        private void updateFontStyleTextBox(object sender, EventArgs e)
        {
            if (!fontStyleListBox.Text.Equals(String.Empty))
            {
                fontStyleTextBox.Text = fontStyleListBox.Text;
                switch (fontStyleListBox.Text)
                {
                    case "Italic":
                        style = System.Drawing.FontStyle.Italic;
                        break;
                    case "Bold":
                        style = System.Drawing.FontStyle.Bold;
                        // this.style ^= System.Drawing.FontStyle.Bold;
                        break;
                    case "Bold Italic":
                        style = System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic;
                        break;
                    default:
                        style = System.Drawing.FontStyle.Regular;
                        break;
                }
                updateSampleFont();
            }
        }

        private void updateFontSizeTextBox(object sender, EventArgs e)
        {
            if (!fontSizeListBox.Text.Equals(String.Empty))
            {
                fontSizeTextBox.Text = fontSizeListBox.Text;
                emSize = Convert.ToInt32(fontSizeListBox.Text);
                updateSampleFont();
            }
        }

        private void updateSampleFont()
        {
            sampleTextBox.Font = getFont();
        }

        private void updateSampleFont(object sender, EventArgs e)
        {
            sampleTextBox.Font = getFont();
            sampleTextBox.ForeColor = color;
        }

        public Font getFont()
        {
            
            return new System.Drawing.Font(familyName, emSize, style, unit, ((byte)(0)));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void updateSampleFontKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                TextBox obj = (TextBox)sender;
                switch (obj.Name)
                {
                    case "fontTextBox":
                        familyName = fontTextBox.Text;
                        updateSampleFont();
                        break;
                    case "fontStyleTextBox":
                        switch (fontStyleTextBox.Text)
                        {
                            case "Italic":
                                style = System.Drawing.FontStyle.Italic;
                                break;
                            case "Bold":
                                style = System.Drawing.FontStyle.Bold;
                                break;
                            case "Bold Italic":
                                style = System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic;
                                break;
                            default:
                                style = System.Drawing.FontStyle.Regular;
                                break;
                        }
                        updateSampleFont();
                        break;
                    case "fontSizeTextBox":
                        emSize = Convert.ToInt32(fontSizeTextBox.Text);
                        updateSampleFont();
                        break;
                }
                
            }
        }

        private void colorPicker(object sender, EventArgs e)
        {
            this.colorDialog = new ColorDialog();
            this.colorDialog.ShowDialog();
            color = this.colorDialog.Color;
            this.updateSampleFont();
        }

        public Color GetColor() {
            return color;
        }
    }
}
