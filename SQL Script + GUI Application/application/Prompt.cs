public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 300,
            Height = 150,
            Text = caption
        };
        Label lblText = new Label() { Left = 10, Top = 10, Text = text };
        TextBox txtInput = new TextBox() { Left = 10, Top = 40, Width = 260 };
        Button btnOk = new Button() { Text = "OK", Left = 200, Top = 70, DialogResult = DialogResult.OK };
        prompt.Controls.Add(lblText);
        prompt.Controls.Add(txtInput);
        prompt.Controls.Add(btnOk);
        prompt.AcceptButton = btnOk;

        return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : string.Empty;
    }
}