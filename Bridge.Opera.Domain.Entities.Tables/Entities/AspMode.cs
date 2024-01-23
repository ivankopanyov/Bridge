namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AspMode
{
    public string AspYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AspMode>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ASP_MODE");

            entity.Property(e => e.AspYn)
                .HasColumnName("ASP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
