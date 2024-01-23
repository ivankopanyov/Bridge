namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oUserPreferences
{
    public string O2oMigId { get; set; }
    public string Resort { get; set; }
    public string MigratePropertyYn { get; set; }
    public string BackupFoliosYn { get; set; }
    public string ExportPropertyToXmlYn { get; set; }
    public string DeletePropertyYn { get; set; }
    public string SourceUser { get; set; }
    public string SourcePassword { get; set; }
    public string SourceInstance { get; set; }
    public string SourcePortNo { get; set; }
    public string SourceHost { get; set; }
    public string SourceProperty { get; set; }
    public string TargetUser { get; set; }
    public string TargetPassword { get; set; }
    public string TargetInstance { get; set; }
    public string TargetPortNo { get; set; }
    public string TargetHost { get; set; }
    public string TargetProperty { get; set; }
    public string InclPropertyConfigYn { get; set; }
    public string CreatePropertyFromShellYn { get; set; }
    public string InclPackagesYn { get; set; }
    public string InclProfilesYn { get; set; }
    public string InclRatesYn { get; set; }
    public string InclArAccountsYn { get; set; }
    public string ArAcctsWithoutBalancesYn { get; set; }
    public string InclRateRestrictionsYn { get; set; }
    public string InclTelephoneBookYn { get; set; }
    public string InclBlocksYn { get; set; }
    public string InclOooOosRoomsYn { get; set; }
    public string InclReservationsYn { get; set; }
    public string InclOverbookingYn { get; set; }
    public string InclReservationHistoryYn { get; set; }
    public string InclStatisticsYn { get; set; }
    public string SendProfilesFirstYn { get; set; }
    public string OnlyProfilesResvsBlocksAr { get; set; }
    public string ProfilesWOMembershipsYn { get; set; }
    public string ExclProfilesMemTypes { get; set; }
    public string CleanupAllTabsYn { get; set; }
    public string FrequentCleanupYn { get; set; }
    public string CopyFromPropertyShell { get; set; }
    public string CopyReportsFromProperty { get; set; }
    public string InclPropertyConfigFrmSrc { get; set; }
    public string TrnsConfigExistingPropYn { get; set; }
    public string FolioBackupDirectory { get; set; }
    public string ExpStorageLocation { get; set; }
    public string ExpInclAllProfiles { get; set; }
    public string ExpInclProfileOfResBlAr { get; set; }
    public string ExpProfilesWOMemberships { get; set; }
    public string ExpExclProfilesMemTypes { get; set; }
    public string DelPassword { get; set; }
    public string DelInclAllProfiles { get; set; }
    public string DelInclProfileOfResBlAr { get; set; }
    public string DelProfilesWOMemberships { get; set; }
    public string DelExclProfilesMemTypes { get; set; }
    public string CreatePropFrmStdIns { get; set; }
    public string Propertycreationoptions { get; set; }
    public string ShellLocation { get; set; }
    public string CopyReportsFromPropertyYn { get; set; }
    public string ResortName { get; set; }
    public string TargetResortName { get; set; }
    public string CreateNewOrUseExistingNe { get; set; }
    public string TargetChainCode { get; set; }
    public string SourceChainCode { get; set; }
    public string SyncParameters { get; set; }
    public string NResortConfOpt { get; set; }
    public string NTargetResort { get; set; }
    public string NTargetResortName { get; set; }
    public string NMigrateConfig { get; set; }
    public string NSyncParameters { get; set; }
    public string NTargerResortChain { get; set; }
    public string NTargerChainName { get; set; }
    public string TargerChainName { get; set; }
    public string TargetAppServer { get; set; }
    public string SourceToTargetDblink { get; set; }
    public string TargetToSourceDblink { get; set; }
    public string CopyFromOtherProperty { get; set; }
    public string ExternalResort { get; set; }
    public string ConfigStatus { get; set; }
    public decimal? CashierId { get; set; }
    public string AuthorizationCode { get; set; }
    public string PotentialsYn { get; set; }
    public string EventsYn { get; set; }
    public string SalesAllowanceYn { get; set; }
    public string SalesManagerGoalsYn { get; set; }
    public string MeetingProfilesYn { get; set; }
    public string WorkOrderYn { get; set; }
    public string EmailAttachmentsYn { get; set; }
    public string AuthCodeValidated { get; set; }
    public decimal? LastPageVisited { get; set; }
    public string SourceConnectionValidyn { get; set; }
    public string SourceAppServer { get; set; }
    public string O2oMigUserName { get; set; }
    public DateTime? FoliosBeginDate { get; set; }
    public DateTime? ReservationHistCutoffDate { get; set; }
    public decimal? Prof1StayInLastNDays { get; set; }
    public decimal? ProfAtleastNPrevStays { get; set; }
    public DateTime? ProfLastUpdated { get; set; }
    public string TransferGuestBalancesYn { get; set; }
    public string SendRelatedProfilesFirstYn { get; set; }
    public string DelayRateRestrictionsYn { get; set; }
    public string TransferDepBalancesYn { get; set; }
    public string MigrationStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oUserPreferences>(entity =>
        {
            entity.HasKey(e => e.O2oMigId)
                .HasName("O2O_USR_PREF_PK");

            entity.ToTable("O2O_USER_PREFERENCES");

            entity.Property(e => e.O2oMigId)
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArAcctsWithoutBalancesYn)
                .HasColumnName("AR_ACCTS_WITHOUT_BALANCES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthCodeValidated)
                .HasColumnName("AUTH_CODE_VALIDATED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizationCode)
                .HasColumnName("AUTHORIZATION_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BackupFoliosYn)
                .HasColumnName("BACKUP_FOLIOS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CleanupAllTabsYn)
                .HasColumnName("CLEANUP_ALL_TABS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfigStatus)
                .HasColumnName("CONFIG_STATUS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CopyFromOtherProperty)
                .HasColumnName("COPY_FROM_OTHER_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CopyFromPropertyShell)
                .HasColumnName("COPY_FROM_PROPERTY_SHELL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CopyReportsFromProperty)
                .HasColumnName("COPY_REPORTS_FROM_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CopyReportsFromPropertyYn)
                .HasColumnName("COPY_REPORTS_FROM_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreateNewOrUseExistingNe)
                .HasColumnName("CREATE_NEW_OR_USE_EXISTING_NE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreatePropFrmStdIns)
                .HasColumnName("CREATE_PROP_FRM_STD_INS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreatePropertyFromShellYn)
                .HasColumnName("CREATE_PROPERTY_FROM_SHELL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DelExclProfilesMemTypes)
                .HasColumnName("DEL_EXCL_PROFILES_MEM_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DelInclAllProfiles)
                .HasColumnName("DEL_INCL_ALL_PROFILES")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DelInclProfileOfResBlAr)
                .HasColumnName("DEL_INCL_PROFILE_OF_RES_BL_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DelPassword)
                .HasColumnName("DEL_PASSWORD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DelProfilesWOMemberships)
                .HasColumnName("DEL_PROFILES_W_O_MEMBERSHIPS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DelayRateRestrictionsYn)
                .HasColumnName("DELAY_RATE_RESTRICTIONS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeletePropertyYn)
                .HasColumnName("DELETE_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailAttachmentsYn)
                .HasColumnName("EMAIL_ATTACHMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventsYn)
                .HasColumnName("EVENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExclProfilesMemTypes)
                .HasColumnName("EXCL_PROFILES_MEM_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpExclProfilesMemTypes)
                .HasColumnName("EXP_EXCL_PROFILES_MEM_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpInclAllProfiles)
                .HasColumnName("EXP_INCL_ALL_PROFILES")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpInclProfileOfResBlAr)
                .HasColumnName("EXP_INCL_PROFILE_OF_RES_BL_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpProfilesWOMemberships)
                .HasColumnName("EXP_PROFILES_W_O_MEMBERSHIPS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExpStorageLocation)
                .HasColumnName("EXP_STORAGE_LOCATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportPropertyToXmlYn)
                .HasColumnName("EXPORT_PROPERTY_TO_XML_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResort)
                .HasColumnName("EXTERNAL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioBackupDirectory)
                .HasColumnName("FOLIO_BACKUP_DIRECTORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FoliosBeginDate)
                .HasColumnName("FOLIOS_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FrequentCleanupYn)
                .HasColumnName("FREQUENT_CLEANUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclArAccountsYn)
                .HasColumnName("INCL_AR_ACCOUNTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclBlocksYn)
                .HasColumnName("INCL_BLOCKS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclOooOosRoomsYn)
                .HasColumnName("INCL_OOO_OOS_ROOMS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclOverbookingYn)
                .HasColumnName("INCL_OVERBOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclPackagesYn)
                .HasColumnName("INCL_PACKAGES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclProfilesYn)
                .HasColumnName("INCL_PROFILES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclPropertyConfigFrmSrc)
                .HasColumnName("INCL_PROPERTY_CONFIG_FRM_SRC")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclPropertyConfigYn)
                .HasColumnName("INCL_PROPERTY_CONFIG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclRateRestrictionsYn)
                .HasColumnName("INCL_RATE_RESTRICTIONS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclRatesYn)
                .HasColumnName("INCL_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclReservationHistoryYn)
                .HasColumnName("INCL_RESERVATION_HISTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclReservationsYn)
                .HasColumnName("INCL_RESERVATIONS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclStatisticsYn)
                .HasColumnName("INCL_STATISTICS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclTelephoneBookYn)
                .HasColumnName("INCL_TELEPHONE_BOOK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastPageVisited)
                .HasColumnName("LAST_PAGE_VISITED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MeetingProfilesYn)
                .HasColumnName("MEETING_PROFILES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MigratePropertyYn)
                .HasColumnName("MIGRATE_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MigrationStatus)
                .HasColumnName("MIGRATION_STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NMigrateConfig)
                .HasColumnName("N_MIGRATE_CONFIG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NResortConfOpt)
                .HasColumnName("N_RESORT_CONF_OPT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NSyncParameters)
                .HasColumnName("N_SYNC_PARAMETERS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NTargerChainName)
                .HasColumnName("N_TARGER_CHAIN_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NTargerResortChain)
                .HasColumnName("N_TARGER_RESORT_CHAIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NTargetResort)
                .HasColumnName("N_TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NTargetResortName)
                .HasColumnName("N_TARGET_RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.O2oMigUserName)
                .HasColumnName("O2O_MIG_USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OnlyProfilesResvsBlocksAr)
                .HasColumnName("ONLY_PROFILES_RESVS_BLOCKS_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PotentialsYn)
                .HasColumnName("POTENTIALS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Prof1StayInLastNDays)
                .HasColumnName("PROF_1_STAY_IN_LAST_N_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfAtleastNPrevStays)
                .HasColumnName("PROF_ATLEAST_N_PREV_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfLastUpdated)
                .HasColumnName("PROF_LAST_UPDATED")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfilesWOMembershipsYn)
                .HasColumnName("PROFILES_W_O_MEMBERSHIPS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Propertycreationoptions)
                .HasColumnName("PROPERTYCREATIONOPTIONS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ReservationHistCutoffDate)
                .HasColumnName("RESERVATION_HIST_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SalesAllowanceYn)
                .HasColumnName("SALES_ALLOWANCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SalesManagerGoalsYn)
                .HasColumnName("SALES_MANAGER_GOALS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendProfilesFirstYn)
                .HasColumnName("SEND_PROFILES_FIRST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendRelatedProfilesFirstYn)
                .HasColumnName("SEND_RELATED_PROFILES_FIRST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShellLocation)
                .HasColumnName("SHELL_LOCATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceAppServer)
                .HasColumnName("SOURCE_APP_SERVER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceChainCode)
                .HasColumnName("SOURCE_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceConnectionValidyn)
                .HasColumnName("SOURCE_CONNECTION_VALIDYN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceHost)
                .HasColumnName("SOURCE_HOST")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourceInstance)
                .HasColumnName("SOURCE_INSTANCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourcePassword)
                .HasColumnName("SOURCE_PASSWORD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourcePortNo)
                .HasColumnName("SOURCE_PORT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceProperty)
                .HasColumnName("SOURCE_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceToTargetDblink)
                .HasColumnName("SOURCE_TO_TARGET_DBLINK")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourceUser)
                .HasColumnName("SOURCE_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SyncParameters)
                .HasColumnName("SYNC_PARAMETERS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TargerChainName)
                .HasColumnName("TARGER_CHAIN_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TargetAppServer)
                .HasColumnName("TARGET_APP_SERVER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TargetChainCode)
                .HasColumnName("TARGET_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TargetHost)
                .HasColumnName("TARGET_HOST")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TargetInstance)
                .HasColumnName("TARGET_INSTANCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TargetPassword)
                .HasColumnName("TARGET_PASSWORD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TargetPortNo)
                .HasColumnName("TARGET_PORT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TargetProperty)
                .HasColumnName("TARGET_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TargetResortName)
                .HasColumnName("TARGET_RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TargetToSourceDblink)
                .HasColumnName("TARGET_TO_SOURCE_DBLINK")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TargetUser)
                .HasColumnName("TARGET_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransferDepBalancesYn)
                .HasColumnName("TRANSFER_DEP_BALANCES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TransferGuestBalancesYn)
                .HasColumnName("TRANSFER_GUEST_BALANCES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrnsConfigExistingPropYn)
                .HasColumnName("TRNS_CONFIG_EXISTING_PROP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WorkOrderYn)
                .HasColumnName("WORK_ORDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
