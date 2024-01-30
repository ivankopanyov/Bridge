namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkstationPrinters
{
    public string? StationId { get; set; }
    public string? PrintTask { get; set; }
    public string? OutputDevice { get; set; }
    public string? ChainCode { get; set; }

    public virtual PmsTerminals PmsTerminals { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkstationPrinters>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.StationId, e.OutputDevice, e.PrintTask })
                .HasName("WORKSTATION_PRINTERS_PK");

            entity.ToTable("WORKSTATION_PRINTERS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.OutputDevice)
                .HasColumnName("OUTPUT_DEVICE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrintTask)
                .HasColumnName("PRINT_TASK")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(PmsTerminals)))
				entity.Ignore(e => e.PmsTerminals);
			else
	            entity.HasOne(d => d.PmsTerminals)
	                .WithMany(p => p.WorkstationPrinters)
	                .HasForeignKey(d => new { d.ChainCode, d.StationId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("WORKSTATION_PRINTER_FK1");
        });
	}
}
