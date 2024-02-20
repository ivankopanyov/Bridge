namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentRoomtypePriorities
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? Priority { get; set; }
    public string? PriorityType { get; set; }
    public string? DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? DownloadDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public byte? LaptopChange { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentRoomtypePriorities>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ALLOTMENT_ROOMTYPE_PRIORITIES");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("ALLOTMENT_PRIORITY_RMCAT_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.RoomCategory })
                .HasName("ALLOTMENT_PRIORITY_UK1")
                .IsUnique();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorityType)
                .HasColumnName("PRIORITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'PMSGRID'");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany()
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_PRIORITY_FK1");
        });
	}
}
