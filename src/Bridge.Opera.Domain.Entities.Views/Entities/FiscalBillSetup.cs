namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FiscalBillSetup
{
    public string Resort { get; set; }
    public string Period { get; set; }
    public string Description { get; set; }
    public string Prefix { get; set; }
    public decimal? BeginNo { get; set; }
    public decimal? EndNo { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? CurrentFiscalBillNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FiscalBillSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FISCAL_BILL_SETUP");

            entity.Property(e => e.BeginNo)
                .HasColumnName("BEGIN_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentFiscalBillNo)
                .HasColumnName("CURRENT_FISCAL_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.EndNo)
                .HasColumnName("END_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Period)
                .IsRequired()
                .HasColumnName("PERIOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Prefix)
                .HasColumnName("PREFIX")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
