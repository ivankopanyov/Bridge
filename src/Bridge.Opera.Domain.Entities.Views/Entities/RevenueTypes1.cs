namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RevenueTypes1
{
    public string? RevType { get; set; }
    public string? RevGroup { get; set; }
    public string? Description { get; set; }
    public string? FbClass { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? Vat { get; set; }
    public string? ContributeMinRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REVENUE_TYPES");

            entity.Property(e => e.ContributeMinRevenueYn)
                .HasColumnName("CONTRIBUTE_MIN_REVENUE_YN")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FbClass)
                .HasColumnName("FB_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .IsRequired()
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");
        });
	}
}
