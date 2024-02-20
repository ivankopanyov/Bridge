namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ColorDefinitions
{
    public string? Resort { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
    public decimal? DisplaySequence { get; set; }
    public string? InactiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ColorDefinitions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Color })
                .HasName("CLRDEF_PK");

            entity.ToTable("COLOR_DEFINITIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySequence)
                .HasColumnName("DISPLAY_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
