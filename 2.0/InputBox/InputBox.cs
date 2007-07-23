namespace Sagile.Forms
{
    using System;
    using System.Windows.Forms;

    public class InputBox
    {
        public static DialogResult Show(out string value)
        {
            value = String.Empty;

            return new InputBoxForm().ShowDialog();
        }

        public static DialogResult Show<T>(out T value) where T : new()
        {
            value = new T();

            return new InputBoxForm().ShowDialog();
        }
    }
}
