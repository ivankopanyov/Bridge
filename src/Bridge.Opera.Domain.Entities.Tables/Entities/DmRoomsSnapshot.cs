namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DmRoomsSnapshot
{
    public decimal? ActionId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? CurrentStatus { get; set; }
    public string? PriorStatus { get; set; }
    public decimal? AvgRate { get; set; }
    public decimal? TotalRooms { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string? DmProcessedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmRoomsSnapshot>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("DM_RS_PK");

            entity.ToTable("DM_ROOMS_SNAPSHOT");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("DM_RS_AH_RESORT_IDX");

            entity.HasIndex(e => new { e.DmProcessedYn, e.Resort, e.InsertDate })
                .HasName("DM_RS_PROCESSED_YN");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRate)
                .HasColumnName("AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
