namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractAcc
{
    public decimal? NameId { get; set; }
    public string? DisplayName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Citystatezip { get; set; }
    public string? Country { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractAcc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_ACC");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Citystatezip)
                .HasColumnName("CITYSTATEZIP")
                .HasMaxLength(99)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
