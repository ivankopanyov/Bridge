namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BlockOffsetDataElements
{
    public decimal? ActionInstanceId { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public DateTime? ScopeFrom { get; set; }
    public DateTime? ScopeTo { get; set; }
    public decimal? RaDataElementId { get; set; }
    public string? ElementType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlockOffsetDataElements>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BLOCK_OFFSET_DATA_ELEMENTS");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElementType)
                .HasColumnName("ELEMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RaDataElementId)
                .HasColumnName("RA_DATA_ELEMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();
        });
	}
}
