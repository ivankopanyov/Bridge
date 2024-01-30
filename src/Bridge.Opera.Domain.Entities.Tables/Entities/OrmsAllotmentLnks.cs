namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentLnks
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? LinkedAllotmentId { get; set; }
    public decimal? LinkSequence { get; set; }
    public string? LinkedBy { get; set; }
    public DateTime? CycleStart { get; set; }
    public DateTime? CycleEnd { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentLnks>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AllotmentHeaderId, e.LinkSequence })
                .HasName("ORMS_ALLOTMENT_LNKS_PK");

            entity.ToTable("ORMS_ALLOTMENT_LNKS");

            entity.HasIndex(e => new { e.Resort, e.LinkedAllotmentId })
                .HasName("ORMS_ALLOTMENT_LNKS_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkSequence)
                .HasColumnName("LINK_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CycleEnd)
                .HasColumnName("CYCLE_END")
                .HasColumnType("DATE");

            entity.Property(e => e.CycleStart)
                .HasColumnName("CYCLE_START")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkedAllotmentId)
                .HasColumnName("LINKED_ALLOTMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkedBy)
                .IsRequired()
                .HasColumnName("LINKED_BY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
