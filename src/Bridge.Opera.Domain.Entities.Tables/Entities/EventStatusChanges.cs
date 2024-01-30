namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventStatusChanges
{
    public decimal? EvChangeId { get; set; }
    public decimal? EventId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public string? PriorStatus { get; set; }
    public string? CurrentStatus { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventStatusChanges>(entity =>
        {
            entity.HasKey(e => e.EvChangeId)
                .HasName("ESC_PK");

            entity.ToTable("EVENT$STATUS_CHANGES");

            entity.HasIndex(e => e.EventId)
                .HasName("ESC_GE_FK_IDX");

            entity.HasIndex(e => e.InsertDate)
                .HasName("ESC_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("ESC_AH_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId })
                .HasName("ESC_EVENT_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.CurrentStatus, e.InsertDate })
                .HasName("ESC_STATUS_IDX");

            entity.Property(e => e.EvChangeId)
                .HasColumnName("EV_CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventStatusChanges)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ESC_GE_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.EventStatusChanges)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ESC_AH_FK");
        });
	}
}
