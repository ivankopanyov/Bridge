namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CompRoutingView
{
    public string? RoutingType { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? BillingInstrnCode { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? CompCovers { get; set; }
    public string? UserName { get; set; }
    public string? CompTypeCode { get; set; }
    public string? ResvStatus { get; set; }
    public string? RoutingInstructionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CompRoutingView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMP_ROUTING_VIEW");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompCovers)
                .HasColumnName("COMP_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingInstructionList)
                .HasColumnName("ROUTING_INSTRUCTION_LIST")
                .IsUnicode(false);

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);
        });
	}
}
