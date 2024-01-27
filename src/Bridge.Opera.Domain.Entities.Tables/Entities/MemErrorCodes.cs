namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemErrorCodes
{
    public string OperaErrorCode { get; set; }
    public string OperaErrorDescription { get; set; }
    public string AcceptRejectIndicator { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemErrorCodes>(entity =>
        {
            entity.HasKey(e => e.OperaErrorCode)
                .HasName("MEE_PK");

            entity.ToTable("MEM_ERROR_CODES");

            entity.Property(e => e.OperaErrorCode)
                .HasColumnName("OPERA_ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AcceptRejectIndicator)
                .HasColumnName("ACCEPT_REJECT_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaErrorDescription)
                .HasColumnName("OPERA_ERROR_DESCRIPTION")
                .HasMaxLength(2000)
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
