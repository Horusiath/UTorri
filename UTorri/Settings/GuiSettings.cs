using System.Linq;

namespace UTorri.Settings
{
    /// <summary>
    /// Gui-oriented settings container.
    /// </summary>
    public class GuiSettings : SettingsBase
    {
        public bool GranularPriority
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiGranularPriority];
            }
            set
            {
                _parent[AppSettingsKeys.guiGranularPriority] = value;
            }
        }
        public bool OverheadInStatusbar
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiOverheadInStatusbar];
            }
            set
            {
                _parent[AppSettingsKeys.guiOverheadInStatusbar] = value;
            }
        }
        public bool ShowAvIcon
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiShowAvIcon];
            }
            set
            {
                _parent[AppSettingsKeys.guiShowAvIcon] = value;
            }
        }
        public int[] UploadRateMenu
        {
            get
            {
                return _parent[AppSettingsKeys.guiUploadRateMenu].ToString().Split(',')
                    .Select(x=>int.Parse(x)).ToArray();
            }
            set
            {
                _parent[AppSettingsKeys.guiUploadRateMenu] = string.Join(",", value.Select(x=>x.ToString()).ToArray());
            }
        }

        public int[] DownloadRateMenu
        {
            get
            {
                return _parent[AppSettingsKeys.guidDownloadRateMenu].ToString().Split(',')
                    .Select(x => int.Parse(x)).ToArray();
            }
            set
            {
                _parent[AppSettingsKeys.guidDownloadRateMenu] = string.Join(",", value.Select(x => x.ToString()).ToArray());
            }
        }
        public bool ManualRateMenu
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiManualRateMenu];
            }
            set
            {
                _parent[AppSettingsKeys.guiManualRateMenu] = value;
            }
        }
        public bool AutoRestart
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiAutoRestart];
            }
            set
            {
                _parent[AppSettingsKeys.guiAutoRestart] = value;
            }
        }
        public bool ReportProblems
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiReportProblems];
            }
            set
            {
                _parent[AppSettingsKeys.guiReportProblems] = value;
            }
        }
        public string PersistentLabels
        {
            get
            {
                return _parent[AppSettingsKeys.guiPersistentLabels].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.guiPersistentLabels] = value;
            }
        }
        public bool CompatibileDirectoryOpen
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiCompatibileDirOpen];
            }
            set
            {
                _parent[AppSettingsKeys.guiCompatibileDirOpen] = value;
            }
        }
        public bool AlternateColor
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiAlternateColor];
            }
            set
            {
                _parent[AppSettingsKeys.guiAlternateColor] = value;
            }
        }
        public bool TransparentGraphLegend
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiTransparentGraphLegend];
            }
            set
            {
                _parent[AppSettingsKeys.guiTransparentGraphLegend] = value;
            }
        }
        public bool CombineListviewStatusDone
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiComineListviewStatusDone];
            }
            set
            {
                _parent[AppSettingsKeys.guiComineListviewStatusDone] = value;
            }
        }
        public bool LogDate
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiLogDate];
            }
            set
            {
                _parent[AppSettingsKeys.guiLogDate] = value;
            }
        }
        public bool ColorProgressBar
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiColorProgressBars];
            }
            set
            {
                _parent[AppSettingsKeys.guiColorProgressBars] = value;
            }
        }

        public bool DeleteToTrash
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiDeleteToTrash];
            }
            set
            {
                _parent[AppSettingsKeys.guiDeleteToTrash] = value;
            }
        }
        public int DefaultDeleteAction
        {
            get
            {
                return (int)_parent[AppSettingsKeys.guiDeleteAction];
            }
            set
            {
                _parent[AppSettingsKeys.guiDeleteAction] = value;
            }
        }
        public bool SpeedInTitle
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiSpeedInTitle];
            }
            set
            {
                _parent[AppSettingsKeys.guiSpeedInTitle] = value;
            }
        }
        public bool LimitsInStatusbar
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiLimitsInStatusbar];
            }
            set
            {
                _parent[AppSettingsKeys.guiLimitsInStatusbar] = value;
            }
        }
        public bool GraphicProgress
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiGraphicProgress];
            }
            set
            {
                _parent[AppSettingsKeys.guiGraphicProgress] = value;
            }
        }
        public bool PiecebarProgress
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiPiecebarProgress];
            }
            set
            {
                _parent[AppSettingsKeys.guiPiecebarProgress] = value;
            }
        }
        public bool ShowStatusIconInDownloadList
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiShowStatusIconInDownloadList];
            }
            set
            {
                _parent[AppSettingsKeys.guiShowStatusIconInDownloadList] = value;
            }
        }

        public int UpdateRate
        {
            get
            {
                return (int)_parent[AppSettingsKeys.guiUpdateRate];
            }
            set
            {
                _parent[AppSettingsKeys.guiUpdateRate] = value;
            }
        }
        public bool TallCategoryList
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiTallCategoryList];
            }
            set
            {
                _parent[AppSettingsKeys.guiTallCategoryList] = value;
            }
        }
        public bool WideToolbar
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiWideToolbar];
            }
            set
            {
                _parent[AppSettingsKeys.guiWideToolbar] = value;
            }
        }
        public bool FindPane
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiFindPane];
            }
            set
            {
                _parent[AppSettingsKeys.guiFindPane] = value;
            }
        }
        public bool ToolbarLabels
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiToolbarLabels];
            }
            set
            {
                _parent[AppSettingsKeys.guiToolbarLabels] = value;
            }
        }
        public bool CategoryListSpaces
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiCategoryListSpaces];
            }
            set
            {
                _parent[AppSettingsKeys.guiCategoryListSpaces] = value;
            }
        }
        public bool GraphTcpRateControl
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiGraphTcpRateControl];
            }
            set
            {
                _parent[AppSettingsKeys.guiGraphTcpRateControl] = value;
            }
        }
        public bool GraphOverhead
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiGraphOverhead];
            }
            set
            {
                _parent[AppSettingsKeys.guiGraphOverhead] = value;
            }
        }
        public bool GraphLegend
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.guiGraphLegend];
            }
            set
            {
                _parent[AppSettingsKeys.guiGraphLegend] = value;
            }
        }
        protected internal GuiSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
