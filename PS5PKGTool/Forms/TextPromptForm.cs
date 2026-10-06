

namespace PS5PKGTool.Forms;

public partial class TextPromptForm : Form
{
    public TextPromptForm()
    {
        InitializeComponent();
    }

    public TextPromptForm(string title, string prompt, string initial) : this()
    {
        Text = title;
        lblPrompt.Text = prompt;
        txtValue.Text = initial;
        txtValue.SelectAll();
    }

    public string Value => txtValue.Text;
}
