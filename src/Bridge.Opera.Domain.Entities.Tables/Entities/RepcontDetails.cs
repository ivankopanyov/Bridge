namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepcontDetails
{
    public decimal? AttachId { get; set; }
    public string? Tablename { get; set; }
    public string? Fieldname { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepcontDetails>(entity =>
        {
            entity.HasKey(e => new { e.AttachId, e.Tablename, e.Fieldname })
                .HasName("REPCD_PK");

            entity.ToTable("REPCONT$DETAILS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tablename)
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
