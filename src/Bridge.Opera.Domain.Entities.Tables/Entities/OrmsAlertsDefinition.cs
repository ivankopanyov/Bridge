namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAlertsDefinition
{
    public OrmsAlertsDefinition()
    {
        OrmsAlertsDefinitionDates = new HashSet<OrmsAlertsDefinitionDates>();
        OrmsAlertsParameters = new HashSet<OrmsAlertsParameters>();
    }

    public decimal? AlertId { get; set; }
    public string? Resort { get; set; }
    public string? AlertName { get; set; }
    public string? AlertOnlyYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Code { get; set; }
    public string? AlertText { get; set; }
    public string? AlertColor { get; set; }
    public string? SeasonCode { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? EventCodes { get; set; }
    public decimal? Priority { get; set; }
    public string? DisplayPages { get; set; }

    public virtual ICollection<OrmsAlertsDefinitionDates> OrmsAlertsDefinitionDates { get; set; }
    public virtual ICollection<OrmsAlertsParameters> OrmsAlertsParameters { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAlertsDefinition>(entity =>
        {
            entity.HasKey(e => e.AlertId)
                .HasName("ORMS_ALERT_DEF_PK");

            entity.ToTable("ORMS_ALERTS_DEFINITION");

            entity.HasIndex(e => new { e.Resort, e.Code })
                .HasName("ORMS_ALERTS_DEFINITION_UK1")
                .IsUnique();

            entity.Property(e => e.AlertId)
                .HasColumnName("ALERT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertColor)
                .HasColumnName("ALERT_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'#FFCCCC'");

            entity.Property(e => e.AlertName)
                .IsRequired()
                .HasColumnName("ALERT_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertOnlyYn)
                .HasColumnName("ALERT_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.AlertText)
                .IsRequired()
                .HasColumnName("ALERT_TEXT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.DisplayPages)
                .HasColumnName("DISPLAY_PAGES")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.EventCodes)
                .HasColumnName("EVENT_CODES")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsAlertsDefinitionDates)))
				entity.Ignore(e => e.OrmsAlertsDefinitionDates);

			if (!types.Contains(typeof(OrmsAlertsParameters)))
				entity.Ignore(e => e.OrmsAlertsParameters);
		});
	}
}
