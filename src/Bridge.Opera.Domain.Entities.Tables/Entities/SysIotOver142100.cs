namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SysIotOver142100
{

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SysIotOver142100>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SYS_IOT_OVER_142100");
        });
	}
}
