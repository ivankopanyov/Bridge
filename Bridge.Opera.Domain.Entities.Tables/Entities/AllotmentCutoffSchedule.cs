namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentCutoffSchedule
{
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public DateTime CutoffDate { get; set; }
    public decimal? CutoffPerc { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? CutoffRooms1 { get; set; }
    public decimal? CutoffRooms2 { get; set; }
    public decimal? CutoffRooms3 { get; set; }
    public decimal? CutoffRooms4 { get; set; }
    public decimal? CutoffSellRooms { get; set; }
    public string RoomCategories { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentCutoffSchedule>(entity =>
        {
            entity.HasKey(e => new { e.CutoffDate, e.Resort, e.AllotmentHeaderId })
                .HasName("ACS_PK");

            entity.ToTable("ALLOTMENT_CUTOFF_SCHEDULE");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ACS_BOOK_IDX");

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffPerc)
                .HasColumnName("CUTOFF_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms1)
                .HasColumnName("CUTOFF_ROOMS1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms2)
                .HasColumnName("CUTOFF_ROOMS2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms3)
                .HasColumnName("CUTOFF_ROOMS3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffRooms4)
                .HasColumnName("CUTOFF_ROOMS4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffSellRooms)
                .HasColumnName("CUTOFF_SELL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategories)
                .HasColumnName("ROOM_CATEGORIES")
                .HasMaxLength(2000)
                .IsUnicode(false);

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
	                .WithMany(p => p.AllotmentCutoffSchedule)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("ACS_AH_FK");
        });
	}
}
