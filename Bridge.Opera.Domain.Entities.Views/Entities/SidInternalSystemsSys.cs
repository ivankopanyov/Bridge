namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidInternalSystemsSys
{
    public string Code { get; set; }
    public string Lic1 { get; set; }
    public string Lic2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidInternalSystemsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INTERNAL_SYSTEMS_SYS");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Lic1)
                .HasColumnName("LIC1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Lic2)
                .HasColumnName("LIC2")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
