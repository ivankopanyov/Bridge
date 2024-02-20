namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmpSchedule
{
    public decimal? ScheduleId { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public DateTime? Starttime { get; set; }
    public DateTime? Endtime { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpSchedule>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ScheduleId })
                .HasName("ES_PK");

            entity.ToTable("EMP_SCHEDULE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleId)
                .HasColumnName("SCHEDULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Endtime)
                .HasColumnName("ENDTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Starttime)
                .HasColumnName("STARTTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
