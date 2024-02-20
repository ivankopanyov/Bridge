namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentAlternateDates
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? AlternateArrivalDate { get; set; }
    public DateTime? AlternateDepartureDate { get; set; }
    public decimal? AllotmentAltDateSeqno { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? SingleOccRate { get; set; }
    public decimal? DoubleOccRate { get; set; }
    public decimal? TripleOccRate { get; set; }
    public decimal? QuadOccRate { get; set; }
    public string? PreferredYn { get; set; }
    public string? ScRoomCategory { get; set; }
    public decimal? Priority { get; set; }
    public string? MainBookDatesYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentAlternateDates>(entity =>
        {
            entity.HasKey(e => e.AllotmentAltDateSeqno)
                .HasName("ALLOTMENT_ALT_DATES_PK");

            entity.ToTable("ALLOTMENT$ALTERNATE_DATES");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("AAD_AH_FKI");

            entity.Property(e => e.AllotmentAltDateSeqno)
                .HasColumnName("ALLOTMENT_ALT_DATE_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlternateArrivalDate)
                .HasColumnName("ALTERNATE_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AlternateDepartureDate)
                .HasColumnName("ALTERNATE_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DoubleOccRate)
                .HasColumnName("DOUBLE_OCC_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MainBookDatesYn)
                .HasColumnName("MAIN_BOOK_DATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferredYn)
                .HasColumnName("PREFERRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QuadOccRate)
                .HasColumnName("QUAD_OCC_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SingleOccRate)
                .HasColumnName("SINGLE_OCC_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TripleOccRate)
                .HasColumnName("TRIPLE_OCC_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentAlternateDates)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("AAD_AH_FK");
        });
	}
}
