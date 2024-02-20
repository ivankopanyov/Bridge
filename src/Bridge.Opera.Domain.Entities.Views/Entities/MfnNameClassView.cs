namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MfnNameClassView
{
    public string? NameType { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MfnNameClassView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MFN_NAME_CLASS_VIEW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
