namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NaParameters
{
    public string? Resort { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? CashierId { get; set; }
    public string? StopNightAudit { get; set; }
    public string? Terminal { get; set; }
    public decimal? NightAuditSid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NA_PARAMETERS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightAuditSid)
                .HasColumnName("NIGHT_AUDIT_SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StopNightAudit)
                .HasColumnName("STOP_NIGHT_AUDIT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
