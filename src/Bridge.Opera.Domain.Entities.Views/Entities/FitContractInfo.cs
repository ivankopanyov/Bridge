namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractInfo
{
    public decimal? ContractId { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public string? ContractPeriod { get; set; }
    public string? ContractNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_INFO");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractNo)
                .IsRequired()
                .HasColumnName("CONTRACT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractPeriod)
                .HasColumnName("CONTRACT_PERIOD")
                .HasMaxLength(153)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
