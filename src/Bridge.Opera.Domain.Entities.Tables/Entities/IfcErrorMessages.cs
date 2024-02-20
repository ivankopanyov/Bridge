namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcErrorMessages
{
    public string? Resort { get; set; }
    public string? Interface { get; set; }
    public decimal? OperaSid { get; set; }
    public decimal? MessageId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcErrorMessages>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_ERROR_MESSAGES");

            entity.HasIndex(e => new { e.Resort, e.Interface })
                .HasName("IFC_ERROR_MSG_IDX");

            entity.Property(e => e.Interface)
                .HasColumnName("INTERFACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaSid)
                .HasColumnName("OPERA_SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
