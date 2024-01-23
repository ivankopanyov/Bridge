namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LeadChanges
{
    public decimal ActionId { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string ActionDesc { get; set; }
    public string Machine { get; set; }
    public string Module { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadChanges>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("LCE_PK");

            entity.ToTable("LEAD_CHANGES");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("LCE_ALLOTMENT_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.Resort })
                .HasName("LCE_INSERT_DATE_IDX");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
