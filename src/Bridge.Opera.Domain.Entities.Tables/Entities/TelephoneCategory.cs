namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TelephoneCategory
{
    public string? CategoryCode { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public decimal? CategorySeq { get; set; }
    public string? IsCategoryGeneric { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TelephoneCategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryCode, e.Resort })
                .HasName("TELEPHONE$_CATEGORY_PK");

            entity.ToTable("TELEPHONE$_CATEGORY");

            entity.HasIndex(e => e.CategorySeq)
                .HasName("TELEPHONE$_CATEGORY_UK")
                .IsUnique();

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategorySeq)
                .HasColumnName("CATEGORY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsCategoryGeneric)
                .HasColumnName("IS_CATEGORY_GENERIC")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
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
