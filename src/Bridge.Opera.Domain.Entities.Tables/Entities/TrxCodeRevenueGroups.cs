namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodeRevenueGroups
{
    public string? Resort { get; set; }
    public decimal? RevGroupId { get; set; }
    public string? RevGroupCd { get; set; }
    public string? RevGroupType { get; set; }
    public string? RevGroupDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeRevenueGroups>(entity =>
        {
            entity.HasKey(e => e.RevGroupId)
                .HasName("REV_GROUP_PK");

            entity.ToTable("TRX$_CODE_REVENUE_GROUPS");

            entity.Property(e => e.RevGroupId)
                .HasColumnName("REV_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupCd)
                .IsRequired()
                .HasColumnName("REV_GROUP_CD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupDesc)
                .HasColumnName("REV_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupType)
                .IsRequired()
                .HasColumnName("REV_GROUP_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
