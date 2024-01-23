namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CommissionResvData
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ResvStatus { get; set; }
    public decimal? TravelAgentId { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? CommissionPaid { get; set; }
    public string PaidTaYn { get; set; }
    public string PaidSourceYn { get; set; }
    public string ProcessedYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CommissionResvData>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("COMMISSION_RESV_DATA_PK");

            entity.ToTable("COMMISSION_RESV_DATA");

            entity.HasIndex(e => new { e.Resort, e.ResvStatus })
                .HasName("COMMISSION_RESV_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaidSourceYn)
                .HasColumnName("PAID_SOURCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaidTaYn)
                .HasColumnName("PAID_TA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessedYn)
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.CommissionResvData)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("COMM_RESV_DATA_FK1");
        });
	}
}
