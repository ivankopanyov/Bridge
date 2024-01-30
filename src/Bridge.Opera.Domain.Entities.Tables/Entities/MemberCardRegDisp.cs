namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemberCardRegDisp
{
    public string? ChainCode { get; set; }
    public string? DisplayMode { get; set; }
    public string? EntityName { get; set; }
    public string? MembershipType { get; set; }
    public string? CodeTypeKeyval { get; set; }
    public string? RequiredYn { get; set; }
    public string? SidYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegDisp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBER_CARD_REG_DISP");

            entity.HasIndex(e => new { e.ChainCode, e.DisplayMode, e.EntityName, e.MembershipType, e.CodeTypeKeyval })
                .HasName("MEMBER_CARD_REG_DISP_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CodeTypeKeyval)
                .HasColumnName("CODE_TYPE_KEYVAL")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DisplayMode)
                .IsRequired()
                .HasColumnName("DISPLAY_MODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .IsRequired()
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

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

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SidYn)
                .HasColumnName("SID_YN")
                .HasMaxLength(1)
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
