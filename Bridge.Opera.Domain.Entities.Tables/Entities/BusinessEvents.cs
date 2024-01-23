namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessEvents
{
    public string Module { get; set; }
    public decimal? ActionId { get; set; }
    public string ExtSystemCode { get; set; }
    public string DataElement { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
    public DateTime? ScopeFrom { get; set; }
    public DateTime? ScopeTo { get; set; }
    public decimal? ElementSeq { get; set; }
    public string ElementType { get; set; }
    public string ElementRole { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessEvents>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BUSINESS_EVENTS");

            entity.HasIndex(e => new { e.ExtSystemCode, e.Module, e.ActionId })
                .HasName("BUSINESS_EVENTS_IDX1");

            entity.HasIndex(e => new { e.Module, e.ActionId, e.ExtSystemCode, e.DataElement, e.ScopeFrom, e.ScopeTo, e.ElementSeq, e.ElementType, e.ElementRole })
                .HasName("BUS_EVENTS_UK")
                .IsUnique();

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ElementRole)
                .HasColumnName("ELEMENT_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ElementSeq)
                .HasColumnName("ELEMENT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementType)
                .HasColumnName("ELEMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("DATE");
        });
	}
}
