namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OutputDevice
{
    public string OutputDevice1 { get; set; }
    public string OutputType { get; set; }
    public string Description { get; set; }
    public string PhysicalDevice { get; set; }
    public string SpoolerFilename { get; set; }
    public string QueueName { get; set; }
    public string ShellCommand { get; set; }
    public string PrintServer { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string DeviceMode { get; set; }
    public string DeviceDriver { get; set; }
    public decimal? StartBillNo { get; set; }
    public string FolioPrinterYn { get; set; }
    public string Papersize { get; set; }
    public string TrayEmulation { get; set; }
    public string Resort { get; set; }
    public string BillNoPrefix { get; set; }
    public string ChainCode { get; set; }
    public string AlertYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OutputDevice>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.OutputDevice1, e.PhysicalDevice })
                .HasName("OUTPUT_DEVICE_PK");

            entity.ToTable("OUTPUT_DEVICE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OutputDevice1)
                .HasColumnName("OUTPUT_DEVICE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhysicalDevice)
                .HasColumnName("PHYSICAL_DEVICE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AlertYn)
                .HasColumnName("ALERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillNoPrefix)
                .HasColumnName("BILL_NO_PREFIX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DeviceDriver)
                .HasColumnName("DEVICE_DRIVER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DeviceMode)
                .HasColumnName("DEVICE_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioPrinterYn)
                .HasColumnName("FOLIO_PRINTER_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutputType)
                .IsRequired()
                .HasColumnName("OUTPUT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Papersize)
                .HasColumnName("PAPERSIZE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'LETTER'");

            entity.Property(e => e.PrintServer)
                .HasColumnName("PRINT_SERVER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ShellCommand)
                .HasColumnName("SHELL_COMMAND")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SpoolerFilename)
                .HasColumnName("SPOOLER_FILENAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StartBillNo)
                .HasColumnName("START_BILL_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrayEmulation)
                .HasColumnName("TRAY_EMULATION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
