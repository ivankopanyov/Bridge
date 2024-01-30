namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CateringChangelogDetail
{
    public decimal? ChangeId { get; set; }
    public string? Fieldname { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringChangelogDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CATERING_CHANGELOG_DETAIL");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fieldname)
                .IsRequired()
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
