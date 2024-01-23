namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BeDetailsGttLog
{
    public decimal? ReportId { get; set; }
    public string OriginalTable { get; set; }
    public decimal? DataElementId { get; set; }
    public string ActionType { get; set; }
    public decimal? ActionInstanceId { get; set; }
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
		modelBuilder.Entity<BeDetailsGttLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BE_DETAILS_GTT_LOG");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DataElementId)
                .HasColumnName("DATA_ELEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementRole)
                .HasColumnName("ELEMENT_ROLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ElementSeq)
                .HasColumnName("ELEMENT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementType)
                .HasColumnName("ELEMENT_TYPE")
                .HasMaxLength(100)
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
                .HasColumnName("ORIGINAL_TABLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
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
