namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PmsTerminals
{
    public PmsTerminals()
    {
        WorkstationPrinters = new HashSet<WorkstationPrinters>();
    }

    public string? StationId { get; set; }
    public decimal? CCInterfaceSetupId { get; set; }
    public string? StationName { get; set; }
    public string? LastLoggedUser { get; set; }
    public DateTime? LastLoginTime { get; set; }
    public string? CCReaderAttachedYn { get; set; }
    public string? Description { get; set; }
    public string? DomainPrinterStationId { get; set; }
    public string? FiscalPrinterAttachedYn { get; set; }
    public string? ChipPinDeviceAttachedYn { get; set; }
    public string? ChainCode { get; set; }
    public string? FiscalUnitSerialNumber { get; set; }
    public decimal? CCReaderDeviceId { get; set; }
    public string? SoftwareId { get; set; }
    public string? ElectronicSignatureDeviceYn { get; set; }
    public string? EsdNo { get; set; }

    public virtual CreditCardReaderDevices C { get; set; }
    public virtual ICollection<WorkstationPrinters> WorkstationPrinters { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsTerminals>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.StationId })
                .HasName("TERM_PK");

            entity.ToTable("PMS_TERMINALS");

            entity.HasIndex(e => new { e.ChainCode, e.CCReaderDeviceId })
                .HasName("TERM_C_C_READER_DEVICE_FKI");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CCInterfaceSetupId)
                .HasColumnName("C_C_INTERFACE_SETUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCReaderAttachedYn)
                .HasColumnName("C_C_READER_ATTACHED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CCReaderDeviceId)
                .HasColumnName("C_C_READER_DEVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChipPinDeviceAttachedYn)
                .HasColumnName("CHIP_PIN_DEVICE_ATTACHED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DomainPrinterStationId)
                .HasColumnName("DOMAIN_PRINTER_STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElectronicSignatureDeviceYn)
                .HasColumnName("ELECTRONIC_SIGNATURE_DEVICE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EsdNo)
                .HasColumnName("ESD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FiscalPrinterAttachedYn)
                .HasColumnName("FISCAL_PRINTER_ATTACHED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.FiscalUnitSerialNumber)
                .HasColumnName("FISCAL_UNIT_SERIAL_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastLoggedUser)
                .HasColumnName("LAST_LOGGED_USER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.LastLoginTime)
                .HasColumnName("LAST_LOGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.SoftwareId)
                .HasColumnName("SOFTWARE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StationName)
                .HasColumnName("STATION_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(CreditCardReaderDevices)))
				entity.Ignore(e => e.C);
			else
	            entity.HasOne(d => d.C)
	                .WithMany(p => p.PmsTerminals)
	                .HasForeignKey(d => new { d.ChainCode, d.CCReaderDeviceId })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("TERM_CC_READER_DEV_FK");
        
			if (!types.Contains(typeof(WorkstationPrinters)))
				entity.Ignore(e => e.WorkstationPrinters);
		});
	}
}
