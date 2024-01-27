namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventChanges
{
    public decimal EventChangeId { get; set; }
    public decimal BookId { get; set; }
    public string Resort { get; set; }
    public decimal EventId { get; set; }
    public string RevenueType { get; set; }
    public DateTime? EventDate { get; set; }
    public string EventStatus { get; set; }
    public decimal? EventRevenue { get; set; }
    public string Currency { get; set; }
    public decimal? Attendees { get; set; }
    public string MainSrepResort { get; set; }
    public decimal? MainSrep { get; set; }
    public string RmsSrepResort { get; set; }
    public decimal? RmsSrep { get; set; }
    public string CatSrepResort { get; set; }
    public decimal? CatSrep { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string PkgRevenueYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventChanges>(entity =>
        {
            entity.HasKey(e => e.EventChangeId)
                .HasName("EC_PK");

            entity.ToTable("EVENT$CHANGES");

            entity.HasIndex(e => e.EventId)
                .HasName("EC_EVENT_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("EC_BOOK_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.EventDate })
                .HasName("EC_INSERTDATE_IDX");

            entity.Property(e => e.EventChangeId)
                .HasColumnName("EVENT_CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrep)
                .HasColumnName("CAT_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrepResort)
                .HasColumnName("CAT_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventRevenue)
                .HasColumnName("EVENT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrep)
                .HasColumnName("MAIN_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrepResort)
                .HasColumnName("MAIN_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgRevenueYn)
                .HasColumnName("PKG_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrep)
                .HasColumnName("RMS_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsSrepResort)
                .HasColumnName("RMS_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventChanges)
	                .HasForeignKey(d => d.EventId)
	                .HasConstraintName("EC_GE_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.EventChanges)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EC_AH_FK");
        });
	}
}
