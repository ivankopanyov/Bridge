namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidNoteTypesChn
{
    public string ChainCode { get; set; }
    public string NoteType { get; set; }
    public string NoteCode { get; set; }
    public string Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string CanDeleteYn { get; set; }
    public string DefaultYn { get; set; }
    public string InternalYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string OverrideInternal { get; set; }
    public string ProtectDescriptionYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidNoteTypesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_NOTE$TYPES_CHN");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteType)
                .IsRequired()
                .HasColumnName("NOTE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideInternal)
                .HasColumnName("OVERRIDE_INTERNAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProtectDescriptionYn)
                .HasColumnName("PROTECT_DESCRIPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
