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

            InputBox.Show(out value, new string[] { "New name", "Left aligned", "Input" }, HorizontalAlignment.Left, "Default value");
            InputBox.Show(out value, new string[] { "New name", "Centered", "Input" }, "Default value", HorizontalAlignment.Center);
            InputBox.Show(out value, new string[] { "New name", "Right aligned", "Input" }, "Default value", HorizontalAlignment.Right);
        }
    }
}