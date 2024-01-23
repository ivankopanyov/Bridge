namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipRevenueGroupCodes
{
    public string MemRevenueGroup { get; set; }
    public string MembershipRevenueType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipRevenueGroupCodes>(entity =>
        {
            entity.HasKey(e => new { e.MemRevenueGroup, e.MembershipRevenueType })
                .HasName("MEM_REVENUE_GROUP_CODES_PK");

            entity.ToTable("MEMBERSHIP_REVENUE_GROUP_CODES");

            entity.Property(e => e.MemRevenueGroup)
                .HasColumnName("MEM_REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipRevenueType)
                .HasColumnName("MEMBERSHIP_REVENUE_TYPE")
                .HasMaxLength(20)
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
