namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScDemandDayType
{
    public ScDemandDayType()
    {
        ScDemandDates = new HashSet<ScDemandDates>();
    }

    public string? Resort { get; set; }
    public string? DtCode { get; set; }
    public string? Description { get; set; }
    public string? DisplayColor { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<ScDemandDates> ScDemandDates { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScDemandDayType>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DtCode })
                .HasName("SCDDT_PK");

            entity.ToTable("SC_DEMAND_DAY_TYPE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(ScDemandDates)))
				entity.Ignore(e => e.ScDemandDates);
		});
	}
}
