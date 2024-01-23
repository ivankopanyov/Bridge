namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResvPrintlogSetup
{
    public string DataElement { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResvPrintlogSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESV_PRINTLOG_SETUP");

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
