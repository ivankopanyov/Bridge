namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YearSetup
{
    public string Resort { get; set; }
    public decimal YearId { get; set; }
    public string YearType { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal? Year { get; set; }
    public string Calendar { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YearSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("YEAR$SETUP");

            entity.HasIndex(e => new { e.Resort, e.YearId, e.Calendar })
                .HasName("YEAR_SETUP_PK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.YearType, e.StartDate, e.Calendar })
                .HasName("YEAR_SETUP_UK")
                .IsUnique();

            entity.Property(e => e.Calendar)
                .HasColumnName("CALENDAR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearType)
                .IsRequired()
                .HasColumnName("YEAR_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
