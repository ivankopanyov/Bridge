namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictionChannels
{
    public string Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string ExternalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictionChannels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTION_CHANNELS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExternalYn)
                .HasColumnName("EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
