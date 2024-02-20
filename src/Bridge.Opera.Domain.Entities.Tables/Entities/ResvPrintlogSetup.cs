namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvPrintlogSetup
{
    public string? Resort { get; set; }
    public string? DataElement { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvPrintlogSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESV_PRINTLOG_SETUP");

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
