namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmResource
{
    public string? ResId { get; set; }
    public string? Resort { get; set; }
    public string? ResDesc { get; set; }
    public string? ResType { get; set; }
    public string? ResLongDesc { get; set; }
    public decimal? Qty { get; set; }
    public decimal? NameId { get; set; }
    public string? AddonYn { get; set; }
    public string? ScheduleByOutletCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmResource>(entity =>
        {
            entity.HasKey(e => new { e.ResId, e.Resort })
                .HasName("LM_RESOURCE_PK");

            entity.ToTable("LM_RESOURCE");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddonYn)
                .IsRequired()
                .HasColumnName("ADDON_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.ResDesc)
                .IsRequired()
                .HasColumnName("RES_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResLongDesc)
                .HasColumnName("RES_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleByOutletCode)
                .HasColumnName("SCHEDULE_BY_OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
