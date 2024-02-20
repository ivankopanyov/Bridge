namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentChanges
{
    public decimal? AllotmentChangeId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? Roomnights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public string? BookingStatus { get; set; }
    public string? MainSrepResort { get; set; }
    public decimal? MainSrep { get; set; }
    public string? RmsSrepResort { get; set; }
    public decimal? RmsSrep { get; set; }
    public string? CatSrepResort { get; set; }
    public decimal? CatSrep { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentChanges>(entity =>
        {
            entity.HasKey(e => e.AllotmentChangeId)
                .HasName("ALC_PK");

            entity.ToTable("ALLOTMENT_CHANGES");

            entity.HasIndex(e => e.StayDate)
                .HasName("ALC_STAY_DATE_IDX");

            entity.HasIndex(e => new { e.BookingStatus, e.Resort })
                .HasName("ALC_BOOKING_STATUS_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.Resort })
                .HasName("ALC_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.StayDate })
                .HasName("ALC_AH_ID_IDX");

            entity.Property(e => e.AllotmentChangeId)
                .HasColumnName("ALLOTMENT_CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatSrep)
                .HasColumnName("CAT_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrepResort)
                .HasColumnName("CAT_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MainSrep)
                .HasColumnName("MAIN_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrepResort)
                .HasColumnName("MAIN_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrep)
                .HasColumnName("RMS_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsSrepResort)
                .HasColumnName("RMS_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomnights)
                .HasColumnName("ROOMNIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentChanges)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALC_AH_FK");
        });
	}
}
