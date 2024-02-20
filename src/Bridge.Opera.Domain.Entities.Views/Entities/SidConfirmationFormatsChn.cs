namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidConfirmationFormatsChn
{
    public string? ChainCode { get; set; }
    public string? FormatCode { get; set; }
    public string? FormatType { get; set; }
    public string? FormatDefinition { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidConfirmationFormatsChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CONFIRMATION_FORMATS_CHN");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FormatCode)
                .IsRequired()
                .HasColumnName("FORMAT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormatDefinition)
                .IsRequired()
                .HasColumnName("FORMAT_DEFINITION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FormatType)
                .IsRequired()
                .HasColumnName("FORMAT_TYPE")
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
