using System;
using System.Windows.Forms;

namespace FieldsToValues
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(preFind.Text)
                && !string.IsNullOrEmpty(preReplace.Text)
                && !string.IsNullOrEmpty(postFind.Text)
                && !string.IsNullOrEmpty(postReplace.Text)
                && !string.IsNullOrEmpty(Fields.Text))
            {
                Result.Text = Fields.Text;
                Result.Text = Result.Text.Replace(preFind.Text, preReplace.Text);
                Result.Text = Result.Text.Replace(postFind.Text, postReplace.Text);
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text))
            {
                Clipboard.SetText(Result.Text);
            }
        }
    }
}