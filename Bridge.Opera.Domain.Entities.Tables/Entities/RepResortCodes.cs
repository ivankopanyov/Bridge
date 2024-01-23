namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepResortCodes
{
    public decimal LovGrpId { get; set; }
    public string FormName { get; set; }
    public string BlockName { get; set; }
    public string ItemName { get; set; }
    public string ReportName { get; set; }
    public string Resort { get; set; }
    public string LovMode { get; set; }
    public string Codes { get; set; }
    public string Description { get; set; }
    public string AssociatedCodes { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResortCodes>(entity =>
        {
            entity.HasKey(e => e.LovGrpId)
                .HasName("RRC_PK");

            entity.ToTable("REP_RESORT_CODES");

            entity.HasIndex(e => new { e.FormName, e.BlockName, e.ItemName, e.ReportName, e.Resort, e.LovMode, e.Codes })
                .HasName("REP_RESORT_IDX1")
                .IsUnique();

            entity.Property(e => e.LovGrpId)
                .HasColumnName("LOV_GRP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssociatedCodes)
                .HasColumnName("ASSOCIATED_CODES")
                .IsUnicode(false);

            entity.Property(e => e.BlockName)
                .IsRequired()
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Codes)
                .IsRequired()
                .HasColumnName("CODES")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LovMode)
                .HasColumnName("LOV_MODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'DEFAULT'");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportName)
                .IsRequired()
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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
