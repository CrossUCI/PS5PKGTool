#nullable enable

namespace PS5PKGTool.Forms;

partial class ConvertImageForm
{
    private System.ComponentModel.IContainer? components = null;
    private PS5PKGTool.UI.Controls.AppLabel lblSource = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTarget = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboTarget = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutput = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutput = null!;
    private PS5PKGTool.UI.Controls.AppButton btnBrowseOutput = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOverwrite = null!;
    private PS5PKGTool.UI.Controls.AppButton btnConvert = null!;
    private PS5PKGTool.UI.Controls.AppButton btnCancel = null!;
    private SaveFileDialog saveFileDialog = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertImageForm));
        components = new System.ComponentModel.Container();
        lblSource = new PS5PKGTool.UI.Controls.AppLabel();
        lblTarget = new PS5PKGTool.UI.Controls.AppLabel();
        cboTarget = new PS5PKGTool.UI.Controls.AppComboBox();
        lblOutput = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutput = new PS5PKGTool.UI.Controls.AppTextBox();
        btnBrowseOutput = new PS5PKGTool.UI.Controls.AppButton();
        chkOverwrite = new PS5PKGTool.UI.Controls.AppCheckBox();
        btnConvert = new PS5PKGTool.UI.Controls.AppButton();
        btnCancel = new PS5PKGTool.UI.Controls.AppButton();
        saveFileDialog = new SaveFileDialog();
        SuspendLayout();
        // 
        // lblSource
        // 
        lblSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblSource.AutoEllipsis = true;
        lblSource.Location = new Point(16, 16);
        lblSource.Name = "lblSource";
        lblSource.Size = new Size(652, 34);
        lblSource.TabIndex = 0;
        lblSource.Text = "Source:";
        // 
        // lblTarget
        // 
        lblTarget.Location = new Point(16, 64);
        lblTarget.Name = "lblTarget";
        lblTarget.Size = new Size(120, 15);
        lblTarget.TabIndex = 1;
        lblTarget.Text = "Convert to";
        // 
        // cboTarget
        // 
        cboTarget.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTarget.Location = new Point(150, 60);
        cboTarget.Name = "cboTarget";
        cboTarget.Size = new Size(240, 23);
        cboTarget.TabIndex = 2;
        cboTarget.SelectedIndexChanged += cboTarget_SelectedIndexChanged;
        // 
        // lblOutput
        // 
        lblOutput.Location = new Point(16, 100);
        lblOutput.Name = "lblOutput";
        lblOutput.Size = new Size(120, 15);
        lblOutput.TabIndex = 3;
        lblOutput.Text = "Output file";
        // 
        // txtOutput
        // 
        txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtOutput.Location = new Point(150, 96);
        txtOutput.Name = "txtOutput";
        txtOutput.Size = new Size(438, 23);
        txtOutput.TabIndex = 4;
        // 
        // btnBrowseOutput
        // 
        btnBrowseOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBrowseOutput.Location = new Point(594, 95);
        btnBrowseOutput.Name = "btnBrowseOutput";
        btnBrowseOutput.Size = new Size(74, 26);
        btnBrowseOutput.TabIndex = 5;
        btnBrowseOutput.Text = "Browse...";
        btnBrowseOutput.Click += btnBrowseOutput_Click;
        // 
        // chkOverwrite
        // 
        chkOverwrite.AutoSize = true;
        chkOverwrite.Location = new Point(150, 130);
        chkOverwrite.Name = "chkOverwrite";
        chkOverwrite.Size = new Size(200, 19);
        chkOverwrite.TabIndex = 6;
        chkOverwrite.Text = "Overwrite the output if it exists";
        // 
        // btnConvert
        // 
        btnConvert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnConvert.Location = new Point(458, 172);
        btnConvert.Name = "btnConvert";
        btnConvert.Size = new Size(110, 32);
        btnConvert.TabIndex = 7;
        btnConvert.Text = "Convert";
        btnConvert.Click += btnConvert_Click;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(574, 172);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 32);
        btnCancel.TabIndex = 8;
        btnCancel.Text = "Cancel";
        // 
        // ConvertImageForm
        // 
        AcceptButton = btnConvert;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        CancelButton = btnCancel;
        ClientSize = new Size(684, 216);
        Controls.Add(btnCancel);
        Controls.Add(btnConvert);
        Controls.Add(chkOverwrite);
        Controls.Add(btnBrowseOutput);
        Controls.Add(txtOutput);
        Controls.Add(lblOutput);
        Controls.Add(cboTarget);
        Controls.Add(lblTarget);
        Controls.Add(lblSource);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        Name = "ConvertImageForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Convert Image";
        ResumeLayout(false);
    }
}
