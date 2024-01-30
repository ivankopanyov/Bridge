namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PrAutomergeKeyvalues
{
    public string? Label { get; set; }
    public string? SourceTable { get; set; }
    public string? SourceColumn { get; set; }
    public string? ProfileType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrAutomergeKeyvalues>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PR_AUTOMERGE_KEYVALUES");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(26)
                .IsUnicode(false);

            entity.Property(e => e.SourceColumn)
                .HasColumnName("SOURCE_COLUMN")
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.Property(e => e.SourceTable)
                .HasColumnName("SOURCE_TABLE")
                .HasMaxLength(18)
                .IsUnicode(false);
        });
	}
}
