namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsMilestones
{
    public string? Resort { get; set; }
    public bool MilestoneId { get; set; }
    public byte FromLeadday { get; set; }
    public byte ToLeadday { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsMilestones>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MilestoneId })
                .HasName("ORMS_MILESTONES_PK");

            entity.ToTable("ORMS_MILESTONES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MilestoneId).HasColumnName("MILESTONE_ID");

            entity.Property(e => e.FromLeadday).HasColumnName("FROM_LEADDAY");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToLeadday).HasColumnName("TO_LEADDAY");

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
