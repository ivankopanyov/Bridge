namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationChildren
{
    public decimal ResvChildId { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal Age { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? ResvDailyElSeq { get; set; }
    public DateTime? ReservationDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationChildren>(entity =>
        {
            entity.HasKey(e => e.ResvChildId)
                .HasName("RESV_CHILD_PK");

            entity.ToTable("RESERVATION_CHILDREN");

            entity.HasIndex(e => new { e.ResvNameId, e.ReservationDate, e.ResvChildId })
                .HasName("RC_UK1")
                .IsUnique();

            entity.Property(e => e.ResvChildId)
                .HasColumnName("RESV_CHILD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age)
                .HasColumnName("AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvDailyElSeq)
                .HasColumnName("RESV_DAILY_EL_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
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
