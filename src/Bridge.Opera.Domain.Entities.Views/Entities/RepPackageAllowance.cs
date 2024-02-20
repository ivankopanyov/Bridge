namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepPackageAllowance
{
    public string? Room { get; set; }
    public string? RateCode { get; set; }
    public string? Product { get; set; }
    public string? Description { get; set; }
    public string? PosNextDayYn { get; set; }
    public decimal? Allowance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepPackageAllowance>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PACKAGE_ALLOWANCE");

            entity.Property(e => e.Allowance)
                .HasColumnName("ALLOWANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PosNextDayYn)
                .HasColumnName("POS_NEXT_DAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
