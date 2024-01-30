namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AssignmentReasonsTemplate
{
    public string? AssignReason { get; set; }
    public string? AssignDesc { get; set; }
    public string? AssignType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ChainCode { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AssignmentReasonsTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.AssignReason })
                .HasName("ASSIGNMENT_REASONS_TEMPLAT_PK");

            entity.ToTable("ASSIGNMENT_REASONS_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignDesc)
                .HasColumnName("ASSIGN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .IsRequired()
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
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
