using System.Diagnostics;

namespace ShowAbfComments;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadStartupAbfList();
    }

    private void LoadStartupAbfList()
    {
        string startupPathFile = Path.GetFullPath("../../../../../dev/test-abfs.txt");
        Debug.WriteLine(startupPathFile);

        if (File.Exists(startupPathFile))
            richTextBox1.Text = File.ReadAllText(startupPathFile);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 frm = new(richTextBox1.Text);
        Hide();
        frm.ShowDialog();
        Show();
    }
}
