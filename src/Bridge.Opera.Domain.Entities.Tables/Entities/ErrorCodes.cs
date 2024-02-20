namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ErrorCodes
{
    public string? Module { get; set; }
    public string? ReferenceId { get; set; }
    public string? ErrCode { get; set; }
    public string? ErrDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ErrorCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ERROR_CODES");

            entity.HasIndex(e => new { e.Module, e.ReferenceId })
                .HasName("ERROR_CODE_IDX");

            entity.Property(e => e.ErrCode)
                .IsRequired()
                .HasColumnName("ERR_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ErrDesc)
                .HasColumnName("ERR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReferenceId)
                .IsRequired()
                .HasColumnName("REFERENCE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
