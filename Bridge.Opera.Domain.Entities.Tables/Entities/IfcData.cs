namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcData
{
    public decimal? TrnId { get; set; }
    public string TrnData { get; set; }
    public DateTime? TrnDate { get; set; }
    public string Dest { get; set; }
    public string Src { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_DATA");

            entity.Property(e => e.Dest)
                .HasColumnName("DEST")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.TrnData)
                .HasColumnName("TRN_DATA")
                .HasColumnType("LONG");

            entity.Property(e => e.TrnDate)
                .HasColumnName("TRN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnId)
                .HasColumnName("TRN_ID")
                .HasColumnType("NUMBER");
        });
	}
}
