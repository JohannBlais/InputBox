namespace Sagile.Forms.Test
{
    using System;
    using System.Windows.Forms;

    public partial class InputBoxDesigner : Form
    {
        public InputBoxDesigner()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string value;

            InputBox.Show(out value, "New name", "Please enter the new name.", HorizontalAlignment.Left);
            InputBox.Show(out value, "New name", "Please enter the new name.", HorizontalAlignment.Center);
            InputBox.Show(out value, "New name", "Please enter the new name.", HorizontalAlignment.Right);
        }
    }
}