namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmSchedule
{
    public decimal ScheduleId { get; set; }
    public string Resort { get; set; }
    public string OutletCode { get; set; }
    public string ResId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string BeginTimeHh24mi { get; set; }
    public string EndTimeHh24mi { get; set; }
    public string Dayofweek { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmSchedule>(entity =>
        {
            entity.HasKey(e => new { e.ScheduleId, e.Resort })
                .HasName("LM_SCHEDULE_PK");

            entity.ToTable("LM_SCHEDULE");

            entity.HasIndex(e => new { e.OutletCode, e.Resort, e.BeginDate, e.EndDate, e.BeginTimeHh24mi, e.EndTimeHh24mi, e.Dayofweek })
                .HasName("LM_SCHEDULE_IND");

            entity.HasIndex(e => new { e.ResId, e.Resort, e.BeginDate, e.EndDate, e.BeginTimeHh24mi, e.EndTimeHh24mi, e.Dayofweek })
                .HasName("LM_SCHEDULE_IND2");

            entity.Property(e => e.ScheduleId)
                .HasColumnName("SCHEDULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginTimeHh24mi)
                .IsRequired()
                .HasColumnName("BEGIN_TIME_HH24MI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dayofweek)
                .HasColumnName("DAYOFWEEK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTimeHh24mi)
                .IsRequired()
                .HasColumnName("END_TIME_HH24MI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

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
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

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
