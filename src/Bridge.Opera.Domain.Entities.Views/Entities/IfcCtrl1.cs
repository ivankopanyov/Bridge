namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcCtrl1
{
    public decimal? RowId { get; set; }
    public string? IfcMenu { get; set; }
    public string? IfcType { get; set; }
    public string? Active { get; set; }
    public string? Name { get; set; }
    public string? Version { get; set; }
    public string? FktLogo { get; set; }
    public string? DbfLogo { get; set; }
    public decimal? ShellNum { get; set; }
    public string? Ch1 { get; set; }
    public string? Ch2 { get; set; }
    public string? Ch3 { get; set; }
    public string? Ch4 { get; set; }
    public string? InXlatId { get; set; }
    public string? OuXlatId { get; set; }
    public string? Features { get; set; }
    public string? Command { get; set; }
    public decimal? PathId1 { get; set; }
    public decimal? PathId2 { get; set; }
    public decimal? PathId3 { get; set; }
    public decimal? PathId4 { get; set; }
    public string? SerialNum { get; set; }
    public byte? Ifcnumber { get; set; }
    public string? ArticleNoPrefix { get; set; }
    public string? Acct { get; set; }
    public decimal? Charge { get; set; }
    public string? Dc1 { get; set; }
    public string? Dc2 { get; set; }
    public string? CallAcct { get; set; }
    public string? WakeType { get; set; }
    public decimal? WakeKeep { get; set; }
    public decimal? WakeMax { get; set; }
    public decimal? Recvbufsiz { get; set; }
    public decimal? Refnums { get; set; }
    public decimal? WakeCount { get; set; }
    public decimal? WakeRetry { get; set; }
    public decimal? WakeDelay { get; set; }
    public decimal? WakeStart { get; set; }
    public decimal? WakeStop { get; set; }
    public decimal? WakeRes { get; set; }
    public string? WakeParam { get; set; }
    public string? CmdValid { get; set; }
    public DateTime? InitDate { get; set; }
    public decimal? CashierNr { get; set; }
    public string? MenuName { get; set; }
    public byte? Xpos { get; set; }
    public byte? Ypos { get; set; }
    public DateTime? AliveDate { get; set; }
    public string? CommAlarm { get; set; }
    public string? CommText { get; set; }
    public decimal? FoServerJobId { get; set; }
    public string? TaxGenerateYn { get; set; }
    public decimal? FoServerJobProcesses { get; set; }
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public string? DbfSwap { get; set; }
    public string? Ip { get; set; }
    public decimal? Conversion { get; set; }
    public string? VnPools { get; set; }
    public string? Timeout { get; set; }
    public decimal? ScreenX { get; set; }
    public decimal? ScreenY { get; set; }
    public decimal? Prevwake { get; set; }
    public string? ForceAuthorizationYn { get; set; }
    public string? ResvAuthRequiredYn { get; set; }
    public decimal? PingTime { get; set; }
    public decimal? PingRetry { get; set; }
    public string? IfcStatus { get; set; }
    public decimal? MachineId { get; set; }
    public string? DisplayMode { get; set; }
    public string? AutoStartYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? IfcFktLogo { get; set; }
    public decimal? DeviceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCtrl1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_CTRL");

            entity.Property(e => e.Acct)
                .HasColumnName("ACCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Active)
                .HasColumnName("ACTIVE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AliveDate)
                .HasColumnName("ALIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArticleNoPrefix)
                .HasColumnName("ARTICLE_NO_PREFIX")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.AutoStartYn)
                .HasColumnName("AUTO_START_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CallAcct)
                .HasColumnName("CALL_ACCT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CashierNr)
                .HasColumnName("CASHIER_NR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ch1)
                .HasColumnName("CH1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Ch2)
                .HasColumnName("CH2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Ch3)
                .HasColumnName("CH3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Ch4)
                .HasColumnName("CH4")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Charge)
                .HasColumnName("CHARGE")
                .HasColumnType("NUMBER(12,2)");

            entity.Property(e => e.CmdValid)
                .HasColumnName("CMD_VALID")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CommAlarm)
                .HasColumnName("COMM_ALARM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CommText)
                .HasColumnName("COMM_TEXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Command)
                .HasColumnName("COMMAND")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Conversion)
                .HasColumnName("CONVERSION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.DbfSwap)
                .HasColumnName("DBF_SWAP")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Dc1)
                .HasColumnName("DC_1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dc2)
                .HasColumnName("DC_2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeviceId)
                .HasColumnName("DEVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayMode)
                .HasColumnName("DISPLAY_MODE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Features)
                .HasColumnName("FEATURES")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FktLogo)
                .HasColumnName("FKT_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.FoServerJobId)
                .HasColumnName("FO_SERVER_JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoServerJobProcesses)
                .HasColumnName("FO_SERVER_JOB_PROCESSES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForceAuthorizationYn)
                .HasColumnName("FORCE_AUTHORIZATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IfcFktLogo)
                .HasColumnName("IFC_FKT_LOGO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IfcMenu)
                .HasColumnName("IFC_MENU")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.IfcStatus)
                .HasColumnName("IFC_STATUS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IfcType)
                .HasColumnName("IFC_TYPE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Ifcnumber)
                .HasColumnName("IFCNUMBER")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.InXlatId)
                .HasColumnName("IN_XLAT_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InitDate)
                .HasColumnName("INIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ip)
                .HasColumnName("IP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MachineId)
                .HasColumnName("MACHINE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenuName)
                .HasColumnName("MENU_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OuXlatId)
                .HasColumnName("OU_XLAT_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PathId1)
                .HasColumnName("PATH_ID_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PathId2)
                .HasColumnName("PATH_ID_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PathId3)
                .HasColumnName("PATH_ID_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PathId4)
                .HasColumnName("PATH_ID_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PingRetry)
                .HasColumnName("PING_RETRY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PingTime)
                .HasColumnName("PING_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Prevwake)
                .HasColumnName("PREVWAKE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Recvbufsiz)
                .HasColumnName("RECVBUFSIZ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Refnums)
                .HasColumnName("REFNUMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .IsRequired()
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResvAuthRequiredYn)
                .HasColumnName("RESV_AUTH_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenX)
                .HasColumnName("SCREEN_X")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenY)
                .HasColumnName("SCREEN_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SerialNum)
                .HasColumnName("SERIAL_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShellNum)
                .HasColumnName("SHELL_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxGenerateYn)
                .HasColumnName("TAX_GENERATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Timeout)
                .HasColumnName("TIMEOUT")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.VnPools)
                .HasColumnName("VN_POOLS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WakeCount)
                .HasColumnName("WAKE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeDelay)
                .HasColumnName("WAKE_DELAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeKeep)
                .HasColumnName("WAKE_KEEP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeMax)
                .HasColumnName("WAKE_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeParam)
                .HasColumnName("WAKE_PARAM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.WakeRes)
                .HasColumnName("WAKE_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeRetry)
                .HasColumnName("WAKE_RETRY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeStart)
                .HasColumnName("WAKE_START")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeStop)
                .HasColumnName("WAKE_STOP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeType)
                .HasColumnName("WAKE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Xpos)
                .HasColumnName("XPOS")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Ypos)
                .HasColumnName("YPOS")
                .HasColumnType("NUMBER(2)");
        });
	}
}
