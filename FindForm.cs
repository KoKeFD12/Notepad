using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FindForm : Form
    {
        String mainText;
        public FindForm(string mainText)
        {
            InitializeComponent();
            this.mainText = mainText;
        }

        private void find (object sender, EventArgs e)
        {
            if (mainText.Contains(textInput.Text)) this.DialogResult = DialogResult.OK;
            else MessageBox.Show("Cannot find \""+textInput.Text+"\"");
        }

        public String getText()
        {
            return textInput.Text;
        }

        private void textInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textInput.Text.Equals(String.Empty)) findNextButton.Enabled = false;
            else findNextButton.Enabled = true;
        }

        private void textInput_Validating(object sender, CancelEventArgs e)
        {
            if (textInput.Text.Equals(String.Empty)) findNextButton.Enabled = false;
            else findNextButton.Enabled = true;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            if (textInput.Text.Equals(String.Empty)) findNextButton.Enabled = false;
            else findNextButton.Enabled = true;
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
