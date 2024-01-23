namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortAllotmentOffsetType
{
    public string Resort { get; set; }
    public string OffsetType { get; set; }
    public string ShortDesc { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortAllotmentOffsetType>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.OffsetType })
                .HasName("RESORT_OFFSET_TYPE_PK");

            entity.ToTable("RESORT_ALLOTMENT_OFFSET_TYPE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OffsetType)
                .HasColumnName("OFFSET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShortDesc)
                .HasColumnName("SHORT_DESC")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
