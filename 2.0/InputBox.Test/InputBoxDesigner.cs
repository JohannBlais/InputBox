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
            String stringValue = String.Empty;
            bool boolValue;

            InputBox.Show(out stringValue);
            InputBox.Show(out boolValue);
        }
    }
}