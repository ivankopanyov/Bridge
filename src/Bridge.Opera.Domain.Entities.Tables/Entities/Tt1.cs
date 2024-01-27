namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tt1
{
    public int? Invaluelist { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tt1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TT_1");

            entity.Property(e => e.Invaluelist)
                .HasColumnName("INVALUELIST")
                .HasColumnType("NUMBER(6)");
        });
	}
}
