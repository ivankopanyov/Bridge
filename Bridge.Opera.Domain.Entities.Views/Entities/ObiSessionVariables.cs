namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiSessionVariables
{
    public string CodeName { get; set; }
    public string CodeValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSessionVariables>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SESSION_VARIABLES");

            entity.Property(e => e.CodeName)
                .HasColumnName("CODE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CodeValue)
                .HasColumnName("CODE_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
