namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BankMaster
{
    public string? Resort { get; set; }
    public string? BankCode { get; set; }
    public string? BranchCode { get; set; }
    public string? BankName { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BankMaster>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BankCode, e.BranchCode })
                .HasName("BANK_MASTER_PK");

            entity.ToTable("BANK_MASTER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasColumnName("BANK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BranchCode)
                .HasColumnName("BRANCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasColumnName("BANK_NAME")
                .HasMaxLength(2000)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
