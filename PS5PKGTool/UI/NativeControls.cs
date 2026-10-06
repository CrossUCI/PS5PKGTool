using System.ComponentModel;

namespace PS5PKGTool.UI.Controls;

public class AppButton : Button { }

public class AppCheckBox : CheckBox { }

public class AppComboBox : ComboBox { }

public class AppContextMenu : ContextMenuStrip { }

public class AppDataGridView : DataGridView
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AllowUserToDragDropRows { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AutoSortGroups { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int GroupHeaderColumnIndex { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string? GroupHeaderColumnName { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public float GroupHeaderHeight { get; set; } = 26;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<object?, object?, int>? GroupCellValueComparer { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<object?, int, string>? GroupLabelFormatter { get; set; }

    public bool IsGrouped => _groups is not null;

    private List<GroupState>? _groups;
    private Action<DataGridViewRow, object?>? _fillGroupRow;
    private Font? _groupHeaderFont;

    public AppDataGridView()
    {
        CellDoubleClick += (_, e) =>
        {
            if (e.RowIndex < 0 || !IsGroupRow(e.RowIndex)) return;
            GroupState group = (GroupState)Rows[e.RowIndex].Tag!;
            group.Expanded = !group.Expanded;
            UpdateGroupRows(group);
        };
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _groupHeaderFont?.Dispose();
            _groupHeaderFont = null;
        }
        base.Dispose(disposing);
    }

    public void SetGroups<T>(
        IEnumerable<T> items,
        Func<T, object?> keySelector,
        Action<DataGridViewRow, T> fillRow,
        IComparer<object>? groupComparer = null)
    {
        _groups = [];
        _fillGroupRow = (row, item) => fillRow(row, (T)item!);
        foreach (T item in items)
        {
            object? key = keySelector(item);
            GroupState? group = _groups.FirstOrDefault(candidate => Equals(candidate.Key, key));
            if (group is null)
            {
                group = new GroupState(key);
                _groups.Add(group);
            }
            group.Items.Add(item);
        }

        if (groupComparer is not null)
            _groups.Sort((left, right) => groupComparer.Compare(left.Key!, right.Key!));

        RebuildGroupRows();
    }

    public void ClearGroups() => _groups = null;

    public bool IsGroupRow(int rowIndex) =>
        rowIndex >= 0 && rowIndex < Rows.Count && Rows[rowIndex].Tag is GroupState;

    public bool IsGroupRow(DataGridViewRow row) => row.Tag is GroupState;

    public IEnumerable<T> GetGroupItems<T>(int rowIndex) =>
        IsGroupRow(rowIndex) ? ((GroupState)Rows[rowIndex].Tag!).Items.OfType<T>() : [];

    public void SortGroups(int columnIndex, ListSortDirection direction)
    {
        if (_groups is null || _fillGroupRow is null || columnIndex < 0 || columnIndex >= Columns.Count) return;

        int directionFactor = direction == ListSortDirection.Ascending ? 1 : -1;
        foreach (GroupState group in _groups)
        {
            var rows = new List<(object? Item, object? Value)>();
            foreach (object? item in group.Items)
            {
                using var row = new DataGridViewRow();
                row.CreateCells(this);
                _fillGroupRow(row, item);
                rows.Add((item, row.Cells[columnIndex].Value));
            }

            rows.Sort((left, right) => directionFactor * CompareGroupValues(left.Value, right.Value));
            group.Items.Clear();
            group.Items.AddRange(rows.Select(pair => pair.Item));
        }

        RebuildGroupRows();
    }

    private int CompareGroupValues(object? left, object? right)
    {
        if (GroupCellValueComparer is not null) return GroupCellValueComparer(left, right);
        if (left is null) return right is null ? 0 : -1;
        if (right is null) return 1;
        if (left is IComparable comparable && left.GetType() == right.GetType())
            return comparable.CompareTo(right);
        return string.Compare(left.ToString(), right.ToString(), StringComparison.CurrentCultureIgnoreCase);
    }

    private void RebuildGroupRows()
    {
        if (_groups is null || _fillGroupRow is null) return;

        Rows.Clear();
        foreach (GroupState group in _groups)
        {
            int headerIndex = Rows.Add();
            DataGridViewRow header = Rows[headerIndex];
            header.Tag = group;
            header.ReadOnly = true;
            header.Height = Math.Max(18, (int)GroupHeaderHeight);
            header.DefaultCellStyle.BackColor = SystemColors.ControlLight;
            header.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            _groupHeaderFont ??= new Font(Font, FontStyle.Bold);
            header.DefaultCellStyle.Font = _groupHeaderFont;
            int columnIndex = ResolveGroupHeaderColumn();
            if (columnIndex >= 0)
            {
                object? value = group.Key;
                header.Cells[columnIndex].Value = GroupLabelFormatter?.Invoke(value, group.Items.Count)
                    ?? $"{value} ({group.Items.Count})";
            }

            foreach (object? item in group.Items)
            {
                int rowIndex = Rows.Add();
                DataGridViewRow row = Rows[rowIndex];
                _fillGroupRow(row, item);
                row.Visible = group.Expanded;
            }
        }
    }

    private int ResolveGroupHeaderColumn()
    {
        if (GroupHeaderColumnName is { Length: > 0 } name && Columns.Contains(name))
            return Columns[name]!.Index;
        return GroupHeaderColumnIndex >= 0 && GroupHeaderColumnIndex < Columns.Count
            ? GroupHeaderColumnIndex
            : -1;
    }

    private void UpdateGroupRows(GroupState group)
    {
        int headerIndex = Rows.Cast<DataGridViewRow>().ToList().FindIndex(row => ReferenceEquals(row.Tag, group));
        if (headerIndex < 0) return;
        for (int index = headerIndex + 1; index < Rows.Count && Rows[index].Tag is not GroupState; index++)
            Rows[index].Visible = group.Expanded;
    }

    private sealed class GroupState(object? key)
    {
        public object? Key { get; } = key;
        public List<object?> Items { get; } = [];
        public bool Expanded { get; set; } = true;
    }
}

public class AppFooterBar : Panel { }

public class AppLabel : Label { }

public class AppListBox : ListBox { }

public class AppListView : ListView
{
    public void RefreshLayout() => PerformLayout();
}

public class AppMenuStrip : MenuStrip { }

public class AppNumericUpDown : NumericUpDown { }

public class AppPanel : Panel { }

public class AppProgressBar : ProgressBar { }

public class AppRichTextBox : RichTextBox
{
    public RichTextBox InnerRichTextBox => this;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Padding TextPadding
    {
        get => Padding;
        set => Padding = value;
    }
}

public class AppSectionPanel : GroupBox
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SectionHeader
    {
        get => Text;
        set => Text = value;
    }
}

public class AppStatusStrip : StatusStrip { }

public class AppTabControl : TabControl { }

public class AppTabPage : TabPage { }

public class AppTableLayoutPanel : TableLayoutPanel { }

public class AppTextBox : TextBox { }

public class AppToolStripSeparator : ToolStripSeparator { }

public class AppToolStripStatusLabel : ToolStripStatusLabel { }

public class AppTreeView : TreeView { }

public class AppSearchBox : TextBox
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Placeholder
    {
        get => PlaceholderText;
        set => PlaceholderText = value;
    }

    public event EventHandler? SearchTextChanged;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SearchText
    {
        get => Text;
        set => Text = value;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        SearchTextChanged?.Invoke(this, e);
    }
}

public class AppChipsPanel : FlowLayoutPanel
{
    public AppChipsPanel() { }

    public AppChipsPanel(IContainer container) => container.Add(this);

    public void AddChip(string text, EventHandler onClick)
    {
        var chip = new Button
        {
            AutoSize = true,
            Text = text,
            UseVisualStyleBackColor = true
        };
        chip.Click += onClick;
        Controls.Add(chip);
    }
}

public class AppCheckedComboBox : UserControl
{
    private readonly Button _button = new() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
    private readonly CheckedListBox _itemsList = new() { BorderStyle = BorderStyle.None, CheckOnClick = true, IntegralHeight = false };
    private readonly ToolStripDropDown _dropDown = new();
    private bool _settingChecks;

    public AppCheckedComboBox()
    {
        Padding = Padding.Empty;
        Controls.Add(_button);
        _button.Click += (_, _) => ShowDropDown();
        _itemsList.ItemCheck += (_, _) =>
        {
            if (_settingChecks || !IsHandleCreated) return;
            BeginInvoke((Action)(() =>
            {
                UpdateButtonText();
                CheckedItemsChanged?.Invoke(this, EventArgs.Empty);
            }));
        };

        var host = new ToolStripControlHost(_itemsList)
        {
            AutoSize = false,
            Margin = Padding.Empty,
            Padding = Padding.Empty
        };
        _dropDown.Padding = Padding.Empty;
        _dropDown.Items.Add(host);
        _dropDown.Opening += (_, _) =>
        {
            host.Size = new Size(Math.Max(Width, 160), Math.Min(Math.Max(_itemsList.PreferredHeight, 60), 240));
            _itemsList.Size = host.Size;
        };
    }

    public AppCheckedComboBox(IContainer container) : this() => container.Add(this);

    public CheckedListBox.ObjectCollection Items => _itemsList.Items;

    public CheckedListBox.CheckedItemCollection CheckedItems => _itemsList.CheckedItems;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int ItemHeight
    {
        get => _itemsList.ItemHeight;
        set => _itemsList.ItemHeight = value;
    }

    public event EventHandler? CheckedItemsChanged;

    public void SetAllItemsChecked(bool isChecked)
    {
        _settingChecks = true;
        try
        {
            for (int i = 0; i < Items.Count; i++)
                _itemsList.SetItemChecked(i, isChecked);
        }
        finally
        {
            _settingChecks = false;
        }
        UpdateButtonText();
        CheckedItemsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetItemChecked(int index, bool isChecked)
    {
        if (_itemsList.GetItemChecked(index) == isChecked) return;
        _settingChecks = true;
        try { _itemsList.SetItemChecked(index, isChecked); }
        finally { _settingChecks = false; }
        UpdateButtonText();
        CheckedItemsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void ShowDropDown()
    {
        _dropDown.Show(this, new Point(0, Height));
    }

    private void UpdateButtonText()
    {
        string[] values = CheckedItems.Cast<object>().Select(item => item.ToString() ?? string.Empty).ToArray();
        _button.Text = values.Length == 0 ? string.Empty : string.Join(", ", values);
    }
}

public class AppSplitPane : Panel { }

public class AppSplitContainer : SplitContainer
{
    private AppSplitPane? _splitPane1;
    private AppSplitPane? _splitPane2;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int[] PanelSizes
    {
        get
        {
            int extent = base.Orientation == System.Windows.Forms.Orientation.Horizontal
                ? Height - SplitterWidth
                : Width - SplitterWidth;
            int first = Math.Clamp(SplitterDistance, 0, Math.Max(0, extent));
            return [first, Math.Max(0, extent - first)];
        }
        set
        {
            if (value is { Length: > 0 })
                SetPanelSize(0, value[0]);
        }
    }

    public IReadOnlyList<AppSplitPane> Panels =>
        new[] { _splitPane1, _splitPane2 }.Where(pane => pane is not null).Cast<AppSplitPane>().ToArray();

    public int PanelCount => Panels.Count;

    public AppSplitContainer()
    {
        Panel1MinSize = 40;
        Panel2MinSize = 40;
    }

    public void SetPanelSize(int panelIndex, int size)
    {
        if (panelIndex is < 0 or > 1)
            throw new ArgumentOutOfRangeException(nameof(panelIndex));

        int extent = base.Orientation == System.Windows.Forms.Orientation.Horizontal
            ? Height - SplitterWidth
            : Width - SplitterWidth;
        if (extent <= Panel1MinSize + Panel2MinSize)
            return;

        int distance = panelIndex == 0 ? size : extent - size;
        SplitterDistance = Math.Clamp(distance, Panel1MinSize, extent - Panel2MinSize);
    }

    public void RemovePanel(AppSplitPane pane)
    {
        if (ReferenceEquals(pane, _splitPane1))
        {
            Panel1.Controls.Remove(pane);
            _splitPane1 = null;
        }
        else if (ReferenceEquals(pane, _splitPane2))
        {
            Panel2.Controls.Remove(pane);
            _splitPane2 = null;
            Panel2Collapsed = true;
        }
    }

    public void AddPanel(AppSplitPane pane)
    {
        if (_splitPane2 is null)
        {
            _splitPane2 = pane;
            pane.Dock = DockStyle.Fill;
            Panel2.Controls.Add(pane);
        }
        Panel2Collapsed = false;
    }

    public void AddPane(AppSplitPane pane)
    {
        ArgumentNullException.ThrowIfNull(pane);
        pane.Dock = DockStyle.Fill;
        if (_splitPane1 is null)
        {
            _splitPane1 = pane;
            Panel1.Controls.Add(pane);
        }
        else
        {
            _splitPane2 = pane;
            Panel2.Controls.Add(pane);
        }
    }
}
