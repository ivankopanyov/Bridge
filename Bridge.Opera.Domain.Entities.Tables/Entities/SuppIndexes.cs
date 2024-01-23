namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SuppIndexes
{
    public string IndexName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SuppIndexes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SUPP_INDEXES");

            entity.Property(e => e.IndexName)
                .IsRequired()
                .HasColumnName("INDEX_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
