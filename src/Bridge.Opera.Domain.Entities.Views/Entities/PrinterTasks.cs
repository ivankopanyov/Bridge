namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PrinterTasks
{
    public string? Station { get; set; }
    public string? Printer { get; set; }
    public string? PrinterDesc { get; set; }
    public string? PrintTask { get; set; }
    public string? PhysicalDevice { get; set; }
    public string? Resort { get; set; }
    public string? PrintServer { get; set; }
    public string? FolioPrinter { get; set; }
    public string? DeviceDriver { get; set; }
    public string? DeviceMode { get; set; }
    public string? Papersize { get; set; }
    public string? TrayEmulation { get; set; }
    public string? DomainStation { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrinterTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PRINTER_TASKS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeviceDriver)
                .HasColumnName("DEVICE_DRIVER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DeviceMode)
                .HasColumnName("DEVICE_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DomainStation)
                .HasColumnName("DOMAIN_STATION")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.FolioPrinter)
                .HasColumnName("FOLIO_PRINTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Papersize)
                .HasColumnName("PAPERSIZE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhysicalDevice)
                .HasColumnName("PHYSICAL_DEVICE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PrintServer)
                .HasColumnName("PRINT_SERVER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PrintTask)
                .HasColumnName("PRINT_TASK")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Printer)
                .HasColumnName("PRINTER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrinterDesc)
                .HasColumnName("PRINTER_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.Station)
                .HasColumnName("STATION")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.TrayEmulation)
                .HasColumnName("TRAY_EMULATION")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
