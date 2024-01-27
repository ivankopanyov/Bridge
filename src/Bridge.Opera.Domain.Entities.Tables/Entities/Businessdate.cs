namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Businessdate
{
    public string Weather { get; set; }
    public string Resort { get; set; }
    public DateTime BusinessDate1 { get; set; }
    public string State { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string MandatoryProcsProgress { get; set; }
    public decimal? NaTranActionId { get; set; }
    public string LedgersBalancedYn { get; set; }
    public string LedgersFixedYn { get; set; }
    public DateTime? LedgersFixedDate { get; set; }
    public DateTime? QrushSmsSentOn { get; set; }
    public string QrushSmsSentBy { get; set; }
    public string PmsActiveYn { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Businessdate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BusinessDate1 })
                .HasName("BUSINESS_DATE_PK");

            entity.ToTable("BUSINESSDATE");

            entity.HasIndex(e => new { e.Resort, e.InsertDate })
                .HasName("BD_INSERT_IDX");

            entity.HasIndex(e => new { e.Resort, e.State })
                .HasName("BD_STATUS_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate1)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LedgersBalancedYn)
                .HasColumnName("LEDGERS_BALANCED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LedgersFixedDate)
                .HasColumnName("LEDGERS_FIXED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LedgersFixedYn)
                .HasColumnName("LEDGERS_FIXED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryProcsProgress)
                .HasColumnName("MANDATORY_PROCS_PROGRESS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NaTranActionId)
                .HasColumnName("NA_TRAN_ACTION_ID")
                .HasColumnType("NUMBER(37)");

            entity.Property(e => e.PmsActiveYn)
                .HasColumnName("PMS_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QrushSmsSentBy)
                .HasColumnName("QRUSH_SMS_SENT_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.QrushSmsSentOn)
                .HasColumnName("QRUSH_SMS_SENT_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.State)
                .IsRequired()
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'OPEN'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Weather)
                .HasColumnName("WEATHER")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.Businessdate)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BUSINESS_DATE_FK1");
        });
	}
}
