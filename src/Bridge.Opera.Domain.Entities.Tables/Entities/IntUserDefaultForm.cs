namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntUserDefaultForm
{
    public string? UserName { get; set; }
    public string? FormName { get; set; }
    public string? Parameter { get; set; }
    public string? Application { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntUserDefaultForm>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.Application })
                .HasName("INT_USER_DEFAULT_FORM_PK");

            entity.ToTable("INT_USER_DEFAULT_FORM");

            entity.HasIndex(e => e.FormName)
                .HasName("INT_USER_DEFAULT_FORM_NAME");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Parameter)
                .HasColumnName("PARAMETER")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
