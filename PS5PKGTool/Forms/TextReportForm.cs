

namespace PS5PKGTool.Forms;

public partial class TextReportForm : Form
{
    public TextReportForm()
    {
        InitializeComponent();
    }

    public TextReportForm(string title, string body) : this()
    {
        Text = title;
        txtReport.Text = body;
    }
}
