#nullable enable

namespace PS5PKGTool.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private PS5PKGTool.UI.Controls.AppMenuStrip menuMain = null!;
    private ToolStripMenuItem menuFile = null!;
    private ToolStripMenuItem menuAddFolder = null!;
    private ToolStripMenuItem menuOpenDump = null!;
    private ToolStripMenuItem menuOpenPackage = null!;
    private ToolStripMenuItem menuRefresh = null!;
    private ToolStripMenuItem menuSaveManifest = null!;
        private ToolStripMenuItem menuEmptyList = null!;
        private ToolStripMenuItem menuRemoveMissing = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuSeparator = null!;
    private ToolStripMenuItem menuSettings = null!;
    private ToolStripMenuItem menuExit = null!;
    private ToolStripMenuItem menuHelp = null!;
    private ToolStripMenuItem menuAbout = null!;
    private ToolStripMenuItem menuRecent = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuHelpSeparator = null!;
    private ToolStripMenuItem menuHelpCheckUpdate = null!;
        private ToolStripMenuItem menuHelpKofi = null!;
        private ToolStripMenuItem menuHelpPayPal = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextLibrary = null!;
    private ToolStripMenuItem menuLibraryReveal = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuLibrarySeparator1 = null!;
    private ToolStripMenuItem menuLibraryCopy = null!;
    private ToolStripMenuItem menuLibraryCopyTitle = null!;
    private ToolStripMenuItem menuLibraryCopyTitleId = null!;
    private ToolStripMenuItem menuLibraryCopyContentId = null!;
    private ToolStripMenuItem menuLibraryCopyPath = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuLibrarySeparator2 = null!;
    private ToolStripMenuItem menuLibraryRename = null!;
    private ToolStripMenuItem menuLibraryRenameAll = null!;
    private ToolStripMenuItem menuLibraryRenameByPriority = null!;
    private ToolStripMenuItem menuLibraryGroupBy = null!;
    private ToolStripMenuItem menuLibraryGroupNone = null!;
    private ToolStripMenuItem menuLibraryGroupFamily = null!;
    private ToolStripMenuItem menuLibraryGroupTitleId = null!;
    private ToolStripMenuItem menuLibraryGroupCategory = null!;
    private ToolStripMenuItem menuLibraryGroupRegion = null!;
    private ToolStripMenuItem menuLibraryGroupSource = null!;
    private ToolStripMenuItem menuLibraryGroupFirmware = null!;
    private ToolStripMenuItem menuLibraryDuplicates = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuLibrarySeparator3 = null!;
    private ToolStripMenuItem menuLibraryExport = null!;
    private ToolStripMenuItem menuLibraryCopyFileName = null!;
    private ToolStripMenuItem menuLibrarySaveArtwork = null!;
    private ToolStripMenuItem menuLibraryMove = null!;
    private ToolStripMenuItem menuLibraryMoveTitle = null!;
    private ToolStripMenuItem menuLibraryMoveTitleId = null!;
    private ToolStripMenuItem menuLibraryMoveCategory = null!;
    private ToolStripMenuItem menuLibraryMoveRegion = null!;
    private ToolStripMenuItem menuLibraryMoveSource = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuLibraryMoveSeparator = null!;
    private ToolStripMenuItem menuLibraryMoveSingle = null!;
    private ToolStripMenuItem menuLibraryDelete = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuLibrarySeparator5 = null!;
    private ToolStripMenuItem menuLibraryGroupExport = null!;
    private ToolStripMenuItem menuLibraryGroupArtwork = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchLibrary = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterCategory = null!;
    private PS5PKGTool.UI.Controls.AppCheckedComboBox cboFilterCategory = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterRegion = null!;
    private PS5PKGTool.UI.Controls.AppCheckedComboBox cboFilterRegion = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterFormat = null!;
    private PS5PKGTool.UI.Controls.AppCheckedComboBox cboFilterFormat = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterGroup = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboFilterGroup = null!;
    private PS5PKGTool.UI.Controls.AppButton btnFilterClear = null!;
    private PS5PKGTool.UI.Controls.AppChipsPanel chipsFilter = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterPreset = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboFilterPreset = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilterEmpty = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitMain = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitMainPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitMainPane2 = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridLibrary = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsWorkspace = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabWorkspaceGeneral = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabWorkspaceTools = null!;
        private PS5PKGTool.UI.Controls.AppTabPage tabTasks = null!;
        private PS5PKGTool.UI.Controls.AppTabPage tabLog = null!;
        private PS5PKGTool.UI.Controls.AppLabel lblLogLevel = null!;
        private PS5PKGTool.UI.Controls.AppComboBox cboLogLevel = null!;
        private PS5PKGTool.UI.Controls.AppCheckBox chkLogAutoScroll = null!;
        private PS5PKGTool.UI.Controls.AppButton btnLogClear = null!;
        private PS5PKGTool.UI.Controls.AppButton btnLogOpenFolder = null!;
        private PS5PKGTool.UI.Controls.AppRichTextBox txtLogView = null!;
    private PS5PKGTool.UI.Controls.AppTableLayoutPanel tasksLayout = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTaskAutoStart = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskStart = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskCancel = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskRetry = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskRemove = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskOpen = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskClear = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskSummary = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTaskFollow = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboTaskFilter = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchTasks = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskToggleDetails = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskGroup = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboTaskGroup = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitTasks = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitTasksPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitTasksPane2 = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionTasksList = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridTasks = null!;
    private DataGridViewTextBoxColumn colTaskName = null!;
    private DataGridViewTextBoxColumn colTaskOperation = null!;
    private DataGridViewTextBoxColumn colTaskRoute = null!;
    private DataGridViewTextBoxColumn colTaskStatus = null!;
    private DataGridViewTextBoxColumn colTaskStage = null!;
    private DataGridViewTextBoxColumn colTaskProgress = null!;
    private DataGridViewTextBoxColumn colTaskElapsed = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionTaskDetails = null!;
    private PS5PKGTool.UI.Controls.AppTableLayoutPanel taskDetailLayout = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskStage = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskCurrentCaption = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskOverallCaption = null!;
    private PS5PKGTool.UI.Controls.AppProgressBar barTaskCurrent = null!;
    private PS5PKGTool.UI.Controls.AppProgressBar barTaskOverall = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskMessage = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskMeta = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTaskResult = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTaskDiagnostic = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextTasks = null!;
    private ToolStripMenuItem menuTaskStart = null!;
    private ToolStripMenuItem menuTaskCancel = null!;
    private ToolStripMenuItem menuTaskRetry = null!;
    private ToolStripMenuItem menuTaskRemove = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuTaskSeparator1 = null!;
    private ToolStripMenuItem menuTaskOpen = null!;
    private ToolStripMenuItem menuTaskShowSource = null!;
    private ToolStripMenuItem menuTaskReport = null!;
    private ToolStripMenuItem menuTaskClear = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsDetails = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabOverview = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOverviewCopyAll = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOverviewCopySelected = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridOverview = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabArtwork = null!;
    private PS5PKGTool.UI.Controls.AppButton btnArtworkSaveAll = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextArtwork = null!;
    private ToolStripMenuItem menuArtworkSaveThis = null!;
    private ToolStripMenuItem menuArtworkSaveAll = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitArtwork = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitArtworkPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitArtworkPane2 = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionIcon = null!;
    private PictureBox pictureIcon = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionBackground = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsBackgrounds = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPic0 = null!;
    private PictureBox pictureBackground0 = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPic1 = null!;
    private PictureBox pictureBackground1 = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPic2 = null!;
    private PictureBox pictureBackground2 = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTrophies = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblTrophySummary = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridTrophies = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTrophySaveIcons = null!;
    private PS5PKGTool.UI.Controls.AppButton btnTrophyExportCsv = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTrophyPlatinum = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTrophyGold = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTrophySilver = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTrophyBronze = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkTrophyShowHidden = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchTrophy = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextTrophies = null!;
    private ToolStripMenuItem menuTrophySaveIcon = null!;
    private ToolStripMenuItem menuTrophySaveAllIcons = null!;
    private ToolStripMenuItem menuTrophyExportCsv = null!;
    private SaveFileDialog trophyCsvSaveDialog = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabActivities = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblActivitiesSummary = null!;
    private PS5PKGTool.UI.Controls.AppButton btnUdsCopyAll = null!;
    private PS5PKGTool.UI.Controls.AppButton btnUdsCopySelected = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchUds = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsUds = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabUdsEvents = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitUdsEvents = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitUdsEventsPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitUdsEventsPane2 = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridUdsEvents = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridUdsEventProperties = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabUdsStats = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridUdsStats = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabUdsEnums = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridUdsEnums = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabUdsRules = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridUdsRules = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabFiles = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFilesSummary = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionFileBrowser = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitFileBrowser = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitFileBrowserPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitFileBrowserPane2 = null!;
    private PS5PKGTool.UI.Controls.AppTreeView treeFiles = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitFileContentPreview = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitFileContentPreviewPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitFileContentPreviewPane2 = null!;
    private PS5PKGTool.UI.Controls.AppPanel fileListPanel = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchFileFilter = null!;
    private PS5PKGTool.UI.Controls.AppListView listFiles = null!;
    private ColumnHeader colFileName = null!;
    private ColumnHeader colFileType = null!;
    private ColumnHeader colFilePath = null!;
    private ColumnHeader colFileSize = null!;
    private ImageList imageListFiles = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextTreeFiles = null!;
    private ToolStripMenuItem menuTreeExpand = null!;
    private ToolStripMenuItem menuTreeCollapse = null!;
    private ToolStripMenuItem menuTreeExpandAll = null!;
    private ToolStripMenuItem menuTreeCollapseAll = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuTreeSeparator = null!;
    private ToolStripMenuItem menuTreeCopyPath = null!;
    private ToolStripMenuItem menuTreeExtract = null!;
    private ToolStripMenuItem menuFileCopyPath = null!;
    private ToolStripMenuItem menuFileCopyName = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuFileCopySeparator = null!;
    private PS5PKGTool.UI.Controls.AppContextMenu contextFiles = null!;
    private ToolStripMenuItem menuFileOpenContained = null!;
    private ToolStripMenuItem menuFileExtractContained = null!;
    private ToolStripMenuItem menuFileExtractSelected = null!;
    private PS5PKGTool.UI.Controls.AppToolStripSeparator menuFileContainerSeparator = null!;
    private ToolStripMenuItem menuFileRevealContainer = null!;
    private PS5PKGTool.UI.Controls.AppButton btnFileExtractAll = null!;
    private PS5PKGTool.UI.Controls.AppButton btnFileCancel = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionFileViewer = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblFileViewerInfo = null!;
    private PictureBox pictureFileViewer = null!;
    private PS5PKGTool.UI.Controls.AppRichTextBox txtFileViewer = null!;
    private PS5PKGTool.UI.Controls.AppRichTextBox txtHexViewer = null!;
    private System.Windows.Forms.Integration.ElementHost mediaFileHost = null!;
    private System.Windows.Controls.MediaElement mediaFileViewer = null!;
    private PS5PKGTool.UI.Controls.AppButton btnMediaLoad = null!;
    private PS5PKGTool.UI.Controls.AppButton btnMediaPlay = null!;
    private PS5PKGTool.UI.Controls.AppButton btnMediaPause = null!;
    private PS5PKGTool.UI.Controls.AppButton btnMediaStop = null!;
    private PS5PKGTool.UI.Controls.AppButton btnHexPrevious = null!;
    private PS5PKGTool.UI.Controls.AppButton btnHexNext = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblHexPage = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabExecutable = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblExecutableSummary = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridModules = null!;
    private PS5PKGTool.UI.Controls.AppButton btnExecExtract = null!;
    private PS5PKGTool.UI.Controls.AppButton btnExecHash = null!;
    private PS5PKGTool.UI.Controls.AppButton btnExecCopyAll = null!;
    private PS5PKGTool.UI.Controls.AppButton btnExecCopySelected = null!;
    private PS5PKGTool.UI.Controls.AppSearchBox searchExecutable = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsExecutable = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabExecModules = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabExecElf = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitExecElf = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitExecElfPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitExecElfPane2 = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridElfPrograms = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridElfSections = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabExecSelf = null!;
    private PS5PKGTool.UI.Controls.AppSplitContainer splitExecSelf = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitExecSelfPane1 = null!;
    private PS5PKGTool.UI.Controls.AppSplitPane splitExecSelfPane2 = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridSelfHeader = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridSelfSegments = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabRaw = null!;
    private PS5PKGTool.UI.Controls.AppButton btnCopyRawJson = null!;
    private PS5PKGTool.UI.Controls.AppButton btnRawFormatted = null!;
    private PS5PKGTool.UI.Controls.AppButton btnRawOriginal = null!;
    private PS5PKGTool.UI.Controls.AppRichTextBox txtRawMetadata = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPackage = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsPackage = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabMetadata = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsMetadata = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgContainer = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPkgHeader = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgSegments = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPkgSegments = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgEntries = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPkgEntries = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgSfo = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridParamSfo = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgKeystone = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridKeystone = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgSi = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridSi = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPkgPlayGo = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblPlayGoSummary = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsPlayGo = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPlayGoChunks = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPlayGoChunks = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPlayGoScenarios = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPlayGoScenarios = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabPlayGoFiles = null!;
    private PS5PKGTool.UI.Controls.AppDataGridView gridPlayGoFiles = null!;
    private PS5PKGTool.UI.Controls.AppTableLayoutPanel toolsLayout = null!;
    private PS5PKGTool.UI.Controls.AppSectionPanel sectionJob = null!;
    private PS5PKGTool.UI.Controls.AppTabControl tabsImageTargets = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTargetExfat = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTargetFfpkg = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTargetFfpfsc = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTargetDebug = null!;
    private PS5PKGTool.UI.Controls.AppTabPage tabTargetOptions = null!;
    private PS5PKGTool.UI.Controls.AppFooterBar toolsFooter = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageSource = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageSourcePath = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageFormat = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageAction = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageAction = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageOutput = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtImageOutput = null!;
    private PS5PKGTool.UI.Controls.AppButton btnImageBrowseOutput = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageOverwrite = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutExfat = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutExfat = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOutExfat = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOutExfat = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutFfpkg = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutFfpkg = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOutFfpkg = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOutFfpkg = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutFfpfsc = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutFfpfsc = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOutFfpfsc = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOutFfpfsc = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblOutDebug = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtOutDebug = null!;
    private PS5PKGTool.UI.Controls.AppButton btnOutDebug = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkOutDebug = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblDbgPasscode = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtDbgPasscode = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageCluster = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageCluster = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageLevel = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudImageLevel = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageGain = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudImageGain = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageAmpr = null!;
    private PS5PKGTool.UI.Controls.AppButton btnImageRun = null!;
    private PS5PKGTool.UI.Controls.AppButton btnImageCancel = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageStatus = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageBlock = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageBlock = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageFragment = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageFragment = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageDensity = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageDensity = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageMinFree = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudImageMinFree = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImagePasscode = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtImagePasscode = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageSdk = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageSdk = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImagePkgType = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImagePkgType = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageCompression = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageCompression = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageKrakenLevel = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageKrakenLevel = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageKrakenThreads = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudImageKrakenThreads = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImagePlayGo = null!;
    private PS5PKGTool.UI.Controls.AppNumericUpDown nudImagePlayGoChunks = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageDrm = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageDrm = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageFakeSign = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageRightSprx = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageDeterministic = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageBackend = null!;
    private PS5PKGTool.UI.Controls.AppComboBox cboImageBackend = null!;
    private PS5PKGTool.UI.Controls.AppCheckBox chkImageAdvancedOptions = null!;
    private PS5PKGTool.UI.Controls.AppLabel lblImageTemp = null!;
    private PS5PKGTool.UI.Controls.AppTextBox txtImageTemp = null!;
    private PS5PKGTool.UI.Controls.AppButton btnImageTempBrowse = null!;
    private SaveFileDialog imageSaveDialog = null!;
    private PS5PKGTool.UI.Controls.AppStatusStrip statusMain = null!;
    private PS5PKGTool.UI.Controls.AppToolStripStatusLabel statusLabel = null!;
    private PS5PKGTool.UI.Controls.AppToolStripStatusLabel statusSpring = null!;
    private PS5PKGTool.UI.Controls.AppToolStripStatusLabel statusCount = null!;
    private FolderBrowserDialog folderBrowserDialog = null!;
    private OpenFileDialog packageOpenDialog = null!;
    private OpenFileDialog sourceImageOpenDialog = null!;
    private SaveFileDialog containedFileSaveDialog = null!;
    private SaveFileDialog artworkSaveDialog = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        imageListFiles = new ImageList(components);
        menuMain = new PS5PKGTool.UI.Controls.AppMenuStrip();
        menuFile = new ToolStripMenuItem();
        menuAddFolder = new ToolStripMenuItem();
        menuOpenDump = new ToolStripMenuItem();
        menuOpenPackage = new ToolStripMenuItem();
        menuRecent = new ToolStripMenuItem();
        menuRefresh = new ToolStripMenuItem();
        menuSaveManifest = new ToolStripMenuItem();
        menuEmptyList = new ToolStripMenuItem();
        menuRemoveMissing = new ToolStripMenuItem();
        menuSeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuSettings = new ToolStripMenuItem();
        menuExit = new ToolStripMenuItem();
        menuHelp = new ToolStripMenuItem();
        menuAbout = new ToolStripMenuItem();
        menuHelpSeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuHelpCheckUpdate = new ToolStripMenuItem();
        menuHelpKofi = new ToolStripMenuItem();
        menuHelpPayPal = new ToolStripMenuItem();
        contextLibrary = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuLibraryReveal = new ToolStripMenuItem();
        menuLibrarySeparator1 = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuLibraryCopy = new ToolStripMenuItem();
        menuLibraryCopyTitle = new ToolStripMenuItem();
        menuLibraryCopyTitleId = new ToolStripMenuItem();
        menuLibraryCopyContentId = new ToolStripMenuItem();
        menuLibraryCopyFileName = new ToolStripMenuItem();
        menuLibraryCopyPath = new ToolStripMenuItem();
        menuLibraryRename = new ToolStripMenuItem();
        menuLibraryRenameAll = new ToolStripMenuItem();
        menuLibraryRenameByPriority = new ToolStripMenuItem();
        menuLibraryMove = new ToolStripMenuItem();
        menuLibraryMoveTitle = new ToolStripMenuItem();
        menuLibraryMoveTitleId = new ToolStripMenuItem();
        menuLibraryMoveCategory = new ToolStripMenuItem();
        menuLibraryMoveRegion = new ToolStripMenuItem();
        menuLibraryMoveSource = new ToolStripMenuItem();
        menuLibraryMoveSeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuLibraryMoveSingle = new ToolStripMenuItem();
        menuLibraryDelete = new ToolStripMenuItem();
        menuLibrarySeparator2 = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuLibrarySaveArtwork = new ToolStripMenuItem();
        menuLibraryExport = new ToolStripMenuItem();
        menuLibrarySeparator3 = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuLibraryGroupBy = new ToolStripMenuItem();
        menuLibraryGroupNone = new ToolStripMenuItem();
        menuLibraryGroupFamily = new ToolStripMenuItem();
        menuLibraryGroupTitleId = new ToolStripMenuItem();
        menuLibraryGroupCategory = new ToolStripMenuItem();
        menuLibraryGroupRegion = new ToolStripMenuItem();
        menuLibraryGroupSource = new ToolStripMenuItem();
        menuLibraryGroupFirmware = new ToolStripMenuItem();
        menuLibraryDuplicates = new ToolStripMenuItem();
        menuLibrarySeparator5 = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuLibraryGroupExport = new ToolStripMenuItem();
        menuLibraryGroupArtwork = new ToolStripMenuItem();
        searchLibrary = new PS5PKGTool.UI.Controls.AppSearchBox();
        lblFilterCategory = new PS5PKGTool.UI.Controls.AppLabel();
        cboFilterCategory = new PS5PKGTool.UI.Controls.AppCheckedComboBox(components);
        lblFilterRegion = new PS5PKGTool.UI.Controls.AppLabel();
        cboFilterRegion = new PS5PKGTool.UI.Controls.AppCheckedComboBox(components);
        lblFilterFormat = new PS5PKGTool.UI.Controls.AppLabel();
        cboFilterFormat = new PS5PKGTool.UI.Controls.AppCheckedComboBox(components);
        lblFilterGroup = new PS5PKGTool.UI.Controls.AppLabel();
        cboFilterGroup = new PS5PKGTool.UI.Controls.AppComboBox();
        btnFilterClear = new PS5PKGTool.UI.Controls.AppButton();
        chipsFilter = new PS5PKGTool.UI.Controls.AppChipsPanel(components);
        lblFilterPreset = new PS5PKGTool.UI.Controls.AppLabel();
        cboFilterPreset = new PS5PKGTool.UI.Controls.AppComboBox();
        lblFilterEmpty = new PS5PKGTool.UI.Controls.AppLabel();
        splitMain = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitMainPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridLibrary = new PS5PKGTool.UI.Controls.AppDataGridView();
        splitMainPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        tabsWorkspace = new PS5PKGTool.UI.Controls.AppTabControl();
        tabWorkspaceGeneral = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsDetails = new PS5PKGTool.UI.Controls.AppTabControl();
        tabOverview = new PS5PKGTool.UI.Controls.AppTabPage();
        gridOverview = new PS5PKGTool.UI.Controls.AppDataGridView();
        btnOverviewCopySelected = new PS5PKGTool.UI.Controls.AppButton();
        btnOverviewCopyAll = new PS5PKGTool.UI.Controls.AppButton();
        tabArtwork = new PS5PKGTool.UI.Controls.AppTabPage();
        splitArtwork = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitArtworkPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionIcon = new PS5PKGTool.UI.Controls.AppSectionPanel();
        pictureIcon = new PictureBox();
        contextArtwork = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuArtworkSaveThis = new ToolStripMenuItem();
        menuArtworkSaveAll = new ToolStripMenuItem();
        splitArtworkPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionBackground = new PS5PKGTool.UI.Controls.AppSectionPanel();
        tabsBackgrounds = new PS5PKGTool.UI.Controls.AppTabControl();
        tabPic0 = new PS5PKGTool.UI.Controls.AppTabPage();
        pictureBackground0 = new PictureBox();
        tabPic1 = new PS5PKGTool.UI.Controls.AppTabPage();
        pictureBackground1 = new PictureBox();
        tabPic2 = new PS5PKGTool.UI.Controls.AppTabPage();
        pictureBackground2 = new PictureBox();
        btnArtworkSaveAll = new PS5PKGTool.UI.Controls.AppButton();
        tabTrophies = new PS5PKGTool.UI.Controls.AppTabPage();
        gridTrophies = new PS5PKGTool.UI.Controls.AppDataGridView();
        contextTrophies = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuTrophySaveIcon = new ToolStripMenuItem();
        menuTrophySaveAllIcons = new ToolStripMenuItem();
        menuTrophyExportCsv = new ToolStripMenuItem();
        lblTrophySummary = new PS5PKGTool.UI.Controls.AppLabel();
        searchTrophy = new PS5PKGTool.UI.Controls.AppSearchBox();
        chkTrophyShowHidden = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkTrophyBronze = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkTrophySilver = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkTrophyGold = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkTrophyPlatinum = new PS5PKGTool.UI.Controls.AppCheckBox();
        btnTrophyExportCsv = new PS5PKGTool.UI.Controls.AppButton();
        btnTrophySaveIcons = new PS5PKGTool.UI.Controls.AppButton();
        tabActivities = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsUds = new PS5PKGTool.UI.Controls.AppTabControl();
        tabUdsEvents = new PS5PKGTool.UI.Controls.AppTabPage();
        splitUdsEvents = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitUdsEventsPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridUdsEvents = new PS5PKGTool.UI.Controls.AppDataGridView();
        splitUdsEventsPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridUdsEventProperties = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabUdsStats = new PS5PKGTool.UI.Controls.AppTabPage();
        gridUdsStats = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabUdsEnums = new PS5PKGTool.UI.Controls.AppTabPage();
        gridUdsEnums = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabUdsRules = new PS5PKGTool.UI.Controls.AppTabPage();
        gridUdsRules = new PS5PKGTool.UI.Controls.AppDataGridView();
        lblActivitiesSummary = new PS5PKGTool.UI.Controls.AppLabel();
        searchUds = new PS5PKGTool.UI.Controls.AppSearchBox();
        btnUdsCopySelected = new PS5PKGTool.UI.Controls.AppButton();
        btnUdsCopyAll = new PS5PKGTool.UI.Controls.AppButton();
        tabFiles = new PS5PKGTool.UI.Controls.AppTabPage();
        sectionFileBrowser = new PS5PKGTool.UI.Controls.AppSectionPanel();
        splitFileBrowser = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitFileBrowserPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        treeFiles = new PS5PKGTool.UI.Controls.AppTreeView();
        contextTreeFiles = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuTreeExpand = new ToolStripMenuItem();
        menuTreeCollapse = new ToolStripMenuItem();
        menuTreeExpandAll = new ToolStripMenuItem();
        menuTreeCollapseAll = new ToolStripMenuItem();
        menuTreeSeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuTreeCopyPath = new ToolStripMenuItem();
        menuTreeExtract = new ToolStripMenuItem();
        splitFileBrowserPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        splitFileContentPreview = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitFileContentPreviewPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        fileListPanel = new PS5PKGTool.UI.Controls.AppPanel();
        searchFileFilter = new PS5PKGTool.UI.Controls.AppSearchBox();
        listFiles = new PS5PKGTool.UI.Controls.AppListView();
        contextFiles = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuFileOpenContained = new ToolStripMenuItem();
        menuFileExtractContained = new ToolStripMenuItem();
        menuFileExtractSelected = new ToolStripMenuItem();
        menuFileCopySeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuFileCopyPath = new ToolStripMenuItem();
        menuFileCopyName = new ToolStripMenuItem();
        menuFileContainerSeparator = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuFileRevealContainer = new ToolStripMenuItem();
        splitFileContentPreviewPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionFileViewer = new PS5PKGTool.UI.Controls.AppSectionPanel();
        mediaFileHost = new System.Windows.Forms.Integration.ElementHost();
        txtHexViewer = new PS5PKGTool.UI.Controls.AppRichTextBox();
        txtFileViewer = new PS5PKGTool.UI.Controls.AppRichTextBox();
        pictureFileViewer = new PictureBox();
        lblFileViewerInfo = new PS5PKGTool.UI.Controls.AppLabel();
        btnMediaLoad = new PS5PKGTool.UI.Controls.AppButton();
        btnMediaPlay = new PS5PKGTool.UI.Controls.AppButton();
        btnMediaPause = new PS5PKGTool.UI.Controls.AppButton();
        btnMediaStop = new PS5PKGTool.UI.Controls.AppButton();
        btnHexPrevious = new PS5PKGTool.UI.Controls.AppButton();
        btnHexNext = new PS5PKGTool.UI.Controls.AppButton();
        lblHexPage = new PS5PKGTool.UI.Controls.AppLabel();
        lblFilesSummary = new PS5PKGTool.UI.Controls.AppLabel();
        btnFileExtractAll = new PS5PKGTool.UI.Controls.AppButton();
        btnFileCancel = new PS5PKGTool.UI.Controls.AppButton();
        tabExecutable = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsExecutable = new PS5PKGTool.UI.Controls.AppTabControl();
        tabExecModules = new PS5PKGTool.UI.Controls.AppTabPage();
        gridModules = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabExecElf = new PS5PKGTool.UI.Controls.AppTabPage();
        splitExecElf = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitExecElfPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridElfPrograms = new PS5PKGTool.UI.Controls.AppDataGridView();
        splitExecElfPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridElfSections = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabExecSelf = new PS5PKGTool.UI.Controls.AppTabPage();
        splitExecSelf = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitExecSelfPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridSelfHeader = new PS5PKGTool.UI.Controls.AppDataGridView();
        splitExecSelfPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        gridSelfSegments = new PS5PKGTool.UI.Controls.AppDataGridView();
        lblExecutableSummary = new PS5PKGTool.UI.Controls.AppLabel();
        searchExecutable = new PS5PKGTool.UI.Controls.AppSearchBox();
        btnExecCopySelected = new PS5PKGTool.UI.Controls.AppButton();
        btnExecCopyAll = new PS5PKGTool.UI.Controls.AppButton();
        btnExecExtract = new PS5PKGTool.UI.Controls.AppButton();
        btnExecHash = new PS5PKGTool.UI.Controls.AppButton();
        tabRaw = new PS5PKGTool.UI.Controls.AppTabPage();
        txtRawMetadata = new PS5PKGTool.UI.Controls.AppRichTextBox();
        btnRawFormatted = new PS5PKGTool.UI.Controls.AppButton();
        btnRawOriginal = new PS5PKGTool.UI.Controls.AppButton();
        btnCopyRawJson = new PS5PKGTool.UI.Controls.AppButton();
        tabPackage = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsPackage = new PS5PKGTool.UI.Controls.AppTabControl();
        tabPkgContainer = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPkgHeader = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPkgSegments = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPkgSegments = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPkgEntries = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPkgEntries = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabMetadata = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsMetadata = new PS5PKGTool.UI.Controls.AppTabControl();
        tabPkgSfo = new PS5PKGTool.UI.Controls.AppTabPage();
        gridParamSfo = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPkgKeystone = new PS5PKGTool.UI.Controls.AppTabPage();
        gridKeystone = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPkgPlayGo = new PS5PKGTool.UI.Controls.AppTabPage();
        tabsPlayGo = new PS5PKGTool.UI.Controls.AppTabControl();
        tabPlayGoChunks = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPlayGoChunks = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPlayGoScenarios = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPlayGoScenarios = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabPlayGoFiles = new PS5PKGTool.UI.Controls.AppTabPage();
        gridPlayGoFiles = new PS5PKGTool.UI.Controls.AppDataGridView();
        lblPlayGoSummary = new PS5PKGTool.UI.Controls.AppLabel();
        tabPkgSi = new PS5PKGTool.UI.Controls.AppTabPage();
        gridSi = new PS5PKGTool.UI.Controls.AppDataGridView();
        tabWorkspaceTools = new PS5PKGTool.UI.Controls.AppTabPage();
        toolsLayout = new PS5PKGTool.UI.Controls.AppTableLayoutPanel();
        sectionJob = new PS5PKGTool.UI.Controls.AppSectionPanel();
        lblImageSourcePath = new PS5PKGTool.UI.Controls.AppLabel();
        lblImageFormat = new PS5PKGTool.UI.Controls.AppLabel();
        lblImageAction = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageAction = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageSource = new PS5PKGTool.UI.Controls.AppLabel();
        tabsImageTargets = new PS5PKGTool.UI.Controls.AppTabControl();
        tabTargetExfat = new PS5PKGTool.UI.Controls.AppTabPage();
        lblOutExfat = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutExfat = new PS5PKGTool.UI.Controls.AppTextBox();
        btnOutExfat = new PS5PKGTool.UI.Controls.AppButton();
        chkOutExfat = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblImageCluster = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageCluster = new PS5PKGTool.UI.Controls.AppComboBox();
        chkImageAmpr = new PS5PKGTool.UI.Controls.AppCheckBox();
        tabTargetFfpkg = new PS5PKGTool.UI.Controls.AppTabPage();
        lblOutFfpkg = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutFfpkg = new PS5PKGTool.UI.Controls.AppTextBox();
        btnOutFfpkg = new PS5PKGTool.UI.Controls.AppButton();
        chkOutFfpkg = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblImageBlock = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageBlock = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageFragment = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageFragment = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageDensity = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageDensity = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageMinFree = new PS5PKGTool.UI.Controls.AppLabel();
        nudImageMinFree = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        tabTargetFfpfsc = new PS5PKGTool.UI.Controls.AppTabPage();
        lblOutFfpfsc = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutFfpfsc = new PS5PKGTool.UI.Controls.AppTextBox();
        btnOutFfpfsc = new PS5PKGTool.UI.Controls.AppButton();
        chkOutFfpfsc = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblImageLevel = new PS5PKGTool.UI.Controls.AppLabel();
        nudImageLevel = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblImageGain = new PS5PKGTool.UI.Controls.AppLabel();
        nudImageGain = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        tabTargetDebug = new PS5PKGTool.UI.Controls.AppTabPage();
        lblOutDebug = new PS5PKGTool.UI.Controls.AppLabel();
        txtOutDebug = new PS5PKGTool.UI.Controls.AppTextBox();
        btnOutDebug = new PS5PKGTool.UI.Controls.AppButton();
        chkOutDebug = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblDbgPasscode = new PS5PKGTool.UI.Controls.AppLabel();
        txtDbgPasscode = new PS5PKGTool.UI.Controls.AppTextBox();
        lblImageSdk = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageSdk = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImagePkgType = new PS5PKGTool.UI.Controls.AppLabel();
        cboImagePkgType = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageCompression = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageCompression = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageKrakenLevel = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageKrakenLevel = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImagePlayGo = new PS5PKGTool.UI.Controls.AppLabel();
        nudImagePlayGoChunks = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblImageKrakenThreads = new PS5PKGTool.UI.Controls.AppLabel();
        nudImageKrakenThreads = new PS5PKGTool.UI.Controls.AppNumericUpDown();
        lblImageTemp = new PS5PKGTool.UI.Controls.AppLabel();
        txtImageTemp = new PS5PKGTool.UI.Controls.AppTextBox();
        btnImageTempBrowse = new PS5PKGTool.UI.Controls.AppButton();
        lblImageDrm = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageDrm = new PS5PKGTool.UI.Controls.AppComboBox();
        lblImageBackend = new PS5PKGTool.UI.Controls.AppLabel();
        cboImageBackend = new PS5PKGTool.UI.Controls.AppComboBox();
        chkImageFakeSign = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkImageRightSprx = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkImageDeterministic = new PS5PKGTool.UI.Controls.AppCheckBox();
        chkImageAdvancedOptions = new PS5PKGTool.UI.Controls.AppCheckBox();
        tabTargetOptions = new PS5PKGTool.UI.Controls.AppTabPage();
        lblImageOutput = new PS5PKGTool.UI.Controls.AppLabel();
        txtImageOutput = new PS5PKGTool.UI.Controls.AppTextBox();
        btnImageBrowseOutput = new PS5PKGTool.UI.Controls.AppButton();
        chkImageOverwrite = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblImagePasscode = new PS5PKGTool.UI.Controls.AppLabel();
        txtImagePasscode = new PS5PKGTool.UI.Controls.AppTextBox();
        toolsFooter = new PS5PKGTool.UI.Controls.AppFooterBar();
        lblImageStatus = new PS5PKGTool.UI.Controls.AppLabel();
        btnImageRun = new PS5PKGTool.UI.Controls.AppButton();
        btnImageCancel = new PS5PKGTool.UI.Controls.AppButton();
        tabTasks = new PS5PKGTool.UI.Controls.AppTabPage();
        tasksLayout = new PS5PKGTool.UI.Controls.AppTableLayoutPanel();
        chkTaskAutoStart = new PS5PKGTool.UI.Controls.AppCheckBox();
        btnTaskStart = new PS5PKGTool.UI.Controls.AppButton();
        btnTaskCancel = new PS5PKGTool.UI.Controls.AppButton();
        btnTaskRetry = new PS5PKGTool.UI.Controls.AppButton();
        btnTaskRemove = new PS5PKGTool.UI.Controls.AppButton();
        btnTaskOpen = new PS5PKGTool.UI.Controls.AppButton();
        btnTaskClear = new PS5PKGTool.UI.Controls.AppButton();
        lblTaskGroup = new PS5PKGTool.UI.Controls.AppLabel();
        cboTaskGroup = new PS5PKGTool.UI.Controls.AppComboBox();
        cboTaskFilter = new PS5PKGTool.UI.Controls.AppComboBox();
        searchTasks = new PS5PKGTool.UI.Controls.AppSearchBox();
        btnTaskToggleDetails = new PS5PKGTool.UI.Controls.AppButton();
        chkTaskFollow = new PS5PKGTool.UI.Controls.AppCheckBox();
        lblTaskSummary = new PS5PKGTool.UI.Controls.AppLabel();
        splitTasks = new PS5PKGTool.UI.Controls.AppSplitContainer();
        splitTasksPane1 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionTasksList = new PS5PKGTool.UI.Controls.AppSectionPanel();
        gridTasks = new PS5PKGTool.UI.Controls.AppDataGridView();
        colTaskName = new DataGridViewTextBoxColumn();
        colTaskOperation = new DataGridViewTextBoxColumn();
        colTaskRoute = new DataGridViewTextBoxColumn();
        colTaskStatus = new DataGridViewTextBoxColumn();
        colTaskStage = new DataGridViewTextBoxColumn();
        colTaskProgress = new DataGridViewTextBoxColumn();
        colTaskElapsed = new DataGridViewTextBoxColumn();
        contextTasks = new PS5PKGTool.UI.Controls.AppContextMenu();
        menuTaskStart = new ToolStripMenuItem();
        menuTaskCancel = new ToolStripMenuItem();
        menuTaskRetry = new ToolStripMenuItem();
        menuTaskRemove = new ToolStripMenuItem();
        menuTaskSeparator1 = new PS5PKGTool.UI.Controls.AppToolStripSeparator();
        menuTaskOpen = new ToolStripMenuItem();
        menuTaskShowSource = new ToolStripMenuItem();
        menuTaskReport = new ToolStripMenuItem();
        menuTaskClear = new ToolStripMenuItem();
        splitTasksPane2 = new PS5PKGTool.UI.Controls.AppSplitPane();
        sectionTaskDetails = new PS5PKGTool.UI.Controls.AppSectionPanel();
        taskDetailLayout = new PS5PKGTool.UI.Controls.AppTableLayoutPanel();
        lblTaskStage = new PS5PKGTool.UI.Controls.AppLabel();
        lblTaskCurrentCaption = new PS5PKGTool.UI.Controls.AppLabel();
        barTaskCurrent = new PS5PKGTool.UI.Controls.AppProgressBar();
        lblTaskOverallCaption = new PS5PKGTool.UI.Controls.AppLabel();
        barTaskOverall = new PS5PKGTool.UI.Controls.AppProgressBar();
        lblTaskMessage = new PS5PKGTool.UI.Controls.AppLabel();
        lblTaskMeta = new PS5PKGTool.UI.Controls.AppLabel();
        lblTaskResult = new PS5PKGTool.UI.Controls.AppLabel();
        btnTaskDiagnostic = new PS5PKGTool.UI.Controls.AppButton();
        tabLog = new PS5PKGTool.UI.Controls.AppTabPage();
        txtLogView = new PS5PKGTool.UI.Controls.AppRichTextBox();
        lblLogLevel = new PS5PKGTool.UI.Controls.AppLabel();
        cboLogLevel = new PS5PKGTool.UI.Controls.AppComboBox();
        chkLogAutoScroll = new PS5PKGTool.UI.Controls.AppCheckBox();
        btnLogClear = new PS5PKGTool.UI.Controls.AppButton();
        btnLogOpenFolder = new PS5PKGTool.UI.Controls.AppButton();
        colFileName = new ColumnHeader();
        colFileType = new ColumnHeader();
        colFilePath = new ColumnHeader();
        colFileSize = new ColumnHeader();
        imageSaveDialog = new SaveFileDialog();
        trophyCsvSaveDialog = new SaveFileDialog();
        statusMain = new PS5PKGTool.UI.Controls.AppStatusStrip();
        statusLabel = new PS5PKGTool.UI.Controls.AppToolStripStatusLabel();
        statusSpring = new PS5PKGTool.UI.Controls.AppToolStripStatusLabel();
        statusCount = new PS5PKGTool.UI.Controls.AppToolStripStatusLabel();
        folderBrowserDialog = new FolderBrowserDialog();
        packageOpenDialog = new OpenFileDialog();
        sourceImageOpenDialog = new OpenFileDialog();
        containedFileSaveDialog = new SaveFileDialog();
        artworkSaveDialog = new SaveFileDialog();
        menuMain.SuspendLayout();
        contextLibrary.SuspendLayout();
        splitMain.SuspendLayout();
        splitMainPane1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridLibrary).BeginInit();
        splitMainPane2.SuspendLayout();
        tabsWorkspace.SuspendLayout();
        tabWorkspaceGeneral.SuspendLayout();
        tabsDetails.SuspendLayout();
        tabOverview.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridOverview).BeginInit();
        tabArtwork.SuspendLayout();
        splitArtwork.SuspendLayout();
        splitArtworkPane1.SuspendLayout();
        sectionIcon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureIcon).BeginInit();
        contextArtwork.SuspendLayout();
        splitArtworkPane2.SuspendLayout();
        sectionBackground.SuspendLayout();
        tabsBackgrounds.SuspendLayout();
        tabPic0.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBackground0).BeginInit();
        tabPic1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBackground1).BeginInit();
        tabPic2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBackground2).BeginInit();
        tabTrophies.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTrophies).BeginInit();
        contextTrophies.SuspendLayout();
        tabActivities.SuspendLayout();
        tabsUds.SuspendLayout();
        tabUdsEvents.SuspendLayout();
        splitUdsEvents.SuspendLayout();
        splitUdsEventsPane1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridUdsEvents).BeginInit();
        splitUdsEventsPane2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridUdsEventProperties).BeginInit();
        tabUdsStats.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridUdsStats).BeginInit();
        tabUdsEnums.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridUdsEnums).BeginInit();
        tabUdsRules.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridUdsRules).BeginInit();
        tabFiles.SuspendLayout();
        sectionFileBrowser.SuspendLayout();
        splitFileBrowser.SuspendLayout();
        splitFileBrowserPane1.SuspendLayout();
        contextTreeFiles.SuspendLayout();
        splitFileBrowserPane2.SuspendLayout();
        splitFileContentPreview.SuspendLayout();
        splitFileContentPreviewPane1.SuspendLayout();
        fileListPanel.SuspendLayout();
        contextFiles.SuspendLayout();
        splitFileContentPreviewPane2.SuspendLayout();
        sectionFileViewer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureFileViewer).BeginInit();
        tabExecutable.SuspendLayout();
        tabsExecutable.SuspendLayout();
        tabExecModules.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridModules).BeginInit();
        tabExecElf.SuspendLayout();
        splitExecElf.SuspendLayout();
        splitExecElfPane1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridElfPrograms).BeginInit();
        splitExecElfPane2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridElfSections).BeginInit();
        tabExecSelf.SuspendLayout();
        splitExecSelf.SuspendLayout();
        splitExecSelfPane1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridSelfHeader).BeginInit();
        splitExecSelfPane2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridSelfSegments).BeginInit();
        tabRaw.SuspendLayout();
        tabPackage.SuspendLayout();
        tabsPackage.SuspendLayout();
        tabPkgContainer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPkgHeader).BeginInit();
        tabPkgSegments.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPkgSegments).BeginInit();
        tabPkgEntries.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPkgEntries).BeginInit();
        tabMetadata.SuspendLayout();
        tabsMetadata.SuspendLayout();
        tabPkgSfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridParamSfo).BeginInit();
        tabPkgKeystone.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridKeystone).BeginInit();
        tabPkgPlayGo.SuspendLayout();
        tabsPlayGo.SuspendLayout();
        tabPlayGoChunks.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPlayGoChunks).BeginInit();
        tabPlayGoScenarios.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPlayGoScenarios).BeginInit();
        tabPlayGoFiles.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridPlayGoFiles).BeginInit();
        tabPkgSi.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridSi).BeginInit();
        tabWorkspaceTools.SuspendLayout();
        toolsLayout.SuspendLayout();
        sectionJob.SuspendLayout();
        tabsImageTargets.SuspendLayout();
        tabTargetExfat.SuspendLayout();
        tabTargetFfpkg.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudImageMinFree).BeginInit();
        tabTargetFfpfsc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudImageLevel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudImageGain).BeginInit();
        tabTargetDebug.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudImagePlayGoChunks).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudImageKrakenThreads).BeginInit();
        tabTargetOptions.SuspendLayout();
        toolsFooter.SuspendLayout();
        tabTasks.SuspendLayout();
        tasksLayout.SuspendLayout();
        splitTasks.SuspendLayout();
        splitTasksPane1.SuspendLayout();
        sectionTasksList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
        contextTasks.SuspendLayout();
        splitTasksPane2.SuspendLayout();
        sectionTaskDetails.SuspendLayout();
        taskDetailLayout.SuspendLayout();
        tabLog.SuspendLayout();
        statusMain.SuspendLayout();
        SuspendLayout();
        // 
        // imageListFiles
        // 
        imageListFiles.ColorDepth = ColorDepth.Depth32Bit;
        imageListFiles.ImageSize = new Size(16, 16);
        imageListFiles.TransparentColor = Color.Transparent;
        // 
        // menuMain
        // 
        menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuHelp });
        menuMain.Location = new Point(0, 0);
        menuMain.Name = "menuMain";
        menuMain.Padding = new Padding(3, 2, 0, 2);
        menuMain.Size = new Size(1384, 24);
        menuMain.TabIndex = 0;
        // 
        // menuFile
        // 
        menuFile.BackColor = SystemColors.Control;
        menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuAddFolder, menuOpenDump, menuOpenPackage, menuRecent, menuRefresh, menuSaveManifest, menuEmptyList, menuRemoveMissing, menuSeparator, menuSettings, menuExit });
        menuFile.ForeColor = SystemColors.ControlText;
        menuFile.Name = "menuFile";
        menuFile.Size = new Size(37, 20);
        menuFile.Text = "File";
        // 
        // menuAddFolder
        // 
        menuAddFolder.Name = "menuAddFolder";
        menuAddFolder.Size = new Size(233, 22);
        menuAddFolder.Text = "Add Library Folder...";
        menuAddFolder.Click += AddFolder_Click;
        // 
        // menuOpenDump
        // 
        menuOpenDump.Name = "menuOpenDump";
        menuOpenDump.Size = new Size(233, 22);
        menuOpenDump.Text = "Open Dump Folder...";
        menuOpenDump.Click += OpenDump_Click;
        // 
        // menuOpenPackage
        // 
        menuOpenPackage.Name = "menuOpenPackage";
        menuOpenPackage.Size = new Size(233, 22);
        menuOpenPackage.Text = "Open PS5 Container / Image...";
        menuOpenPackage.Click += OpenPackage_Click;
        // 
        // menuRecent
        // 
        menuRecent.Name = "menuRecent";
        menuRecent.Size = new Size(233, 22);
        menuRecent.Text = "Open Recent";
        // 
        // menuRefresh
        // 
        menuRefresh.Name = "menuRefresh";
        menuRefresh.Size = new Size(233, 22);
        menuRefresh.Text = "Refresh Library";
        menuRefresh.Click += Refresh_Click;
        // 
        // menuSaveManifest
        // 
        menuSaveManifest.Name = "menuSaveManifest";
        menuSaveManifest.Size = new Size(233, 22);
        menuSaveManifest.Text = "Save Manifest";
        menuSaveManifest.Click += menuSaveManifest_Click;
        // 
        // menuEmptyList
        // 
        menuEmptyList.Name = "menuEmptyList";
        menuEmptyList.Size = new Size(233, 22);
        menuEmptyList.Text = "Empty List";
        menuEmptyList.Click += menuEmptyList_Click;
        // 
        // menuRemoveMissing
        // 
        menuRemoveMissing.Name = "menuRemoveMissing";
        menuRemoveMissing.Size = new Size(233, 22);
        menuRemoveMissing.Text = "Remove Missing Items";
        menuRemoveMissing.Click += menuRemoveMissing_Click;
        // 
        // menuSeparator
        // 
        menuSeparator.Name = "menuSeparator";
        menuSeparator.Size = new Size(230, 6);
        // 
        // menuSettings
        // 
        menuSettings.Name = "menuSettings";
        menuSettings.Size = new Size(233, 22);
        menuSettings.Text = "Settings...";
        menuSettings.Click += Settings_Click;
        // 
        // menuExit
        // 
        menuExit.Name = "menuExit";
        menuExit.Size = new Size(233, 22);
        menuExit.Text = "Exit";
        menuExit.Click += Exit_Click;
        // 
        // menuHelp
        // 
        menuHelp.BackColor = SystemColors.Control;
        menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuAbout, menuHelpSeparator, menuHelpCheckUpdate, menuHelpKofi, menuHelpPayPal });
        menuHelp.ForeColor = SystemColors.ControlText;
        menuHelp.Name = "menuHelp";
        menuHelp.Size = new Size(44, 20);
        menuHelp.Text = "Help";
        // 
        // menuAbout
        // 
        menuAbout.Name = "menuAbout";
        menuAbout.Size = new Size(180, 22);
        menuAbout.Text = "About";
        menuAbout.Click += About_Click;
        // 
        // menuHelpSeparator
        // 
        menuHelpSeparator.Name = "menuHelpSeparator";
        menuHelpSeparator.Size = new Size(177, 6);
        // 
        // menuHelpCheckUpdate
        // 
        menuHelpCheckUpdate.Name = "menuHelpCheckUpdate";
        menuHelpCheckUpdate.Size = new Size(180, 22);
        menuHelpCheckUpdate.Text = "Check for Updates...";
        menuHelpCheckUpdate.Click += menuHelpCheckUpdate_Click;
        // 
        // menuHelpKofi
        // 
        menuHelpKofi.Name = "menuHelpKofi";
        menuHelpKofi.Size = new Size(180, 22);
        menuHelpKofi.Text = "Buy me a Ko-fi";
        menuHelpKofi.Click += menuHelpKofi_Click;
        // 
        // menuHelpPayPal
        // 
        menuHelpPayPal.Name = "menuHelpPayPal";
        menuHelpPayPal.Size = new Size(180, 22);
        menuHelpPayPal.Text = "Support via PayPal";
        menuHelpPayPal.Click += menuHelpPayPal_Click;
        // 
        // contextLibrary
        // 
        contextLibrary.Items.AddRange(new ToolStripItem[] { menuLibraryReveal, menuLibrarySeparator1, menuLibraryCopy, menuLibraryRename, menuLibraryRenameAll, menuLibraryRenameByPriority, menuLibraryMove, menuLibraryDelete, menuLibrarySeparator2, menuLibrarySaveArtwork, menuLibraryExport, menuLibrarySeparator3, menuLibraryGroupBy, menuLibraryDuplicates, menuLibrarySeparator5, menuLibraryGroupExport, menuLibraryGroupArtwork });
        contextLibrary.Name = "contextLibrary";
        contextLibrary.Size = new Size(261, 318);
        contextLibrary.Opening += contextLibrary_Opening;
        // 
        // menuLibraryReveal
        // 
        menuLibraryReveal.BackColor = SystemColors.Control;
        menuLibraryReveal.ForeColor = SystemColors.ControlText;
        menuLibraryReveal.Name = "menuLibraryReveal";
        menuLibraryReveal.Size = new Size(260, 22);
        menuLibraryReveal.Text = "Reveal in Explorer";
        menuLibraryReveal.Click += menuLibraryReveal_Click;
        // 
        // menuLibrarySeparator1
        // 
        menuLibrarySeparator1.BackColor = SystemColors.Control;
        menuLibrarySeparator1.ForeColor = SystemColors.ControlText;
        menuLibrarySeparator1.Margin = new Padding(0, 0, 0, 1);
        menuLibrarySeparator1.Name = "menuLibrarySeparator1";
        menuLibrarySeparator1.Size = new Size(257, 6);
        // 
        // menuLibraryCopy
        // 
        menuLibraryCopy.BackColor = SystemColors.Control;
        menuLibraryCopy.DropDownItems.AddRange(new ToolStripItem[] { menuLibraryCopyTitle, menuLibraryCopyTitleId, menuLibraryCopyContentId, menuLibraryCopyFileName, menuLibraryCopyPath });
        menuLibraryCopy.ForeColor = SystemColors.ControlText;
        menuLibraryCopy.Name = "menuLibraryCopy";
        menuLibraryCopy.Size = new Size(260, 22);
        menuLibraryCopy.Text = "Copy";
        // 
        // menuLibraryCopyTitle
        // 
        menuLibraryCopyTitle.BackColor = SystemColors.Control;
        menuLibraryCopyTitle.ForeColor = SystemColors.ControlText;
        menuLibraryCopyTitle.Name = "menuLibraryCopyTitle";
        menuLibraryCopyTitle.Size = new Size(162, 22);
        menuLibraryCopyTitle.Text = "Copy Title";
        menuLibraryCopyTitle.Click += menuLibraryCopyTitle_Click;
        // 
        // menuLibraryCopyTitleId
        // 
        menuLibraryCopyTitleId.BackColor = SystemColors.Control;
        menuLibraryCopyTitleId.ForeColor = SystemColors.ControlText;
        menuLibraryCopyTitleId.Name = "menuLibraryCopyTitleId";
        menuLibraryCopyTitleId.Size = new Size(162, 22);
        menuLibraryCopyTitleId.Text = "Copy Title ID";
        menuLibraryCopyTitleId.Click += menuLibraryCopyTitleId_Click;
        // 
        // menuLibraryCopyContentId
        // 
        menuLibraryCopyContentId.BackColor = SystemColors.Control;
        menuLibraryCopyContentId.ForeColor = SystemColors.ControlText;
        menuLibraryCopyContentId.Name = "menuLibraryCopyContentId";
        menuLibraryCopyContentId.Size = new Size(162, 22);
        menuLibraryCopyContentId.Text = "Copy Content ID";
        menuLibraryCopyContentId.Click += menuLibraryCopyContentId_Click;
        // 
        // menuLibraryCopyFileName
        // 
        menuLibraryCopyFileName.BackColor = SystemColors.Control;
        menuLibraryCopyFileName.ForeColor = SystemColors.ControlText;
        menuLibraryCopyFileName.Name = "menuLibraryCopyFileName";
        menuLibraryCopyFileName.Size = new Size(162, 22);
        menuLibraryCopyFileName.Text = "Copy File Name";
        menuLibraryCopyFileName.Click += menuLibraryCopyFileName_Click;
        // 
        // menuLibraryCopyPath
        // 
        menuLibraryCopyPath.BackColor = SystemColors.Control;
        menuLibraryCopyPath.ForeColor = SystemColors.ControlText;
        menuLibraryCopyPath.Name = "menuLibraryCopyPath";
        menuLibraryCopyPath.Size = new Size(162, 22);
        menuLibraryCopyPath.Text = "Copy Path";
        menuLibraryCopyPath.Click += menuLibraryCopyPath_Click;
        // 
        // menuLibraryRename
        // 
        menuLibraryRename.BackColor = SystemColors.Control;
        menuLibraryRename.ForeColor = SystemColors.ControlText;
        menuLibraryRename.Name = "menuLibraryRename";
        menuLibraryRename.Size = new Size(260, 22);
        menuLibraryRename.Text = "Rename";
        // 
        // menuLibraryRenameAll
        // 
        menuLibraryRenameAll.BackColor = SystemColors.Control;
        menuLibraryRenameAll.ForeColor = SystemColors.ControlText;
        menuLibraryRenameAll.Name = "menuLibraryRenameAll";
        menuLibraryRenameAll.Size = new Size(260, 22);
        menuLibraryRenameAll.Text = "Rename All";
        // 
        // menuLibraryRenameByPriority
        // 
        menuLibraryRenameByPriority.BackColor = SystemColors.Control;
        menuLibraryRenameByPriority.ForeColor = SystemColors.ControlText;
        menuLibraryRenameByPriority.Name = "menuLibraryRenameByPriority";
        menuLibraryRenameByPriority.Size = new Size(260, 22);
        menuLibraryRenameByPriority.Text = "Rename by Install Order (packages)";
        menuLibraryRenameByPriority.Click += menuLibraryRenameByPriority_Click;
        // 
        // menuLibraryMove
        // 
        menuLibraryMove.BackColor = SystemColors.Control;
        menuLibraryMove.DropDownItems.AddRange(new ToolStripItem[] { menuLibraryMoveTitle, menuLibraryMoveTitleId, menuLibraryMoveCategory, menuLibraryMoveRegion, menuLibraryMoveSource, menuLibraryMoveSeparator, menuLibraryMoveSingle });
        menuLibraryMove.ForeColor = SystemColors.ControlText;
        menuLibraryMove.Name = "menuLibraryMove";
        menuLibraryMove.Size = new Size(260, 22);
        menuLibraryMove.Text = "Move to Folder";
        // 
        // menuLibraryMoveTitle
        // 
        menuLibraryMoveTitle.Name = "menuLibraryMoveTitle";
        menuLibraryMoveTitle.Size = new Size(195, 22);
        menuLibraryMoveTitle.Text = "By Title";
        menuLibraryMoveTitle.Click += menuLibraryMoveTitle_Click;
        // 
        // menuLibraryMoveTitleId
        // 
        menuLibraryMoveTitleId.Name = "menuLibraryMoveTitleId";
        menuLibraryMoveTitleId.Size = new Size(195, 22);
        menuLibraryMoveTitleId.Text = "By Title ID";
        menuLibraryMoveTitleId.Click += menuLibraryMoveTitleId_Click;
        // 
        // menuLibraryMoveCategory
        // 
        menuLibraryMoveCategory.Name = "menuLibraryMoveCategory";
        menuLibraryMoveCategory.Size = new Size(195, 22);
        menuLibraryMoveCategory.Text = "By Category";
        menuLibraryMoveCategory.Click += menuLibraryMoveCategory_Click;
        // 
        // menuLibraryMoveRegion
        // 
        menuLibraryMoveRegion.Name = "menuLibraryMoveRegion";
        menuLibraryMoveRegion.Size = new Size(195, 22);
        menuLibraryMoveRegion.Text = "By Region";
        menuLibraryMoveRegion.Click += menuLibraryMoveRegion_Click;
        // 
        // menuLibraryMoveSource
        // 
        menuLibraryMoveSource.Name = "menuLibraryMoveSource";
        menuLibraryMoveSource.Size = new Size(195, 22);
        menuLibraryMoveSource.Text = "By Source";
        menuLibraryMoveSource.Click += menuLibraryMoveSource_Click;
        // 
        // menuLibraryMoveSeparator
        // 
        menuLibraryMoveSeparator.Name = "menuLibraryMoveSeparator";
        menuLibraryMoveSeparator.Size = new Size(192, 6);
        // 
        // menuLibraryMoveSingle
        // 
        menuLibraryMoveSingle.Name = "menuLibraryMoveSingle";
        menuLibraryMoveSingle.Size = new Size(195, 22);
        menuLibraryMoveSingle.Text = "All into the Destination";
        menuLibraryMoveSingle.Click += menuLibraryMoveSingle_Click;
        // 
        // menuLibraryDelete
        // 
        menuLibraryDelete.BackColor = SystemColors.Control;
        menuLibraryDelete.ForeColor = SystemColors.ControlText;
        menuLibraryDelete.Name = "menuLibraryDelete";
        menuLibraryDelete.Size = new Size(260, 22);
        menuLibraryDelete.Text = "Delete Package... (Recycle Bin)";
        menuLibraryDelete.Click += menuLibraryDelete_Click;
        // 
        // menuLibrarySeparator2
        // 
        menuLibrarySeparator2.BackColor = SystemColors.Control;
        menuLibrarySeparator2.ForeColor = SystemColors.ControlText;
        menuLibrarySeparator2.Margin = new Padding(0, 0, 0, 1);
        menuLibrarySeparator2.Name = "menuLibrarySeparator2";
        menuLibrarySeparator2.Size = new Size(257, 6);
        // 
        // menuLibrarySaveArtwork
        // 
        menuLibrarySaveArtwork.BackColor = SystemColors.Control;
        menuLibrarySaveArtwork.ForeColor = SystemColors.ControlText;
        menuLibrarySaveArtwork.Name = "menuLibrarySaveArtwork";
        menuLibrarySaveArtwork.Size = new Size(260, 22);
        menuLibrarySaveArtwork.Text = "Save Artwork...";
        menuLibrarySaveArtwork.Click += menuLibrarySaveArtwork_Click;
        // 
        // menuLibraryExport
        // 
        menuLibraryExport.BackColor = SystemColors.Control;
        menuLibraryExport.ForeColor = SystemColors.ControlText;
        menuLibraryExport.Name = "menuLibraryExport";
        menuLibraryExport.Size = new Size(260, 22);
        menuLibraryExport.Text = "Export library (CSV)...";
        menuLibraryExport.Click += menuLibraryExport_Click;
        // 
        // menuLibrarySeparator3
        // 
        menuLibrarySeparator3.BackColor = SystemColors.Control;
        menuLibrarySeparator3.ForeColor = SystemColors.ControlText;
        menuLibrarySeparator3.Margin = new Padding(0, 0, 0, 1);
        menuLibrarySeparator3.Name = "menuLibrarySeparator3";
        menuLibrarySeparator3.Size = new Size(257, 6);
        // 
        // menuLibraryGroupBy
        // 
        menuLibraryGroupBy.BackColor = SystemColors.Control;
        menuLibraryGroupBy.DropDownItems.AddRange(new ToolStripItem[] { menuLibraryGroupNone, menuLibraryGroupFamily, menuLibraryGroupTitleId, menuLibraryGroupCategory, menuLibraryGroupRegion, menuLibraryGroupSource, menuLibraryGroupFirmware });
        menuLibraryGroupBy.ForeColor = SystemColors.ControlText;
        menuLibraryGroupBy.Name = "menuLibraryGroupBy";
        menuLibraryGroupBy.Size = new Size(260, 22);
        menuLibraryGroupBy.Text = "Group by";
        // 
        // menuLibraryGroupNone
        // 
        menuLibraryGroupNone.Name = "menuLibraryGroupNone";
        menuLibraryGroupNone.Size = new Size(236, 22);
        menuLibraryGroupNone.Text = "None";
        menuLibraryGroupNone.Click += menuLibraryGroupNone_Click;
        // 
        // menuLibraryGroupFamily
        // 
        menuLibraryGroupFamily.Name = "menuLibraryGroupFamily";
        menuLibraryGroupFamily.Size = new Size(236, 22);
        menuLibraryGroupFamily.Text = "Family (base + updates + DLC)";
        menuLibraryGroupFamily.Click += menuLibraryGroupFamily_Click;
        // 
        // menuLibraryGroupTitleId
        // 
        menuLibraryGroupTitleId.Name = "menuLibraryGroupTitleId";
        menuLibraryGroupTitleId.Size = new Size(236, 22);
        menuLibraryGroupTitleId.Text = "Title ID";
        menuLibraryGroupTitleId.Click += menuLibraryGroupTitleId_Click;
        // 
        // menuLibraryGroupCategory
        // 
        menuLibraryGroupCategory.Name = "menuLibraryGroupCategory";
        menuLibraryGroupCategory.Size = new Size(236, 22);
        menuLibraryGroupCategory.Text = "Category";
        menuLibraryGroupCategory.Click += menuLibraryGroupCategory_Click;
        // 
        // menuLibraryGroupRegion
        // 
        menuLibraryGroupRegion.Name = "menuLibraryGroupRegion";
        menuLibraryGroupRegion.Size = new Size(236, 22);
        menuLibraryGroupRegion.Text = "Region";
        menuLibraryGroupRegion.Click += menuLibraryGroupRegion_Click;
        // 
        // menuLibraryGroupSource
        // 
        menuLibraryGroupSource.Name = "menuLibraryGroupSource";
        menuLibraryGroupSource.Size = new Size(236, 22);
        menuLibraryGroupSource.Text = "Source format";
        menuLibraryGroupSource.Click += menuLibraryGroupSource_Click;
        // 
        // menuLibraryGroupFirmware
        // 
        menuLibraryGroupFirmware.Name = "menuLibraryGroupFirmware";
        menuLibraryGroupFirmware.Size = new Size(236, 22);
        menuLibraryGroupFirmware.Text = "Required firmware";
        menuLibraryGroupFirmware.Click += menuLibraryGroupFirmware_Click;
        // 
        // menuLibraryDuplicates
        // 
        menuLibraryDuplicates.BackColor = SystemColors.Control;
        menuLibraryDuplicates.ForeColor = SystemColors.ControlText;
        menuLibraryDuplicates.Name = "menuLibraryDuplicates";
        menuLibraryDuplicates.Size = new Size(260, 22);
        menuLibraryDuplicates.Text = "Find Duplicates";
        menuLibraryDuplicates.Click += menuLibraryDuplicates_Click;
        // 
        // menuLibrarySeparator5
        // 
        menuLibrarySeparator5.BackColor = SystemColors.Control;
        menuLibrarySeparator5.ForeColor = SystemColors.ControlText;
        menuLibrarySeparator5.Margin = new Padding(0, 0, 0, 1);
        menuLibrarySeparator5.Name = "menuLibrarySeparator5";
        menuLibrarySeparator5.Size = new Size(257, 6);
        // 
        // menuLibraryGroupExport
        // 
        menuLibraryGroupExport.BackColor = SystemColors.Control;
        menuLibraryGroupExport.ForeColor = SystemColors.ControlText;
        menuLibraryGroupExport.Name = "menuLibraryGroupExport";
        menuLibraryGroupExport.Size = new Size(260, 22);
        menuLibraryGroupExport.Text = "Export Group (CSV)...";
        menuLibraryGroupExport.Click += menuLibraryGroupExport_Click;
        // 
        // menuLibraryGroupArtwork
        // 
        menuLibraryGroupArtwork.BackColor = SystemColors.Control;
        menuLibraryGroupArtwork.ForeColor = SystemColors.ControlText;
        menuLibraryGroupArtwork.Name = "menuLibraryGroupArtwork";
        menuLibraryGroupArtwork.Size = new Size(260, 22);
        menuLibraryGroupArtwork.Text = "Save Group Artwork...";
        menuLibraryGroupArtwork.Click += menuLibraryGroupArtwork_Click;
        // 
        // searchLibrary
        // 
        searchLibrary.AccessibleDescription = "Search the PS5 library by title, ID, size and more.";
        searchLibrary.AccessibleName = "Library search";
        searchLibrary.Location = new Point(10, 8);
        searchLibrary.Name = "searchLibrary";
        searchLibrary.Placeholder = "Search: title:, id:, size:>50GB, -exclude";
        searchLibrary.Size = new Size(520, 28);
        searchLibrary.TabIndex = 0;
        searchLibrary.SearchTextChanged += searchLibrary_SearchTextChanged;
        // 
        // lblFilterCategory
        // 
        lblFilterCategory.Location = new Point(10, 47);
        lblFilterCategory.Name = "lblFilterCategory";
        lblFilterCategory.Size = new Size(58, 15);
        lblFilterCategory.TabIndex = 1;
        lblFilterCategory.Text = "Category";
        // 
        // cboFilterCategory
        // 
        cboFilterCategory.ItemHeight = 18;
        cboFilterCategory.Items.AddRange(new object[] { "Game", "Patch", "DLC", "App", "Unknown" });
        cboFilterCategory.Location = new Point(72, 42);
        cboFilterCategory.Name = "cboFilterCategory";
        cboFilterCategory.Size = new Size(140, 24);
        cboFilterCategory.TabIndex = 2;
        cboFilterCategory.CheckedItemsChanged += cboFilter_CheckedItemsChanged;
        // 
        // lblFilterRegion
        // 
        lblFilterRegion.Location = new Point(224, 47);
        lblFilterRegion.Name = "lblFilterRegion";
        lblFilterRegion.Size = new Size(44, 15);
        lblFilterRegion.TabIndex = 3;
        lblFilterRegion.Text = "Region";
        // 
        // cboFilterRegion
        // 
        cboFilterRegion.ItemHeight = 18;
        cboFilterRegion.Items.AddRange(new object[] { "Americas", "Europe", "Japan", "Korea", "Asia", "Hong Kong", "Other", "Unknown" });
        cboFilterRegion.Location = new Point(276, 42);
        cboFilterRegion.Name = "cboFilterRegion";
        cboFilterRegion.Size = new Size(150, 24);
        cboFilterRegion.TabIndex = 4;
        cboFilterRegion.CheckedItemsChanged += cboFilter_CheckedItemsChanged;
        // 
        // lblFilterFormat
        // 
        lblFilterFormat.Location = new Point(438, 47);
        lblFilterFormat.Name = "lblFilterFormat";
        lblFilterFormat.Size = new Size(48, 15);
        lblFilterFormat.TabIndex = 5;
        lblFilterFormat.Text = "Format";
        // 
        // cboFilterFormat
        // 
        cboFilterFormat.ItemHeight = 18;
        cboFilterFormat.Items.AddRange(new object[] { "Dump Files", "PKG", "FFPFSC", "exFAT", "FFPKG" });
        cboFilterFormat.Location = new Point(492, 42);
        cboFilterFormat.Name = "cboFilterFormat";
        cboFilterFormat.Size = new Size(160, 24);
        cboFilterFormat.TabIndex = 6;
        cboFilterFormat.CheckedItemsChanged += cboFilter_CheckedItemsChanged;
        // 
        // lblFilterGroup
        // 
        lblFilterGroup.Location = new Point(664, 47);
        lblFilterGroup.Name = "lblFilterGroup";
        lblFilterGroup.Size = new Size(42, 15);
        lblFilterGroup.TabIndex = 7;
        lblFilterGroup.Text = "Group";
        // 
        // cboFilterGroup
        // 
        cboFilterGroup.Items.AddRange(new object[] { "None", "Family", "Title ID", "Category", "Region", "Format", "Firmware" });
        cboFilterGroup.Location = new Point(712, 42);
        cboFilterGroup.Name = "cboFilterGroup";
        cboFilterGroup.Size = new Size(140, 24);
        cboFilterGroup.TabIndex = 8;
        cboFilterGroup.SelectedIndexChanged += cboFilterGroup_SelectedIndexChanged;
        // 
        // btnFilterClear
        // 
        btnFilterClear.AccessibleDescription = "Clear the search query and all checkbox filters.";
        btnFilterClear.AccessibleName = "Reset filters";
        btnFilterClear.Location = new Point(772, 8);
        btnFilterClear.Name = "btnFilterClear";
        btnFilterClear.Size = new Size(110, 28);
        btnFilterClear.TabIndex = 13;
        btnFilterClear.Text = "Clear all";
        btnFilterClear.Click += btnFilterClear_Click;
        // 
        // chipsFilter
        // 
        chipsFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        chipsFilter.Location = new Point(10, 78);
        chipsFilter.Name = "chipsFilter";
        chipsFilter.Padding = new Padding(2);
        chipsFilter.Size = new Size(1364, 30);
        chipsFilter.TabIndex = 15;
        // 
        // lblFilterPreset
        // 
        lblFilterPreset.Location = new Point(560, 14);
        lblFilterPreset.Name = "lblFilterPreset";
        lblFilterPreset.Size = new Size(46, 15);
        lblFilterPreset.TabIndex = 16;
        lblFilterPreset.Text = "Preset";
        // 
        // cboFilterPreset
        // 
        cboFilterPreset.Items.AddRange(new object[] { "Presets...", "All", "Games", "Patches", "DLC", "Dumps", "PKG", "FFPKG", "FFPFSC", "exFAT" });
        cboFilterPreset.Location = new Point(612, 8);
        cboFilterPreset.Name = "cboFilterPreset";
        cboFilterPreset.Size = new Size(150, 24);
        cboFilterPreset.TabIndex = 17;
        cboFilterPreset.SelectedIndexChanged += cboFilterPreset_SelectedIndexChanged;
        // 
        // lblFilterEmpty
        // 
        lblFilterEmpty.Dock = DockStyle.Fill;
        lblFilterEmpty.Location = new Point(0, 114);
        lblFilterEmpty.Name = "lblFilterEmpty";
        lblFilterEmpty.Size = new Size(1384, 297);
        lblFilterEmpty.TabIndex = 18;
        lblFilterEmpty.Text = "No games match the current filters.";
        lblFilterEmpty.TextAlign = ContentAlignment.MiddleCenter;
        lblFilterEmpty.Visible = false;
        // 
        // splitMain
        // 
        splitMain.AddPane(splitMainPane1);
        splitMain.AddPane(splitMainPane2);
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 24);
        splitMain.Name = "splitMain";
        splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
        splitMain.Size = new Size(1384, 827);
        splitMain.TabIndex = 2;
        // 
        // splitMainPane1
        // 
        splitMainPane1.Controls.Add(gridLibrary);
        splitMainPane1.Controls.Add(lblFilterEmpty);
        splitMainPane1.Controls.Add(searchLibrary);
        splitMainPane1.Controls.Add(lblFilterPreset);
        splitMainPane1.Controls.Add(cboFilterPreset);
        splitMainPane1.Controls.Add(lblFilterCategory);
        splitMainPane1.Controls.Add(cboFilterCategory);
        splitMainPane1.Controls.Add(lblFilterRegion);
        splitMainPane1.Controls.Add(cboFilterRegion);
        splitMainPane1.Controls.Add(lblFilterFormat);
        splitMainPane1.Controls.Add(cboFilterFormat);
        splitMainPane1.Controls.Add(lblFilterGroup);
        splitMainPane1.Controls.Add(cboFilterGroup);
        splitMainPane1.Controls.Add(btnFilterClear);
        splitMainPane1.Controls.Add(chipsFilter);
        splitMainPane1.Location = new Point(0, 0);
        splitMainPane1.Name = "splitMainPane1";
        splitMainPane1.Padding = new Padding(0, 114, 0, 0);
        splitMainPane1.Size = new Size(1384, 411);
        splitMainPane1.TabIndex = 0;
        // 
        // gridLibrary
        // 
        gridLibrary.AccessibleDescription = "The scanned PS5 library. Right-click for actions such as rename, move and export.";
        gridLibrary.AccessibleName = "PS5 library";
        gridLibrary.AllowUserToAddRows = false;
        gridLibrary.AllowUserToDeleteRows = false;
        gridLibrary.AllowUserToDragDropRows = false;
        gridLibrary.AllowUserToOrderColumns = true;
        gridLibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridLibrary.AutoSortGroups = true;
        gridLibrary.ContextMenuStrip = contextLibrary;
        gridLibrary.Dock = DockStyle.Fill;
        gridLibrary.GroupCellValueComparer = null;
        gridLibrary.GroupHeaderColumnIndex = 0;
        gridLibrary.GroupHeaderColumnName = null;
        gridLibrary.GroupHeaderHeight = 26F;
        gridLibrary.GroupLabelFormatter = null;
        gridLibrary.Location = new Point(0, 114);
        gridLibrary.Name = "gridLibrary";
        gridLibrary.ReadOnly = true;
        gridLibrary.Size = new Size(1384, 297);
        gridLibrary.TabIndex = 0;
        gridLibrary.CellDoubleClick += gridLibrary_CellDoubleClick;
        gridLibrary.ColumnHeaderMouseClick += gridLibrary_ColumnHeaderMouseClick;
        gridLibrary.SelectionChanged += gridLibrary_SelectionChanged;
        gridLibrary.MouseDown += gridLibrary_MouseDown;
        // 
        // splitMainPane2
        // 
        splitMainPane2.Controls.Add(tabsWorkspace);
        splitMainPane2.Location = new Point(0, 416);
        splitMainPane2.Name = "splitMainPane2";
        splitMainPane2.Size = new Size(1384, 411);
        splitMainPane2.TabIndex = 1;
        // 
        // tabsWorkspace
        // 
        tabsWorkspace.AccessibleDescription = "Switch between overview, files, tasks, log and other detail panes.";
        tabsWorkspace.AccessibleName = "Details workspace";
        tabsWorkspace.AllowDrop = true;
        tabsWorkspace.Controls.Add(tabWorkspaceGeneral);
        tabsWorkspace.Controls.Add(tabWorkspaceTools);
        tabsWorkspace.Controls.Add(tabTasks);
        tabsWorkspace.Controls.Add(tabLog);
        tabsWorkspace.Dock = DockStyle.Fill;
        tabsWorkspace.ItemSize = new Size(80, 28);
        tabsWorkspace.Location = new Point(0, 0);
        tabsWorkspace.Name = "tabsWorkspace";
        tabsWorkspace.Padding = new Point(0, 0);
        tabsWorkspace.SelectedIndex = 0;
        tabsWorkspace.Size = new Size(1384, 411);
        tabsWorkspace.TabIndex = 0;
        // 
        // tabWorkspaceGeneral
        // 
        tabWorkspaceGeneral.BackColor = SystemColors.Control;
        tabWorkspaceGeneral.Controls.Add(tabsDetails);
        tabWorkspaceGeneral.Location = new Point(4, 32);
        tabWorkspaceGeneral.Name = "tabWorkspaceGeneral";
        tabWorkspaceGeneral.Size = new Size(1376, 375);
        tabWorkspaceGeneral.TabIndex = 0;
        tabWorkspaceGeneral.Text = "General";
        // 
        // tabsDetails
        // 
        tabsDetails.AllowDrop = true;
        tabsDetails.Controls.Add(tabOverview);
        tabsDetails.Controls.Add(tabArtwork);
        tabsDetails.Controls.Add(tabTrophies);
        tabsDetails.Controls.Add(tabActivities);
        tabsDetails.Controls.Add(tabFiles);
        tabsDetails.Controls.Add(tabExecutable);
        tabsDetails.Controls.Add(tabRaw);
        tabsDetails.Controls.Add(tabPackage);
        tabsDetails.Dock = DockStyle.Fill;
        tabsDetails.ItemSize = new Size(125, 28);
        tabsDetails.Location = new Point(0, 0);
        tabsDetails.Name = "tabsDetails";
        tabsDetails.Padding = new Point(0, 0);
        tabsDetails.SelectedIndex = 0;
        tabsDetails.Size = new Size(1376, 375);
        tabsDetails.TabIndex = 0;
        tabsDetails.SelectedIndexChanged += tabsDetails_SelectedIndexChanged;
        // 
        // tabOverview
        // 
        tabOverview.BackColor = SystemColors.Control;
        tabOverview.Controls.Add(gridOverview);
        tabOverview.Controls.Add(btnOverviewCopySelected);
        tabOverview.Controls.Add(btnOverviewCopyAll);
        tabOverview.Location = new Point(4, 32);
        tabOverview.Name = "tabOverview";
        tabOverview.Padding = new Padding(0, 38, 0, 0);
        tabOverview.Size = new Size(1368, 339);
        tabOverview.TabIndex = 0;
        tabOverview.Text = "Overview";
        // 
        // gridOverview
        // 
        gridOverview.AllowUserToAddRows = false;
        gridOverview.AllowUserToDeleteRows = false;
        gridOverview.AllowUserToDragDropRows = false;
        gridOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridOverview.AutoSortGroups = true;
        gridOverview.Dock = DockStyle.Fill;
        gridOverview.GroupCellValueComparer = null;
        gridOverview.GroupHeaderColumnIndex = 0;
        gridOverview.GroupHeaderColumnName = null;
        gridOverview.GroupHeaderHeight = 26F;
        gridOverview.GroupLabelFormatter = null;
        gridOverview.Location = new Point(0, 38);
        gridOverview.MultiSelect = false;
        gridOverview.Name = "gridOverview";
        gridOverview.ReadOnly = true;
        gridOverview.Size = new Size(1368, 301);
        gridOverview.TabIndex = 0;
        gridOverview.SelectionChanged += gridOverview_SelectionChanged;
        // 
        // btnOverviewCopySelected
        // 
        btnOverviewCopySelected.Location = new Point(110, 6);
        btnOverviewCopySelected.Name = "btnOverviewCopySelected";
        btnOverviewCopySelected.Size = new Size(120, 26);
        btnOverviewCopySelected.TabIndex = 1;
        btnOverviewCopySelected.Text = "Copy Selected";
        btnOverviewCopySelected.Click += btnOverviewCopySelected_Click;
        // 
        // btnOverviewCopyAll
        // 
        btnOverviewCopyAll.Location = new Point(8, 6);
        btnOverviewCopyAll.Name = "btnOverviewCopyAll";
        btnOverviewCopyAll.Size = new Size(96, 26);
        btnOverviewCopyAll.TabIndex = 0;
        btnOverviewCopyAll.Text = "Copy All";
        btnOverviewCopyAll.Click += btnOverviewCopyAll_Click;
        // 
        // tabArtwork
        // 
        tabArtwork.BackColor = SystemColors.Control;
        tabArtwork.Controls.Add(splitArtwork);
        tabArtwork.Controls.Add(btnArtworkSaveAll);
        tabArtwork.Location = new Point(4, 32);
        tabArtwork.Name = "tabArtwork";
        tabArtwork.Padding = new Padding(0, 38, 0, 0);
        tabArtwork.Size = new Size(1368, 339);
        tabArtwork.TabIndex = 1;
        tabArtwork.Text = "Artwork";
        // 
        // splitArtwork
        // 
        splitArtwork.AddPane(splitArtworkPane1);
        splitArtwork.AddPane(splitArtworkPane2);
        splitArtwork.Dock = DockStyle.Fill;
        splitArtwork.Location = new Point(0, 38);
        splitArtwork.Name = "splitArtwork";
        splitArtwork.Size = new Size(1368, 301);
        splitArtwork.TabIndex = 0;
        // 
        // splitArtworkPane1
        // 
        splitArtworkPane1.Controls.Add(sectionIcon);
        splitArtworkPane1.Location = new Point(0, 0);
        splitArtworkPane1.Name = "splitArtworkPane1";
        splitArtworkPane1.Size = new Size(681, 301);
        splitArtworkPane1.TabIndex = 0;
        // 
        // sectionIcon
        // 
        sectionIcon.Controls.Add(pictureIcon);
        sectionIcon.Dock = DockStyle.Fill;
        sectionIcon.Location = new Point(0, 0);
        sectionIcon.Margin = new Padding(6);
        sectionIcon.Name = "sectionIcon";
        sectionIcon.SectionHeader = "Icon (512 �- 512)";
        sectionIcon.Size = new Size(681, 301);
        sectionIcon.TabIndex = 0;
        // 
        // pictureIcon
        // 
        pictureIcon.BackColor = SystemColors.Control;
        pictureIcon.ContextMenuStrip = contextArtwork;
        pictureIcon.Dock = DockStyle.Fill;
        pictureIcon.Location = new Point(1, 25);
        pictureIcon.Name = "pictureIcon";
        pictureIcon.Size = new Size(679, 275);
        pictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
        pictureIcon.TabIndex = 0;
        pictureIcon.TabStop = false;
        // 
        // contextArtwork
        // 
        contextArtwork.Items.AddRange(new ToolStripItem[] { menuArtworkSaveThis, menuArtworkSaveAll });
        contextArtwork.Name = "contextArtwork";
        contextArtwork.Size = new Size(170, 48);
        // 
        // menuArtworkSaveThis
        // 
        menuArtworkSaveThis.BackColor = SystemColors.Control;
        menuArtworkSaveThis.ForeColor = SystemColors.ControlText;
        menuArtworkSaveThis.Name = "menuArtworkSaveThis";
        menuArtworkSaveThis.Size = new Size(169, 22);
        menuArtworkSaveThis.Text = "Save This Image...";
        menuArtworkSaveThis.Click += menuArtworkSaveThis_Click;
        // 
        // menuArtworkSaveAll
        // 
        menuArtworkSaveAll.BackColor = SystemColors.Control;
        menuArtworkSaveAll.ForeColor = SystemColors.ControlText;
        menuArtworkSaveAll.Name = "menuArtworkSaveAll";
        menuArtworkSaveAll.Size = new Size(169, 22);
        menuArtworkSaveAll.Text = "Save All Artwork...";
        menuArtworkSaveAll.Click += btnArtworkSaveAll_Click;
        // 
        // splitArtworkPane2
        // 
        splitArtworkPane2.Controls.Add(sectionBackground);
        splitArtworkPane2.Location = new Point(686, 0);
        splitArtworkPane2.Name = "splitArtworkPane2";
        splitArtworkPane2.Size = new Size(682, 301);
        splitArtworkPane2.TabIndex = 1;
        // 
        // sectionBackground
        // 
        sectionBackground.Controls.Add(tabsBackgrounds);
        sectionBackground.Dock = DockStyle.Fill;
        sectionBackground.Location = new Point(0, 0);
        sectionBackground.Margin = new Padding(6);
        sectionBackground.Name = "sectionBackground";
        sectionBackground.SectionHeader = "Background Art (PIC0 / PIC1 / PIC2)";
        sectionBackground.Size = new Size(682, 301);
        sectionBackground.TabIndex = 0;
        // 
        // tabsBackgrounds
        // 
        tabsBackgrounds.AllowDrop = true;
        tabsBackgrounds.Controls.Add(tabPic0);
        tabsBackgrounds.Controls.Add(tabPic1);
        tabsBackgrounds.Controls.Add(tabPic2);
        tabsBackgrounds.Dock = DockStyle.Fill;
        tabsBackgrounds.ItemSize = new Size(80, 28);
        tabsBackgrounds.Location = new Point(1, 25);
        tabsBackgrounds.Name = "tabsBackgrounds";
        tabsBackgrounds.Padding = new Point(0, 0);
        tabsBackgrounds.SelectedIndex = 0;
        tabsBackgrounds.Size = new Size(680, 275);
        tabsBackgrounds.TabIndex = 0;
        // 
        // tabPic0
        // 
        tabPic0.BackColor = SystemColors.Control;
        tabPic0.Controls.Add(pictureBackground0);
        tabPic0.Location = new Point(4, 32);
        tabPic0.Name = "tabPic0";
        tabPic0.Size = new Size(672, 239);
        tabPic0.TabIndex = 0;
        tabPic0.Text = "PIC0";
        // 
        // pictureBackground0
        // 
        pictureBackground0.BackColor = SystemColors.Control;
        pictureBackground0.ContextMenuStrip = contextArtwork;
        pictureBackground0.Dock = DockStyle.Fill;
        pictureBackground0.Location = new Point(0, 0);
        pictureBackground0.Name = "pictureBackground0";
        pictureBackground0.Size = new Size(672, 239);
        pictureBackground0.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBackground0.TabIndex = 0;
        pictureBackground0.TabStop = false;
        // 
        // tabPic1
        // 
        tabPic1.BackColor = SystemColors.Control;
        tabPic1.Controls.Add(pictureBackground1);
        tabPic1.Location = new Point(4, 32);
        tabPic1.Name = "tabPic1";
        tabPic1.Size = new Size(672, 239);
        tabPic1.TabIndex = 1;
        tabPic1.Text = "PIC1";
        // 
        // pictureBackground1
        // 
        pictureBackground1.BackColor = SystemColors.Control;
        pictureBackground1.ContextMenuStrip = contextArtwork;
        pictureBackground1.Dock = DockStyle.Fill;
        pictureBackground1.Location = new Point(0, 0);
        pictureBackground1.Name = "pictureBackground1";
        pictureBackground1.Size = new Size(672, 239);
        pictureBackground1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBackground1.TabIndex = 0;
        pictureBackground1.TabStop = false;
        // 
        // tabPic2
        // 
        tabPic2.BackColor = SystemColors.Control;
        tabPic2.Controls.Add(pictureBackground2);
        tabPic2.Location = new Point(4, 32);
        tabPic2.Name = "tabPic2";
        tabPic2.Size = new Size(672, 239);
        tabPic2.TabIndex = 2;
        tabPic2.Text = "PIC2";
        // 
        // pictureBackground2
        // 
        pictureBackground2.BackColor = SystemColors.Control;
        pictureBackground2.ContextMenuStrip = contextArtwork;
        pictureBackground2.Dock = DockStyle.Fill;
        pictureBackground2.Location = new Point(0, 0);
        pictureBackground2.Name = "pictureBackground2";
        pictureBackground2.Size = new Size(672, 239);
        pictureBackground2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBackground2.TabIndex = 0;
        pictureBackground2.TabStop = false;
        // 
        // btnArtworkSaveAll
        // 
        btnArtworkSaveAll.Location = new Point(8, 6);
        btnArtworkSaveAll.Name = "btnArtworkSaveAll";
        btnArtworkSaveAll.Size = new Size(110, 26);
        btnArtworkSaveAll.TabIndex = 0;
        btnArtworkSaveAll.Text = "Save All...";
        btnArtworkSaveAll.Click += btnArtworkSaveAll_Click;
        // 
        // tabTrophies
        // 
        tabTrophies.BackColor = SystemColors.Control;
        tabTrophies.Controls.Add(gridTrophies);
        tabTrophies.Controls.Add(lblTrophySummary);
        tabTrophies.Controls.Add(searchTrophy);
        tabTrophies.Controls.Add(chkTrophyShowHidden);
        tabTrophies.Controls.Add(chkTrophyBronze);
        tabTrophies.Controls.Add(chkTrophySilver);
        tabTrophies.Controls.Add(chkTrophyGold);
        tabTrophies.Controls.Add(chkTrophyPlatinum);
        tabTrophies.Controls.Add(btnTrophyExportCsv);
        tabTrophies.Controls.Add(btnTrophySaveIcons);
        tabTrophies.Location = new Point(4, 32);
        tabTrophies.Name = "tabTrophies";
        tabTrophies.Padding = new Padding(0, 74, 0, 0);
        tabTrophies.Size = new Size(1368, 339);
        tabTrophies.TabIndex = 2;
        tabTrophies.Text = "Trophies";
        // 
        // gridTrophies
        // 
        gridTrophies.AllowUserToAddRows = false;
        gridTrophies.AllowUserToDeleteRows = false;
        gridTrophies.AllowUserToDragDropRows = false;
        gridTrophies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridTrophies.AutoSortGroups = true;
        gridTrophies.ContextMenuStrip = contextTrophies;
        gridTrophies.Dock = DockStyle.Fill;
        gridTrophies.GroupCellValueComparer = null;
        gridTrophies.GroupHeaderColumnIndex = 0;
        gridTrophies.GroupHeaderColumnName = null;
        gridTrophies.GroupHeaderHeight = 26F;
        gridTrophies.GroupLabelFormatter = null;
        gridTrophies.Location = new Point(0, 74);
        gridTrophies.Name = "gridTrophies";
        gridTrophies.ReadOnly = true;
        gridTrophies.RowTemplate.Height = 48;
        gridTrophies.Size = new Size(1368, 265);
        gridTrophies.TabIndex = 0;
        // 
        // contextTrophies
        // 
        contextTrophies.Items.AddRange(new ToolStripItem[] { menuTrophySaveIcon, menuTrophySaveAllIcons, menuTrophyExportCsv });
        contextTrophies.Name = "contextTrophies";
        contextTrophies.Size = new Size(156, 70);
        // 
        // menuTrophySaveIcon
        // 
        menuTrophySaveIcon.BackColor = SystemColors.Control;
        menuTrophySaveIcon.ForeColor = SystemColors.ControlText;
        menuTrophySaveIcon.Name = "menuTrophySaveIcon";
        menuTrophySaveIcon.Size = new Size(155, 22);
        menuTrophySaveIcon.Text = "Save Icon...";
        menuTrophySaveIcon.Click += menuTrophySaveIcon_Click;
        // 
        // menuTrophySaveAllIcons
        // 
        menuTrophySaveAllIcons.BackColor = SystemColors.Control;
        menuTrophySaveAllIcons.ForeColor = SystemColors.ControlText;
        menuTrophySaveAllIcons.Name = "menuTrophySaveAllIcons";
        menuTrophySaveAllIcons.Size = new Size(155, 22);
        menuTrophySaveAllIcons.Text = "Save All Icons...";
        menuTrophySaveAllIcons.Click += btnTrophySaveIcons_Click;
        // 
        // menuTrophyExportCsv
        // 
        menuTrophyExportCsv.BackColor = SystemColors.Control;
        menuTrophyExportCsv.ForeColor = SystemColors.ControlText;
        menuTrophyExportCsv.Name = "menuTrophyExportCsv";
        menuTrophyExportCsv.Size = new Size(155, 22);
        menuTrophyExportCsv.Text = "Export CSV...";
        menuTrophyExportCsv.Click += btnTrophyExportCsv_Click;
        // 
        // lblTrophySummary
        // 
        lblTrophySummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTrophySummary.AutoEllipsis = true;
        lblTrophySummary.Location = new Point(0, 0);
        lblTrophySummary.Name = "lblTrophySummary";
        lblTrophySummary.Padding = new Padding(10, 0, 10, 0);
        lblTrophySummary.Size = new Size(1368, 36);
        lblTrophySummary.TabIndex = 0;
        lblTrophySummary.Text = "Select a game to load trophies.";
        lblTrophySummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // searchTrophy
        // 
        searchTrophy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        searchTrophy.Location = new Point(1070, 41);
        searchTrophy.Name = "searchTrophy";
        searchTrophy.Placeholder = "Search trophies";
        searchTrophy.Size = new Size(290, 28);
        searchTrophy.TabIndex = 7;
        searchTrophy.SearchTextChanged += trophyFilter_Changed;
        // 
        // chkTrophyShowHidden
        // 
        chkTrophyShowHidden.AutoSize = true;
        chkTrophyShowHidden.Checked = true;
        chkTrophyShowHidden.CheckState = CheckState.Checked;
        chkTrophyShowHidden.Location = new Point(509, 47);
        chkTrophyShowHidden.Name = "chkTrophyShowHidden";
        chkTrophyShowHidden.Size = new Size(95, 19);
        chkTrophyShowHidden.TabIndex = 6;
        chkTrophyShowHidden.Text = "Show hidden";
        chkTrophyShowHidden.CheckedChanged += trophyFilter_Changed;
        // 
        // chkTrophyBronze
        // 
        chkTrophyBronze.AutoSize = true;
        chkTrophyBronze.Location = new Point(441, 47);
        chkTrophyBronze.Name = "chkTrophyBronze";
        chkTrophyBronze.Size = new Size(62, 19);
        chkTrophyBronze.TabIndex = 5;
        chkTrophyBronze.Text = "Bronze";
        chkTrophyBronze.CheckedChanged += trophyFilter_Changed;
        // 
        // chkTrophySilver
        // 
        chkTrophySilver.AutoSize = true;
        chkTrophySilver.Location = new Point(381, 47);
        chkTrophySilver.Name = "chkTrophySilver";
        chkTrophySilver.Size = new Size(54, 19);
        chkTrophySilver.TabIndex = 4;
        chkTrophySilver.Text = "Silver";
        chkTrophySilver.CheckedChanged += trophyFilter_Changed;
        // 
        // chkTrophyGold
        // 
        chkTrophyGold.AutoSize = true;
        chkTrophyGold.Location = new Point(324, 47);
        chkTrophyGold.Name = "chkTrophyGold";
        chkTrophyGold.Size = new Size(51, 19);
        chkTrophyGold.TabIndex = 3;
        chkTrophyGold.Text = "Gold";
        chkTrophyGold.CheckedChanged += trophyFilter_Changed;
        // 
        // chkTrophyPlatinum
        // 
        chkTrophyPlatinum.AutoSize = true;
        chkTrophyPlatinum.Location = new Point(244, 47);
        chkTrophyPlatinum.Name = "chkTrophyPlatinum";
        chkTrophyPlatinum.Size = new Size(74, 19);
        chkTrophyPlatinum.TabIndex = 2;
        chkTrophyPlatinum.Text = "Platinum";
        chkTrophyPlatinum.CheckedChanged += trophyFilter_Changed;
        // 
        // btnTrophyExportCsv
        // 
        btnTrophyExportCsv.Location = new Point(118, 42);
        btnTrophyExportCsv.Name = "btnTrophyExportCsv";
        btnTrophyExportCsv.Size = new Size(110, 26);
        btnTrophyExportCsv.TabIndex = 1;
        btnTrophyExportCsv.Text = "Export CSV...";
        btnTrophyExportCsv.Click += btnTrophyExportCsv_Click;
        // 
        // btnTrophySaveIcons
        // 
        btnTrophySaveIcons.Location = new Point(8, 42);
        btnTrophySaveIcons.Name = "btnTrophySaveIcons";
        btnTrophySaveIcons.Size = new Size(104, 26);
        btnTrophySaveIcons.TabIndex = 0;
        btnTrophySaveIcons.Text = "Save Icons...";
        btnTrophySaveIcons.Click += btnTrophySaveIcons_Click;
        // 
        // tabActivities
        // 
        tabActivities.BackColor = SystemColors.Control;
        tabActivities.Controls.Add(tabsUds);
        tabActivities.Controls.Add(lblActivitiesSummary);
        tabActivities.Controls.Add(searchUds);
        tabActivities.Controls.Add(btnUdsCopySelected);
        tabActivities.Controls.Add(btnUdsCopyAll);
        tabActivities.Location = new Point(4, 32);
        tabActivities.Name = "tabActivities";
        tabActivities.Padding = new Padding(0, 74, 0, 0);
        tabActivities.Size = new Size(1368, 339);
        tabActivities.TabIndex = 3;
        tabActivities.Text = "Activities & UDS";
        // 
        // tabsUds
        // 
        tabsUds.AllowDrop = true;
        tabsUds.Controls.Add(tabUdsEvents);
        tabsUds.Controls.Add(tabUdsStats);
        tabsUds.Controls.Add(tabUdsEnums);
        tabsUds.Controls.Add(tabUdsRules);
        tabsUds.Dock = DockStyle.Fill;
        tabsUds.ItemSize = new Size(119, 28);
        tabsUds.Location = new Point(0, 74);
        tabsUds.Name = "tabsUds";
        tabsUds.Padding = new Point(0, 0);
        tabsUds.SelectedIndex = 0;
        tabsUds.Size = new Size(1368, 265);
        tabsUds.TabIndex = 0;
        tabsUds.SelectedIndexChanged += tabsUds_SelectedIndexChanged;
        // 
        // tabUdsEvents
        // 
        tabUdsEvents.BackColor = SystemColors.Control;
        tabUdsEvents.Controls.Add(splitUdsEvents);
        tabUdsEvents.Location = new Point(4, 32);
        tabUdsEvents.Name = "tabUdsEvents";
        tabUdsEvents.Size = new Size(1360, 229);
        tabUdsEvents.TabIndex = 0;
        tabUdsEvents.Text = "Events";
        // 
        // splitUdsEvents
        // 
        splitUdsEvents.BorderStyle = BorderStyle.FixedSingle;
        splitUdsEvents.AddPane(splitUdsEventsPane1);
        splitUdsEvents.AddPane(splitUdsEventsPane2);
        splitUdsEvents.Dock = DockStyle.Fill;
        splitUdsEvents.Location = new Point(0, 0);
        splitUdsEvents.Name = "splitUdsEvents";
        splitUdsEvents.Orientation = System.Windows.Forms.Orientation.Horizontal;
        splitUdsEvents.Size = new Size(1360, 229);
        splitUdsEvents.TabIndex = 0;
        // 
        // splitUdsEventsPane1
        // 
        splitUdsEventsPane1.Controls.Add(gridUdsEvents);
        splitUdsEventsPane1.Location = new Point(0, 0);
        splitUdsEventsPane1.Name = "splitUdsEventsPane1";
        splitUdsEventsPane1.Size = new Size(1358, 111);
        splitUdsEventsPane1.TabIndex = 0;
        // 
        // gridUdsEvents
        // 
        gridUdsEvents.AllowUserToAddRows = false;
        gridUdsEvents.AllowUserToDeleteRows = false;
        gridUdsEvents.AllowUserToDragDropRows = false;
        gridUdsEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridUdsEvents.AutoSortGroups = true;
        gridUdsEvents.Dock = DockStyle.Fill;
        gridUdsEvents.GroupCellValueComparer = null;
        gridUdsEvents.GroupHeaderColumnIndex = 0;
        gridUdsEvents.GroupHeaderColumnName = null;
        gridUdsEvents.GroupHeaderHeight = 26F;
        gridUdsEvents.GroupLabelFormatter = null;
        gridUdsEvents.Location = new Point(0, 0);
        gridUdsEvents.Name = "gridUdsEvents";
        gridUdsEvents.ReadOnly = true;
        gridUdsEvents.Size = new Size(1358, 111);
        gridUdsEvents.TabIndex = 0;
        gridUdsEvents.SelectionChanged += gridUdsEvents_SelectionChanged;
        // 
        // splitUdsEventsPane2
        // 
        splitUdsEventsPane2.Controls.Add(gridUdsEventProperties);
        splitUdsEventsPane2.Location = new Point(0, 116);
        splitUdsEventsPane2.Name = "splitUdsEventsPane2";
        splitUdsEventsPane2.Size = new Size(1358, 111);
        splitUdsEventsPane2.TabIndex = 1;
        // 
        // gridUdsEventProperties
        // 
        gridUdsEventProperties.AllowUserToAddRows = false;
        gridUdsEventProperties.AllowUserToDeleteRows = false;
        gridUdsEventProperties.AllowUserToDragDropRows = false;
        gridUdsEventProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridUdsEventProperties.AutoSortGroups = true;
        gridUdsEventProperties.Dock = DockStyle.Fill;
        gridUdsEventProperties.GroupCellValueComparer = null;
        gridUdsEventProperties.GroupHeaderColumnIndex = 0;
        gridUdsEventProperties.GroupHeaderColumnName = null;
        gridUdsEventProperties.GroupHeaderHeight = 26F;
        gridUdsEventProperties.GroupLabelFormatter = null;
        gridUdsEventProperties.Location = new Point(0, 0);
        gridUdsEventProperties.Name = "gridUdsEventProperties";
        gridUdsEventProperties.ReadOnly = true;
        gridUdsEventProperties.Size = new Size(1358, 111);
        gridUdsEventProperties.TabIndex = 0;
        // 
        // tabUdsStats
        // 
        tabUdsStats.BackColor = SystemColors.Control;
        tabUdsStats.Controls.Add(gridUdsStats);
        tabUdsStats.Location = new Point(4, 32);
        tabUdsStats.Name = "tabUdsStats";
        tabUdsStats.Size = new Size(1360, 229);
        tabUdsStats.TabIndex = 1;
        tabUdsStats.Text = "Stats";
        // 
        // gridUdsStats
        // 
        gridUdsStats.AllowUserToAddRows = false;
        gridUdsStats.AllowUserToDeleteRows = false;
        gridUdsStats.AllowUserToDragDropRows = false;
        gridUdsStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridUdsStats.AutoSortGroups = true;
        gridUdsStats.Dock = DockStyle.Fill;
        gridUdsStats.GroupCellValueComparer = null;
        gridUdsStats.GroupHeaderColumnIndex = 0;
        gridUdsStats.GroupHeaderColumnName = null;
        gridUdsStats.GroupHeaderHeight = 26F;
        gridUdsStats.GroupLabelFormatter = null;
        gridUdsStats.Location = new Point(0, 0);
        gridUdsStats.Name = "gridUdsStats";
        gridUdsStats.ReadOnly = true;
        gridUdsStats.Size = new Size(1360, 229);
        gridUdsStats.TabIndex = 0;
        // 
        // tabUdsEnums
        // 
        tabUdsEnums.BackColor = SystemColors.Control;
        tabUdsEnums.Controls.Add(gridUdsEnums);
        tabUdsEnums.Location = new Point(4, 32);
        tabUdsEnums.Name = "tabUdsEnums";
        tabUdsEnums.Size = new Size(1360, 229);
        tabUdsEnums.TabIndex = 2;
        tabUdsEnums.Text = "Enum groups";
        // 
        // gridUdsEnums
        // 
        gridUdsEnums.AllowUserToAddRows = false;
        gridUdsEnums.AllowUserToDeleteRows = false;
        gridUdsEnums.AllowUserToDragDropRows = false;
        gridUdsEnums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridUdsEnums.AutoSortGroups = true;
        gridUdsEnums.Dock = DockStyle.Fill;
        gridUdsEnums.GroupCellValueComparer = null;
        gridUdsEnums.GroupHeaderColumnIndex = 0;
        gridUdsEnums.GroupHeaderColumnName = null;
        gridUdsEnums.GroupHeaderHeight = 26F;
        gridUdsEnums.GroupLabelFormatter = null;
        gridUdsEnums.Location = new Point(0, 0);
        gridUdsEnums.Name = "gridUdsEnums";
        gridUdsEnums.ReadOnly = true;
        gridUdsEnums.Size = new Size(1360, 229);
        gridUdsEnums.TabIndex = 0;
        // 
        // tabUdsRules
        // 
        tabUdsRules.BackColor = SystemColors.Control;
        tabUdsRules.Controls.Add(gridUdsRules);
        tabUdsRules.Location = new Point(4, 32);
        tabUdsRules.Name = "tabUdsRules";
        tabUdsRules.Size = new Size(1360, 229);
        tabUdsRules.TabIndex = 3;
        tabUdsRules.Text = "Extraction rules";
        // 
        // gridUdsRules
        // 
        gridUdsRules.AllowUserToAddRows = false;
        gridUdsRules.AllowUserToDeleteRows = false;
        gridUdsRules.AllowUserToDragDropRows = false;
        gridUdsRules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridUdsRules.AutoSortGroups = true;
        gridUdsRules.Dock = DockStyle.Fill;
        gridUdsRules.GroupCellValueComparer = null;
        gridUdsRules.GroupHeaderColumnIndex = 0;
        gridUdsRules.GroupHeaderColumnName = null;
        gridUdsRules.GroupHeaderHeight = 26F;
        gridUdsRules.GroupLabelFormatter = null;
        gridUdsRules.Location = new Point(0, 0);
        gridUdsRules.Name = "gridUdsRules";
        gridUdsRules.ReadOnly = true;
        gridUdsRules.Size = new Size(1360, 229);
        gridUdsRules.TabIndex = 0;
        // 
        // lblActivitiesSummary
        // 
        lblActivitiesSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblActivitiesSummary.Location = new Point(0, 0);
        lblActivitiesSummary.Name = "lblActivitiesSummary";
        lblActivitiesSummary.Padding = new Padding(10, 0, 10, 0);
        lblActivitiesSummary.Size = new Size(1368, 36);
        lblActivitiesSummary.TabIndex = 0;
        lblActivitiesSummary.Text = "Select a game to load activity definitions.";
        lblActivitiesSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // searchUds
        // 
        searchUds.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        searchUds.Location = new Point(1068, 41);
        searchUds.Name = "searchUds";
        searchUds.Placeholder = "Search events, stats, enums, rules";
        searchUds.Size = new Size(292, 28);
        searchUds.TabIndex = 2;
        searchUds.SearchTextChanged += searchUds_SearchTextChanged;
        // 
        // btnUdsCopySelected
        // 
        btnUdsCopySelected.Location = new Point(110, 42);
        btnUdsCopySelected.Name = "btnUdsCopySelected";
        btnUdsCopySelected.Size = new Size(120, 26);
        btnUdsCopySelected.TabIndex = 1;
        btnUdsCopySelected.Text = "Copy Selected";
        btnUdsCopySelected.Click += btnUdsCopySelected_Click;
        // 
        // btnUdsCopyAll
        // 
        btnUdsCopyAll.Location = new Point(8, 42);
        btnUdsCopyAll.Name = "btnUdsCopyAll";
        btnUdsCopyAll.Size = new Size(96, 26);
        btnUdsCopyAll.TabIndex = 0;
        btnUdsCopyAll.Text = "Copy All";
        btnUdsCopyAll.Click += btnUdsCopyAll_Click;
        // 
        // tabFiles
        // 
        tabFiles.BackColor = SystemColors.Control;
        tabFiles.Controls.Add(sectionFileBrowser);
        tabFiles.Controls.Add(lblFilesSummary);
        tabFiles.Controls.Add(btnFileExtractAll);
        tabFiles.Controls.Add(btnFileCancel);
        tabFiles.Location = new Point(4, 32);
        tabFiles.Name = "tabFiles";
        tabFiles.Padding = new Padding(0, 36, 0, 0);
        tabFiles.Size = new Size(1368, 339);
        tabFiles.TabIndex = 4;
        tabFiles.Text = "Files";
        // 
        // sectionFileBrowser
        // 
        sectionFileBrowser.Controls.Add(splitFileBrowser);
        sectionFileBrowser.Dock = DockStyle.Fill;
        sectionFileBrowser.Location = new Point(0, 36);
        sectionFileBrowser.Margin = new Padding(6);
        sectionFileBrowser.Name = "sectionFileBrowser";
        sectionFileBrowser.SectionHeader = "Dump Files";
        sectionFileBrowser.Size = new Size(1368, 303);
        sectionFileBrowser.TabIndex = 0;
        // 
        // splitFileBrowser
        // 
        splitFileBrowser.BorderStyle = BorderStyle.FixedSingle;
        splitFileBrowser.AddPane(splitFileBrowserPane1);
        splitFileBrowser.AddPane(splitFileBrowserPane2);
        splitFileBrowser.Dock = DockStyle.Fill;
        splitFileBrowser.Location = new Point(1, 25);
        splitFileBrowser.Name = "splitFileBrowser";
        splitFileBrowser.Size = new Size(1366, 277);
        splitFileBrowser.TabIndex = 0;
        splitFileBrowser.SizeChanged += splitFileBrowser_SizeChanged;
        // 
        // splitFileBrowserPane1
        // 
        splitFileBrowserPane1.Controls.Add(treeFiles);
        splitFileBrowserPane1.Location = new Point(0, 0);
        splitFileBrowserPane1.Name = "splitFileBrowserPane1";
        splitFileBrowserPane1.Size = new Size(679, 275);
        splitFileBrowserPane1.TabIndex = 0;
        // 
        // treeFiles
        // 
        treeFiles.CheckBoxes = false;
        treeFiles.ContextMenuStrip = contextTreeFiles;
        treeFiles.Dock = DockStyle.Fill;
        treeFiles.FullRowSelect = false;
        treeFiles.HotTracking = false;
        treeFiles.ImageList = imageListFiles;
        treeFiles.Indent = 19;
        treeFiles.ItemHeight = 24;
        treeFiles.LabelEdit = false;
        treeFiles.Location = new Point(0, 0);
        treeFiles.Name = "treeFiles";
        treeFiles.PathSeparator = "\\";
        treeFiles.Scrollable = true;
        treeFiles.SelectedNode = null;
        treeFiles.ShowLines = true;
        treeFiles.ShowPlusMinus = true;
        treeFiles.ShowRootLines = true;
        treeFiles.Size = new Size(679, 275);
        treeFiles.Sorted = false;
        treeFiles.TabIndex = 0;
        treeFiles.TopNode = null;
        treeFiles.TreeViewNodeSorter = null;
        treeFiles.AfterSelect += treeFiles_AfterSelect;
        // 
        // contextTreeFiles
        // 
        contextTreeFiles.Items.AddRange(new ToolStripItem[] { menuTreeExpand, menuTreeCollapse, menuTreeExpandAll, menuTreeCollapseAll, menuTreeSeparator, menuTreeCopyPath, menuTreeExtract });
        contextTreeFiles.Name = "contextTreeFiles";
        contextTreeFiles.Size = new Size(155, 143);
        // 
        // menuTreeExpand
        // 
        menuTreeExpand.BackColor = SystemColors.Control;
        menuTreeExpand.ForeColor = SystemColors.ControlText;
        menuTreeExpand.Name = "menuTreeExpand";
        menuTreeExpand.Size = new Size(154, 22);
        menuTreeExpand.Text = "Expand";
        menuTreeExpand.Click += menuTreeExpand_Click;
        // 
        // menuTreeCollapse
        // 
        menuTreeCollapse.BackColor = SystemColors.Control;
        menuTreeCollapse.ForeColor = SystemColors.ControlText;
        menuTreeCollapse.Name = "menuTreeCollapse";
        menuTreeCollapse.Size = new Size(154, 22);
        menuTreeCollapse.Text = "Collapse";
        menuTreeCollapse.Click += menuTreeCollapse_Click;
        // 
        // menuTreeExpandAll
        // 
        menuTreeExpandAll.BackColor = SystemColors.Control;
        menuTreeExpandAll.ForeColor = SystemColors.ControlText;
        menuTreeExpandAll.Name = "menuTreeExpandAll";
        menuTreeExpandAll.Size = new Size(154, 22);
        menuTreeExpandAll.Text = "Expand All";
        menuTreeExpandAll.Click += menuTreeExpandAll_Click;
        // 
        // menuTreeCollapseAll
        // 
        menuTreeCollapseAll.BackColor = SystemColors.Control;
        menuTreeCollapseAll.ForeColor = SystemColors.ControlText;
        menuTreeCollapseAll.Name = "menuTreeCollapseAll";
        menuTreeCollapseAll.Size = new Size(154, 22);
        menuTreeCollapseAll.Text = "Collapse All";
        menuTreeCollapseAll.Click += menuTreeCollapseAll_Click;
        // 
        // menuTreeSeparator
        // 
        menuTreeSeparator.BackColor = SystemColors.Control;
        menuTreeSeparator.ForeColor = SystemColors.ControlText;
        menuTreeSeparator.Margin = new Padding(0, 0, 0, 1);
        menuTreeSeparator.Name = "menuTreeSeparator";
        menuTreeSeparator.Size = new Size(151, 6);
        // 
        // menuTreeCopyPath
        // 
        menuTreeCopyPath.BackColor = SystemColors.Control;
        menuTreeCopyPath.ForeColor = SystemColors.ControlText;
        menuTreeCopyPath.Name = "menuTreeCopyPath";
        menuTreeCopyPath.Size = new Size(154, 22);
        menuTreeCopyPath.Text = "Copy Path";
        menuTreeCopyPath.Click += menuTreeCopyPath_Click;
        // 
        // menuTreeExtract
        // 
        menuTreeExtract.BackColor = SystemColors.Control;
        menuTreeExtract.ForeColor = SystemColors.ControlText;
        menuTreeExtract.Name = "menuTreeExtract";
        menuTreeExtract.Size = new Size(154, 22);
        menuTreeExtract.Text = "Extract Folder...";
        menuTreeExtract.Click += menuTreeExtract_Click;
        // 
        // splitFileBrowserPane2
        // 
        splitFileBrowserPane2.Controls.Add(splitFileContentPreview);
        splitFileBrowserPane2.Location = new Point(684, 0);
        splitFileBrowserPane2.Name = "splitFileBrowserPane2";
        splitFileBrowserPane2.Size = new Size(680, 275);
        splitFileBrowserPane2.TabIndex = 1;
        // 
        // splitFileContentPreview
        // 
        splitFileContentPreview.BorderStyle = BorderStyle.FixedSingle;
        splitFileContentPreview.AddPane(splitFileContentPreviewPane1);
        splitFileContentPreview.AddPane(splitFileContentPreviewPane2);
        splitFileContentPreview.Dock = DockStyle.Fill;
        splitFileContentPreview.Location = new Point(0, 0);
        splitFileContentPreview.Name = "splitFileContentPreview";
        splitFileContentPreview.Size = new Size(680, 275);
        splitFileContentPreview.TabIndex = 1;
        // 
        // splitFileContentPreviewPane1
        // 
        splitFileContentPreviewPane1.Controls.Add(fileListPanel);
        splitFileContentPreviewPane1.Location = new Point(0, 0);
        splitFileContentPreviewPane1.Name = "splitFileContentPreviewPane1";
        splitFileContentPreviewPane1.Size = new Size(336, 273);
        splitFileContentPreviewPane1.TabIndex = 0;
        // 
        // fileListPanel
        // 
        fileListPanel.Controls.Add(searchFileFilter);
        fileListPanel.Controls.Add(listFiles);
        fileListPanel.Dock = DockStyle.Fill;
        fileListPanel.Location = new Point(0, 0);
        fileListPanel.Name = "fileListPanel";
        fileListPanel.Padding = new Padding(0, 36, 0, 0);
        fileListPanel.Size = new Size(336, 273);
        fileListPanel.TabIndex = 0;
        // 
        // searchFileFilter
        // 
        searchFileFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        searchFileFilter.Location = new Point(4, 4);
        searchFileFilter.Name = "searchFileFilter";
        searchFileFilter.Placeholder = "Search files (all folders)";
        searchFileFilter.Size = new Size(328, 28);
        searchFileFilter.TabIndex = 0;
        searchFileFilter.SearchTextChanged += searchFileFilter_SearchTextChanged;
        // 
        // listFiles
        // 
        listFiles.ContextMenuStrip = contextFiles;
        listFiles.Dock = DockStyle.Fill;
        listFiles.FullRowSelect = true;
        listFiles.HeaderStyle = ColumnHeaderStyle.Clickable;
        listFiles.LargeImageList = null;
        listFiles.ListViewItemSorter = null;
        listFiles.Location = new Point(0, 36);
        listFiles.MultiSelect = true;
        listFiles.Name = "listFiles";
        listFiles.Size = new Size(336, 237);
        listFiles.SmallImageList = imageListFiles;
        listFiles.TabIndex = 1;
        listFiles.UseCompatibleStateImageBehavior = false;
        listFiles.View = View.Details;
        listFiles.ItemActivate += listFiles_ItemActivate;
        listFiles.ColumnClick += listFiles_ColumnClick;
        listFiles.ItemDrag += listFiles_ItemDrag;
        listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
        listFiles.MouseDown += listFiles_MouseDown;
        // 
        // contextFiles
        // 
        contextFiles.Items.AddRange(new ToolStripItem[] { menuFileOpenContained, menuFileExtractContained, menuFileExtractSelected, menuFileCopySeparator, menuFileCopyPath, menuFileCopyName, menuFileContainerSeparator, menuFileRevealContainer });
        contextFiles.Name = "contextFiles";
        contextFiles.Size = new Size(239, 150);
        contextFiles.Opening += contextFiles_Opening;
        // 
        // menuFileOpenContained
        // 
        menuFileOpenContained.BackColor = SystemColors.Control;
        menuFileOpenContained.ForeColor = SystemColors.ControlText;
        menuFileOpenContained.Name = "menuFileOpenContained";
        menuFileOpenContained.Size = new Size(238, 22);
        menuFileOpenContained.Text = "Open / Preview";
        menuFileOpenContained.Click += menuFileOpenContained_Click;
        // 
        // menuFileExtractContained
        // 
        menuFileExtractContained.BackColor = SystemColors.Control;
        menuFileExtractContained.ForeColor = SystemColors.ControlText;
        menuFileExtractContained.Name = "menuFileExtractContained";
        menuFileExtractContained.Size = new Size(238, 22);
        menuFileExtractContained.Text = "Extract Selected File...";
        menuFileExtractContained.Click += menuFileExtractContained_Click;
        // 
        // menuFileExtractSelected
        // 
        menuFileExtractSelected.BackColor = SystemColors.Control;
        menuFileExtractSelected.ForeColor = SystemColors.ControlText;
        menuFileExtractSelected.Name = "menuFileExtractSelected";
        menuFileExtractSelected.Size = new Size(238, 22);
        menuFileExtractSelected.Text = "Extract Selected (with folders)...";
        menuFileExtractSelected.Click += menuFileExtractSelected_Click;
        // 
        // menuFileCopySeparator
        // 
        menuFileCopySeparator.BackColor = SystemColors.Control;
        menuFileCopySeparator.ForeColor = SystemColors.ControlText;
        menuFileCopySeparator.Margin = new Padding(0, 0, 0, 1);
        menuFileCopySeparator.Name = "menuFileCopySeparator";
        menuFileCopySeparator.Size = new Size(235, 6);
        // 
        // menuFileCopyPath
        // 
        menuFileCopyPath.BackColor = SystemColors.Control;
        menuFileCopyPath.ForeColor = SystemColors.ControlText;
        menuFileCopyPath.Name = "menuFileCopyPath";
        menuFileCopyPath.Size = new Size(238, 22);
        menuFileCopyPath.Text = "Copy Path";
        menuFileCopyPath.Click += menuFileCopyPath_Click;
        // 
        // menuFileCopyName
        // 
        menuFileCopyName.BackColor = SystemColors.Control;
        menuFileCopyName.ForeColor = SystemColors.ControlText;
        menuFileCopyName.Name = "menuFileCopyName";
        menuFileCopyName.Size = new Size(238, 22);
        menuFileCopyName.Text = "Copy Filename";
        menuFileCopyName.Click += menuFileCopyName_Click;
        // 
        // menuFileContainerSeparator
        // 
        menuFileContainerSeparator.BackColor = SystemColors.Control;
        menuFileContainerSeparator.ForeColor = SystemColors.ControlText;
        menuFileContainerSeparator.Margin = new Padding(0, 0, 0, 1);
        menuFileContainerSeparator.Name = "menuFileContainerSeparator";
        menuFileContainerSeparator.Size = new Size(235, 6);
        // 
        // menuFileRevealContainer
        // 
        menuFileRevealContainer.BackColor = SystemColors.Control;
        menuFileRevealContainer.ForeColor = SystemColors.ControlText;
        menuFileRevealContainer.Name = "menuFileRevealContainer";
        menuFileRevealContainer.Size = new Size(238, 22);
        menuFileRevealContainer.Text = "Reveal Container in Explorer";
        menuFileRevealContainer.Click += menuFileRevealContainer_Click;
        // 
        // splitFileContentPreviewPane2
        // 
        splitFileContentPreviewPane2.Controls.Add(sectionFileViewer);
        splitFileContentPreviewPane2.Location = new Point(341, 0);
        splitFileContentPreviewPane2.Name = "splitFileContentPreviewPane2";
        splitFileContentPreviewPane2.Size = new Size(337, 273);
        splitFileContentPreviewPane2.TabIndex = 1;
        // 
        // sectionFileViewer
        // 
        sectionFileViewer.Controls.Add(mediaFileHost);
        sectionFileViewer.Controls.Add(txtHexViewer);
        sectionFileViewer.Controls.Add(txtFileViewer);
        sectionFileViewer.Controls.Add(pictureFileViewer);
        sectionFileViewer.Controls.Add(lblFileViewerInfo);
        sectionFileViewer.Controls.Add(btnMediaLoad);
        sectionFileViewer.Controls.Add(btnMediaPlay);
        sectionFileViewer.Controls.Add(btnMediaPause);
        sectionFileViewer.Controls.Add(btnMediaStop);
        sectionFileViewer.Controls.Add(btnHexPrevious);
        sectionFileViewer.Controls.Add(btnHexNext);
        sectionFileViewer.Controls.Add(lblHexPage);
        sectionFileViewer.Dock = DockStyle.Fill;
        sectionFileViewer.Location = new Point(0, 0);
        sectionFileViewer.Margin = new Padding(6);
        sectionFileViewer.Name = "sectionFileViewer";
        sectionFileViewer.Padding = new Padding(0, 0, 0, 40);
        sectionFileViewer.SectionHeader = "File Viewer";
        sectionFileViewer.Size = new Size(337, 273);
        sectionFileViewer.TabIndex = 0;
        // 
        // mediaFileHost
        // 
        mediaFileHost.BackColor = Color.Black;
        mediaFileHost.Dock = DockStyle.Fill;
        mediaFileHost.Location = new Point(0, 0);
        mediaFileHost.Name = "mediaFileHost";
        mediaFileHost.TabIndex = 3;
        mediaFileHost.Visible = false;
        // 
        // txtHexViewer
        // 
        txtHexViewer.Dock = DockStyle.Fill;
        txtHexViewer.Font = new Font("Consolas", 9F);
        txtHexViewer.Location = new Point(1, 59);
        txtHexViewer.Name = "txtHexViewer";
        txtHexViewer.ReadOnly = true;
        txtHexViewer.SelectionColor = Color.Gainsboro;
        txtHexViewer.SelectionFont = new Font("Consolas", 9F);
        txtHexViewer.Size = new Size(335, 173);
        txtHexViewer.TabIndex = 2;
        txtHexViewer.TextPadding = new Padding(3);
        txtHexViewer.Visible = false;
        txtHexViewer.WordWrap = false;
        // 
        // txtFileViewer
        // 
        txtFileViewer.Dock = DockStyle.Fill;
        txtFileViewer.Font = new Font("Consolas", 9F);
        txtFileViewer.Location = new Point(1, 59);
        txtFileViewer.Name = "txtFileViewer";
        txtFileViewer.ReadOnly = true;
        txtFileViewer.SelectionColor = Color.Gainsboro;
        txtFileViewer.SelectionFont = new Font("Consolas", 9F);
        txtFileViewer.Size = new Size(335, 173);
        txtFileViewer.TabIndex = 1;
        txtFileViewer.TextPadding = new Padding(3);
        txtFileViewer.Visible = false;
        txtFileViewer.WordWrap = false;
        // 
        // pictureFileViewer
        // 
        pictureFileViewer.BackColor = Color.FromArgb(20, 20, 20);
        pictureFileViewer.Dock = DockStyle.Fill;
        pictureFileViewer.Location = new Point(1, 59);
        pictureFileViewer.Name = "pictureFileViewer";
        pictureFileViewer.Size = new Size(335, 173);
        pictureFileViewer.SizeMode = PictureBoxSizeMode.Zoom;
        pictureFileViewer.TabIndex = 0;
        pictureFileViewer.TabStop = false;
        pictureFileViewer.Visible = false;
        // 
        // lblFileViewerInfo
        // 
        lblFileViewerInfo.AutoEllipsis = true;
        lblFileViewerInfo.Dock = DockStyle.Top;
        lblFileViewerInfo.Location = new Point(1, 25);
        lblFileViewerInfo.Name = "lblFileViewerInfo";
        lblFileViewerInfo.Padding = new Padding(8, 0, 8, 0);
        lblFileViewerInfo.Size = new Size(335, 34);
        lblFileViewerInfo.TabIndex = 3;
        lblFileViewerInfo.Text = "Select a file to preview it.";
        lblFileViewerInfo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnMediaLoad
        // 
        btnMediaLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnMediaLoad.Location = new Point(7, 239);
        btnMediaLoad.Name = "btnMediaLoad";
        btnMediaLoad.Size = new Size(100, 27);
        btnMediaLoad.TabIndex = 0;
        btnMediaLoad.Text = "Load & Play";
        btnMediaLoad.Visible = false;
        btnMediaLoad.Click += btnMediaLoad_Click;
        // 
        // btnMediaPlay
        // 
        btnMediaPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnMediaPlay.Location = new Point(113, 239);
        btnMediaPlay.Name = "btnMediaPlay";
        btnMediaPlay.Size = new Size(62, 27);
        btnMediaPlay.TabIndex = 1;
        btnMediaPlay.Text = "Play";
        btnMediaPlay.Visible = false;
        btnMediaPlay.Click += btnMediaPlay_Click;
        // 
        // btnMediaPause
        // 
        btnMediaPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnMediaPause.Location = new Point(181, 239);
        btnMediaPause.Name = "btnMediaPause";
        btnMediaPause.Size = new Size(62, 27);
        btnMediaPause.TabIndex = 2;
        btnMediaPause.Text = "Pause";
        btnMediaPause.Visible = false;
        btnMediaPause.Click += btnMediaPause_Click;
        // 
        // btnMediaStop
        // 
        btnMediaStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnMediaStop.Location = new Point(249, 239);
        btnMediaStop.Name = "btnMediaStop";
        btnMediaStop.Size = new Size(62, 27);
        btnMediaStop.TabIndex = 3;
        btnMediaStop.Text = "Stop";
        btnMediaStop.Visible = false;
        btnMediaStop.Click += btnMediaStop_Click;
        // 
        // btnHexPrevious
        // 
        btnHexPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnHexPrevious.Location = new Point(7, 239);
        btnHexPrevious.Name = "btnHexPrevious";
        btnHexPrevious.Size = new Size(76, 27);
        btnHexPrevious.TabIndex = 4;
        btnHexPrevious.Text = "Previous";
        btnHexPrevious.Visible = false;
        btnHexPrevious.Click += btnHexPrevious_Click;
        // 
        // btnHexNext
        // 
        btnHexNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnHexNext.Location = new Point(89, 239);
        btnHexNext.Name = "btnHexNext";
        btnHexNext.Size = new Size(62, 27);
        btnHexNext.TabIndex = 5;
        btnHexNext.Text = "Next";
        btnHexNext.Visible = false;
        btnHexNext.Click += btnHexNext_Click;
        // 
        // lblHexPage
        // 
        lblHexPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblHexPage.AutoEllipsis = true;
        lblHexPage.Location = new Point(159, 239);
        lblHexPage.Name = "lblHexPage";
        lblHexPage.Size = new Size(435, 27);
        lblHexPage.TabIndex = 6;
        lblHexPage.TextAlign = ContentAlignment.MiddleLeft;
        lblHexPage.Visible = false;
        // 
        // lblFilesSummary
        // 
        lblFilesSummary.AutoEllipsis = true;
        lblFilesSummary.Location = new Point(0, 0);
        lblFilesSummary.Name = "lblFilesSummary";
        lblFilesSummary.Padding = new Padding(10, 0, 10, 0);
        lblFilesSummary.Size = new Size(1130, 36);
        lblFilesSummary.TabIndex = 0;
        lblFilesSummary.Text = "Select a game to inventory its files.";
        lblFilesSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnFileExtractAll
        // 
        btnFileExtractAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnFileExtractAll.Location = new Point(1150, 5);
        btnFileExtractAll.Name = "btnFileExtractAll";
        btnFileExtractAll.Size = new Size(120, 26);
        btnFileExtractAll.TabIndex = 0;
        btnFileExtractAll.Text = "Extract All...";
        btnFileExtractAll.Click += btnFileExtractAll_Click;
        // 
        // btnFileCancel
        // 
        btnFileCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnFileCancel.Location = new Point(1276, 5);
        btnFileCancel.Name = "btnFileCancel";
        btnFileCancel.Size = new Size(84, 26);
        btnFileCancel.TabIndex = 1;
        btnFileCancel.Text = "Cancel";
        btnFileCancel.Click += btnFileCancel_Click;
        // 
        // tabExecutable
        // 
        tabExecutable.BackColor = SystemColors.Control;
        tabExecutable.Controls.Add(tabsExecutable);
        tabExecutable.Controls.Add(lblExecutableSummary);
        tabExecutable.Controls.Add(searchExecutable);
        tabExecutable.Controls.Add(btnExecCopySelected);
        tabExecutable.Controls.Add(btnExecCopyAll);
        tabExecutable.Controls.Add(btnExecExtract);
        tabExecutable.Controls.Add(btnExecHash);
        tabExecutable.Location = new Point(4, 32);
        tabExecutable.Name = "tabExecutable";
        tabExecutable.Padding = new Padding(0, 90, 0, 0);
        tabExecutable.Size = new Size(1368, 339);
        tabExecutable.TabIndex = 5;
        tabExecutable.Text = "Executable";
        // 
        // tabsExecutable
        // 
        tabsExecutable.AllowDrop = true;
        tabsExecutable.Controls.Add(tabExecModules);
        tabsExecutable.Controls.Add(tabExecElf);
        tabsExecutable.Controls.Add(tabExecSelf);
        tabsExecutable.Dock = DockStyle.Fill;
        tabsExecutable.ItemSize = new Size(83, 28);
        tabsExecutable.Location = new Point(0, 90);
        tabsExecutable.Name = "tabsExecutable";
        tabsExecutable.Padding = new Point(0, 0);
        tabsExecutable.SelectedIndex = 0;
        tabsExecutable.Size = new Size(1368, 249);
        tabsExecutable.TabIndex = 0;
        tabsExecutable.SelectedIndexChanged += tabsExecutable_SelectedIndexChanged;
        // 
        // tabExecModules
        // 
        tabExecModules.BackColor = SystemColors.Control;
        tabExecModules.Controls.Add(gridModules);
        tabExecModules.Location = new Point(4, 32);
        tabExecModules.Name = "tabExecModules";
        tabExecModules.Size = new Size(1360, 213);
        tabExecModules.TabIndex = 0;
        tabExecModules.Text = "Modules";
        // 
        // gridModules
        // 
        gridModules.AllowUserToAddRows = false;
        gridModules.AllowUserToDeleteRows = false;
        gridModules.AllowUserToDragDropRows = false;
        gridModules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridModules.AutoSortGroups = true;
        gridModules.Dock = DockStyle.Fill;
        gridModules.GroupCellValueComparer = null;
        gridModules.GroupHeaderColumnIndex = 0;
        gridModules.GroupHeaderColumnName = null;
        gridModules.GroupHeaderHeight = 26F;
        gridModules.GroupLabelFormatter = null;
        gridModules.Location = new Point(0, 0);
        gridModules.Name = "gridModules";
        gridModules.ReadOnly = true;
        gridModules.Size = new Size(1360, 213);
        gridModules.TabIndex = 0;
        // 
        // tabExecElf
        // 
        tabExecElf.BackColor = SystemColors.Control;
        tabExecElf.Controls.Add(splitExecElf);
        tabExecElf.Location = new Point(4, 32);
        tabExecElf.Name = "tabExecElf";
        tabExecElf.Size = new Size(1360, 213);
        tabExecElf.TabIndex = 1;
        tabExecElf.Text = "ELF";
        // 
        // splitExecElf
        // 
        splitExecElf.BorderStyle = BorderStyle.FixedSingle;
        splitExecElf.AddPane(splitExecElfPane1);
        splitExecElf.AddPane(splitExecElfPane2);
        splitExecElf.Dock = DockStyle.Fill;
        splitExecElf.Location = new Point(0, 0);
        splitExecElf.Name = "splitExecElf";
        splitExecElf.Orientation = System.Windows.Forms.Orientation.Horizontal;
        splitExecElf.Size = new Size(1360, 213);
        splitExecElf.TabIndex = 0;
        // 
        // splitExecElfPane1
        // 
        splitExecElfPane1.Controls.Add(gridElfPrograms);
        splitExecElfPane1.Location = new Point(0, 0);
        splitExecElfPane1.Name = "splitExecElfPane1";
        splitExecElfPane1.Size = new Size(1358, 103);
        splitExecElfPane1.TabIndex = 0;
        // 
        // gridElfPrograms
        // 
        gridElfPrograms.AllowUserToAddRows = false;
        gridElfPrograms.AllowUserToDeleteRows = false;
        gridElfPrograms.AllowUserToDragDropRows = false;
        gridElfPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridElfPrograms.AutoSortGroups = true;
        gridElfPrograms.Dock = DockStyle.Fill;
        gridElfPrograms.GroupCellValueComparer = null;
        gridElfPrograms.GroupHeaderColumnIndex = 0;
        gridElfPrograms.GroupHeaderColumnName = null;
        gridElfPrograms.GroupHeaderHeight = 26F;
        gridElfPrograms.GroupLabelFormatter = null;
        gridElfPrograms.Location = new Point(0, 0);
        gridElfPrograms.Name = "gridElfPrograms";
        gridElfPrograms.ReadOnly = true;
        gridElfPrograms.Size = new Size(1358, 103);
        gridElfPrograms.TabIndex = 0;
        // 
        // splitExecElfPane2
        // 
        splitExecElfPane2.Controls.Add(gridElfSections);
        splitExecElfPane2.Location = new Point(0, 108);
        splitExecElfPane2.Name = "splitExecElfPane2";
        splitExecElfPane2.Size = new Size(1358, 103);
        splitExecElfPane2.TabIndex = 1;
        // 
        // gridElfSections
        // 
        gridElfSections.AllowUserToAddRows = false;
        gridElfSections.AllowUserToDeleteRows = false;
        gridElfSections.AllowUserToDragDropRows = false;
        gridElfSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridElfSections.AutoSortGroups = true;
        gridElfSections.Dock = DockStyle.Fill;
        gridElfSections.GroupCellValueComparer = null;
        gridElfSections.GroupHeaderColumnIndex = 0;
        gridElfSections.GroupHeaderColumnName = null;
        gridElfSections.GroupHeaderHeight = 26F;
        gridElfSections.GroupLabelFormatter = null;
        gridElfSections.Location = new Point(0, 0);
        gridElfSections.Name = "gridElfSections";
        gridElfSections.ReadOnly = true;
        gridElfSections.Size = new Size(1358, 103);
        gridElfSections.TabIndex = 0;
        // 
        // tabExecSelf
        // 
        tabExecSelf.BackColor = SystemColors.Control;
        tabExecSelf.Controls.Add(splitExecSelf);
        tabExecSelf.Location = new Point(4, 32);
        tabExecSelf.Name = "tabExecSelf";
        tabExecSelf.Size = new Size(1360, 213);
        tabExecSelf.TabIndex = 2;
        tabExecSelf.Text = "SELF";
        // 
        // splitExecSelf
        // 
        splitExecSelf.BorderStyle = BorderStyle.FixedSingle;
        splitExecSelf.AddPane(splitExecSelfPane1);
        splitExecSelf.AddPane(splitExecSelfPane2);
        splitExecSelf.Dock = DockStyle.Fill;
        splitExecSelf.Location = new Point(0, 0);
        splitExecSelf.Name = "splitExecSelf";
        splitExecSelf.Orientation = System.Windows.Forms.Orientation.Horizontal;
        splitExecSelf.Size = new Size(1360, 213);
        splitExecSelf.TabIndex = 0;
        // 
        // splitExecSelfPane1
        // 
        splitExecSelfPane1.Controls.Add(gridSelfHeader);
        splitExecSelfPane1.Location = new Point(0, 0);
        splitExecSelfPane1.Name = "splitExecSelfPane1";
        splitExecSelfPane1.Size = new Size(1358, 103);
        splitExecSelfPane1.TabIndex = 0;
        // 
        // gridSelfHeader
        // 
        gridSelfHeader.AllowUserToAddRows = false;
        gridSelfHeader.AllowUserToDeleteRows = false;
        gridSelfHeader.AllowUserToDragDropRows = false;
        gridSelfHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridSelfHeader.AutoSortGroups = true;
        gridSelfHeader.Dock = DockStyle.Fill;
        gridSelfHeader.GroupCellValueComparer = null;
        gridSelfHeader.GroupHeaderColumnIndex = 0;
        gridSelfHeader.GroupHeaderColumnName = null;
        gridSelfHeader.GroupHeaderHeight = 26F;
        gridSelfHeader.GroupLabelFormatter = null;
        gridSelfHeader.Location = new Point(0, 0);
        gridSelfHeader.Name = "gridSelfHeader";
        gridSelfHeader.ReadOnly = true;
        gridSelfHeader.Size = new Size(1358, 103);
        gridSelfHeader.TabIndex = 0;
        // 
        // splitExecSelfPane2
        // 
        splitExecSelfPane2.Controls.Add(gridSelfSegments);
        splitExecSelfPane2.Location = new Point(0, 108);
        splitExecSelfPane2.Name = "splitExecSelfPane2";
        splitExecSelfPane2.Size = new Size(1358, 103);
        splitExecSelfPane2.TabIndex = 1;
        // 
        // gridSelfSegments
        // 
        gridSelfSegments.AllowUserToAddRows = false;
        gridSelfSegments.AllowUserToDeleteRows = false;
        gridSelfSegments.AllowUserToDragDropRows = false;
        gridSelfSegments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridSelfSegments.AutoSortGroups = true;
        gridSelfSegments.Dock = DockStyle.Fill;
        gridSelfSegments.GroupCellValueComparer = null;
        gridSelfSegments.GroupHeaderColumnIndex = 0;
        gridSelfSegments.GroupHeaderColumnName = null;
        gridSelfSegments.GroupHeaderHeight = 26F;
        gridSelfSegments.GroupLabelFormatter = null;
        gridSelfSegments.Location = new Point(0, 0);
        gridSelfSegments.Name = "gridSelfSegments";
        gridSelfSegments.ReadOnly = true;
        gridSelfSegments.Size = new Size(1358, 103);
        gridSelfSegments.TabIndex = 0;
        // 
        // lblExecutableSummary
        // 
        lblExecutableSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblExecutableSummary.AutoEllipsis = true;
        lblExecutableSummary.Location = new Point(0, 0);
        lblExecutableSummary.Name = "lblExecutableSummary";
        lblExecutableSummary.Padding = new Padding(10, 0, 10, 0);
        lblExecutableSummary.Size = new Size(1368, 52);
        lblExecutableSummary.TabIndex = 0;
        lblExecutableSummary.Text = "Select a game to inspect eboot.bin and modules.";
        lblExecutableSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // searchExecutable
        // 
        searchExecutable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        searchExecutable.Location = new Point(1068, 57);
        searchExecutable.Name = "searchExecutable";
        searchExecutable.Placeholder = "Search modules";
        searchExecutable.Size = new Size(292, 28);
        searchExecutable.TabIndex = 3;
        searchExecutable.SearchTextChanged += searchExecutable_SearchTextChanged;
        // 
        // btnExecCopySelected
        // 
        btnExecCopySelected.Location = new Point(226, 58);
        btnExecCopySelected.Name = "btnExecCopySelected";
        btnExecCopySelected.Size = new Size(120, 26);
        btnExecCopySelected.TabIndex = 2;
        btnExecCopySelected.Text = "Copy Selected";
        btnExecCopySelected.Click += btnExecCopySelected_Click;
        // 
        // btnExecCopyAll
        // 
        btnExecCopyAll.Location = new Point(124, 58);
        btnExecCopyAll.Name = "btnExecCopyAll";
        btnExecCopyAll.Size = new Size(96, 26);
        btnExecCopyAll.TabIndex = 1;
        btnExecCopyAll.Text = "Copy All";
        btnExecCopyAll.Click += btnExecCopyAll_Click;
        // 
        // btnExecExtract
        // 
        btnExecExtract.Location = new Point(8, 58);
        btnExecExtract.Name = "btnExecExtract";
        btnExecExtract.Size = new Size(110, 26);
        btnExecExtract.TabIndex = 0;
        btnExecExtract.Text = "Extract...";
        btnExecExtract.Click += btnExecExtract_Click;
        // 
        // btnExecHash
        // 
        btnExecHash.Location = new Point(124, 58);
        btnExecHash.Name = "btnExecHash";
        btnExecHash.Size = new Size(130, 26);
        btnExecHash.TabIndex = 1;
        btnExecHash.Text = "SHA-256...";
        btnExecHash.Click += btnExecHash_Click;
        // 
        // tabRaw
        // 
        tabRaw.BackColor = SystemColors.Control;
        tabRaw.Controls.Add(txtRawMetadata);
        tabRaw.Controls.Add(btnRawFormatted);
        tabRaw.Controls.Add(btnRawOriginal);
        tabRaw.Controls.Add(btnCopyRawJson);
        tabRaw.Location = new Point(4, 32);
        tabRaw.Name = "tabRaw";
        tabRaw.Padding = new Padding(0, 38, 0, 0);
        tabRaw.Size = new Size(1368, 339);
        tabRaw.TabIndex = 6;
        tabRaw.Text = "Raw param.json";
        // 
        // txtRawMetadata
        // 
        txtRawMetadata.Dock = DockStyle.Fill;
        txtRawMetadata.Font = new Font("Consolas", 9F);
        txtRawMetadata.Location = new Point(0, 38);
        txtRawMetadata.Name = "txtRawMetadata";
        txtRawMetadata.ReadOnly = true;
        txtRawMetadata.SelectionColor = Color.Gainsboro;
        txtRawMetadata.SelectionFont = new Font("Consolas", 9F);
        txtRawMetadata.Size = new Size(1368, 301);
        txtRawMetadata.TabIndex = 0;
        txtRawMetadata.TextPadding = new Padding(3);
        txtRawMetadata.WordWrap = false;
        // 
        // btnRawFormatted
        // 
        btnRawFormatted.Location = new Point(124, 6);
        btnRawFormatted.Name = "btnRawFormatted";
        btnRawFormatted.Size = new Size(110, 26);
        btnRawFormatted.TabIndex = 1;
        btnRawFormatted.Text = "Formatted";
        btnRawFormatted.Click += btnRawFormatted_Click;
        // 
        // btnRawOriginal
        // 
        btnRawOriginal.Location = new Point(240, 6);
        btnRawOriginal.Name = "btnRawOriginal";
        btnRawOriginal.Size = new Size(130, 26);
        btnRawOriginal.TabIndex = 2;
        btnRawOriginal.Text = "Original bytes";
        btnRawOriginal.Click += btnRawOriginal_Click;
        // 
        // btnCopyRawJson
        // 
        btnCopyRawJson.Location = new Point(8, 6);
        btnCopyRawJson.Name = "btnCopyRawJson";
        btnCopyRawJson.Size = new Size(110, 26);
        btnCopyRawJson.TabIndex = 0;
        btnCopyRawJson.Text = "Copy JSON";
        btnCopyRawJson.Click += btnCopyRawJson_Click;
        // 
        // tabPackage
        // 
        tabPackage.BackColor = SystemColors.Control;
        tabPackage.Controls.Add(tabsPackage);
        tabPackage.Location = new Point(4, 32);
        tabPackage.Name = "tabPackage";
        tabPackage.Size = new Size(1368, 339);
        tabPackage.TabIndex = 8;
        tabPackage.Text = "Container";
        // 
        // tabsPackage
        // 
        tabsPackage.AllowDrop = true;
        tabsPackage.Controls.Add(tabPkgContainer);
        tabsPackage.Controls.Add(tabPkgSegments);
        tabsPackage.Controls.Add(tabPkgEntries);
        tabsPackage.Controls.Add(tabMetadata);
        tabsPackage.Controls.Add(tabPkgSi);
        tabsPackage.Dock = DockStyle.Fill;
        tabsPackage.ItemSize = new Size(125, 28);
        tabsPackage.Location = new Point(0, 0);
        tabsPackage.Name = "tabsPackage";
        tabsPackage.Padding = new Point(0, 0);
        tabsPackage.SelectedIndex = 0;
        tabsPackage.Size = new Size(1368, 339);
        tabsPackage.TabIndex = 0;
        // 
        // tabPkgContainer
        // 
        tabPkgContainer.BackColor = SystemColors.Control;
        tabPkgContainer.Controls.Add(gridPkgHeader);
        tabPkgContainer.Location = new Point(4, 32);
        tabPkgContainer.Name = "tabPkgContainer";
        tabPkgContainer.Size = new Size(1360, 303);
        tabPkgContainer.TabIndex = 0;
        tabPkgContainer.Text = "Source structure";
        // 
        // gridPkgHeader
        // 
        gridPkgHeader.AllowUserToAddRows = false;
        gridPkgHeader.AllowUserToDeleteRows = false;
        gridPkgHeader.AllowUserToDragDropRows = false;
        gridPkgHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPkgHeader.AutoSortGroups = true;
        gridPkgHeader.Dock = DockStyle.Fill;
        gridPkgHeader.GroupCellValueComparer = null;
        gridPkgHeader.GroupHeaderColumnIndex = 0;
        gridPkgHeader.GroupHeaderColumnName = null;
        gridPkgHeader.GroupHeaderHeight = 26F;
        gridPkgHeader.GroupLabelFormatter = null;
        gridPkgHeader.Location = new Point(0, 0);
        gridPkgHeader.Name = "gridPkgHeader";
        gridPkgHeader.ReadOnly = true;
        gridPkgHeader.Size = new Size(1360, 303);
        gridPkgHeader.TabIndex = 0;
        // 
        // tabPkgSegments
        // 
        tabPkgSegments.BackColor = SystemColors.Control;
        tabPkgSegments.Controls.Add(gridPkgSegments);
        tabPkgSegments.Location = new Point(4, 32);
        tabPkgSegments.Name = "tabPkgSegments";
        tabPkgSegments.Size = new Size(1360, 303);
        tabPkgSegments.TabIndex = 1;
        tabPkgSegments.Text = "Segments";
        // 
        // gridPkgSegments
        // 
        gridPkgSegments.AllowUserToAddRows = false;
        gridPkgSegments.AllowUserToDeleteRows = false;
        gridPkgSegments.AllowUserToDragDropRows = false;
        gridPkgSegments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPkgSegments.AutoSortGroups = true;
        gridPkgSegments.Dock = DockStyle.Fill;
        gridPkgSegments.GroupCellValueComparer = null;
        gridPkgSegments.GroupHeaderColumnIndex = 0;
        gridPkgSegments.GroupHeaderColumnName = null;
        gridPkgSegments.GroupHeaderHeight = 26F;
        gridPkgSegments.GroupLabelFormatter = null;
        gridPkgSegments.Location = new Point(0, 0);
        gridPkgSegments.Name = "gridPkgSegments";
        gridPkgSegments.ReadOnly = true;
        gridPkgSegments.Size = new Size(1360, 303);
        gridPkgSegments.TabIndex = 0;
        // 
        // tabPkgEntries
        // 
        tabPkgEntries.BackColor = SystemColors.Control;
        tabPkgEntries.Controls.Add(gridPkgEntries);
        tabPkgEntries.Location = new Point(4, 32);
        tabPkgEntries.Name = "tabPkgEntries";
        tabPkgEntries.Size = new Size(1360, 303);
        tabPkgEntries.TabIndex = 2;
        tabPkgEntries.Text = "CNT entries";
        // 
        // gridPkgEntries
        // 
        gridPkgEntries.AllowUserToAddRows = false;
        gridPkgEntries.AllowUserToDeleteRows = false;
        gridPkgEntries.AllowUserToDragDropRows = false;
        gridPkgEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPkgEntries.AutoSortGroups = true;
        gridPkgEntries.Dock = DockStyle.Fill;
        gridPkgEntries.GroupCellValueComparer = null;
        gridPkgEntries.GroupHeaderColumnIndex = 0;
        gridPkgEntries.GroupHeaderColumnName = null;
        gridPkgEntries.GroupHeaderHeight = 26F;
        gridPkgEntries.GroupLabelFormatter = null;
        gridPkgEntries.Location = new Point(0, 0);
        gridPkgEntries.Name = "gridPkgEntries";
        gridPkgEntries.ReadOnly = true;
        gridPkgEntries.Size = new Size(1360, 303);
        gridPkgEntries.TabIndex = 0;
        // 
        // tabMetadata
        // 
        tabMetadata.BackColor = SystemColors.Control;
        tabMetadata.Controls.Add(tabsMetadata);
        tabMetadata.Location = new Point(4, 32);
        tabMetadata.Name = "tabMetadata";
        tabMetadata.Size = new Size(1360, 303);
        tabMetadata.TabIndex = 3;
        tabMetadata.Text = "Metadata";
        // 
        // tabsMetadata
        // 
        tabsMetadata.AllowDrop = true;
        tabsMetadata.Controls.Add(tabPkgSfo);
        tabsMetadata.Controls.Add(tabPkgKeystone);
        tabsMetadata.Controls.Add(tabPkgPlayGo);
        tabsMetadata.Dock = DockStyle.Fill;
        tabsMetadata.ItemSize = new Size(113, 28);
        tabsMetadata.Location = new Point(0, 0);
        tabsMetadata.Name = "tabsMetadata";
        tabsMetadata.Padding = new Point(0, 0);
        tabsMetadata.SelectedIndex = 0;
        tabsMetadata.Size = new Size(1360, 303);
        tabsMetadata.TabIndex = 0;
        // 
        // tabPkgSfo
        // 
        tabPkgSfo.BackColor = SystemColors.Control;
        tabPkgSfo.Controls.Add(gridParamSfo);
        tabPkgSfo.Location = new Point(4, 32);
        tabPkgSfo.Name = "tabPkgSfo";
        tabPkgSfo.Size = new Size(1352, 267);
        tabPkgSfo.TabIndex = 3;
        tabPkgSfo.Text = "param.sfo";
        // 
        // gridParamSfo
        // 
        gridParamSfo.AllowUserToAddRows = false;
        gridParamSfo.AllowUserToDeleteRows = false;
        gridParamSfo.AllowUserToDragDropRows = false;
        gridParamSfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridParamSfo.AutoSortGroups = true;
        gridParamSfo.Dock = DockStyle.Fill;
        gridParamSfo.GroupCellValueComparer = null;
        gridParamSfo.GroupHeaderColumnIndex = 0;
        gridParamSfo.GroupHeaderColumnName = null;
        gridParamSfo.GroupHeaderHeight = 26F;
        gridParamSfo.GroupLabelFormatter = null;
        gridParamSfo.Location = new Point(0, 0);
        gridParamSfo.Name = "gridParamSfo";
        gridParamSfo.ReadOnly = true;
        gridParamSfo.Size = new Size(1352, 267);
        gridParamSfo.TabIndex = 0;
        // 
        // tabPkgKeystone
        // 
        tabPkgKeystone.BackColor = SystemColors.Control;
        tabPkgKeystone.Controls.Add(gridKeystone);
        tabPkgKeystone.Location = new Point(4, 32);
        tabPkgKeystone.Name = "tabPkgKeystone";
        tabPkgKeystone.Size = new Size(1352, 267);
        tabPkgKeystone.TabIndex = 4;
        tabPkgKeystone.Text = "Keystone / NP";
        // 
        // gridKeystone
        // 
        gridKeystone.AllowUserToAddRows = false;
        gridKeystone.AllowUserToDeleteRows = false;
        gridKeystone.AllowUserToDragDropRows = false;
        gridKeystone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridKeystone.AutoSortGroups = true;
        gridKeystone.Dock = DockStyle.Fill;
        gridKeystone.GroupCellValueComparer = null;
        gridKeystone.GroupHeaderColumnIndex = 0;
        gridKeystone.GroupHeaderColumnName = null;
        gridKeystone.GroupHeaderHeight = 26F;
        gridKeystone.GroupLabelFormatter = null;
        gridKeystone.Location = new Point(0, 0);
        gridKeystone.Name = "gridKeystone";
        gridKeystone.ReadOnly = true;
        gridKeystone.Size = new Size(1352, 267);
        gridKeystone.TabIndex = 0;
        // 
        // tabPkgPlayGo
        // 
        tabPkgPlayGo.BackColor = SystemColors.Control;
        tabPkgPlayGo.Controls.Add(tabsPlayGo);
        tabPkgPlayGo.Controls.Add(lblPlayGoSummary);
        tabPkgPlayGo.Location = new Point(4, 32);
        tabPkgPlayGo.Name = "tabPkgPlayGo";
        tabPkgPlayGo.Size = new Size(1352, 267);
        tabPkgPlayGo.TabIndex = 6;
        tabPkgPlayGo.Text = "PlayGo";
        // 
        // tabsPlayGo
        // 
        tabsPlayGo.AllowDrop = true;
        tabsPlayGo.Controls.Add(tabPlayGoChunks);
        tabsPlayGo.Controls.Add(tabPlayGoScenarios);
        tabsPlayGo.Controls.Add(tabPlayGoFiles);
        tabsPlayGo.Dock = DockStyle.Fill;
        tabsPlayGo.ItemSize = new Size(95, 28);
        tabsPlayGo.Location = new Point(0, 30);
        tabsPlayGo.Name = "tabsPlayGo";
        tabsPlayGo.Padding = new Point(0, 0);
        tabsPlayGo.SelectedIndex = 0;
        tabsPlayGo.Size = new Size(1352, 237);
        tabsPlayGo.TabIndex = 0;
        // 
        // tabPlayGoChunks
        // 
        tabPlayGoChunks.BackColor = SystemColors.Control;
        tabPlayGoChunks.Controls.Add(gridPlayGoChunks);
        tabPlayGoChunks.Location = new Point(4, 32);
        tabPlayGoChunks.Name = "tabPlayGoChunks";
        tabPlayGoChunks.Size = new Size(1344, 201);
        tabPlayGoChunks.TabIndex = 0;
        tabPlayGoChunks.Text = "Chunks";
        // 
        // gridPlayGoChunks
        // 
        gridPlayGoChunks.AllowUserToAddRows = false;
        gridPlayGoChunks.AllowUserToDeleteRows = false;
        gridPlayGoChunks.AllowUserToDragDropRows = false;
        gridPlayGoChunks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPlayGoChunks.AutoSortGroups = true;
        gridPlayGoChunks.Dock = DockStyle.Fill;
        gridPlayGoChunks.GroupCellValueComparer = null;
        gridPlayGoChunks.GroupHeaderColumnIndex = 0;
        gridPlayGoChunks.GroupHeaderColumnName = null;
        gridPlayGoChunks.GroupHeaderHeight = 26F;
        gridPlayGoChunks.GroupLabelFormatter = null;
        gridPlayGoChunks.Location = new Point(0, 0);
        gridPlayGoChunks.Name = "gridPlayGoChunks";
        gridPlayGoChunks.ReadOnly = true;
        gridPlayGoChunks.Size = new Size(1344, 201);
        gridPlayGoChunks.TabIndex = 0;
        // 
        // tabPlayGoScenarios
        // 
        tabPlayGoScenarios.BackColor = SystemColors.Control;
        tabPlayGoScenarios.Controls.Add(gridPlayGoScenarios);
        tabPlayGoScenarios.Location = new Point(4, 32);
        tabPlayGoScenarios.Name = "tabPlayGoScenarios";
        tabPlayGoScenarios.Size = new Size(1344, 201);
        tabPlayGoScenarios.TabIndex = 1;
        tabPlayGoScenarios.Text = "Scenarios";
        // 
        // gridPlayGoScenarios
        // 
        gridPlayGoScenarios.AllowUserToAddRows = false;
        gridPlayGoScenarios.AllowUserToDeleteRows = false;
        gridPlayGoScenarios.AllowUserToDragDropRows = false;
        gridPlayGoScenarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPlayGoScenarios.AutoSortGroups = true;
        gridPlayGoScenarios.Dock = DockStyle.Fill;
        gridPlayGoScenarios.GroupCellValueComparer = null;
        gridPlayGoScenarios.GroupHeaderColumnIndex = 0;
        gridPlayGoScenarios.GroupHeaderColumnName = null;
        gridPlayGoScenarios.GroupHeaderHeight = 26F;
        gridPlayGoScenarios.GroupLabelFormatter = null;
        gridPlayGoScenarios.Location = new Point(0, 0);
        gridPlayGoScenarios.Name = "gridPlayGoScenarios";
        gridPlayGoScenarios.ReadOnly = true;
        gridPlayGoScenarios.Size = new Size(1344, 201);
        gridPlayGoScenarios.TabIndex = 0;
        // 
        // tabPlayGoFiles
        // 
        tabPlayGoFiles.BackColor = SystemColors.Control;
        tabPlayGoFiles.Controls.Add(gridPlayGoFiles);
        tabPlayGoFiles.Location = new Point(4, 32);
        tabPlayGoFiles.Name = "tabPlayGoFiles";
        tabPlayGoFiles.Size = new Size(1344, 201);
        tabPlayGoFiles.TabIndex = 2;
        tabPlayGoFiles.Text = "File chunks";
        // 
        // gridPlayGoFiles
        // 
        gridPlayGoFiles.AllowUserToAddRows = false;
        gridPlayGoFiles.AllowUserToDeleteRows = false;
        gridPlayGoFiles.AllowUserToDragDropRows = false;
        gridPlayGoFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridPlayGoFiles.AutoSortGroups = true;
        gridPlayGoFiles.Dock = DockStyle.Fill;
        gridPlayGoFiles.GroupCellValueComparer = null;
        gridPlayGoFiles.GroupHeaderColumnIndex = 0;
        gridPlayGoFiles.GroupHeaderColumnName = null;
        gridPlayGoFiles.GroupHeaderHeight = 26F;
        gridPlayGoFiles.GroupLabelFormatter = null;
        gridPlayGoFiles.Location = new Point(0, 0);
        gridPlayGoFiles.Name = "gridPlayGoFiles";
        gridPlayGoFiles.ReadOnly = true;
        gridPlayGoFiles.Size = new Size(1344, 201);
        gridPlayGoFiles.TabIndex = 0;
        // 
        // lblPlayGoSummary
        // 
        lblPlayGoSummary.AutoEllipsis = true;
        lblPlayGoSummary.Dock = DockStyle.Top;
        lblPlayGoSummary.Location = new Point(0, 0);
        lblPlayGoSummary.Name = "lblPlayGoSummary";
        lblPlayGoSummary.Padding = new Padding(10, 0, 10, 0);
        lblPlayGoSummary.Size = new Size(1352, 30);
        lblPlayGoSummary.TabIndex = 1;
        lblPlayGoSummary.Text = "Select a game to inspect the PlayGo chunk map.";
        lblPlayGoSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tabPkgSi
        // 
        tabPkgSi.BackColor = SystemColors.Control;
        tabPkgSi.Controls.Add(gridSi);
        tabPkgSi.Location = new Point(4, 32);
        tabPkgSi.Name = "tabPkgSi";
        tabPkgSi.Size = new Size(1360, 303);
        tabPkgSi.TabIndex = 5;
        tabPkgSi.Text = "SI contents";
        // 
        // gridSi
        // 
        gridSi.AllowUserToAddRows = false;
        gridSi.AllowUserToDeleteRows = false;
        gridSi.AllowUserToDragDropRows = false;
        gridSi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridSi.AutoSortGroups = true;
        gridSi.Dock = DockStyle.Fill;
        gridSi.GroupCellValueComparer = null;
        gridSi.GroupHeaderColumnIndex = 0;
        gridSi.GroupHeaderColumnName = null;
        gridSi.GroupHeaderHeight = 26F;
        gridSi.GroupLabelFormatter = null;
        gridSi.Location = new Point(0, 0);
        gridSi.Name = "gridSi";
        gridSi.ReadOnly = true;
        gridSi.Size = new Size(1360, 303);
        gridSi.TabIndex = 0;
        // 
        // tabWorkspaceTools
        // 
        tabWorkspaceTools.BackColor = SystemColors.Control;
        tabWorkspaceTools.Controls.Add(toolsLayout);
        tabWorkspaceTools.Location = new Point(4, 32);
        tabWorkspaceTools.Name = "tabWorkspaceTools";
        tabWorkspaceTools.Size = new Size(1376, 375);
        tabWorkspaceTools.TabIndex = 1;
        tabWorkspaceTools.Text = "Tools";
        // 
        // toolsLayout
        // 
        toolsLayout.ColumnCount = 1;
        toolsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        toolsLayout.Controls.Add(sectionJob, 0, 0);
        toolsLayout.Controls.Add(tabsImageTargets, 0, 1);
        toolsLayout.Controls.Add(toolsFooter, 0, 2);
        toolsLayout.Dock = DockStyle.Fill;
        toolsLayout.Location = new Point(0, 0);
        toolsLayout.Name = "toolsLayout";
        toolsLayout.Padding = new Padding(10, 8, 10, 8);
        toolsLayout.RowCount = 3;
        toolsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
        toolsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        toolsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        toolsLayout.Size = new Size(1376, 375);
        toolsLayout.TabIndex = 0;
        // 
        // sectionJob
        // 
        sectionJob.Controls.Add(lblImageSourcePath);
        sectionJob.Controls.Add(lblImageFormat);
        sectionJob.Controls.Add(lblImageAction);
        sectionJob.Controls.Add(cboImageAction);
        sectionJob.Controls.Add(lblImageSource);
        sectionJob.Dock = DockStyle.Fill;
        sectionJob.Location = new Point(10, 8);
        sectionJob.Margin = new Padding(0, 0, 0, 6);
        sectionJob.Name = "sectionJob";
        sectionJob.SectionHeader = "Job";
        sectionJob.Size = new Size(1356, 109);
        sectionJob.TabIndex = 0;
        // 
        // lblImageSourcePath
        // 
        lblImageSourcePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblImageSourcePath.AutoEllipsis = true;
        lblImageSourcePath.Location = new Point(120, 27);
        lblImageSourcePath.Name = "lblImageSourcePath";
        lblImageSourcePath.Size = new Size(1200, 20);
        lblImageSourcePath.TabIndex = 1;
        lblImageSourcePath.Text = "Select a game in the library above.";
        lblImageSourcePath.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblImageFormat
        // 
        lblImageFormat.AutoEllipsis = true;
        lblImageFormat.Location = new Point(120, 53);
        lblImageFormat.Name = "lblImageFormat";
        lblImageFormat.Size = new Size(320, 15);
        lblImageFormat.TabIndex = 4;
        lblImageFormat.Text = "Detected: -";
        // 
        // lblImageAction
        // 
        lblImageAction.Location = new Point(12, 83);
        lblImageAction.Name = "lblImageAction";
        lblImageAction.Size = new Size(100, 15);
        lblImageAction.TabIndex = 5;
        lblImageAction.Text = "Action:";
        lblImageAction.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageAction
        // 
        cboImageAction.Location = new Point(120, 79);
        cboImageAction.Name = "cboImageAction";
        cboImageAction.Size = new Size(260, 24);
        cboImageAction.TabIndex = 6;
        cboImageAction.SelectedIndexChanged += cboImageAction_SelectedIndexChanged;
        // 
        // lblImageSource
        // 
        lblImageSource.Location = new Point(12, 31);
        lblImageSource.Name = "lblImageSource";
        lblImageSource.Size = new Size(100, 15);
        lblImageSource.TabIndex = 0;
        lblImageSource.Text = "Source:";
        lblImageSource.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tabsImageTargets
        // 
        tabsImageTargets.AllowDrop = true;
        tabsImageTargets.Controls.Add(tabTargetExfat);
        tabsImageTargets.Controls.Add(tabTargetFfpkg);
        tabsImageTargets.Controls.Add(tabTargetFfpfsc);
        tabsImageTargets.Controls.Add(tabTargetDebug);
        tabsImageTargets.Controls.Add(tabTargetOptions);
        tabsImageTargets.Dock = DockStyle.Fill;
        tabsImageTargets.ItemSize = new Size(80, 28);
        tabsImageTargets.Location = new Point(13, 126);
        tabsImageTargets.Name = "tabsImageTargets";
        tabsImageTargets.Padding = new Point(0, 0);
        tabsImageTargets.SelectedIndex = 0;
        tabsImageTargets.Size = new Size(1350, 188);
        tabsImageTargets.TabIndex = 1;
        tabsImageTargets.SelectedIndexChanged += tabsImageTargets_SelectedIndexChanged;
        // 
        // tabTargetExfat
        // 
        tabTargetExfat.BackColor = SystemColors.Control;
        tabTargetExfat.Controls.Add(lblOutExfat);
        tabTargetExfat.Controls.Add(txtOutExfat);
        tabTargetExfat.Controls.Add(btnOutExfat);
        tabTargetExfat.Controls.Add(chkOutExfat);
        tabTargetExfat.Controls.Add(lblImageCluster);
        tabTargetExfat.Controls.Add(cboImageCluster);
        tabTargetExfat.Controls.Add(chkImageAmpr);
        tabTargetExfat.Location = new Point(4, 32);
        tabTargetExfat.Name = "tabTargetExfat";
        tabTargetExfat.Size = new Size(1342, 152);
        tabTargetExfat.TabIndex = 0;
        tabTargetExfat.Text = "exFAT";
        // 
        // lblOutExfat
        // 
        lblOutExfat.Location = new Point(217, 9);
        lblOutExfat.Name = "lblOutExfat";
        lblOutExfat.Size = new Size(100, 15);
        lblOutExfat.TabIndex = 9;
        lblOutExfat.Text = "Output:";
        lblOutExfat.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtOutExfat
        // 
        txtOutExfat.Location = new Point(325, 5);
        txtOutExfat.Name = "txtOutExfat";
        txtOutExfat.Size = new Size(560, 23);
        txtOutExfat.TabIndex = 10;
        // 
        // btnOutExfat
        // 
        btnOutExfat.Location = new Point(893, 5);
        btnOutExfat.Name = "btnOutExfat";
        btnOutExfat.Size = new Size(80, 24);
        btnOutExfat.TabIndex = 11;
        btnOutExfat.Text = "Browse...";
        btnOutExfat.Click += btnImageBrowseOutput_Click;
        // 
        // chkOutExfat
        // 
        chkOutExfat.AutoSize = true;
        chkOutExfat.Location = new Point(981, 9);
        chkOutExfat.Name = "chkOutExfat";
        chkOutExfat.Size = new Size(120, 19);
        chkOutExfat.TabIndex = 12;
        chkOutExfat.Text = "Overwrite existing";
        // 
        // lblImageCluster
        // 
        lblImageCluster.Location = new Point(217, 39);
        lblImageCluster.Name = "lblImageCluster";
        lblImageCluster.Size = new Size(100, 15);
        lblImageCluster.TabIndex = 13;
        lblImageCluster.Text = "Cluster size:";
        lblImageCluster.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageCluster
        // 
        cboImageCluster.Items.AddRange(new object[] { "Auto", "32 KB", "64 KB" });
        cboImageCluster.Location = new Point(325, 35);
        cboImageCluster.Name = "cboImageCluster";
        cboImageCluster.Size = new Size(140, 24);
        cboImageCluster.TabIndex = 14;
        // 
        // chkImageAmpr
        // 
        chkImageAmpr.AutoSize = true;
        chkImageAmpr.Location = new Point(485, 39);
        chkImageAmpr.Name = "chkImageAmpr";
        chkImageAmpr.Size = new Size(140, 19);
        chkImageAmpr.TabIndex = 19;
        chkImageAmpr.Text = "Generate AMPR index";
        // 
        // tabTargetFfpkg
        // 
        tabTargetFfpkg.BackColor = SystemColors.Control;
        tabTargetFfpkg.Controls.Add(lblOutFfpkg);
        tabTargetFfpkg.Controls.Add(txtOutFfpkg);
        tabTargetFfpkg.Controls.Add(btnOutFfpkg);
        tabTargetFfpkg.Controls.Add(chkOutFfpkg);
        tabTargetFfpkg.Controls.Add(lblImageBlock);
        tabTargetFfpkg.Controls.Add(cboImageBlock);
        tabTargetFfpkg.Controls.Add(lblImageFragment);
        tabTargetFfpkg.Controls.Add(cboImageFragment);
        tabTargetFfpkg.Controls.Add(lblImageDensity);
        tabTargetFfpkg.Controls.Add(cboImageDensity);
        tabTargetFfpkg.Controls.Add(lblImageMinFree);
        tabTargetFfpkg.Controls.Add(nudImageMinFree);
        tabTargetFfpkg.Location = new Point(4, 32);
        tabTargetFfpkg.Name = "tabTargetFfpkg";
        tabTargetFfpkg.Size = new Size(1342, 152);
        tabTargetFfpkg.TabIndex = 1;
        tabTargetFfpkg.Text = "FFPKG";
        // 
        // lblOutFfpkg
        // 
        lblOutFfpkg.Location = new Point(217, 9);
        lblOutFfpkg.Name = "lblOutFfpkg";
        lblOutFfpkg.Size = new Size(100, 15);
        lblOutFfpkg.TabIndex = 9;
        lblOutFfpkg.Text = "Output:";
        lblOutFfpkg.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtOutFfpkg
        // 
        txtOutFfpkg.Location = new Point(325, 5);
        txtOutFfpkg.Name = "txtOutFfpkg";
        txtOutFfpkg.Size = new Size(560, 23);
        txtOutFfpkg.TabIndex = 10;
        // 
        // btnOutFfpkg
        // 
        btnOutFfpkg.Location = new Point(893, 5);
        btnOutFfpkg.Name = "btnOutFfpkg";
        btnOutFfpkg.Size = new Size(80, 24);
        btnOutFfpkg.TabIndex = 11;
        btnOutFfpkg.Text = "Browse...";
        btnOutFfpkg.Click += btnImageBrowseOutput_Click;
        // 
        // chkOutFfpkg
        // 
        chkOutFfpkg.AutoSize = true;
        chkOutFfpkg.Location = new Point(981, 9);
        chkOutFfpkg.Name = "chkOutFfpkg";
        chkOutFfpkg.Size = new Size(120, 19);
        chkOutFfpkg.TabIndex = 12;
        chkOutFfpkg.Text = "Overwrite existing";
        // 
        // lblImageBlock
        // 
        lblImageBlock.Location = new Point(217, 39);
        lblImageBlock.Name = "lblImageBlock";
        lblImageBlock.Size = new Size(100, 15);
        lblImageBlock.TabIndex = 24;
        lblImageBlock.Text = "Block size:";
        lblImageBlock.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageBlock
        // 
        cboImageBlock.Items.AddRange(new object[] { "32 KB", "64 KB" });
        cboImageBlock.Location = new Point(325, 35);
        cboImageBlock.Name = "cboImageBlock";
        cboImageBlock.Size = new Size(100, 24);
        cboImageBlock.TabIndex = 25;
        // 
        // lblImageFragment
        // 
        lblImageFragment.Location = new Point(427, 39);
        lblImageFragment.Name = "lblImageFragment";
        lblImageFragment.Size = new Size(100, 15);
        lblImageFragment.TabIndex = 26;
        lblImageFragment.Text = "Fragment:";
        lblImageFragment.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageFragment
        // 
        cboImageFragment.Items.AddRange(new object[] { "4 KB", "64 KB" });
        cboImageFragment.Location = new Point(535, 35);
        cboImageFragment.Name = "cboImageFragment";
        cboImageFragment.Size = new Size(100, 24);
        cboImageFragment.TabIndex = 27;
        // 
        // lblImageDensity
        // 
        lblImageDensity.Location = new Point(637, 39);
        lblImageDensity.Name = "lblImageDensity";
        lblImageDensity.Size = new Size(100, 15);
        lblImageDensity.TabIndex = 28;
        lblImageDensity.Text = "Density:";
        lblImageDensity.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageDensity
        // 
        cboImageDensity.Items.AddRange(new object[] { "256 KiB", "512 KiB", "1 MiB" });
        cboImageDensity.Location = new Point(745, 35);
        cboImageDensity.Name = "cboImageDensity";
        cboImageDensity.Size = new Size(140, 24);
        cboImageDensity.TabIndex = 29;
        // 
        // lblImageMinFree
        // 
        lblImageMinFree.Location = new Point(887, 39);
        lblImageMinFree.Name = "lblImageMinFree";
        lblImageMinFree.Size = new Size(100, 15);
        lblImageMinFree.TabIndex = 30;
        lblImageMinFree.Text = "Min free %:";
        lblImageMinFree.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudImageMinFree
        // 
        nudImageMinFree.Location = new Point(995, 35);
        nudImageMinFree.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        nudImageMinFree.Name = "nudImageMinFree";
        nudImageMinFree.Size = new Size(60, 23);
        nudImageMinFree.TabIndex = 31;
        // 
        // tabTargetFfpfsc
        // 
        tabTargetFfpfsc.BackColor = SystemColors.Control;
        tabTargetFfpfsc.Controls.Add(lblOutFfpfsc);
        tabTargetFfpfsc.Controls.Add(txtOutFfpfsc);
        tabTargetFfpfsc.Controls.Add(btnOutFfpfsc);
        tabTargetFfpfsc.Controls.Add(chkOutFfpfsc);
        tabTargetFfpfsc.Controls.Add(lblImageLevel);
        tabTargetFfpfsc.Controls.Add(nudImageLevel);
        tabTargetFfpfsc.Controls.Add(lblImageGain);
        tabTargetFfpfsc.Controls.Add(nudImageGain);
        tabTargetFfpfsc.Location = new Point(4, 32);
        tabTargetFfpfsc.Name = "tabTargetFfpfsc";
        tabTargetFfpfsc.Size = new Size(1342, 152);
        tabTargetFfpfsc.TabIndex = 2;
        tabTargetFfpfsc.Text = "FFPFSC";
        // 
        // lblOutFfpfsc
        // 
        lblOutFfpfsc.Location = new Point(217, 9);
        lblOutFfpfsc.Name = "lblOutFfpfsc";
        lblOutFfpfsc.Size = new Size(100, 15);
        lblOutFfpfsc.TabIndex = 9;
        lblOutFfpfsc.Text = "Output:";
        lblOutFfpfsc.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtOutFfpfsc
        // 
        txtOutFfpfsc.Location = new Point(325, 5);
        txtOutFfpfsc.Name = "txtOutFfpfsc";
        txtOutFfpfsc.Size = new Size(560, 23);
        txtOutFfpfsc.TabIndex = 10;
        // 
        // btnOutFfpfsc
        // 
        btnOutFfpfsc.Location = new Point(893, 5);
        btnOutFfpfsc.Name = "btnOutFfpfsc";
        btnOutFfpfsc.Size = new Size(80, 24);
        btnOutFfpfsc.TabIndex = 11;
        btnOutFfpfsc.Text = "Browse...";
        btnOutFfpfsc.Click += btnImageBrowseOutput_Click;
        // 
        // chkOutFfpfsc
        // 
        chkOutFfpfsc.AutoSize = true;
        chkOutFfpfsc.Location = new Point(981, 9);
        chkOutFfpfsc.Name = "chkOutFfpfsc";
        chkOutFfpfsc.Size = new Size(120, 19);
        chkOutFfpfsc.TabIndex = 12;
        chkOutFfpfsc.Text = "Overwrite existing";
        // 
        // lblImageLevel
        // 
        lblImageLevel.Location = new Point(217, 39);
        lblImageLevel.Name = "lblImageLevel";
        lblImageLevel.Size = new Size(100, 15);
        lblImageLevel.TabIndex = 15;
        lblImageLevel.Text = "Level:";
        lblImageLevel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudImageLevel
        // 
        nudImageLevel.Location = new Point(325, 35);
        nudImageLevel.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
        nudImageLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudImageLevel.Name = "nudImageLevel";
        nudImageLevel.Size = new Size(60, 23);
        nudImageLevel.TabIndex = 16;
        nudImageLevel.Value = new decimal(new int[] { 7, 0, 0, 0 });
        // 
        // lblImageGain
        // 
        lblImageGain.Location = new Point(405, 39);
        lblImageGain.Name = "lblImageGain";
        lblImageGain.Size = new Size(100, 15);
        lblImageGain.TabIndex = 17;
        lblImageGain.Text = "Gain %:";
        lblImageGain.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudImageGain
        // 
        nudImageGain.Location = new Point(513, 35);
        nudImageGain.Name = "nudImageGain";
        nudImageGain.Size = new Size(60, 23);
        nudImageGain.TabIndex = 18;
        nudImageGain.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // tabTargetDebug
        // 
        tabTargetDebug.BackColor = SystemColors.Control;
        tabTargetDebug.Controls.Add(lblOutDebug);
        tabTargetDebug.Controls.Add(txtOutDebug);
        tabTargetDebug.Controls.Add(btnOutDebug);
        tabTargetDebug.Controls.Add(chkOutDebug);
        tabTargetDebug.Controls.Add(lblDbgPasscode);
        tabTargetDebug.Controls.Add(txtDbgPasscode);
        tabTargetDebug.Controls.Add(lblImageSdk);
        tabTargetDebug.Controls.Add(cboImageSdk);
        tabTargetDebug.Controls.Add(lblImagePkgType);
        tabTargetDebug.Controls.Add(cboImagePkgType);
        tabTargetDebug.Controls.Add(lblImageCompression);
        tabTargetDebug.Controls.Add(cboImageCompression);
        tabTargetDebug.Controls.Add(lblImageKrakenLevel);
        tabTargetDebug.Controls.Add(cboImageKrakenLevel);
        tabTargetDebug.Controls.Add(lblImagePlayGo);
        tabTargetDebug.Controls.Add(nudImagePlayGoChunks);
        tabTargetDebug.Controls.Add(lblImageKrakenThreads);
        tabTargetDebug.Controls.Add(nudImageKrakenThreads);
        tabTargetDebug.Controls.Add(lblImageTemp);
        tabTargetDebug.Controls.Add(txtImageTemp);
        tabTargetDebug.Controls.Add(btnImageTempBrowse);
        tabTargetDebug.Controls.Add(lblImageDrm);
        tabTargetDebug.Controls.Add(cboImageDrm);
        tabTargetDebug.Controls.Add(lblImageBackend);
        tabTargetDebug.Controls.Add(cboImageBackend);
        tabTargetDebug.Controls.Add(chkImageFakeSign);
        tabTargetDebug.Controls.Add(chkImageRightSprx);
        tabTargetDebug.Controls.Add(chkImageDeterministic);
        tabTargetDebug.Controls.Add(chkImageAdvancedOptions);
        tabTargetDebug.Location = new Point(4, 32);
        tabTargetDebug.Name = "tabTargetDebug";
        tabTargetDebug.Size = new Size(1342, 152);
        tabTargetDebug.TabIndex = 3;
        tabTargetDebug.Text = "PKG";
        // 
        // lblOutDebug
        // 
        lblOutDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblOutDebug.Location = new Point(217, 9);
        lblOutDebug.Name = "lblOutDebug";
        lblOutDebug.Size = new Size(100, 15);
        lblOutDebug.TabIndex = 9;
        lblOutDebug.Text = "Output:";
        lblOutDebug.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtOutDebug
        // 
        txtOutDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtOutDebug.Location = new Point(325, 5);
        txtOutDebug.Name = "txtOutDebug";
        txtOutDebug.Size = new Size(560, 23);
        txtOutDebug.TabIndex = 10;
        // 
        // btnOutDebug
        // 
        btnOutDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnOutDebug.Location = new Point(893, 5);
        btnOutDebug.Name = "btnOutDebug";
        btnOutDebug.Size = new Size(80, 24);
        btnOutDebug.TabIndex = 11;
        btnOutDebug.Text = "Browse...";
        btnOutDebug.Click += btnImageBrowseOutput_Click;
        // 
        // chkOutDebug
        // 
        chkOutDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chkOutDebug.AutoSize = true;
        chkOutDebug.Location = new Point(981, 9);
        chkOutDebug.Name = "chkOutDebug";
        chkOutDebug.Size = new Size(120, 19);
        chkOutDebug.TabIndex = 12;
        chkOutDebug.Text = "Overwrite existing";
        // 
        // lblDbgPasscode
        // 
        lblDbgPasscode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblDbgPasscode.Location = new Point(217, 39);
        lblDbgPasscode.Name = "lblDbgPasscode";
        lblDbgPasscode.Size = new Size(100, 15);
        lblDbgPasscode.TabIndex = 34;
        lblDbgPasscode.Text = "Passcode:";
        lblDbgPasscode.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtDbgPasscode
        // 
        txtDbgPasscode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtDbgPasscode.Location = new Point(325, 35);
        txtDbgPasscode.Name = "txtDbgPasscode";
        txtDbgPasscode.Size = new Size(288, 23);
        txtDbgPasscode.TabIndex = 35;
        // 
        // lblImageSdk
        // 
        lblImageSdk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageSdk.Location = new Point(631, 39);
        lblImageSdk.Name = "lblImageSdk";
        lblImageSdk.Size = new Size(100, 15);
        lblImageSdk.TabIndex = 36;
        lblImageSdk.Text = "SDK:";
        lblImageSdk.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageSdk
        // 
        cboImageSdk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImageSdk.Location = new Point(739, 34);
        cboImageSdk.Name = "cboImageSdk";
        cboImageSdk.Size = new Size(234, 24);
        cboImageSdk.TabIndex = 37;
        // 
        // lblImagePkgType
        // 
        lblImagePkgType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImagePkgType.Location = new Point(217, 69);
        lblImagePkgType.Name = "lblImagePkgType";
        lblImagePkgType.Size = new Size(100, 15);
        lblImagePkgType.TabIndex = 42;
        lblImagePkgType.Text = "Package type:";
        lblImagePkgType.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImagePkgType
        // 
        cboImagePkgType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImagePkgType.Location = new Point(325, 65);
        cboImagePkgType.Name = "cboImagePkgType";
        cboImagePkgType.Size = new Size(288, 24);
        cboImagePkgType.TabIndex = 43;
        cboImagePkgType.SelectedIndexChanged += cboImagePkgType_SelectedIndexChanged;
        // 
        // lblImageCompression
        // 
        lblImageCompression.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageCompression.Location = new Point(631, 69);
        lblImageCompression.Name = "lblImageCompression";
        lblImageCompression.Size = new Size(100, 15);
        lblImageCompression.TabIndex = 44;
        lblImageCompression.Text = "Compression:";
        lblImageCompression.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageCompression
        // 
        cboImageCompression.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImageCompression.Location = new Point(739, 65);
        cboImageCompression.Name = "cboImageCompression";
        cboImageCompression.Size = new Size(234, 24);
        cboImageCompression.TabIndex = 45;
        cboImageCompression.SelectedIndexChanged += cboImageCompression_SelectedIndexChanged;
        // 
        // lblImageKrakenLevel
        // 
        lblImageKrakenLevel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageKrakenLevel.Location = new Point(397, 99);
        lblImageKrakenLevel.Name = "lblImageKrakenLevel";
        lblImageKrakenLevel.Size = new Size(100, 15);
        lblImageKrakenLevel.TabIndex = 46;
        lblImageKrakenLevel.Text = "Kraken level:";
        lblImageKrakenLevel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageKrakenLevel
        // 
        cboImageKrakenLevel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImageKrakenLevel.Location = new Point(505, 94);
        cboImageKrakenLevel.Name = "cboImageKrakenLevel";
        cboImageKrakenLevel.Size = new Size(108, 24);
        cboImageKrakenLevel.TabIndex = 47;
        // 
        // lblImagePlayGo
        // 
        lblImagePlayGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImagePlayGo.Location = new Point(217, 99);
        lblImagePlayGo.Name = "lblImagePlayGo";
        lblImagePlayGo.Size = new Size(100, 15);
        lblImagePlayGo.TabIndex = 50;
        lblImagePlayGo.Text = "PlayGo chunks:";
        lblImagePlayGo.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudImagePlayGoChunks
        // 
        nudImagePlayGoChunks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nudImagePlayGoChunks.Location = new Point(325, 95);
        nudImagePlayGoChunks.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudImagePlayGoChunks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudImagePlayGoChunks.Name = "nudImagePlayGoChunks";
        nudImagePlayGoChunks.Size = new Size(70, 23);
        nudImagePlayGoChunks.TabIndex = 51;
        nudImagePlayGoChunks.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblImageKrakenThreads
        // 
        lblImageKrakenThreads.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageKrakenThreads.Location = new Point(631, 99);
        lblImageKrakenThreads.Name = "lblImageKrakenThreads";
        lblImageKrakenThreads.Size = new Size(100, 15);
        lblImageKrakenThreads.TabIndex = 48;
        lblImageKrakenThreads.Text = "Kraken threads:";
        lblImageKrakenThreads.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudImageKrakenThreads
        // 
        nudImageKrakenThreads.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nudImageKrakenThreads.Location = new Point(739, 95);
        nudImageKrakenThreads.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
        nudImageKrakenThreads.Name = "nudImageKrakenThreads";
        nudImageKrakenThreads.Size = new Size(70, 23);
        nudImageKrakenThreads.TabIndex = 49;
        // 
        // lblImageTemp
        // 
        lblImageTemp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageTemp.Location = new Point(217, 129);
        lblImageTemp.Name = "lblImageTemp";
        lblImageTemp.Size = new Size(100, 15);
        lblImageTemp.TabIndex = 52;
        lblImageTemp.Text = "Workspace:";
        lblImageTemp.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtImageTemp
        // 
        txtImageTemp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtImageTemp.Location = new Point(325, 125);
        txtImageTemp.Name = "txtImageTemp";
        txtImageTemp.Size = new Size(288, 23);
        txtImageTemp.TabIndex = 53;
        // 
        // btnImageTempBrowse
        // 
        btnImageTempBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnImageTempBrowse.Location = new Point(619, 124);
        btnImageTempBrowse.Name = "btnImageTempBrowse";
        btnImageTempBrowse.Size = new Size(80, 24);
        btnImageTempBrowse.TabIndex = 54;
        btnImageTempBrowse.Text = "Browse...";
        btnImageTempBrowse.Click += btnImageTempBrowse_Click;
        // 
        // lblImageDrm
        // 
        lblImageDrm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageDrm.Location = new Point(701, 129);
        lblImageDrm.Name = "lblImageDrm";
        lblImageDrm.Size = new Size(44, 15);
        lblImageDrm.TabIndex = 55;
        lblImageDrm.Text = "DRM:";
        lblImageDrm.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageDrm
        // 
        cboImageDrm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImageDrm.Location = new Point(751, 124);
        cboImageDrm.Name = "cboImageDrm";
        cboImageDrm.Size = new Size(130, 24);
        cboImageDrm.TabIndex = 56;
        cboImageDrm.SelectedIndexChanged += cboImageDrm_SelectedIndexChanged;
        // 
        // lblImageBackend
        // 
        lblImageBackend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblImageBackend.Location = new Point(893, 129);
        lblImageBackend.Name = "lblImageBackend";
        lblImageBackend.Size = new Size(56, 15);
        lblImageBackend.TabIndex = 57;
        lblImageBackend.Text = "Builder:";
        lblImageBackend.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboImageBackend
        // 
        cboImageBackend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        cboImageBackend.Location = new Point(951, 124);
        cboImageBackend.Name = "cboImageBackend";
        cboImageBackend.Size = new Size(150, 24);
        cboImageBackend.TabIndex = 58;
        cboImageBackend.SelectedIndexChanged += cboImageBackend_SelectedIndexChanged;
        // 
        // chkImageFakeSign
        // 
        chkImageFakeSign.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chkImageFakeSign.AutoSize = true;
        chkImageFakeSign.Checked = true;
        chkImageFakeSign.CheckState = CheckState.Checked;
        chkImageFakeSign.Location = new Point(981, 68);
        chkImageFakeSign.Name = "chkImageFakeSign";
        chkImageFakeSign.Size = new Size(126, 19);
        chkImageFakeSign.TabIndex = 62;
        chkImageFakeSign.Text = "Fake-sign modules";
        // 
        // chkImageRightSprx
        // 
        chkImageRightSprx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chkImageRightSprx.AutoSize = true;
        chkImageRightSprx.Checked = true;
        chkImageRightSprx.CheckState = CheckState.Checked;
        chkImageRightSprx.Location = new Point(981, 97);
        chkImageRightSprx.Name = "chkImageRightSprx";
        chkImageRightSprx.Size = new Size(144, 19);
        chkImageRightSprx.TabIndex = 63;
        chkImageRightSprx.Text = "Inject debug right.sprx";
        // 
        // chkImageDeterministic
        // 
        chkImageDeterministic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chkImageDeterministic.AutoSize = true;
        chkImageDeterministic.Location = new Point(836, 97);
        chkImageDeterministic.Name = "chkImageDeterministic";
        chkImageDeterministic.Size = new Size(126, 19);
        chkImageDeterministic.TabIndex = 64;
        chkImageDeterministic.Text = "Deterministic build";
        // 
        // chkImageAdvancedOptions
        // 
        chkImageAdvancedOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        chkImageAdvancedOptions.AutoSize = true;
        chkImageAdvancedOptions.Location = new Point(981, 37);
        chkImageAdvancedOptions.Name = "chkImageAdvancedOptions";
        chkImageAdvancedOptions.Size = new Size(122, 19);
        chkImageAdvancedOptions.TabIndex = 59;
        chkImageAdvancedOptions.Text = "Advanced options";
        chkImageAdvancedOptions.CheckedChanged += chkImageAdvancedOptions_CheckedChanged;
        // 
        // tabTargetOptions
        // 
        tabTargetOptions.BackColor = SystemColors.Control;
        tabTargetOptions.Controls.Add(lblImageOutput);
        tabTargetOptions.Controls.Add(txtImageOutput);
        tabTargetOptions.Controls.Add(btnImageBrowseOutput);
        tabTargetOptions.Controls.Add(chkImageOverwrite);
        tabTargetOptions.Controls.Add(lblImagePasscode);
        tabTargetOptions.Controls.Add(txtImagePasscode);
        tabTargetOptions.Location = new Point(4, 32);
        tabTargetOptions.Name = "tabTargetOptions";
        tabTargetOptions.Size = new Size(1342, 152);
        tabTargetOptions.TabIndex = 4;
        tabTargetOptions.Text = "Options";
        // 
        // lblImageOutput
        // 
        lblImageOutput.Location = new Point(12, 16);
        lblImageOutput.Name = "lblImageOutput";
        lblImageOutput.Size = new Size(100, 15);
        lblImageOutput.TabIndex = 9;
        lblImageOutput.Text = "Output:";
        lblImageOutput.TextAlign = ContentAlignment.MiddleRight;
        lblImageOutput.Visible = false;
        // 
        // txtImageOutput
        // 
        txtImageOutput.Location = new Point(120, 12);
        txtImageOutput.Name = "txtImageOutput";
        txtImageOutput.Size = new Size(560, 23);
        txtImageOutput.TabIndex = 10;
        txtImageOutput.Visible = false;
        // 
        // btnImageBrowseOutput
        // 
        btnImageBrowseOutput.Location = new Point(688, 12);
        btnImageBrowseOutput.Name = "btnImageBrowseOutput";
        btnImageBrowseOutput.Size = new Size(80, 24);
        btnImageBrowseOutput.TabIndex = 11;
        btnImageBrowseOutput.Text = "Browse...";
        btnImageBrowseOutput.Visible = false;
        btnImageBrowseOutput.Click += btnImageBrowseOutput_Click;
        // 
        // chkImageOverwrite
        // 
        chkImageOverwrite.AutoSize = true;
        chkImageOverwrite.Location = new Point(776, 16);
        chkImageOverwrite.Name = "chkImageOverwrite";
        chkImageOverwrite.Size = new Size(120, 19);
        chkImageOverwrite.TabIndex = 12;
        chkImageOverwrite.Text = "Overwrite existing";
        chkImageOverwrite.Visible = false;
        // 
        // lblImagePasscode
        // 
        lblImagePasscode.Location = new Point(12, 46);
        lblImagePasscode.Name = "lblImagePasscode";
        lblImagePasscode.Size = new Size(100, 15);
        lblImagePasscode.TabIndex = 34;
        lblImagePasscode.Text = "Passcode:";
        lblImagePasscode.TextAlign = ContentAlignment.MiddleRight;
        lblImagePasscode.Visible = false;
        // 
        // txtImagePasscode
        // 
        txtImagePasscode.Location = new Point(120, 42);
        txtImagePasscode.Name = "txtImagePasscode";
        txtImagePasscode.Size = new Size(300, 23);
        txtImagePasscode.TabIndex = 35;
        txtImagePasscode.Visible = false;
        // 
        // toolsFooter
        // 
        toolsFooter.Controls.Add(lblImageStatus);
        toolsFooter.Controls.Add(btnImageRun);
        toolsFooter.Controls.Add(btnImageCancel);
        toolsFooter.Dock = DockStyle.Fill;
        toolsFooter.Location = new Point(10, 317);
        toolsFooter.Margin = new Padding(0);
        toolsFooter.Name = "toolsFooter";
        toolsFooter.Size = new Size(1356, 50);
        toolsFooter.TabIndex = 2;
        // 
        // lblImageStatus
        // 
        lblImageStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblImageStatus.AutoEllipsis = true;
        lblImageStatus.Location = new Point(12, 14);
        lblImageStatus.Name = "lblImageStatus";
        lblImageStatus.Size = new Size(1086, 18);
        lblImageStatus.TabIndex = 20;
        lblImageStatus.Text = "Select a source, then choose an action.";
        // 
        // btnImageRun
        // 
        btnImageRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnImageRun.Location = new Point(1214, 8);
        btnImageRun.Name = "btnImageRun";
        btnImageRun.Size = new Size(130, 30);
        btnImageRun.TabIndex = 21;
        btnImageRun.Text = "Run";
        btnImageRun.Click += btnImageRun_Click;
        // 
        // btnImageCancel
        // 
        btnImageCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnImageCancel.Location = new Point(1110, 8);
        btnImageCancel.Name = "btnImageCancel";
        btnImageCancel.Size = new Size(96, 30);
        btnImageCancel.TabIndex = 22;
        btnImageCancel.Text = "Cancel";
        btnImageCancel.Click += btnImageCancel_Click;
        // 
        // tabTasks
        // 
        tabTasks.BackColor = SystemColors.Control;
        tabTasks.Controls.Add(tasksLayout);
        tabTasks.Location = new Point(4, 32);
        tabTasks.Name = "tabTasks";
        tabTasks.Size = new Size(1376, 375);
        tabTasks.TabIndex = 2;
        tabTasks.Text = "Tasks";
        // 
        // tasksLayout
        // 
        tasksLayout.ColumnCount = 14;
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tasksLayout.Controls.Add(chkTaskAutoStart, 0, 0);
        tasksLayout.Controls.Add(btnTaskStart, 1, 0);
        tasksLayout.Controls.Add(btnTaskCancel, 2, 0);
        tasksLayout.Controls.Add(btnTaskRetry, 3, 0);
        tasksLayout.Controls.Add(btnTaskRemove, 4, 0);
        tasksLayout.Controls.Add(btnTaskOpen, 5, 0);
        tasksLayout.Controls.Add(btnTaskClear, 6, 0);
        tasksLayout.Controls.Add(lblTaskGroup, 7, 0);
        tasksLayout.Controls.Add(cboTaskGroup, 8, 0);
        tasksLayout.Controls.Add(cboTaskFilter, 9, 0);
        tasksLayout.Controls.Add(searchTasks, 10, 0);
        tasksLayout.Controls.Add(btnTaskToggleDetails, 11, 0);
        tasksLayout.Controls.Add(chkTaskFollow, 12, 0);
        tasksLayout.Controls.Add(lblTaskSummary, 13, 0);
        tasksLayout.Controls.Add(splitTasks, 0, 1);
        tasksLayout.Dock = DockStyle.Fill;
        tasksLayout.Location = new Point(0, 0);
        tasksLayout.Name = "tasksLayout";
        tasksLayout.RowCount = 2;
        tasksLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tasksLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tasksLayout.Size = new Size(1376, 375);
        tasksLayout.TabIndex = 0;
        // 
        // chkTaskAutoStart
        // 
        chkTaskAutoStart.Anchor = AnchorStyles.Left;
        chkTaskAutoStart.AutoSize = true;
        chkTaskAutoStart.Location = new Point(3, 9);
        chkTaskAutoStart.Name = "chkTaskAutoStart";
        chkTaskAutoStart.Size = new Size(74, 19);
        chkTaskAutoStart.TabIndex = 0;
        chkTaskAutoStart.Text = "Run queue";
        chkTaskAutoStart.CheckedChanged += chkTaskAutoStart_CheckedChanged;
        // 
        // btnTaskStart
        // 
        btnTaskStart.Anchor = AnchorStyles.Left;
        btnTaskStart.Location = new Point(83, 6);
        btnTaskStart.Name = "btnTaskStart";
        btnTaskStart.Size = new Size(80, 26);
        btnTaskStart.TabIndex = 1;
        btnTaskStart.Text = "Start Next";
        btnTaskStart.Click += btnTaskStart_Click;
        // 
        // btnTaskCancel
        // 
        btnTaskCancel.Anchor = AnchorStyles.Left;
        btnTaskCancel.Location = new Point(169, 6);
        btnTaskCancel.Name = "btnTaskCancel";
        btnTaskCancel.Size = new Size(80, 26);
        btnTaskCancel.TabIndex = 2;
        btnTaskCancel.Text = "Cancel";
        btnTaskCancel.Click += btnTaskCancel_Click;
        // 
        // btnTaskRetry
        // 
        btnTaskRetry.Anchor = AnchorStyles.Left;
        btnTaskRetry.Location = new Point(255, 6);
        btnTaskRetry.Name = "btnTaskRetry";
        btnTaskRetry.Size = new Size(80, 26);
        btnTaskRetry.TabIndex = 3;
        btnTaskRetry.Text = "Retry";
        btnTaskRetry.Click += btnTaskRetry_Click;
        // 
        // btnTaskRemove
        // 
        btnTaskRemove.Anchor = AnchorStyles.Left;
        btnTaskRemove.Location = new Point(341, 6);
        btnTaskRemove.Name = "btnTaskRemove";
        btnTaskRemove.Size = new Size(80, 26);
        btnTaskRemove.TabIndex = 4;
        btnTaskRemove.Text = "Remove";
        btnTaskRemove.Click += btnTaskRemove_Click;
        // 
        // btnTaskOpen
        // 
        btnTaskOpen.Anchor = AnchorStyles.Left;
        btnTaskOpen.Location = new Point(427, 6);
        btnTaskOpen.Name = "btnTaskOpen";
        btnTaskOpen.Size = new Size(90, 26);
        btnTaskOpen.TabIndex = 5;
        btnTaskOpen.Text = "Open Output";
        btnTaskOpen.Click += btnTaskOpen_Click;
        // 
        // btnTaskClear
        // 
        btnTaskClear.Anchor = AnchorStyles.Left;
        btnTaskClear.Location = new Point(523, 6);
        btnTaskClear.Name = "btnTaskClear";
        btnTaskClear.Size = new Size(104, 26);
        btnTaskClear.TabIndex = 6;
        btnTaskClear.Text = "Clear successful";
        btnTaskClear.Click += btnTaskClear_Click;
        // 
        // lblTaskGroup
        // 
        lblTaskGroup.Anchor = AnchorStyles.Left;
        lblTaskGroup.Location = new Point(633, 11);
        lblTaskGroup.Name = "lblTaskGroup";
        lblTaskGroup.Size = new Size(43, 15);
        lblTaskGroup.TabIndex = 7;
        lblTaskGroup.Text = "Group:";
        // 
        // cboTaskGroup
        // 
        cboTaskGroup.Anchor = AnchorStyles.Left;
        cboTaskGroup.Items.AddRange(new object[] { "None", "Status" });
        cboTaskGroup.Location = new Point(683, 7);
        cboTaskGroup.Name = "cboTaskGroup";
        cboTaskGroup.Size = new Size(94, 24);
        cboTaskGroup.TabIndex = 8;
        cboTaskGroup.SelectedIndexChanged += cboTaskGroup_SelectedIndexChanged;
        // 
        // cboTaskFilter
        // 
        cboTaskFilter.Anchor = AnchorStyles.Left;
        cboTaskFilter.Location = new Point(783, 7);
        cboTaskFilter.Name = "cboTaskFilter";
        cboTaskFilter.Size = new Size(124, 24);
        cboTaskFilter.TabIndex = 10;
        cboTaskFilter.SelectedIndexChanged += cboTaskFilter_SelectedIndexChanged;
        // 
        // searchTasks
        // 
        searchTasks.AccessibleDescription = "Filter the task list by title or status.";
        searchTasks.AccessibleName = "Task search";
        searchTasks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        searchTasks.Location = new Point(913, 5);
        searchTasks.Name = "searchTasks";
        searchTasks.Size = new Size(164, 28);
        searchTasks.TabIndex = 10;
        searchTasks.SearchTextChanged += searchTasks_SearchTextChanged;
        // 
        // btnTaskToggleDetails
        // 
        btnTaskToggleDetails.Anchor = AnchorStyles.Left;
        btnTaskToggleDetails.Location = new Point(1083, 6);
        btnTaskToggleDetails.Name = "btnTaskToggleDetails";
        btnTaskToggleDetails.Size = new Size(90, 26);
        btnTaskToggleDetails.TabIndex = 11;
        btnTaskToggleDetails.Text = "Details";
        btnTaskToggleDetails.Click += btnTaskToggleDetails_Click;
        // 
        // chkTaskFollow
        // 
        chkTaskFollow.Anchor = AnchorStyles.Left;
        chkTaskFollow.AutoSize = true;
        chkTaskFollow.Checked = true;
        chkTaskFollow.CheckState = CheckState.Checked;
        chkTaskFollow.Location = new Point(1179, 9);
        chkTaskFollow.Name = "chkTaskFollow";
        chkTaskFollow.Size = new Size(106, 19);
        chkTaskFollow.TabIndex = 10;
        chkTaskFollow.Text = "Follow running";
        chkTaskFollow.CheckedChanged += chkTaskFollow_CheckedChanged;
        // 
        // lblTaskSummary
        // 
        lblTaskSummary.Dock = DockStyle.Fill;
        lblTaskSummary.Location = new Point(1299, 0);
        lblTaskSummary.Name = "lblTaskSummary";
        lblTaskSummary.Size = new Size(74, 38);
        lblTaskSummary.TabIndex = 9;
        lblTaskSummary.Text = "Queue is empty.";
        lblTaskSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // splitTasks
        // 
        tasksLayout.SetColumnSpan(splitTasks, 14);
        splitTasks.AddPane(splitTasksPane1);
        splitTasks.AddPane(splitTasksPane2);
        splitTasks.Dock = DockStyle.Fill;
        splitTasks.Location = new Point(3, 41);
        splitTasks.Name = "splitTasks";
        splitTasks.Orientation = System.Windows.Forms.Orientation.Horizontal;
        splitTasks.Size = new Size(1370, 331);
        splitTasks.TabIndex = 1;
        // 
        // splitTasksPane1
        // 
        splitTasksPane1.Controls.Add(sectionTasksList);
        splitTasksPane1.Location = new Point(0, 0);
        splitTasksPane1.Name = "splitTasksPane1";
        splitTasksPane1.Size = new Size(1370, 163);
        splitTasksPane1.TabIndex = 0;
        // 
        // sectionTasksList
        // 
        sectionTasksList.Controls.Add(gridTasks);
        sectionTasksList.Dock = DockStyle.Fill;
        sectionTasksList.Location = new Point(0, 0);
        sectionTasksList.Margin = new Padding(0);
        sectionTasksList.Name = "sectionTasksList";
        sectionTasksList.SectionHeader = "Task Queue";
        sectionTasksList.Size = new Size(1370, 163);
        sectionTasksList.TabIndex = 0;
        // 
        // gridTasks
        // 
        gridTasks.AccessibleDescription = "Queued, running and finished package tasks.";
        gridTasks.AccessibleName = "Task list";
        gridTasks.AllowUserToAddRows = false;
        gridTasks.AllowUserToDeleteRows = false;
        gridTasks.AllowUserToDragDropRows = false;
        gridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridTasks.AutoSortGroups = true;
        gridTasks.Columns.AddRange(new DataGridViewColumn[] { colTaskName, colTaskOperation, colTaskRoute, colTaskStatus, colTaskStage, colTaskProgress, colTaskElapsed });
        gridTasks.ContextMenuStrip = contextTasks;
        gridTasks.Dock = DockStyle.Fill;
        gridTasks.GroupCellValueComparer = null;
        gridTasks.GroupHeaderColumnIndex = 0;
        gridTasks.GroupHeaderColumnName = null;
        gridTasks.GroupHeaderHeight = 26F;
        gridTasks.GroupLabelFormatter = null;
        gridTasks.Location = new Point(1, 25);
        gridTasks.MultiSelect = false;
        gridTasks.Name = "gridTasks";
        gridTasks.ReadOnly = true;
        gridTasks.RowTemplate.Height = 24;
        gridTasks.Size = new Size(1368, 137);
        gridTasks.TabIndex = 0;
        gridTasks.CellDoubleClick += gridTasks_CellDoubleClick;
        gridTasks.CellMouseDown += gridTasks_CellMouseDown;
        gridTasks.SelectionChanged += gridTasks_SelectionChanged;
        // 
        // colTaskName
        // 
        colTaskName.FillWeight = 220F;
        colTaskName.HeaderText = "Filename";
        colTaskName.Name = "colTaskName";
        colTaskName.ReadOnly = true;
        // 
        // colTaskOperation
        // 
        colTaskOperation.FillWeight = 90F;
        colTaskOperation.HeaderText = "Operation";
        colTaskOperation.Name = "colTaskOperation";
        colTaskOperation.ReadOnly = true;
        // 
        // colTaskRoute
        // 
        colTaskRoute.HeaderText = "From → To";
        colTaskRoute.Name = "colTaskRoute";
        colTaskRoute.ReadOnly = true;
        // 
        // colTaskStatus
        // 
        colTaskStatus.FillWeight = 80F;
        colTaskStatus.HeaderText = "Status";
        colTaskStatus.Name = "colTaskStatus";
        colTaskStatus.ReadOnly = true;
        // 
        // colTaskStage
        // 
        colTaskStage.FillWeight = 130F;
        colTaskStage.HeaderText = "Stage";
        colTaskStage.Name = "colTaskStage";
        colTaskStage.ReadOnly = true;
        // 
        // colTaskProgress
        // 
        colTaskProgress.FillWeight = 60F;
        colTaskProgress.HeaderText = "Progress";
        colTaskProgress.Name = "colTaskProgress";
        colTaskProgress.ReadOnly = true;
        // 
        // colTaskElapsed
        // 
        colTaskElapsed.FillWeight = 60F;
        colTaskElapsed.HeaderText = "Elapsed";
        colTaskElapsed.Name = "colTaskElapsed";
        colTaskElapsed.ReadOnly = true;
        // 
        // contextTasks
        // 
        contextTasks.Items.AddRange(new ToolStripItem[] { menuTaskStart, menuTaskCancel, menuTaskRetry, menuTaskRemove, menuTaskSeparator1, menuTaskOpen, menuTaskShowSource, menuTaskReport, menuTaskClear });
        contextTasks.Name = "contextTasks";
        contextTasks.Size = new Size(164, 187);
        contextTasks.Opening += contextTasks_Opening;
        // 
        // menuTaskStart
        // 
        menuTaskStart.BackColor = SystemColors.Control;
        menuTaskStart.ForeColor = SystemColors.ControlText;
        menuTaskStart.Name = "menuTaskStart";
        menuTaskStart.Size = new Size(163, 22);
        menuTaskStart.Text = "Start Next";
        menuTaskStart.Click += btnTaskStart_Click;
        // 
        // menuTaskCancel
        // 
        menuTaskCancel.BackColor = SystemColors.Control;
        menuTaskCancel.ForeColor = SystemColors.ControlText;
        menuTaskCancel.Name = "menuTaskCancel";
        menuTaskCancel.Size = new Size(163, 22);
        menuTaskCancel.Text = "Cancel";
        menuTaskCancel.Click += btnTaskCancel_Click;
        // 
        // menuTaskRetry
        // 
        menuTaskRetry.BackColor = SystemColors.Control;
        menuTaskRetry.ForeColor = SystemColors.ControlText;
        menuTaskRetry.Name = "menuTaskRetry";
        menuTaskRetry.Size = new Size(163, 22);
        menuTaskRetry.Text = "Retry";
        menuTaskRetry.Click += btnTaskRetry_Click;
        // 
        // menuTaskRemove
        // 
        menuTaskRemove.BackColor = SystemColors.Control;
        menuTaskRemove.ForeColor = SystemColors.ControlText;
        menuTaskRemove.Name = "menuTaskRemove";
        menuTaskRemove.Size = new Size(163, 22);
        menuTaskRemove.Text = "Remove";
        menuTaskRemove.Click += btnTaskRemove_Click;
        // 
        // menuTaskSeparator1
        // 
        menuTaskSeparator1.BackColor = SystemColors.Control;
        menuTaskSeparator1.ForeColor = SystemColors.ControlText;
        menuTaskSeparator1.Margin = new Padding(0, 0, 0, 1);
        menuTaskSeparator1.Name = "menuTaskSeparator1";
        menuTaskSeparator1.Size = new Size(160, 6);
        // 
        // menuTaskOpen
        // 
        menuTaskOpen.BackColor = SystemColors.Control;
        menuTaskOpen.ForeColor = SystemColors.ControlText;
        menuTaskOpen.Name = "menuTaskOpen";
        menuTaskOpen.Size = new Size(163, 22);
        menuTaskOpen.Text = "Open Output";
        menuTaskOpen.Click += btnTaskOpen_Click;
        // 
        // menuTaskShowSource
        // 
        menuTaskShowSource.BackColor = SystemColors.Control;
        menuTaskShowSource.ForeColor = SystemColors.ControlText;
        menuTaskShowSource.Name = "menuTaskShowSource";
        menuTaskShowSource.Size = new Size(163, 22);
        menuTaskShowSource.Text = "Show Source";
        menuTaskShowSource.Click += btnTaskShowSource_Click;
        // 
        // menuTaskReport
        // 
        menuTaskReport.BackColor = SystemColors.Control;
        menuTaskReport.ForeColor = SystemColors.ControlText;
        menuTaskReport.Name = "menuTaskReport";
        menuTaskReport.Size = new Size(163, 22);
        menuTaskReport.Text = "Export Report...";
        menuTaskReport.Click += btnTaskReport_Click;
        // 
        // menuTaskClear
        // 
        menuTaskClear.BackColor = SystemColors.Control;
        menuTaskClear.ForeColor = SystemColors.ControlText;
        menuTaskClear.Name = "menuTaskClear";
        menuTaskClear.Size = new Size(163, 22);
        menuTaskClear.Text = "Clear Completed";
        menuTaskClear.Click += btnTaskClear_Click;
        // 
        // splitTasksPane2
        // 
        splitTasksPane2.Controls.Add(sectionTaskDetails);
        splitTasksPane2.Location = new Point(0, 168);
        splitTasksPane2.Name = "splitTasksPane2";
        splitTasksPane2.Size = new Size(1370, 163);
        splitTasksPane2.TabIndex = 1;
        // 
        // sectionTaskDetails
        // 
        sectionTaskDetails.Controls.Add(taskDetailLayout);
        sectionTaskDetails.Dock = DockStyle.Fill;
        sectionTaskDetails.Location = new Point(0, 0);
        sectionTaskDetails.Margin = new Padding(0);
        sectionTaskDetails.Name = "sectionTaskDetails";
        sectionTaskDetails.SectionHeader = "Task Details";
        sectionTaskDetails.Size = new Size(1370, 163);
        sectionTaskDetails.TabIndex = 0;
        // 
        // taskDetailLayout
        // 
        taskDetailLayout.ColumnCount = 2;
        taskDetailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        taskDetailLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        taskDetailLayout.Controls.Add(lblTaskStage, 0, 0);
        taskDetailLayout.Controls.Add(lblTaskCurrentCaption, 0, 1);
        taskDetailLayout.Controls.Add(barTaskCurrent, 1, 1);
        taskDetailLayout.Controls.Add(lblTaskOverallCaption, 0, 2);
        taskDetailLayout.Controls.Add(barTaskOverall, 1, 2);
        taskDetailLayout.Controls.Add(lblTaskMessage, 0, 3);
        taskDetailLayout.Controls.Add(lblTaskMeta, 0, 4);
        taskDetailLayout.Controls.Add(lblTaskResult, 0, 5);
        taskDetailLayout.Controls.Add(btnTaskDiagnostic, 0, 6);
        taskDetailLayout.Dock = DockStyle.Fill;
        taskDetailLayout.Location = new Point(1, 25);
        taskDetailLayout.Name = "taskDetailLayout";
        taskDetailLayout.Padding = new Padding(10, 2, 10, 4);
        taskDetailLayout.RowCount = 7;
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        taskDetailLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        taskDetailLayout.Size = new Size(1368, 137);
        taskDetailLayout.TabIndex = 0;
        // 
        // lblTaskStage
        // 
        taskDetailLayout.SetColumnSpan(lblTaskStage, 2);
        lblTaskStage.Dock = DockStyle.Fill;
        lblTaskStage.Location = new Point(13, 2);
        lblTaskStage.Name = "lblTaskStage";
        lblTaskStage.Size = new Size(1342, 20);
        lblTaskStage.TabIndex = 0;
        lblTaskStage.Text = "No task selected.";
        lblTaskStage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTaskCurrentCaption
        // 
        lblTaskCurrentCaption.Dock = DockStyle.Fill;
        lblTaskCurrentCaption.Location = new Point(13, 22);
        lblTaskCurrentCaption.Name = "lblTaskCurrentCaption";
        lblTaskCurrentCaption.Size = new Size(114, 22);
        lblTaskCurrentCaption.TabIndex = 1;
        lblTaskCurrentCaption.Text = "Step progress";
        lblTaskCurrentCaption.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // barTaskCurrent
        // 
        barTaskCurrent.Dock = DockStyle.Fill;
        barTaskCurrent.Location = new Point(133, 25);
        barTaskCurrent.Name = "barTaskCurrent";
        barTaskCurrent.Size = new Size(1222, 16);
        barTaskCurrent.TabIndex = 2;
        // 
        // lblTaskOverallCaption
        // 
        lblTaskOverallCaption.Dock = DockStyle.Fill;
        lblTaskOverallCaption.Location = new Point(13, 44);
        lblTaskOverallCaption.Name = "lblTaskOverallCaption";
        lblTaskOverallCaption.Size = new Size(114, 22);
        lblTaskOverallCaption.TabIndex = 3;
        lblTaskOverallCaption.Text = "Task steps";
        lblTaskOverallCaption.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // barTaskOverall
        // 
        barTaskOverall.Dock = DockStyle.Fill;
        barTaskOverall.Location = new Point(133, 47);
        barTaskOverall.Name = "barTaskOverall";
        barTaskOverall.Size = new Size(1222, 16);
        barTaskOverall.TabIndex = 4;
        // 
        // lblTaskMessage
        // 
        lblTaskMessage.AutoEllipsis = true;
        taskDetailLayout.SetColumnSpan(lblTaskMessage, 2);
        lblTaskMessage.Dock = DockStyle.Fill;
        lblTaskMessage.Location = new Point(13, 66);
        lblTaskMessage.Name = "lblTaskMessage";
        lblTaskMessage.Size = new Size(1342, 18);
        lblTaskMessage.TabIndex = 5;
        lblTaskMessage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTaskMeta
        // 
        lblTaskMeta.AutoEllipsis = true;
        taskDetailLayout.SetColumnSpan(lblTaskMeta, 2);
        lblTaskMeta.Dock = DockStyle.Fill;
        lblTaskMeta.Location = new Point(13, 84);
        lblTaskMeta.Name = "lblTaskMeta";
        lblTaskMeta.Size = new Size(1342, 1);
        lblTaskMeta.TabIndex = 6;
        lblTaskMeta.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTaskResult
        // 
        lblTaskResult.AutoEllipsis = true;
        taskDetailLayout.SetColumnSpan(lblTaskResult, 2);
        lblTaskResult.Dock = DockStyle.Fill;
        lblTaskResult.Location = new Point(13, 85);
        lblTaskResult.Name = "lblTaskResult";
        lblTaskResult.Size = new Size(1342, 20);
        lblTaskResult.TabIndex = 7;
        lblTaskResult.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnTaskDiagnostic
        // 
        taskDetailLayout.SetColumnSpan(btnTaskDiagnostic, 2);
        btnTaskDiagnostic.Location = new Point(13, 108);
        btnTaskDiagnostic.Name = "btnTaskDiagnostic";
        btnTaskDiagnostic.Size = new Size(160, 22);
        btnTaskDiagnostic.TabIndex = 8;
        btnTaskDiagnostic.Text = "Diagnostic...";
        btnTaskDiagnostic.Click += btnTaskDiagnostic_Click;
        // 
        // tabLog
        // 
        tabLog.BackColor = SystemColors.Control;
        tabLog.Controls.Add(txtLogView);
        tabLog.Controls.Add(lblLogLevel);
        tabLog.Controls.Add(cboLogLevel);
        tabLog.Controls.Add(chkLogAutoScroll);
        tabLog.Controls.Add(btnLogClear);
        tabLog.Controls.Add(btnLogOpenFolder);
        tabLog.Location = new Point(4, 32);
        tabLog.Name = "tabLog";
        tabLog.Padding = new Padding(0, 36, 0, 0);
        tabLog.Size = new Size(1376, 375);
        tabLog.TabIndex = 3;
        tabLog.Text = "Log";
        // 
        // txtLogView
        // 
        txtLogView.Dock = DockStyle.Fill;
        txtLogView.Font = new Font("Consolas", 9F);
        txtLogView.Location = new Point(0, 36);
        txtLogView.Name = "txtLogView";
        txtLogView.ReadOnly = true;
        txtLogView.SelectionColor = Color.Gainsboro;
        txtLogView.SelectionFont = new Font("Consolas", 9F);
        txtLogView.Size = new Size(1376, 339);
        txtLogView.TabIndex = 5;
        txtLogView.TextPadding = new Padding(3);
        txtLogView.WordWrap = false;
        // 
        // lblLogLevel
        // 
        lblLogLevel.Location = new Point(8, 10);
        lblLogLevel.Name = "lblLogLevel";
        lblLogLevel.Size = new Size(44, 15);
        lblLogLevel.TabIndex = 0;
        lblLogLevel.Text = "Show:";
        // 
        // cboLogLevel
        // 
        cboLogLevel.Items.AddRange(new object[] { "All", "Info", "Warning", "Error" });
        cboLogLevel.Location = new Point(54, 6);
        cboLogLevel.Name = "cboLogLevel";
        cboLogLevel.Size = new Size(110, 24);
        cboLogLevel.TabIndex = 1;
        cboLogLevel.SelectedIndexChanged += cboLogLevel_SelectedIndexChanged;
        // 
        // chkLogAutoScroll
        // 
        chkLogAutoScroll.AutoSize = true;
        chkLogAutoScroll.Location = new Point(178, 9);
        chkLogAutoScroll.Name = "chkLogAutoScroll";
        chkLogAutoScroll.Size = new Size(85, 19);
        chkLogAutoScroll.TabIndex = 2;
        chkLogAutoScroll.Text = "Auto-scroll";
        chkLogAutoScroll.CheckedChanged += chkLogAutoScroll_CheckedChanged;
        // 
        // btnLogClear
        // 
        btnLogClear.Location = new Point(286, 5);
        btnLogClear.Name = "btnLogClear";
        btnLogClear.Size = new Size(70, 26);
        btnLogClear.TabIndex = 3;
        btnLogClear.Text = "Clear";
        btnLogClear.Click += btnLogClear_Click;
        // 
        // btnLogOpenFolder
        // 
        btnLogOpenFolder.Location = new Point(364, 5);
        btnLogOpenFolder.Name = "btnLogOpenFolder";
        btnLogOpenFolder.Size = new Size(130, 26);
        btnLogOpenFolder.TabIndex = 4;
        btnLogOpenFolder.Text = "Open log folder";
        btnLogOpenFolder.Click += btnLogOpenFolder_Click;
        // 
        // colFileName
        // 
        colFileName.Text = "Name";
        colFileName.Width = 260;
        // 
        // colFileType
        // 
        colFileType.Text = "Type";
        colFileType.Width = 100;
        // 
        // colFilePath
        // 
        colFilePath.Text = "Path";
        colFilePath.Width = 420;
        // 
        // colFileSize
        // 
        colFileSize.Text = "Size";
        colFileSize.TextAlign = HorizontalAlignment.Right;
        colFileSize.Width = 30;
        // 
        // imageSaveDialog
        // 
        imageSaveDialog.Title = "Select the output image";
        // 
        // trophyCsvSaveDialog
        // 
        trophyCsvSaveDialog.DefaultExt = "csv";
        trophyCsvSaveDialog.FileName = "trophies.csv";
        trophyCsvSaveDialog.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
        trophyCsvSaveDialog.Title = "Export trophies";
        // 
        // statusMain
        // 
        statusMain.Items.AddRange(new ToolStripItem[] { statusLabel, statusSpring, statusCount });
        statusMain.Location = new Point(0, 851);
        statusMain.Name = "statusMain";
        statusMain.Padding = new Padding(0, 4, 0, 4);
        statusMain.Size = new Size(1384, 30);
        statusMain.TabIndex = 3;
        // 
        // statusLabel
        // 
        statusLabel.BackColor = SystemColors.Control;
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(39, 17);
        statusLabel.Text = "Ready";
        // 
        // statusSpring
        // 
        statusSpring.BackColor = SystemColors.Control;
        statusSpring.Name = "statusSpring";
        statusSpring.Size = new Size(1294, 17);
        statusSpring.Spring = true;
        // 
        // statusCount
        // 
        statusCount.BackColor = SystemColors.Control;
        statusCount.Name = "statusCount";
        statusCount.Size = new Size(51, 17);
        statusCount.Text = "0 games";
        // 
        // packageOpenDialog
        // 
        packageOpenDialog.DefaultExt = "ffpfsc";
        packageOpenDialog.Filter = resources.GetString("packageOpenDialog.Filter");
        packageOpenDialog.Title = "Open a PS5 package or filesystem image";
        // 
        // sourceImageOpenDialog
        // 
        sourceImageOpenDialog.Filter = "PS5 filesystem images (*.exfat;*.ffpkg)|*.exfat;*.ffpkg|All files (*.*)|*.*";
        sourceImageOpenDialog.Title = "Select a PS5 filesystem image";
        // 
        // containedFileSaveDialog
        // 
        containedFileSaveDialog.Filter = "All files (*.*)|*.*";
        containedFileSaveDialog.Title = "Extract file from FFPFSC";
        // 
        // artworkSaveDialog
        // 
        artworkSaveDialog.DefaultExt = "png";
        artworkSaveDialog.FileName = "artwork.png";
        artworkSaveDialog.Filter = "PNG image (*.png)|*.png|JPEG image (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|All files (*.*)|*.*";
        artworkSaveDialog.Title = "Save artwork image";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1384, 881);
        Controls.Add(splitMain);
        Controls.Add(statusMain);
        Controls.Add(menuMain);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MainMenuStrip = menuMain;
        MinimumSize = new Size(1050, 700);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PS5 PKG Tool";
        FormClosing += MainForm_FormClosing;
        Shown += MainForm_Shown;
        KeyDown += MainForm_KeyDown;
        menuMain.ResumeLayout(false);
        menuMain.PerformLayout();
        contextLibrary.ResumeLayout(false);
        splitMain.ResumeLayout(false);
        splitMainPane1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridLibrary).EndInit();
        splitMainPane2.ResumeLayout(false);
        tabsWorkspace.ResumeLayout(false);
        tabWorkspaceGeneral.ResumeLayout(false);
        tabsDetails.ResumeLayout(false);
        tabOverview.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridOverview).EndInit();
        tabArtwork.ResumeLayout(false);
        splitArtwork.ResumeLayout(false);
        splitArtworkPane1.ResumeLayout(false);
        sectionIcon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureIcon).EndInit();
        contextArtwork.ResumeLayout(false);
        splitArtworkPane2.ResumeLayout(false);
        sectionBackground.ResumeLayout(false);
        tabsBackgrounds.ResumeLayout(false);
        tabPic0.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBackground0).EndInit();
        tabPic1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBackground1).EndInit();
        tabPic2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBackground2).EndInit();
        tabTrophies.ResumeLayout(false);
        tabTrophies.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridTrophies).EndInit();
        contextTrophies.ResumeLayout(false);
        tabActivities.ResumeLayout(false);
        tabsUds.ResumeLayout(false);
        tabUdsEvents.ResumeLayout(false);
        splitUdsEvents.ResumeLayout(false);
        splitUdsEventsPane1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridUdsEvents).EndInit();
        splitUdsEventsPane2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridUdsEventProperties).EndInit();
        tabUdsStats.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridUdsStats).EndInit();
        tabUdsEnums.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridUdsEnums).EndInit();
        tabUdsRules.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridUdsRules).EndInit();
        tabFiles.ResumeLayout(false);
        sectionFileBrowser.ResumeLayout(false);
        splitFileBrowser.ResumeLayout(false);
        splitFileBrowserPane1.ResumeLayout(false);
        contextTreeFiles.ResumeLayout(false);
        splitFileBrowserPane2.ResumeLayout(false);
        splitFileContentPreview.ResumeLayout(false);
        splitFileContentPreviewPane1.ResumeLayout(false);
        fileListPanel.ResumeLayout(false);
        contextFiles.ResumeLayout(false);
        splitFileContentPreviewPane2.ResumeLayout(false);
        sectionFileViewer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureFileViewer).EndInit();
        tabExecutable.ResumeLayout(false);
        tabsExecutable.ResumeLayout(false);
        tabExecModules.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridModules).EndInit();
        tabExecElf.ResumeLayout(false);
        splitExecElf.ResumeLayout(false);
        splitExecElfPane1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridElfPrograms).EndInit();
        splitExecElfPane2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridElfSections).EndInit();
        tabExecSelf.ResumeLayout(false);
        splitExecSelf.ResumeLayout(false);
        splitExecSelfPane1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridSelfHeader).EndInit();
        splitExecSelfPane2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridSelfSegments).EndInit();
        tabRaw.ResumeLayout(false);
        tabPackage.ResumeLayout(false);
        tabsPackage.ResumeLayout(false);
        tabPkgContainer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPkgHeader).EndInit();
        tabPkgSegments.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPkgSegments).EndInit();
        tabPkgEntries.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPkgEntries).EndInit();
        tabMetadata.ResumeLayout(false);
        tabsMetadata.ResumeLayout(false);
        tabPkgSfo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridParamSfo).EndInit();
        tabPkgKeystone.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridKeystone).EndInit();
        tabPkgPlayGo.ResumeLayout(false);
        tabsPlayGo.ResumeLayout(false);
        tabPlayGoChunks.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPlayGoChunks).EndInit();
        tabPlayGoScenarios.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPlayGoScenarios).EndInit();
        tabPlayGoFiles.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridPlayGoFiles).EndInit();
        tabPkgSi.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridSi).EndInit();
        tabWorkspaceTools.ResumeLayout(false);
        toolsLayout.ResumeLayout(false);
        sectionJob.ResumeLayout(false);
        tabsImageTargets.ResumeLayout(false);
        tabTargetExfat.ResumeLayout(false);
        tabTargetExfat.PerformLayout();
        tabTargetFfpkg.ResumeLayout(false);
        tabTargetFfpkg.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudImageMinFree).EndInit();
        tabTargetFfpfsc.ResumeLayout(false);
        tabTargetFfpfsc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudImageLevel).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudImageGain).EndInit();
        tabTargetDebug.ResumeLayout(false);
        tabTargetDebug.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudImagePlayGoChunks).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudImageKrakenThreads).EndInit();
        tabTargetOptions.ResumeLayout(false);
        tabTargetOptions.PerformLayout();
        toolsFooter.ResumeLayout(false);
        tabTasks.ResumeLayout(false);
        tasksLayout.ResumeLayout(false);
        tasksLayout.PerformLayout();
        splitTasks.ResumeLayout(false);
        splitTasksPane1.ResumeLayout(false);
        sectionTasksList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
        contextTasks.ResumeLayout(false);
        splitTasksPane2.ResumeLayout(false);
        sectionTaskDetails.ResumeLayout(false);
        taskDetailLayout.ResumeLayout(false);
        tabLog.ResumeLayout(false);
        tabLog.PerformLayout();
        statusMain.ResumeLayout(false);
        statusMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}