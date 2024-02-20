namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntExchangedEntities
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? Entity { get; set; }
    public string? Code { get; set; }
    public string? MasterCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntExchangedEntities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_EXCHANGED_ENTITIES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Entity)
                .IsRequired()
                .HasColumnName("ENTITY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MasterCode)
                .HasColumnName("MASTER_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
