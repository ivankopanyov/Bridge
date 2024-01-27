namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SysIotOver165791
{

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SysIotOver165791>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SYS_IOT_OVER_165791");
        });
	}
}
