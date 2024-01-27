namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BeDetailsGtt
{
    public string OriginalTable { get; set; }
    public decimal DataElementId { get; set; }
    public string ActionType { get; set; }
    public decimal ActionInstanceId { get; set; }
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
		modelBuilder.Entity<BeDetailsGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BE_DETAILS_GTT");

            entity.HasIndex(e => new { e.DataElementId, e.OriginalTable })
                .HasName("BE_DETAILS_IDX2");

            entity.HasIndex(e => new { e.OriginalTable, e.ActionType, e.ActionInstanceId, e.DataElement, e.ScopeFrom, e.ScopeTo, e.ElementSeq, e.ElementType, e.ElementRole, e.Resort })
                .HasName("BE_DETAILS_IDX3");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DataElementId)
                .HasColumnName("DATA_ELEMENT_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OriginalTable)
                .IsRequired()
                .HasColumnName("ORIGINAL_TABLE")
                .HasMaxLength(10)
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
