#nullable enable

namespace PS5PKGTool.Forms;

partial class SettingsForm
{
    private System.ComponentModel.IContainer? components = null;
    private PS5PKGTool.UI.Controls.AppTabControl tabsSettings = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabLibrary = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblLibraryInfo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFolders = null!;
    private PS5PKGTool.UI.Controls.AppListBox lstFolders = null!;
    private PS5PKGTool.UI.Controls.AppButton btnAdd = null!;
    private PS5PKGTool.UI.Controls.AppButton btnRemove = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblManualSources = null!;
    private PS5PKGTool.UI.Controls.AppListBox lstManualSources = null!;
    private PS5PKGTool.UI.Controls.AppButton btnRemoveSource = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkRecursive = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkRefreshOnStartup = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblLibraryNotice = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabAppearance = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblAppearanceInfo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRowHeight = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudRowHeight = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblDensity = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboDensity = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkShowThumbnails = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkShowGridLines = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkShowFilePreview = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblDefaultGroup = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboDefaultGroup = null!;
    private PS5PKGTool.UI.Controls.AppButton btnResetLayout = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblAppearanceNotice = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabNaming = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblNamingInfo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRenameFormat = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtRenameFormat = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRenamePreset = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboRenamePreset = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRenameToken = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboRenameToken = null!;
    private PS5PKGTool.UI.Controls.AppButton btnInsertToken = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRenamePreview = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblRenameUnknown = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabFiles = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblViewingInfo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblMaxPreview = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudMaxPreviewMb = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblHexPage = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudHexPageKb = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblThumbCache = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudThumbnailCache = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblThumbCacheHint = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblViewingNotice = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabPaths = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblPathsInfo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutputDir = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutputDirectory = null!;
    private PS5PKGTool.UI.Controls.AppButton btnBrowseOutput = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTempDirectory = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtTempDirectory = null!;
    private PS5PKGTool.UI.Controls.AppButton btnBrowseTemp = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblDefaultBackend = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboDefaultBackend = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblPasscode = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtDebugPasscode = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkShowPasscode = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblPasscodeHint = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOpenOutputAfterTask = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutputNotice = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabSafety = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblSafetyInfo = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkConfirmMove = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkConfirmDelete = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkPermanentDelete = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblPermanentNotice = null!;

    private PS5PKGTool.UI.Controls.AppTabPage tabDiagnostics = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblMaintenanceInfo = null!;
    private PS5PKGTool.UI.Controls.AppButton btnExportSettings = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkExportCredentials = null!;
    private PS5PKGTool.UI.Controls.AppButton btnImportSettings = null!;
    private PS5PKGTool.UI.Controls.AppButton btnResetSettings = null!;
    private PS5PKGTool.UI.Controls.AppButton btnClearCaches = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOpenLogs = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblMaintenanceNotice = null!;

    private PS5PKGTool.UI.Controls.AppButton btnSave = null!;
    private PS5PKGTool.UI.Controls.AppButton btnCancel = null!;
    private FolderBrowserDialog folderBrowserDialog = null!;
    private SaveFileDialog exportSettingsDialog = null!;
    private OpenFileDialog importSettingsDialog = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
        components = new System.ComponentModel.Container();
        tabsSettings = new PS5PKGTool.UI.Controls.AppTabControl();
        tabLibrary = new PS5PKGTool.UI.Controls.AppTabPage();
        lblLibraryInfo = new PS5PKGTool.UI.Controls.AppLabel();
        lblFolders = new PS5PKGTool.UI.Controls.AppLabel();
        lstFolders = new PS5PKGTool.UI.Controls.AppListBox();
        btnAdd = new PS5PKGTool.UI.Controls.AppButton();
        btnRemove = new PS5PKGTool.UI.Controls.AppButton();
        lblManualSources = new PS5PKGTool.UI.Controls.AppLabel();
        lstManualSources = new PS5PKGTool.UI.Controls.AppListBox();
        btnRemoveSource = new PS5PKGTool.UI.Controls.AppButton();
        chkRecursive = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkRefreshOnStartup = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblLibraryNotice = new PS5PKGTool.UI.Controls.AppLabel();
        tabAppearance = new PS5PKGTool.UI.Controls.AppTabPage();
        lblAppearanceInfo = new PS5PKGTool.UI.Controls.AppLabel();
        lblRowHeight = new PS5PKGTool.UI.Controls.AppLabel();
        nudRowHeight = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblDensity = new PS5PKGTool.UI.Controls.AppLabel();
        cboDensity = new PS5PKGTool.UI.Controls.AppComboBox();
        chkShowThumbnails = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkShowGridLines = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkShowFilePreview = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblDefaultGroup = new PS5PKGTool.UI.Controls.AppLabel();
        cboDefaultGroup = new PS5PKGTool.UI.Controls.AppComboBox();
        btnResetLayout = new PS5PKGTool.UI.Controls.AppButton();
        lblAppearanceNotice = new PS5PKGTool.UI.Controls.AppLabel();
        tabNaming = new PS5PKGTool.UI.Controls.AppTabPage();
        lblNamingInfo = new PS5PKGTool.UI.Controls.AppLabel();
        lblRenameFormat = new PS5PKGTool.UI.Controls.AppLabel();
        txtRenameFormat = new PS5PKGTool.UI.Controls.AppTextBox();
        lblRenamePreset = new PS5PKGTool.UI.Controls.AppLabel();
        cboRenamePreset = new PS5PKGTool.UI.Controls.AppComboBox();
        lblRenameToken = new PS5PKGTool.UI.Controls.AppLabel();
        cboRenameToken = new PS5PKGTool.UI.Controls.AppComboBox();
        btnInsertToken = new PS5PKGTool.UI.Controls.AppButton();
        lblRenamePreview = new PS5PKGTool.UI.Controls.AppLabel();
        lblRenameUnknown = new PS5PKGTool.UI.Controls.AppLabel();
        tabFiles = new PS5PKGTool.UI.Controls.AppTabPage();
        lblViewingInfo = new PS5PKGTool.UI.Controls.AppLabel();
        lblMaxPreview = new PS5PKGTool.UI.Controls.AppLabel();
        nudMaxPreviewMb = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblHexPage = new PS5PKGTool.UI.Controls.AppLabel();
        nudHexPageKb = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblThumbCache = new PS5PKGTool.UI.Controls.AppLabel();
        nudThumbnailCache = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblThumbCacheHint = new PS5PKGTool.UI.Controls.AppLabel();
        lblViewingNotice = new PS5PKGTool.UI.Controls.AppLabel();
        tabPaths = new PS5PKGTool.UI.Controls.AppTabPage();
        lblPathsInfo = new PS5PKGTool.UI.Controls.AppLabel();
        lblOutputDir = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutputDirectory = new PS5PKGTool.UI.Controls.AppTextBox();
        btnBrowseOutput = new PS5PKGTool.UI.Controls.AppButton();
        lblTempDirectory = new PS5PKGTool.UI.Controls.AppLabel();
        txtTempDirectory = new PS5PKGTool.UI.Controls.AppTextBox();
        btnBrowseTemp = new PS5PKGTool.UI.Controls.AppButton();
        lblDefaultBackend = new PS5PKGTool.UI.Controls.AppLabel();
        cboDefaultBackend = new PS5PKGTool.UI.Controls.AppComboBox();
        lblPasscode = new PS5PKGTool.UI.Controls.AppLabel();
        txtDebugPasscode = new PS5PKGTool.UI.Controls.AppTextBox();
        chkShowPasscode = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblPasscodeHint = new PS5PKGTool.UI.Controls.AppLabel();
        chkOpenOutputAfterTask = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblOutputNotice = new PS5PKGTool.UI.Controls.AppLabel();
        tabSafety = new PS5PKGTool.UI.Controls.AppTabPage();
        lblSafetyInfo = new PS5PKGTool.UI.Controls.AppLabel();
        chkConfirmMove = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkConfirmDelete = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkPermanentDelete = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblPermanentNotice = new PS5PKGTool.UI.Controls.AppLabel();
        tabDiagnostics = new PS5PKGTool.UI.Controls.AppTabPage();
        lblMaintenanceInfo = new PS5PKGTool.UI.Controls.AppLabel();
        btnExportSettings = new PS5PKGTool.UI.Controls.AppButton();
        chkExportCredentials = new PS5PKGTool.UI.Controls.AppCheckBox();
        btnImportSettings = new PS5PKGTool.UI.Controls.AppButton();
        btnResetSettings = new PS5PKGTool.UI.Controls.AppButton();
        btnClearCaches = new PS5PKGTool.UI.Controls.AppButton();
        btnOpenLogs = new PS5PKGTool.UI.Controls.AppButton();
        lblMaintenanceNotice = new PS5PKGTool.UI.Controls.AppLabel();
        btnSave = new PS5PKGTool.UI.Controls.AppButton();
        btnCancel = new PS5PKGTool.UI.Controls.AppButton();
        folderBrowserDialog = new FolderBrowserDialog();
        exportSettingsDialog = new SaveFileDialog();
        importSettingsDialog = new OpenFileDialog();
        tabsSettings.SuspendLayout();
        tabLibrary.SuspendLayout();
        tabAppearance.SuspendLayout();
        tabNaming.SuspendLayout();
        tabFiles.SuspendLayout();
        tabPaths.SuspendLayout();
        tabSafety.SuspendLayout();
        tabDiagnostics.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRowHeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudMaxPreviewMb).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudHexPageKb).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudThumbnailCache).BeginInit();
        SuspendLayout();
        // 
        // tabsSettings
        // 
        tabsSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabsSettings.Controls.Add(tabLibrary);
        tabsSettings.Controls.Add(tabAppearance);
        tabsSettings.Controls.Add(tabNaming);
        tabsSettings.Controls.Add(tabFiles);
        tabsSettings.Controls.Add(tabPaths);
        tabsSettings.Controls.Add(tabSafety);
        tabsSettings.Controls.Add(tabDiagnostics);
        tabsSettings.Location = new Point(12, 12);
        tabsSettings.Name = "tabsSettings";
        tabsSettings.SelectedIndex = 0;
        tabsSettings.Size = new Size(696, 392);
        tabsSettings.TabIndex = 0;
        // 
        // tabLibrary
        // 
        tabLibrary.BackColor = SystemColors.Control;
        tabLibrary.Controls.Add(lblLibraryInfo);
        tabLibrary.Controls.Add(lblFolders);
        tabLibrary.Controls.Add(lstFolders);
        tabLibrary.Controls.Add(btnAdd);
        tabLibrary.Controls.Add(btnRemove);
        tabLibrary.Controls.Add(lblManualSources);
        tabLibrary.Controls.Add(lstManualSources);
        tabLibrary.Controls.Add(btnRemoveSource);
        tabLibrary.Controls.Add(chkRecursive);
        tabLibrary.Controls.Add(chkRefreshOnStartup);
        tabLibrary.Controls.Add(lblLibraryNotice);
        tabLibrary.Location = new Point(4, 26);
        tabLibrary.Name = "tabLibrary";
        tabLibrary.Size = new Size(688, 362);
        tabLibrary.TabIndex = 0;
        tabLibrary.Text = "Library";
        // 
        // lblLibraryInfo
        // 
        lblLibraryInfo.Location = new Point(16, 14);
        lblLibraryInfo.Name = "lblLibraryInfo";
        lblLibraryInfo.Size = new Size(656, 15);
        lblLibraryInfo.TabIndex = 0;
        lblLibraryInfo.Text = "Folders scanned for dumps, packages and images, plus sources added individually.";
        // 
        // lblFolders
        // 
        lblFolders.Location = new Point(16, 40);
        lblFolders.Name = "lblFolders";
        lblFolders.Size = new Size(380, 15);
        lblFolders.TabIndex = 1;
        lblFolders.Text = "Library folders";
        // 
        // lstFolders
        // 
        lstFolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstFolders.DrawMode = DrawMode.OwnerDrawFixed;
        lstFolders.FormattingEnabled = true;
        lstFolders.ItemHeight = 20;
        lstFolders.Location = new Point(16, 58);
        lstFolders.Name = "lstFolders";
        lstFolders.SelectionMode = SelectionMode.MultiExtended;
        lstFolders.Size = new Size(380, 174);
        lstFolders.TabIndex = 2;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(16, 240);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(120, 30);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add Folder...";
        btnAdd.Click += btnAdd_Click;
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(142, 240);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(140, 30);
        btnRemove.TabIndex = 4;
        btnRemove.Text = "Remove from Library";
        btnRemove.Click += btnRemove_Click;
        // 
        // lblManualSources
        // 
        lblManualSources.Location = new Point(420, 40);
        lblManualSources.Name = "lblManualSources";
        lblManualSources.Size = new Size(252, 15);
        lblManualSources.TabIndex = 5;
        lblManualSources.Text = "Manually added sources";
        // 
        // lstManualSources
        // 
        lstManualSources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        lstManualSources.DrawMode = DrawMode.OwnerDrawFixed;
        lstManualSources.FormattingEnabled = true;
        lstManualSources.ItemHeight = 20;
        lstManualSources.Location = new Point(420, 58);
        lstManualSources.Name = "lstManualSources";
        lstManualSources.SelectionMode = SelectionMode.MultiExtended;
        lstManualSources.Size = new Size(252, 174);
        lstManualSources.TabIndex = 6;
        // 
        // btnRemoveSource
        // 
        btnRemoveSource.Location = new Point(420, 240);
        btnRemoveSource.Name = "btnRemoveSource";
        btnRemoveSource.Size = new Size(180, 30);
        btnRemoveSource.TabIndex = 7;
        btnRemoveSource.Text = "Forget Source";
        btnRemoveSource.Click += btnRemoveSource_Click;
        // 
        // chkRecursive
        // 
        chkRecursive.AutoSize = true;
        chkRecursive.Location = new Point(16, 282);
        chkRecursive.Name = "chkRecursive";
        chkRecursive.Size = new Size(300, 19);
        chkRecursive.TabIndex = 8;
        chkRecursive.Text = "Scan subfolders (dumps, packages and images)";
        // 
        // chkRefreshOnStartup
        // 
        chkRefreshOnStartup.AutoSize = true;
        chkRefreshOnStartup.Location = new Point(16, 306);
        chkRefreshOnStartup.Name = "chkRefreshOnStartup";
        chkRefreshOnStartup.Size = new Size(300, 19);
        chkRefreshOnStartup.TabIndex = 9;
        chkRefreshOnStartup.Text = "Refresh library on startup (rescans every launch)";
        // 
        // lblLibraryNotice
        // 
        lblLibraryNotice.Location = new Point(16, 330);
        lblLibraryNotice.Name = "lblLibraryNotice";
        lblLibraryNotice.Size = new Size(656, 15);
        lblLibraryNotice.TabIndex = 10;
        lblLibraryNotice.Text = "Changing folders or Scan subfolders rescans the library when you save. Removing a folder never deletes files.";
        // 
        // tabAppearance
        // 
        tabAppearance.BackColor = SystemColors.Control;
        tabAppearance.Controls.Add(lblAppearanceInfo);
        tabAppearance.Controls.Add(lblRowHeight);
        tabAppearance.Controls.Add(nudRowHeight);
        tabAppearance.Controls.Add(lblDensity);
        tabAppearance.Controls.Add(cboDensity);
        tabAppearance.Controls.Add(chkShowThumbnails);
        tabAppearance.Controls.Add(chkShowGridLines);
        tabAppearance.Controls.Add(chkShowFilePreview);
        tabAppearance.Controls.Add(lblDefaultGroup);
        tabAppearance.Controls.Add(cboDefaultGroup);
        tabAppearance.Controls.Add(btnResetLayout);
        tabAppearance.Controls.Add(lblAppearanceNotice);
        tabAppearance.Location = new Point(4, 26);
        tabAppearance.Name = "tabAppearance";
        tabAppearance.Size = new Size(688, 362);
        tabAppearance.TabIndex = 1;
        tabAppearance.Text = "Appearance";
        // 
        // lblAppearanceInfo
        // 
        lblAppearanceInfo.Location = new Point(16, 14);
        lblAppearanceInfo.Name = "lblAppearanceInfo";
        lblAppearanceInfo.Size = new Size(656, 15);
        lblAppearanceInfo.TabIndex = 0;
        lblAppearanceInfo.Text = "Library grid display and grouping. Visual preferences apply when you save.";
        // 
        // lblRowHeight
        // 
        lblRowHeight.Location = new Point(16, 83);
        lblRowHeight.Name = "lblRowHeight";
        lblRowHeight.Size = new Size(170, 15);
        lblRowHeight.TabIndex = 3;
        lblRowHeight.Text = "Grid row height (px)";
        // 
        // nudRowHeight
        // 
        nudRowHeight.Location = new Point(196, 79);
        nudRowHeight.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        nudRowHeight.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
        nudRowHeight.Name = "nudRowHeight";
        nudRowHeight.Size = new Size(80, 23);
        nudRowHeight.TabIndex = 4;
        nudRowHeight.Value = new decimal(new int[] { 22, 0, 0, 0 });
        // 
        // lblDensity
        // 
        lblDensity.Location = new Point(300, 83);
        lblDensity.Name = "lblDensity";
        lblDensity.Size = new Size(90, 15);
        lblDensity.TabIndex = 5;
        lblDensity.Text = "Density";
        // 
        // cboDensity
        // 
        cboDensity.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDensity.Location = new Point(396, 79);
        cboDensity.Name = "cboDensity";
        cboDensity.Size = new Size(160, 23);
        cboDensity.TabIndex = 6;
        // 
        // chkShowThumbnails
        // 
        chkShowThumbnails.AutoSize = true;
        chkShowThumbnails.Location = new Point(16, 118);
        chkShowThumbnails.Name = "chkShowThumbnails";
        chkShowThumbnails.Size = new Size(260, 19);
        chkShowThumbnails.TabIndex = 7;
        chkShowThumbnails.Text = "Show game thumbnails in the list";
        // 
        // chkShowGridLines
        // 
        chkShowGridLines.AutoSize = true;
        chkShowGridLines.Location = new Point(16, 146);
        chkShowGridLines.Name = "chkShowGridLines";
        chkShowGridLines.Size = new Size(260, 19);
        chkShowGridLines.TabIndex = 8;
        chkShowGridLines.Text = "Show grid lines";
        // 
        // chkShowFilePreview
        // 
        chkShowFilePreview.AutoSize = true;
        chkShowFilePreview.Location = new Point(16, 170);
        chkShowFilePreview.Name = "chkShowFilePreview";
        chkShowFilePreview.Size = new Size(400, 19);
        chkShowFilePreview.TabIndex = 13;
        chkShowFilePreview.Text = "Show the file preview pane in the Files tab";
        // 
        // lblDefaultGroup
        // 
        lblDefaultGroup.Location = new Point(16, 205);
        lblDefaultGroup.Name = "lblDefaultGroup";
        lblDefaultGroup.Size = new Size(170, 15);
        lblDefaultGroup.TabIndex = 7;
        lblDefaultGroup.Text = "Default grouping";
        // 
        // cboDefaultGroup
        // 
        cboDefaultGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDefaultGroup.Location = new Point(196, 201);
        cboDefaultGroup.Name = "cboDefaultGroup";
        cboDefaultGroup.Size = new Size(320, 23);
        cboDefaultGroup.TabIndex = 10;
        // 
        // btnResetLayout
        // 
        btnResetLayout.Location = new Point(196, 234);
        btnResetLayout.Name = "btnResetLayout";
        btnResetLayout.Size = new Size(220, 30);
        btnResetLayout.TabIndex = 11;
        btnResetLayout.Text = "Reset Column Layout (on Save)";
        btnResetLayout.Click += btnResetLayout_Click;
        // 
        // lblAppearanceNotice
        // 
        lblAppearanceNotice.Location = new Point(16, 330);
        lblAppearanceNotice.Name = "lblAppearanceNotice";
        lblAppearanceNotice.Size = new Size(656, 15);
        lblAppearanceNotice.TabIndex = 12;
        lblAppearanceNotice.Text = "The default grouping is applied to the open library when you save.";
        // 
        // tabNaming
        // 
        tabNaming.BackColor = SystemColors.Control;
        tabNaming.Controls.Add(lblNamingInfo);
        tabNaming.Controls.Add(lblRenameFormat);
        tabNaming.Controls.Add(txtRenameFormat);
        tabNaming.Controls.Add(lblRenamePreset);
        tabNaming.Controls.Add(cboRenamePreset);
        tabNaming.Controls.Add(lblRenameToken);
        tabNaming.Controls.Add(cboRenameToken);
        tabNaming.Controls.Add(btnInsertToken);
        tabNaming.Controls.Add(lblRenamePreview);
        tabNaming.Controls.Add(lblRenameUnknown);
        tabNaming.Location = new Point(4, 26);
        tabNaming.Name = "tabNaming";
        tabNaming.Size = new Size(688, 362);
        tabNaming.TabIndex = 2;
        tabNaming.Text = "Naming";
        // 
        // lblNamingInfo
        // 
        lblNamingInfo.Location = new Point(16, 14);
        lblNamingInfo.Name = "lblNamingInfo";
        lblNamingInfo.Size = new Size(656, 15);
        lblNamingInfo.TabIndex = 0;
        lblNamingInfo.Text = "Default format used by the custom rename option.";
        // 
        // lblRenameFormat
        // 
        lblRenameFormat.Location = new Point(16, 49);
        lblRenameFormat.Name = "lblRenameFormat";
        lblRenameFormat.Size = new Size(170, 15);
        lblRenameFormat.TabIndex = 1;
        lblRenameFormat.Text = "Rename format";
        // 
        // txtRenameFormat
        // 
        txtRenameFormat.Location = new Point(196, 45);
        txtRenameFormat.Name = "txtRenameFormat";
        txtRenameFormat.PlaceholderText = "{TITLE} [{TITLE_ID}]";
        txtRenameFormat.Size = new Size(460, 23);
        txtRenameFormat.TabIndex = 2;
        txtRenameFormat.TextChanged += txtRenameFormat_TextChanged;
        // 
        // lblRenamePreset
        // 
        lblRenamePreset.Location = new Point(16, 87);
        lblRenamePreset.Name = "lblRenamePreset";
        lblRenamePreset.Size = new Size(170, 15);
        lblRenamePreset.TabIndex = 3;
        lblRenamePreset.Text = "Start from a preset";
        // 
        // cboRenamePreset
        // 
        cboRenamePreset.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRenamePreset.Location = new Point(196, 83);
        cboRenamePreset.Name = "cboRenamePreset";
        cboRenamePreset.Size = new Size(460, 23);
        cboRenamePreset.TabIndex = 4;
        cboRenamePreset.SelectedIndexChanged += cboRenamePreset_SelectedIndexChanged;
        // 
        // lblRenameToken
        // 
        lblRenameToken.Location = new Point(16, 125);
        lblRenameToken.Name = "lblRenameToken";
        lblRenameToken.Size = new Size(170, 15);
        lblRenameToken.TabIndex = 5;
        lblRenameToken.Text = "Insert a token";
        // 
        // cboRenameToken
        // 
        cboRenameToken.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRenameToken.Location = new Point(196, 121);
        cboRenameToken.Name = "cboRenameToken";
        cboRenameToken.Size = new Size(300, 23);
        cboRenameToken.TabIndex = 6;
        // 
        // btnInsertToken
        // 
        btnInsertToken.Location = new Point(504, 120);
        btnInsertToken.Name = "btnInsertToken";
        btnInsertToken.Size = new Size(152, 26);
        btnInsertToken.TabIndex = 7;
        btnInsertToken.Text = "Insert";
        btnInsertToken.Click += btnInsertToken_Click;
        // 
        // lblRenamePreview
        // 
        lblRenamePreview.Location = new Point(16, 168);
        lblRenamePreview.Name = "lblRenamePreview";
        lblRenamePreview.Size = new Size(656, 15);
        lblRenamePreview.TabIndex = 8;
        lblRenamePreview.Text = "Example: ...";
        // 
        // lblRenameUnknown
        // 
        lblRenameUnknown.Location = new Point(16, 192);
        lblRenameUnknown.Name = "lblRenameUnknown";
        lblRenameUnknown.Size = new Size(656, 30);
        lblRenameUnknown.TabIndex = 9;
        lblRenameUnknown.Text = "";
        // 
        // tabFiles
        // 
        tabFiles.BackColor = SystemColors.Control;
        tabFiles.Controls.Add(lblViewingInfo);
        tabFiles.Controls.Add(lblMaxPreview);
        tabFiles.Controls.Add(nudMaxPreviewMb);
        tabFiles.Controls.Add(lblHexPage);
        tabFiles.Controls.Add(nudHexPageKb);
        tabFiles.Controls.Add(lblThumbCache);
        tabFiles.Controls.Add(nudThumbnailCache);
        tabFiles.Controls.Add(lblThumbCacheHint);
        tabFiles.Controls.Add(lblViewingNotice);
        tabFiles.Location = new Point(4, 26);
        tabFiles.Name = "tabFiles";
        tabFiles.Size = new Size(688, 362);
        tabFiles.TabIndex = 3;
        tabFiles.Text = "Viewing & Cache";
        // 
        // lblViewingInfo
        // 
        lblViewingInfo.Location = new Point(16, 14);
        lblViewingInfo.Name = "lblViewingInfo";
        lblViewingInfo.Size = new Size(656, 15);
        lblViewingInfo.TabIndex = 0;
        lblViewingInfo.Text = "Preview limits and thumbnail cache. Limits bound what is loaded for a preview, not total memory.";
        // 
        // lblMaxPreview
        // 
        lblMaxPreview.Location = new Point(16, 49);
        lblMaxPreview.Name = "lblMaxPreview";
        lblMaxPreview.Size = new Size(170, 15);
        lblMaxPreview.TabIndex = 1;
        lblMaxPreview.Text = "Max auto-preview (MiB)";
        // 
        // nudMaxPreviewMb
        // 
        nudMaxPreviewMb.Location = new Point(196, 45);
        nudMaxPreviewMb.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
        nudMaxPreviewMb.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudMaxPreviewMb.Name = "nudMaxPreviewMb";
        nudMaxPreviewMb.Size = new Size(80, 23);
        nudMaxPreviewMb.TabIndex = 2;
        nudMaxPreviewMb.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // lblHexPage
        // 
        lblHexPage.Location = new Point(16, 83);
        lblHexPage.Name = "lblHexPage";
        lblHexPage.Size = new Size(170, 15);
        lblHexPage.TabIndex = 3;
        lblHexPage.Text = "Hex page size (KiB)";
        // 
        // nudHexPageKb
        // 
        nudHexPageKb.Location = new Point(196, 79);
        nudHexPageKb.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
        nudHexPageKb.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudHexPageKb.Name = "nudHexPageKb";
        nudHexPageKb.Size = new Size(80, 23);
        nudHexPageKb.TabIndex = 4;
        nudHexPageKb.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // lblThumbCache
        // 
        lblThumbCache.Location = new Point(16, 117);
        lblThumbCache.Name = "lblThumbCache";
        lblThumbCache.Size = new Size(170, 15);
        lblThumbCache.TabIndex = 5;
        lblThumbCache.Text = "Thumbnail cache entries";
        // 
        // nudThumbnailCache
        // 
        nudThumbnailCache.Location = new Point(196, 113);
        nudThumbnailCache.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudThumbnailCache.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudThumbnailCache.Name = "nudThumbnailCache";
        nudThumbnailCache.Size = new Size(80, 23);
        nudThumbnailCache.TabIndex = 6;
        nudThumbnailCache.Value = new decimal(new int[] { 512, 0, 0, 0 });
        // 
        // lblThumbCacheHint
        // 
        lblThumbCacheHint.Location = new Point(286, 117);
        lblThumbCacheHint.Name = "lblThumbCacheHint";
        lblThumbCacheHint.Size = new Size(386, 15);
        lblThumbCacheHint.TabIndex = 7;
        lblThumbCacheHint.Text = "Minimum 1. Older thumbnails are evicted first.";
        // 
        // lblViewingNotice
        // 
        lblViewingNotice.Location = new Point(16, 330);
        lblViewingNotice.Name = "lblViewingNotice";
        lblViewingNotice.Size = new Size(656, 15);
        lblViewingNotice.TabIndex = 8;
        lblViewingNotice.Text = "Hex page size applies the next time a page is read. Cache entries are decoded images held in memory.";
        // 
        // tabPaths
        // 
        tabPaths.BackColor = SystemColors.Control;
        tabPaths.Controls.Add(lblPathsInfo);
        tabPaths.Controls.Add(lblOutputDir);
        tabPaths.Controls.Add(txtOutputDirectory);
        tabPaths.Controls.Add(btnBrowseOutput);
        tabPaths.Controls.Add(lblTempDirectory);
        tabPaths.Controls.Add(txtTempDirectory);
        tabPaths.Controls.Add(btnBrowseTemp);
        tabPaths.Controls.Add(lblDefaultBackend);
        tabPaths.Controls.Add(cboDefaultBackend);
        tabPaths.Controls.Add(lblPasscode);
        tabPaths.Controls.Add(txtDebugPasscode);
        tabPaths.Controls.Add(chkShowPasscode);
        tabPaths.Controls.Add(lblPasscodeHint);
        tabPaths.Controls.Add(chkOpenOutputAfterTask);
        tabPaths.Controls.Add(lblOutputNotice);
        tabPaths.Location = new Point(4, 26);
        tabPaths.Name = "tabPaths";
        tabPaths.Size = new Size(688, 362);
        tabPaths.TabIndex = 4;
        tabPaths.Text = "Output & Defaults";
        // 
        // lblPathsInfo
        // 
        lblPathsInfo.Location = new Point(16, 14);
        lblPathsInfo.Name = "lblPathsInfo";
        lblPathsInfo.Size = new Size(656, 15);
        lblPathsInfo.TabIndex = 0;
        lblPathsInfo.Text = "Defaults for output, the builder and package credentials. New jobs inherit these; existing jobs keep their own values.";
        // 
        // lblOutputDir
        // 
        lblOutputDir.Location = new Point(16, 49);
        lblOutputDir.Name = "lblOutputDir";
        lblOutputDir.Size = new Size(170, 15);
        lblOutputDir.TabIndex = 1;
        lblOutputDir.Text = "Default output folder";
        // 
        // txtOutputDirectory
        // 
        txtOutputDirectory.Location = new Point(196, 45);
        txtOutputDirectory.Name = "txtOutputDirectory";
        txtOutputDirectory.Size = new Size(380, 23);
        txtOutputDirectory.TabIndex = 2;
        // 
        // btnBrowseOutput
        // 
        btnBrowseOutput.Location = new Point(584, 44);
        btnBrowseOutput.Name = "btnBrowseOutput";
        btnBrowseOutput.Size = new Size(80, 26);
        btnBrowseOutput.TabIndex = 3;
        btnBrowseOutput.Text = "Browse...";
        btnBrowseOutput.Click += btnBrowseOutput_Click;
        // lblTempDirectory
        lblTempDirectory.Location = new Point(16, 87);
        lblTempDirectory.Name = "lblTempDirectory";
        lblTempDirectory.Size = new Size(170, 15);
        lblTempDirectory.TabIndex = 4;
        lblTempDirectory.Text = "Temporary workspace folder";
        // txtTempDirectory
        txtTempDirectory.Location = new Point(196, 83);
        txtTempDirectory.Name = "txtTempDirectory";
        txtTempDirectory.Size = new Size(380, 23);
        txtTempDirectory.TabIndex = 5;
        // btnBrowseTemp
        btnBrowseTemp.Location = new Point(584, 82);
        btnBrowseTemp.Name = "btnBrowseTemp";
        btnBrowseTemp.Size = new Size(80, 26);
        btnBrowseTemp.TabIndex = 6;
        btnBrowseTemp.Text = "Browse...";
        btnBrowseTemp.Click += btnBrowseTemp_Click;
        // lblDefaultBackend
        // 
        lblDefaultBackend.Location = new Point(16, 125);
        lblDefaultBackend.Name = "lblDefaultBackend";
        lblDefaultBackend.Size = new Size(170, 15);
        lblDefaultBackend.TabIndex = 7;
        lblDefaultBackend.Text = "Default builder";
        // 
        // cboDefaultBackend
        // 
        cboDefaultBackend.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDefaultBackend.Location = new Point(196, 121);
        cboDefaultBackend.Name = "cboDefaultBackend";
        cboDefaultBackend.Size = new Size(320, 23);
        cboDefaultBackend.TabIndex = 8;
        // 
        // lblPasscode
        // 
        lblPasscode.Location = new Point(16, 163);
        lblPasscode.Name = "lblPasscode";
        lblPasscode.Size = new Size(170, 15);
        lblPasscode.TabIndex = 9;
        lblPasscode.Text = "Default debug passcode";
        // 
        // txtDebugPasscode
        // 
        txtDebugPasscode.Location = new Point(196, 159);
        txtDebugPasscode.Name = "txtDebugPasscode";
        txtDebugPasscode.Size = new Size(280, 23);
        txtDebugPasscode.TabIndex = 10;
        txtDebugPasscode.UseSystemPasswordChar = true;
        txtDebugPasscode.TextChanged += txtDebugPasscode_TextChanged;
        // 
        // chkShowPasscode
        // 
        chkShowPasscode.AutoSize = true;
        chkShowPasscode.Location = new Point(486, 161);
        chkShowPasscode.Name = "chkShowPasscode";
        chkShowPasscode.Size = new Size(60, 19);
        chkShowPasscode.TabIndex = 11;
        chkShowPasscode.Text = "Show";
        chkShowPasscode.CheckedChanged += chkShowPasscode_CheckedChanged;
        // 
        // lblPasscodeHint
        // 
        lblPasscodeHint.Location = new Point(196, 188);
        lblPasscodeHint.Name = "lblPasscodeHint";
        lblPasscodeHint.Size = new Size(470, 30);
        lblPasscodeHint.TabIndex = 12;
        lblPasscodeHint.Text = "Blank uses the default all-zero passcode. Otherwise exactly 32 printable ASCII characters.";
        // 
        // chkOpenOutputAfterTask
        // 
        chkOpenOutputAfterTask.AutoSize = true;
        chkOpenOutputAfterTask.Location = new Point(16, 230);
        chkOpenOutputAfterTask.Name = "chkOpenOutputAfterTask";
        chkOpenOutputAfterTask.Size = new Size(400, 19);
        chkOpenOutputAfterTask.TabIndex = 13;
        chkOpenOutputAfterTask.Text = "Open the output folder after a task succeeds";
        // 
        // lblOutputNotice
        // 
        lblOutputNotice.Location = new Point(16, 330);
        lblOutputNotice.Name = "lblOutputNotice";
        lblOutputNotice.Size = new Size(656, 15);
        lblOutputNotice.TabIndex = 14;
        lblOutputNotice.Text = "The output folder also seeds the Move and Save artwork dialogs. Builder changes apply to new jobs.";
        // 
        // tabSafety
        // 
        tabSafety.BackColor = SystemColors.Control;
        tabSafety.Controls.Add(lblSafetyInfo);
        tabSafety.Controls.Add(chkConfirmMove);
        tabSafety.Controls.Add(chkConfirmDelete);
        tabSafety.Controls.Add(chkPermanentDelete);
        tabSafety.Controls.Add(lblPermanentNotice);
        tabSafety.Location = new Point(4, 26);
        tabSafety.Name = "tabSafety";
        tabSafety.Size = new Size(688, 362);
        tabSafety.TabIndex = 5;
        tabSafety.Text = "File Operations";
        // 
        // lblSafetyInfo
        // 
        lblSafetyInfo.Location = new Point(16, 14);
        lblSafetyInfo.Name = "lblSafetyInfo";
        lblSafetyInfo.Size = new Size(656, 15);
        lblSafetyInfo.TabIndex = 0;
        lblSafetyInfo.Text = "Confirmation prompts and deletion mode for sources in the library.";
        // 
        // chkConfirmMove
        // 
        chkConfirmMove.AutoSize = true;
        chkConfirmMove.Location = new Point(16, 49);
        chkConfirmMove.Name = "chkConfirmMove";
        chkConfirmMove.Size = new Size(400, 19);
        chkConfirmMove.TabIndex = 1;
        chkConfirmMove.Text = "Confirm before moving sources on disk";
        // 
        // chkConfirmDelete
        // 
        chkConfirmDelete.AutoSize = true;
        chkConfirmDelete.Location = new Point(16, 77);
        chkConfirmDelete.Name = "chkConfirmDelete";
        chkConfirmDelete.Size = new Size(400, 19);
        chkConfirmDelete.TabIndex = 2;
        chkConfirmDelete.Text = "Confirm before sending a source to the Recycle Bin";
        // 
        // chkPermanentDelete
        // 
        chkPermanentDelete.AutoSize = true;
        chkPermanentDelete.Location = new Point(16, 105);
        chkPermanentDelete.Name = "chkPermanentDelete";
        chkPermanentDelete.Size = new Size(400, 19);
        chkPermanentDelete.TabIndex = 3;
        chkPermanentDelete.Text = "Delete permanently instead of sending to the Recycle Bin";
        // 
        // lblPermanentNotice
        // 
        lblPermanentNotice.Location = new Point(16, 132);
        lblPermanentNotice.Name = "lblPermanentNotice";
        lblPermanentNotice.Size = new Size(656, 30);
        lblPermanentNotice.TabIndex = 4;
        lblPermanentNotice.Text = "Permanent deletion always asks for confirmation, even when the Recycle Bin prompt is turned off.";
        // 
        // tabDiagnostics
        // 
        tabDiagnostics.BackColor = SystemColors.Control;
        tabDiagnostics.Controls.Add(lblMaintenanceInfo);
        tabDiagnostics.Controls.Add(btnExportSettings);
        tabDiagnostics.Controls.Add(chkExportCredentials);
        tabDiagnostics.Controls.Add(btnImportSettings);
        tabDiagnostics.Controls.Add(btnResetSettings);
        tabDiagnostics.Controls.Add(btnClearCaches);
        tabDiagnostics.Controls.Add(btnOpenLogs);
        tabDiagnostics.Controls.Add(lblMaintenanceNotice);
        tabDiagnostics.Location = new Point(4, 26);
        tabDiagnostics.Name = "tabDiagnostics";
        tabDiagnostics.Size = new Size(688, 362);
        tabDiagnostics.TabIndex = 6;
        tabDiagnostics.Text = "Maintenance";
        // 
        // lblMaintenanceInfo
        // 
        lblMaintenanceInfo.Location = new Point(16, 14);
        lblMaintenanceInfo.Name = "lblMaintenanceInfo";
        lblMaintenanceInfo.Size = new Size(656, 15);
        lblMaintenanceInfo.TabIndex = 0;
        lblMaintenanceInfo.Text = "Back up, restore or clear application data.";
        // 
        // btnExportSettings
        // 
        btnExportSettings.Location = new Point(16, 48);
        btnExportSettings.Name = "btnExportSettings";
        btnExportSettings.Size = new Size(220, 30);
        btnExportSettings.TabIndex = 1;
        btnExportSettings.Text = "Export Preferences...";
        btnExportSettings.Click += btnExportSettings_Click;
        // 
        // chkExportCredentials
        // 
        chkExportCredentials.AutoSize = true;
        chkExportCredentials.Location = new Point(250, 54);
        chkExportCredentials.Name = "chkExportCredentials";
        chkExportCredentials.Size = new Size(300, 19);
        chkExportCredentials.TabIndex = 2;
        chkExportCredentials.Text = "Include the debug passcode (private backup)";
        // 
        // btnImportSettings
        // 
        btnImportSettings.Location = new Point(16, 84);
        btnImportSettings.Name = "btnImportSettings";
        btnImportSettings.Size = new Size(220, 30);
        btnImportSettings.TabIndex = 3;
        btnImportSettings.Text = "Import Preferences...";
        btnImportSettings.Click += btnImportSettings_Click;
        // 
        // btnResetSettings
        // 
        btnResetSettings.Location = new Point(16, 120);
        btnResetSettings.Name = "btnResetSettings";
        btnResetSettings.Size = new Size(220, 30);
        btnResetSettings.TabIndex = 4;
        btnResetSettings.Text = "Reset Preferences...";
        btnResetSettings.Click += btnResetSettings_Click;
        // 
        // btnClearCaches
        // 
        btnClearCaches.Location = new Point(16, 156);
        btnClearCaches.Name = "btnClearCaches";
        btnClearCaches.Size = new Size(220, 30);
        btnClearCaches.TabIndex = 5;
        btnClearCaches.Text = "Clear Caches (on Save)";
        btnClearCaches.Click += btnClearCaches_Click;
        // 
        // btnOpenLogs
        // 
        btnOpenLogs.Location = new Point(16, 192);
        btnOpenLogs.Name = "btnOpenLogs";
        btnOpenLogs.Size = new Size(220, 30);
        btnOpenLogs.TabIndex = 6;
        btnOpenLogs.Text = "Open Log Folder";
        btnOpenLogs.Click += btnOpenLogs_Click;
        // 
        // lblMaintenanceNotice
        // 
        lblMaintenanceNotice.Location = new Point(16, 236);
        lblMaintenanceNotice.Name = "lblMaintenanceNotice";
        lblMaintenanceNotice.Size = new Size(656, 60);
        lblMaintenanceNotice.TabIndex = 7;
        lblMaintenanceNotice.Text = "Export and Import cover preferences; library folders, sources and window layout are included. Open Log Folder is immediate. Clear Caches takes effect when you save; Cancel discards it.";
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSave.Location = new Point(478, 416);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(110, 32);
        btnSave.TabIndex = 1;
        btnSave.Text = "Save";
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(598, 416);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(110, 32);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancel";
        // 
        // SettingsForm
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        CancelButton = btnCancel;
        ClientSize = new Size(720, 460);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(tabsSettings);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(0, 0);
        Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        Name = "SettingsForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "PS5 PKG Tool Settings";
        tabsSettings.ResumeLayout(false);
        tabLibrary.ResumeLayout(false);
        tabLibrary.PerformLayout();
        tabAppearance.ResumeLayout(false);
        tabAppearance.PerformLayout();
        tabNaming.ResumeLayout(false);
        tabNaming.PerformLayout();
        tabFiles.ResumeLayout(false);
        tabFiles.PerformLayout();
        tabPaths.ResumeLayout(false);
        tabPaths.PerformLayout();
        tabSafety.ResumeLayout(false);
        tabSafety.PerformLayout();
        tabDiagnostics.ResumeLayout(false);
        tabDiagnostics.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRowHeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudMaxPreviewMb).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudHexPageKb).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudThumbnailCache).EndInit();
        ResumeLayout(false);
    }
}
