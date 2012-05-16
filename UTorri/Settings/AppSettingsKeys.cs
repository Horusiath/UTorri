namespace UTorri.Settings
{
    /// <summary>
    /// Container of keys for application settings parameters.
    /// </summary>
    public class AppSettingsKeys
    {
        #region Webui keys

        public const string webuiEnable = "webui.enable";
        public const string webuiEnableGuest = "webui.enable_guest";
        public const string webuiEnableListen = "webui.enable_listen";
        public const string webuiTokenAuth = "webui.token_auth";
        public const string webuiUsername = "webui.username";
        public const string webuiPassword = "webui.password";
        public const string webuiUconnectEnable = "webui.uconnect_enable";
        public const string webuiUconnectUsername = "webui.uconnect_username";
        public const string webuiUconnectPassword = "webui.uconnect_password";
        public const string webuiUconnectUsernameAnonymous = "webui.uconnect_username_anonymous";
        public const string webuiUconnectQuestionOptedOut = "webui.uconnect_question_opted_out";
        public const string webuiUconnectComputername = "webui.uconnect_computername";
        public const string webuiAllowPairing = "webui.allow_pairing";
        public const string webuiSsdpUuid = "webui.ssdp_uuid";
        public const string webuiGuest = "webui.guest";
        public const string webuiRestrict = "webui.restrict";
        public const string webuiCookie = "webui.cookie";
        public const string webuiPort = "webui.port";
        public const string webuiUconnectToolbarEver = "webui.uconnect_toolbar_ever";
        public const string webuiUconnectEnableEver = "webui.uconnect_enable_ever";
        public const string webuiUconnectConnectedEver = "webui.uconnect_connected_ever";
        public const string webuiUconnectActionsCount = "webui.uconnect_actions_count";
        public const string webuiUconnectActionsListCount = "webui.uconnect_actions_list_count";
        public const string webuiUpdateMessage = "webui.update_message";

        #endregion

        #region Gui keys

        public const string guiGranularPriority = "gui.granular_priority";
        public const string guiOverheadInStatusbar = "gui.overhead_in_statusbar";
        public const string guiShowAvIcon = "gui.show_av_icon";
        public const string guiUploadRateMenu = "gui.ulrate_menu";
        public const string guidDownloadRateMenu = "gui.dlrate_menu";
        public const string guiManualRateMenu = "gui.manual_ratemenu";
        public const string guiAutoRestart = "gui.auto_restart";
        public const string guiReportProblems = "gui.report_problems";
        public const string guiPersistentLabels = "gui.persistent_labels";
        public const string guiCompatibileDirOpen = "gui.compat_diropen";
        public const string guiAlternateColor = "gui.alternate_color";
        public const string guiTransparentGraphLegend = "gui.transparent_graph_legend";
        public const string guiComineListviewStatusDone = "gui.combine_listview_status_done";
        public const string guiLogDate = "gui.log_date";
        public const string guiColorProgressBars = "gui.color_progress_bars";
        public const string guiUpdateRate = "gui.update_rate";
        public const string guiDeleteToTrash = "gui.delete_to_trash";
        public const string guiDeleteAction = "gui.default_del_action";
        public const string guiSpeedInTitle = "gui.speed_in_title";
        public const string guiLimitsInStatusbar = "gui.limits_in_statusbar";
        public const string guiGraphicProgress = "gui.graphic_progress";
        public const string guiPiecebarProgress = "gui.piecebar_progress";
        public const string guiShowStatusIconInDownloadList = "gui.show_status_icon_in_dl_list";
        public const string guiTallCategoryList = "gui.tall_category_list";
        public const string guiWideToolbar = "gui.wide_toolbar";
        public const string guiFindPane = "gui.find_pane";
        public const string guiToolbarLabels = "gui.toolbar_labels";
        public const string guiCategoryListSpaces = "gui.category_list_spaces";
        public const string guiGraphTcpRateControl = "gui.graph_tcp_rate_control";
        public const string guiGraphOverhead = "gui.graph_overhead";
        public const string guiGraphLegend = "gui.graph_legend";

        #endregion

        #region BitTorrent keys

        public const string btSaveResumeRate = "bt.save_resume_rate";
        public const string btAutoDownloadEnable = "bt.auto_dl_enable";
        public const string btAutoDownloadInterval = "bt.auto_dl_interval";
        public const string btAutoDownloadQosMin = "bt.auto_dl_qos_min";
        public const string btAutoDownloadSampleWindow = "bt.auto_dl_sample_window";
        public const string btAutoDownloadSampleAverage = "bt.auto_dl_sample_average";
        public const string btAutoDownloadFactor = "bt.auto_dl_factor";
        public const string btTcpRateControl = "bt.tcp_rate_control";
        public const string btRateLimitTcpOnly = "bt.ratelimit_tcp_only";
        public const string btPrioritizePartialPieces = "bt.prioritize_partial_pieces";
        public const string btTranspDisposition = "bt.transp_disposition";
        public const string btEnablePuls = "bt.enable_pulse";
        public const string btPulseInterval = "bt.pulse_interval";
        public const string btPulseWeight = "bt.pulse_weight";
        public const string btConnectSpeed = "bt.connect_speed";
        public const string btDetermineEncodedRateForStreamables = "bt.determine_encoded_rate_for_streamables";
        public const string btFailoverPeerSpeedThreshold = "bt.failover_peer_speed_threshold";
        public const string streamingMinBufferPiece = "streaming.min_buffer_piece";
        public const string btAllowSameIp = "bt.allow_same_ip";
        public const string btNoConnectToServices = "bt.no_connect_to_services";
        public const string btNoConnectToServicesList = "bt.no_connect_to_services_list";
        public const string btBanThreshold = "bt.ban_threshold";
        public const string btUseBanRatio = "bt.use_ban_ratio";
        public const string btBanRatio = "bt.ban_ratio";
        public const string btUseRangeBlock = "bt.use_rangeblock";
        public const string btGracefulShutdown = "bt.graceful_shutdown";
        public const string btShutdownTrackerTimeout = "bt.shutdown_tracker_timeout";
        public const string btShutdownUpnpTimeout = "bt.shutdown_upnp_timeout";

        #endregion

        #region Net keys

        public const string netBindIp = "net.bind_ip";
        public const string netOutgoingIp = "net.outgoing_ip";
        public const string netOutgoingPort = "net.outgoing_port";
        public const string netOutgoingMaxPort = "net.outgoing_max_port";
        public const string netLowCpu = "net.low_cpu";
        public const string netCalcOverhead = "net.calc_overhead";
        public const string netCalcRssOverhead = "net.calc_rss_overhead";
        public const string netCalcTrackerOverhead = "net.calc_tracker_overhead";
        public const string netMaxHalfopen = "net.max_halfopen";
        public const string netExcludesLocal = "net.limit_excludeslocal";
        public const string netUpnpTcpOnly = "net.upnp_tcp_only";
        public const string netDisableIncomingIpv6 = "net.disable_incoming_ipv6";
        public const string netRateLimitUtp = "net.ratelimit_utp";
        public const string netFriendlyName = "net.friendly_name";
        public const string netUtpTargetDelay = "net.utp_target_delay";
        public const string netUtpPacketSizeInterval = "net.utp_packet_size_interval";
        public const string netUtpReceiveTargetDelay = "net.utp_receive_target_delay";
        public const string netUtpInitialPackSize = "net.utp_initial_packet_size";
        public const string netUtpDynamicPacketSize = "net.utp_dynamic_packet_size";
        public const string netDicoverable = "net.discoverable";

        #endregion

        #region Queue keys

        public const string queueDontCountSlowDownload = "queue.dont_count_slow_dl";
        public const string queueDontCountSlowUpload = "queue.dont_count_slow_ul";
        public const string queueSlowDownloadTreshold = "queue.slow_dl_threshold";
        public const string queueSlowUploadTreshold = "queue.slow_ul_threshold";
        public const string queueUseSeedPeerRatio = "queue.use_seed_peer_ratio";
        public const string queuePrioNoSeeds = "queue.prio_no_seeds";

        #endregion

        #region Streaming keys

        public const string streamingSafetyFactor = "streaming.safety_factor";
        public const string streamingFailoverRateFactor = "streaming.failover_rate_factor";
        public const string streamingFailoverSetPercentage = "streaming.failover_set_percentage";
        public const string streamingPreviewPlayer = "streaming.preview_player";

        #endregion

        #region Multiday keys

        public const string multiDayTransferLimitEn = "multi_day_transfer_limit_en";
        public const string multiDayTransferModeUpload = "multi_day_transfer_mode_ul";
        public const string multiDayTransferModeDownload = "multi_day_transfer_mode_dl";
        public const string multiDayTransferModeUploadDownload = "multi_day_transfer_mode_uldl";
        public const string multiDayTransferLimitUnit = "multi_day_transfer_limit_unit";
        public const string multiDayTransferLimitValue = "multi_day_transfer_limit_value";
        public const string multiDayTransferLimitSpan = "multi_day_transfer_limit_span";

        #endregion

        #region Directory keys

        public const string dirActiveDownloadFlag = "dir_active_download_flag";
        public const string dirTorrentFilesFlag = "dir_torrent_files_flag";
        public const string dirCompletedDownloadFlag = "dir_completed_download_flag";
        public const string dirCompletedTorrentsFlag = "dir_completed_torrents_flag";
        public const string dirActiveDownload = "dir_active_download";
        public const string dirTorrentFiles = "dir_torrent_files";
        public const string dirCompletedDownload = "dir_completed_download";
        public const string dirAddLabel = "dir_add_label";
        public const string dirAutoloadFlag = "dir_autoload_flag";
        public const string dirAutoloadDelete = "dir_autoload_delete";
        public const string dirAutoload = "dir_autoload";
        public const string dirNotifyComplete = "notify_complete";

        #endregion

        #region Stats keys

        public const string statsVideo1TimeWatched = "stats.video1.time_watched";
        public const string statsVideo2TimeWatched = "stats.video2.time_watched";
        public const string statsVideo3TimeWatched = "stats.video3.time_watched";
        public const string statsVideo1Finished = "stats.video1.finished";
        public const string statsVideo2Finished = "stats.video2.finished";
        public const string statsVideo3Finished = "stats.video3.finished";
        public const string statsWelcomePageUseful = "stats.welcome_page_useful";

        #endregion

        #region Show keys

        public const string showToolbar = "show_toolbar";
        public const string showDetails = "show_details";
        public const string showStatus = "show_status";
        public const string showCategory = "show_category";
        public const string showTabIcons = "show_tabicons";
        public const string showGeneralTab = "show_general_tab";
        public const string showPulseTab = "show_pulse_tab";
        public const string showTrackerTab = "show_tracker_tab";
        public const string showPeersTab = "show_peers_tab";
        public const string showPiecesTab = "show_pieces_tab";
        public const string showFilesTab = "show_files_tab";
        public const string showSpeedTab = "show_speed_tab";
        public const string showLoggerTab = "show_logger_tab";
        public const string showAddDialog = "show_add_dialog";
        public const string showAddDialogAlways = "always_show_add_dialog";

        #endregion

        #region Peer keys

        public const string peerLazyBitfield = "peer.lazy_bitfield";
        public const string peerResolveCountry = "peer.resolve_country";
        public const string peerDisconnectInactive = "peer.disconnect_inactive";
        public const string peerDisconnectInactiveInterval = "peer.disconnect_inactive_interval";

        #endregion

        #region Seed keys

        public const string seedPrioLimitUpload = "seed_prio_limitul";
        public const string seedPrioLimitUploadFlag = "seed_prio_limitul_flag";
        public const string seedsPrioritized = "seeds_prioritized";
        public const string seedRatio = "seed_ratio";
        public const string seedTime = "seed_time";
        public const string seedNumber = "seed_num";

        #endregion

        #region Isp keys

        public const string ispBep22 = "isp.bep22";
        public const string ispPrimaryDns = "isp.primary_dns";
        public const string ispSecondaryDns = "isp.secondary_dns";
        public const string ispFqdn = "isp.fqdn";
        public const string ispPeerPolicyEnable = "isp.peer_policy_enable";
        public const string ispPeerPolicyUrl = "isp.peer_policy_url";
        public const string ispPeerPolicyOverride = "isp.peer_policy_override";

        #endregion

        #region Sheduling keys

        public const string schedUploadRate = "sched_ul_rate";
        public const string schedEnable = "sched_enable";
        public const string schedInteraction = "sched_interaction";
        public const string schedDownloadRate = "sched_dl_rate";
        public const string schedTable = "sched_table";
        public const string schedDisDht = "sched_dis_dht";

        #endregion

        public const string torrentsStartStopped = "torrents_start_stopped";
        public const string confirmWhenDeleting = "confirm_when_deleting";
        public const string installRevision = "torrents_start_stopped";
        public const string settingsSavedSystime = "settings_saved_systime";
        public const string dnaUploadLimit = "dna_upload_limit";
        public const string limitDnaUpload = "limit_dna_upload";
        public const string dnaDisableScreensaver = "dna_disable_screensaver";
        public const string dnaShowSystrayIcon = "dna_show_systray_icon";
        public const string confirmExit = "confirm_exit";
        public const string confirmExitCriticalSeeder = "confirm_exit_critical_seeder";
        public const string closeToTray = "close_to_tray";
        public const string minimizeToTray = "minimize_to_tray";
        public const string startMinimized = "start_minimized";
        public const string trayActivate = "tray_activate";
        public const string trayShow = "tray.show";
        public const string traySingleClick = "tray.single_click";
        public const string activateOnFile = "activate_on_file";
        public const string confirmRemoveTracker = "confirm_remove_tracker";
        public const string checkAssociationsOnStart = "check_assoc_on_start";
        public const string bindPort = "bind_port";
        public const string trackerIp = "tracker_ip";
        public const string maxDownloadRate = "max_dl_rate";
        public const string maxUploadRate = "max_ul_rate";
        public const string maxUploadRateSeed = "max_ul_rate_seed";
        public const string maxUploadRateSeedFlag = "max_ul_rate_seed_flag";
        public const string privateIp = "private_ip";
        public const string onlyProxiedConnections = "only_proxied_conns";
        public const string noLocalDns = "no_local_dns";
        public const string sysPreventStandby = "sys.prevent_standby";
        public const string sysEnableWineHacks = "sys.enable_wine_hacks";
        public const string uploadSlotsPerTorrent = "ul_slots_per_torrent";
        public const string connsPerTorrent = "conns_per_torrent";
        public const string connsGlobally = "conns_globally";
        public const string maxActiveTorrent = "max_active_torrent";
        public const string maxActiveDownloads = "max_active_downloads";
        public const string minified = "minified";
        public const string moveIfDefDir = "move_if_defdir";
        public const string mainWindowStatus = "mainwndstatus";
        public const string mainWindowSplit = "mainwnd_split";
        public const string mainWindowSplitX = "mainwnd_split_x";
        public const string resolvePeerIps = "resolve_peerips";
        public const string checkUpadte = "check_update";
        public const string checkUpdateBeta = "check_update_beta";
        public const string anonInfo = "anoninfo";
        public const string upnp = "upnp";
        public const string useUdpTrackers = "use_udp_trackers";
        public const string upnpExternalTcpPort = "upnp.external_tcp_port";
        public const string upnpExternalUdpPort = "upnp.external_udp_port";
        public const string upnpExternalIp = "upnp.external_ip";
        public const string natPmp = "natpmp";
        public const string lsd = "lsd";
        public const string disableFw = "disable_fw";
        public const string finishCmd = "finish_cmd";
        public const string stateCmd = "state_cmd";
        public const string dw = "dw";
        public const string fd = "fd";
        public const string k = "k";
        public const string v = "v";
        public const string asip = "asip";
        public const string asdlUrl = "asdlurl";
        public const string asDns = "asdns";
        public const string asCon = "ascon";
        public const string asdl = "asdl";
        public const string enableScrape = "enable_scrape";
        public const string randPortOnStart = "rand_port_on_start";
        public const string preallocSpace = "prealloc_space";
        public const string language = "language";
        public const string loggerMask = "logger_mask";
        public const string dht = "dht";
        public const string dhtPerTorrent = "dht_per_torrent";
        public const string pex = "pex";
        public const string rateLimitLocalPeers = "rate_limit_local_peers";
        public const string ipFilterEnable = "ipfilter.enable";
        public const string searchList = "search_list";
        public const string searchListSelect = "search_list_sel";
        public const string dhtCollectFeed = "dht.collect_feed";
        public const string dhtRate = "dht.rate";
        public const string appendIncomplete = "append_incomplete";
        public const string remTorrentFilesWithPrivateData = "remove_torrent_files_with_private_data";
        public const string bossKey = "boss_key";
        public const string bossKeySalt = "boss_key_salt";
        public const string useBossKeyPw = "use_boss_key_pw";
        public const string boosKeyPw = "boss_key_pw";
        public const string encryptionMode = "encryption_mode";
        public const string encryptionAllowLegacy = "encryption_allow_legacy";
        public const string rssUpdateInterval = "rss.update_interval";
        public const string rssSmartRepackFilter = "rss.smart_repack_filter";
        public const string rssFeedAsDefaultLabel = "rss.feed_as_default_label";
        public const string avWindow = "avwindow";
        public const string avEnabled = "av_enabled";
        public const string avAutoUpdate = "av_auto_update";
        public const string avLastUpdateDate = "av_last_update_date";

        #region Diskio keys

        public const string diskioFlushFiles = "diskio.flush_files";
        public const string diskioSparseFiles = "diskio.sparse_files";
        public const string diskioNoZero = "diskio.no_zero";
        public const string diskioUserPartfile = "diskio.use_partfile";
        public const string diskioSmartHash = "diskio.smart_hash";
        public const string diskioSmartSparseHash = "diskio.smart_sparse_hash";
        public const string diskioCoalesceWrtes = "diskio.coalesce_writes";
        public const string diskioCoalesceWriteSize = "diskio.coalesce_write_size";
        public const string diskioResumeMin = "diskio.resume_min";
        public const string diskioMaxWriteQueue = "diskio.max_write_queue";
        public const string diskioCacheReduceMinutes = "diskio.cache_reduce_minutes";
        public const string diskioCacheStripe = "diskio.cache_stripe";

        #endregion

        #region Cache keys

        public const string cacheOverride = "cache.override";
        public const string cacheOverrideSize = "cache.override_size";
        public const string cacheReduce = "cache.reduce";
        public const string cacheWrite = "cache.write";
        public const string cacheWriteout = "cache.writeout";
        public const string cacheWriteimm = "cache.writeimm";
        public const string cacheRead = "cache.read";
        public const string cacheReadTurnoff = "cache.read_turnoff";
        public const string cacheReadPrune = "cache.read_prune";
        public const string cacheReadThrash = "cache.read_thrash";
        public const string cacheDisableWinRead = "cache.disable_win_read";
        public const string cacheDisableWinWrite = "cache.disable_win_write";

        #endregion

        #region Proxy keys

        public const string proxyProxy = "proxy.proxy";
        public const string proxyType = "proxy.type";
        public const string proxyPort = "proxy.port";
        public const string proxyAuth = "proxy.auth";
        public const string proxyP2p = "proxy.p2p";
        public const string proxyResolve = "proxy.resolve";
        public const string proxyUsername = "proxy.username";
        public const string proxyPassword = "proxy.password";

        #endregion

    }
}
