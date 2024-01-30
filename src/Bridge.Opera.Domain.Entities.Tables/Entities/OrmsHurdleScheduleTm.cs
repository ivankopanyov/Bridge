namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsHurdleScheduleTm
{
    public string? Resort { get; set; }
    public string? SchDetailId { get; set; }
    public DateTime? SchTime { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsHurdleScheduleTm>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SchDetailId, e.SchTime })
                .HasName("ORMS_HURDLE_SC_TM_PK");

            entity.ToTable("ORMS_HURDLE_SCHEDULE_TM");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SchDetailId)
                .HasColumnName("SCH_DETAIL_ID")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SchTime)
                .HasColumnName("SCH_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
        });
	}
}
