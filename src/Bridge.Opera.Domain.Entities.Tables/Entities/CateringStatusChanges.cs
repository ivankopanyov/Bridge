namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CateringStatusChanges
{
    public decimal? ActionId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? PriorStatus { get; set; }
    public string? CurrentStatus { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringStatusChanges>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("CATSTATCHG_PK");

            entity.ToTable("CATERING_STATUS_CHANGES");

            entity.HasIndex(e => e.CurrentStatus)
                .HasName("CATSTATCHG_STATUS_IDX");

            entity.HasIndex(e => e.InsertDate)
                .HasName("CATSTATCHG_INSERTDATE_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("CATSTATCHG_BOOKID_IDX");

            entity.HasIndex(e => new { e.Resort, e.InsertDate, e.CurrentStatus })
                .HasName("CATSTATCHG_RES_DATE_STAT");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

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
        });
	}
}
