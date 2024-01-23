namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AlternateResort
{
    public string Resort { get; set; }
    public string AlternateResort1 { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? Distance { get; set; }
    public string DistanceType { get; set; }
    public string DrivingTime { get; set; }
    public string Direction { get; set; }
    public string Comments { get; set; }
    public decimal? OrderBy { get; set; }
    public string CrossBookingYn { get; set; }
    public string CrossPostingYn { get; set; }
    public string CrossBlockingYn { get; set; }
    public string AlternateYn { get; set; }
    public string CrossReportingYn { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AlternateResort>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AlternateResort1 })
                .HasName("ALTERNATE_RESORT_PK");

            entity.ToTable("ALTERNATE_RESORT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlternateResort1)
                .HasColumnName("ALTERNATE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlternateYn)
                .HasColumnName("ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrossBlockingYn)
                .HasColumnName("CROSS_BLOCKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrossBookingYn)
                .HasColumnName("CROSS_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrossPostingYn)
                .HasColumnName("CROSS_POSTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrossReportingYn)
                .HasColumnName("CROSS_REPORTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Direction)
                .HasColumnName("DIRECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Distance)
                .HasColumnName("DISTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DistanceType)
                .HasColumnName("DISTANCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DrivingTime)
                .HasColumnName("DRIVING_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.AlternateResort)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALTERNATE_RESORT_FK1");
        });
	}
}
