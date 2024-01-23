namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpgradeFtTo34
{
    public decimal? TrxNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpgradeFtTo34>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("UPGRADE_FT_TO_34");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
