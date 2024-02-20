namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntOxiInterfaceResorts
{
    public string? InterfaceId { get; set; }
    public string? IntDescription { get; set; }
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public DateTime? BeInactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntOxiInterfaceResorts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_OXI_INTERFACE_RESORTS");

            entity.Property(e => e.BeInactiveDate)
                .HasColumnName("BE_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IntDescription)
                .HasColumnName("INT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
