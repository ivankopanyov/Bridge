namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Qrooms
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime? QueueStart { get; set; }
    public DateTime? QueueEnd { get; set; }
    public decimal? QueuePriority { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? SmsSentOn { get; set; }
    public string SmsSentBy { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Qrooms>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("QROOMS_PK");

            entity.ToTable("QROOMS");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate })
                .HasName("QRM_BDATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.QueuePriority })
                .HasName("QRM_PRIORITY_IDX");

            entity.HasIndex(e => new { e.Resort, e.QueueStart })
                .HasName("QRM_DATE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QueueEnd)
                .HasColumnName("QUEUE_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QueuePriority)
                .HasColumnName("QUEUE_PRIORITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QueueStart)
                .HasColumnName("QUEUE_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmsSentBy)
                .HasColumnName("SMS_SENT_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentOn)
                .HasColumnName("SMS_SENT_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithOne(p => p.Qrooms)
	                .HasForeignKey<Qrooms>(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("QRMS_RESVNAME_FK");
        });
	}
}
