namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuDetails1
{
    public decimal? MenuId { get; set; }
    public string? Resort { get; set; }
    public decimal? MitId { get; set; }
    public byte? Course { get; set; }
    public byte? CourseOrder { get; set; }
    public string? ShowbeoYn { get; set; }
    public decimal? Serving { get; set; }
    public string? IncludedYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? DemandFactor { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? CreationSeq { get; set; }
    public string? ConsumptionYn { get; set; }
    public string? MandatoryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENU_DETAILS");

            entity.Property(e => e.ConsumptionYn)
                .HasColumnName("CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Course)
                .HasColumnName("COURSE")
                .HasColumnType("NUMBER(4)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CourseOrder)
                .HasColumnName("COURSE_ORDER")
                .HasColumnType("NUMBER(4)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreationSeq)
                .HasColumnName("CREATION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DemandFactor)
                .HasColumnName("DEMAND_FACTOR")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncludedYn)
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.MandatoryYn)
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Serving)
                .HasColumnName("SERVING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowbeoYn)
                .HasColumnName("SHOWBEO_YN")
                .HasMaxLength(1)
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
        });
	}
}
