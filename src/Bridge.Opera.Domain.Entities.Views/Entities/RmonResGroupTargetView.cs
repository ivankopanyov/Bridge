namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RmonResGroupTargetView
{
    public string SiteCode { get; set; }
    public string RemoteResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonResGroupTargetView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RMON_RES_GROUP_TARGET_VIEW");

            entity.Property(e => e.RemoteResort)
                .HasColumnName("REMOTE_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.SiteCode)
                .HasColumnName("SITE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
