namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntExtSysActiveResort
{
    public string? Code { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntExtSysActiveResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_EXT_SYS_ACTIVE_RESORT");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
