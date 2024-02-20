namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractReplyStatus
{
    public string? StatusCode { get; set; }
    public string? Label { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractReplyStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_REPLY_STATUS");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasColumnType("CHAR(3)");
        });
	}
}
