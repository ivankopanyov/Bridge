namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidEntityDetailChn
{
    public string? EntityName { get; set; }
    public string? AttributeCode { get; set; }
    public string? Description { get; set; }
    public string? LanguageCode { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Comments { get; set; }
    public string? DisplayColor { get; set; }
    public decimal? TitleSuffix { get; set; }
    public string? BusinessTitle { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidEntityDetailChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ENTITY_DETAIL_CHN");

            entity.Property(e => e.AttributeCode)
                .IsRequired()
                .HasColumnName("ATTRIBUTE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
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
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TitleSuffix)
                .HasColumnName("TITLE_SUFFIX")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
