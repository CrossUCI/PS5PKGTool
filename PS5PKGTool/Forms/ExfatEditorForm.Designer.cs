#nullable enable

namespace PS5PKGTool.Forms;

partial class ExfatEditorForm
{
    private System.ComponentModel.IContainer? components = null;
    private PS5PKGTool.UI.Controls.AppLabel lblImage = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitEditor = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitEditorPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitEditorPane2 = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionEntries = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridEntries = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionChanges = null!;
    private PS5PKGTool.UI.Controls.AppListBox lstChanges = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTarget = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtTarget = null!;
    private PS5PKGTool.UI.Controls.AppButton btnReplace = null!;
    private PS5PKGTool.UI.Controls.AppButton btnAddFiles = null!;
    private PS5PKGTool.UI.Controls.AppButton btnAddFolder = null!;
    private PS5PKGTool.UI.Controls.AppButton btnNewDirectory = null!;
    private PS5PKGTool.UI.Controls.AppButton btnDelete = null!;
    private PS5PKGTool.UI.Controls.AppButton btnUndo = null!;
    private PS5PKGTool.UI.Controls.AppProgressBar progressEdit = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblStatus = null!;
    private PS5PKGTool.UI.Controls.AppButton btnApply = null!;
    private PS5PKGTool.UI.Controls.AppButton btnCancelOperation = null!;
    private PS5PKGTool.UI.Controls.AppButton btnClose = null!;
    private OpenFileDialog replacementOpenDialog = null!;
    private OpenFileDialog addFilesOpenDialog = null!;
    private FolderBrowserDialog addFolderDialog = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExfatEditorForm));
        components = new System.ComponentModel.Container();
        lblImage = new PS5PKGTool.UI.Controls.AppLabel();
        splitEditor = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitEditorPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        splitEditorPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionEntries = new PS5PKGTool.UI.Controls.AppSectionPanel();
        gridEntries = new PS5PKGTool.UI.Controls.AppDataGridView();
        sectionChanges = new PS5PKGTool.UI.Controls.AppSectionPanel();
        lstChanges = new PS5PKGTool.UI.Controls.AppListBox();
        lblTarget = new PS5PKGTool.UI.Controls.AppLabel();
        txtTarget = new PS5PKGTool.UI.Controls.AppTextBox();
        btnReplace = new PS5PKGTool.UI.Controls.AppButton();
        btnAddFiles = new PS5PKGTool.UI.Controls.AppButton();
        btnAddFolder = new PS5PKGTool.UI.Controls.AppButton();
        btnNewDirectory = new PS5PKGTool.UI.Controls.AppButton();
        btnDelete = new PS5PKGTool.UI.Controls.AppButton();
        btnUndo = new PS5PKGTool.UI.Controls.AppButton();
        progressEdit = new PS5PKGTool.UI.Controls.AppProgressBar();
        lblStatus = new PS5PKGTool.UI.Controls.AppLabel();
        btnApply = new PS5PKGTool.UI.Controls.AppButton();
        btnCancelOperation = new PS5PKGTool.UI.Controls.AppButton();
        btnClose = new PS5PKGTool.UI.Controls.AppButton();
        replacementOpenDialog = new OpenFileDialog();
        addFilesOpenDialog = new OpenFileDialog();
        addFolderDialog = new FolderBrowserDialog();
        splitEditor.SuspendLayout();
        splitEditorPane1.SuspendLayout();
        splitEditorPane2.SuspendLayout();
        sectionEntries.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridEntries).BeginInit();
        sectionChanges.SuspendLayout();
        SuspendLayout();
        // 
        // lblImage
        // 
        lblImage.AutoEllipsis = true;
        lblImage.Dock = DockStyle.Top;
        lblImage.Location = new Point(10, 10);
        lblImage.Name = "lblImage";
        lblImage.Padding = new Padding(8, 0, 8, 0);
        lblImage.Size = new Size(1164, 32);
        lblImage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // splitEditor
        // 
        splitEditor.Dock = DockStyle.Fill;
        splitEditor.Location = new Point(10, 42);
        splitEditor.AddPane(splitEditorPane1);
        splitEditor.AddPane(splitEditorPane2);
        splitEditor.Name = "splitEditor";
        splitEditorPane1.Controls.Add(sectionEntries);
        splitEditorPane2.Controls.Add(sectionChanges);
        splitEditor.Size = new Size(1164, 530);
        splitEditor.PanelSizes = new int[] { 780, 384 };
        // 
        // sectionEntries
        // 
        sectionEntries.Controls.Add(gridEntries);
        sectionEntries.Dock = DockStyle.Fill;
        sectionEntries.Name = "sectionEntries";
        sectionEntries.SectionHeader = "Image files and directories";
        // 
        // gridEntries
        // 
        gridEntries.AllowUserToAddRows = false;
        gridEntries.AllowUserToDeleteRows = false;
        gridEntries.AllowUserToDragDropRows = false;
        gridEntries.AllowUserToOrderColumns = true;
        gridEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridEntries.Dock = DockStyle.Fill;
        gridEntries.MultiSelect = true;
        gridEntries.Name = "gridEntries";
        gridEntries.ReadOnly = true;
        gridEntries.RowHeadersVisible = false;
        gridEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridEntries.SelectionChanged += gridEntries_SelectionChanged;
        // 
        // sectionChanges
        // 
        sectionChanges.Controls.Add(lstChanges);
        sectionChanges.Dock = DockStyle.Fill;
        sectionChanges.Name = "sectionChanges";
        sectionChanges.SectionHeader = "Queued changes";
        // 
        // lstChanges
        // 
        lstChanges.Dock = DockStyle.Fill;
        lstChanges.DrawMode = DrawMode.OwnerDrawFixed;
        lstChanges.FormattingEnabled = true;
        lstChanges.ItemHeight = 18;
        lstChanges.Name = "lstChanges";
        // 
        // lblTarget
        // 
        lblTarget.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTarget.Location = new Point(18, 580);
        lblTarget.Name = "lblTarget";
        lblTarget.Size = new Size(130, 25);
        lblTarget.Text = "Target directory:";
        lblTarget.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtTarget
        // 
        txtTarget.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtTarget.Location = new Point(150, 580);
        txtTarget.Name = "txtTarget";
        txtTarget.PlaceholderText = "Root is empty; use forward slashes for nested paths";
        txtTarget.Size = new Size(1016, 25);
        // 
        // btnReplace
        // 
        btnReplace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnReplace.Location = new Point(18, 612);
        btnReplace.Name = "btnReplace";
        btnReplace.Size = new Size(120, 29);
        btnReplace.Text = "Replace File...";
        btnReplace.Click += btnReplace_Click;
        // 
        // btnAddFiles
        // 
        btnAddFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddFiles.Location = new Point(144, 612);
        btnAddFiles.Name = "btnAddFiles";
        btnAddFiles.Size = new Size(120, 29);
        btnAddFiles.Text = "Add Files...";
        btnAddFiles.Click += btnAddFiles_Click;
        // 
        // btnAddFolder
        // 
        btnAddFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddFolder.Location = new Point(270, 612);
        btnAddFolder.Name = "btnAddFolder";
        btnAddFolder.Size = new Size(120, 29);
        btnAddFolder.Text = "Add Folder...";
        btnAddFolder.Click += btnAddFolder_Click;
        // 
        // btnNewDirectory
        // 
        btnNewDirectory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnNewDirectory.Location = new Point(396, 612);
        btnNewDirectory.Name = "btnNewDirectory";
        btnNewDirectory.Size = new Size(130, 29);
        btnNewDirectory.Text = "New Target Folder";
        btnNewDirectory.Click += btnNewDirectory_Click;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDelete.Location = new Point(532, 612);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(120, 29);
        btnDelete.Text = "Delete Selected";
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUndo
        // 
        btnUndo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnUndo.Location = new Point(658, 612);
        btnUndo.Name = "btnUndo";
        btnUndo.Size = new Size(120, 29);
        btnUndo.Text = "Undo Last";
        btnUndo.Click += btnUndo_Click;
        // 
        // progressEdit
        // 
        progressEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progressEdit.Location = new Point(18, 650);
        progressEdit.Name = "progressEdit";
        progressEdit.Size = new Size(1148, 22);
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblStatus.AutoEllipsis = true;
        lblStatus.Location = new Point(18, 677);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(730, 32);
        lblStatus.Text = "Queue changes, then Apply. Structural changes use a verified transactional rebuild.";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnApply
        // 
        btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnApply.Location = new Point(796, 680);
        btnApply.Name = "btnApply";
        btnApply.Size = new Size(120, 31);
        btnApply.Text = "Apply Changes";
        btnApply.Click += btnApply_Click;
        // 
        // btnCancelOperation
        // 
        btnCancelOperation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelOperation.Enabled = false;
        btnCancelOperation.Location = new Point(922, 680);
        btnCancelOperation.Name = "btnCancelOperation";
        btnCancelOperation.Size = new Size(112, 31);
        btnCancelOperation.Text = "Cancel";
        btnCancelOperation.Click += btnCancelOperation_Click;
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnClose.DialogResult = DialogResult.Cancel;
        btnClose.Location = new Point(1040, 680);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(126, 31);
        btnClose.Text = "Close";
        // 
        // replacementOpenDialog
        // 
        replacementOpenDialog.CheckFileExists = true;
        replacementOpenDialog.Filter = "All files (*.*)|*.*";
        replacementOpenDialog.Title = "Select replacement file";
        // 
        // addFilesOpenDialog
        // 
        addFilesOpenDialog.CheckFileExists = true;
        addFilesOpenDialog.Filter = "All files (*.*)|*.*";
        addFilesOpenDialog.Multiselect = true;
        addFilesOpenDialog.Title = "Select files to add";
        // 
        // addFolderDialog
        // 
        addFolderDialog.Description = "Select a directory tree to add to the exFAT image";
        // 
        // ExfatEditorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        CancelButton = btnClose;
        ClientSize = new Size(1184, 732);
        Controls.Add(splitEditor);
        Controls.Add(lblTarget);
        Controls.Add(txtTarget);
        Controls.Add(btnReplace);
        Controls.Add(btnAddFiles);
        Controls.Add(btnAddFolder);
        Controls.Add(btnNewDirectory);
        Controls.Add(btnDelete);
        Controls.Add(btnUndo);
        Controls.Add(progressEdit);
        Controls.Add(lblStatus);
        Controls.Add(btnApply);
        Controls.Add(btnCancelOperation);
        Controls.Add(btnClose);
        Controls.Add(lblImage);
        MinimumSize = new Size(950, 650);
        Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        Name = "ExfatEditorForm";
        Padding = new Padding(10, 10, 10, 160);
        StartPosition = FormStartPosition.CenterParent;
        Text = "exFAT Image Editor";
        FormClosing += ExfatEditorForm_FormClosing;
        splitEditorPane1.ResumeLayout(false);
        splitEditorPane2.ResumeLayout(false);
        splitEditor.ResumeLayout(false);
        sectionEntries.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridEntries).EndInit();
        sectionChanges.ResumeLayout(false);
        ResumeLayout(false);
    }
}
