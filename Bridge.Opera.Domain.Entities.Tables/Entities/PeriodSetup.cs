namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PeriodSetup
{
    public string Resort { get; set; }
    public decimal YearId { get; set; }
    public string PeriodType { get; set; }
    public string Code { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public string PeriodScope { get; set; }
    public string ParentPeriod { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PeriodSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PERIOD$SETUP");

            entity.HasIndex(e => new { e.Resort, e.StartDate })
                .HasName("PERIOD_YEAR_DATE");

            entity.HasIndex(e => new { e.Resort, e.PeriodType, e.EndDate })
                .HasName("PERIOD_END_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.PeriodType, e.StartDate })
                .HasName("PERIOD_START_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.YearId, e.StartDate, e.PeriodScope })
                .HasName("PERIOD_SETUP_PK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.YearId, e.PeriodType, e.Code, e.PeriodScope })
                .HasName("PERIOD$SETUP_UK")
                .IsUnique();

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentPeriod)
                .HasColumnName("PARENT_PERIOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PeriodScope)
                .HasColumnName("PERIOD_SCOPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PeriodType)
                .IsRequired()
                .HasColumnName("PERIOD_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
