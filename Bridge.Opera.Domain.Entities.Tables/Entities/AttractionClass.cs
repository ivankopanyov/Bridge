namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AttractionClass
{
    public string AttractionClass1 { get; set; }
    public string Description { get; set; }
    public decimal? AttractionId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AttractionClass>(entity =>
        {
            entity.HasKey(e => e.AttractionClass1)
                .HasName("ATTRACTION_CLASS_PK");

            entity.ToTable("ATTRACTION_CLASS");

            entity.Property(e => e.AttractionClass1)
                .HasColumnName("ATTRACTION_CLASS")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AttractionId)
                .HasColumnName("ATTRACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
