namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileDataElements
{
    public decimal? ActionId { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public decimal? ProfDataElementId { get; set; }
    public string? ElementType { get; set; }
    public decimal? ElementSeq { get; set; }
    public string? ElementRole { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileDataElements>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_DATA_ELEMENTS");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
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

            entity.Property(e => e.ElementRole)
                .HasColumnName("ELEMENT_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElementSeq)
                .HasColumnName("ELEMENT_SEQ")
                .HasColumnType("NUMBER")
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

            entity.Property(e => e.ProfDataElementId)
                .HasColumnName("PROF_DATA_ELEMENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
