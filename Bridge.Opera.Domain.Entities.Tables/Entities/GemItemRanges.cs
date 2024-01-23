namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemRanges
{
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public decimal ItemNumberFrom { get; set; }
    public decimal ItemNumberTo { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemRanges>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GEM$ITEM_RANGES");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("GEM$ITEM_RANGES_IDX");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemNumberFrom)
                .HasColumnName("ITEM_NUMBER_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemNumberTo)
                .HasColumnName("ITEM_NUMBER_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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
