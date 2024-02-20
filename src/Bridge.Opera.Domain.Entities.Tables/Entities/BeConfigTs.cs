namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BeConfigTs
{
    public DateTime? ChangedAt { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BeConfigTs>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BE_CONFIG_TS");

            entity.HasIndex(e => e.ChangedAt)
                .HasName("BE_CONFIG_TS_IDX1");

            entity.Property(e => e.ChangedAt)
                .HasColumnName("CHANGED_AT")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
