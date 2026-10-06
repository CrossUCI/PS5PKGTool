

namespace PS5PKGTool.Forms;

/// <summary>
/// Routes application notices through the standard Windows message box.
/// </summary>
public static class AppDialog
{
    public static DialogResult ShowInformation(string message, string caption,
        MessageBoxButtons buttons = MessageBoxButtons.OK) =>
        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

    public static DialogResult ShowWarning(string message, string caption,
        MessageBoxButtons buttons = MessageBoxButtons.OK) =>
        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);

    public static DialogResult ShowError(string message, string caption,
        MessageBoxButtons buttons = MessageBoxButtons.OK) =>
        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);

    public static DialogResult DialogYesNo(string message, string caption,
        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel) =>
        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

    public static DialogResult DialogYesNoCancel(string message, string caption,
        MessageBoxButtons buttons = MessageBoxButtons.YesNo) =>
        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
}
