namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WaitlistCodes
{
    public string WaitlistReasonCode { get; set; }
    public string WaitlistReasonDesc { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string Resort { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WaitlistCodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.WaitlistReasonCode })
                .HasName("WAITLIST_CODES_PK");

            entity.ToTable("WAITLIST_CODES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WaitlistReasonCode)
                .HasColumnName("WAITLIST_REASON_CODE")
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

            entity.Property(e => e.WaitlistReasonDesc)
                .HasColumnName("WAITLIST_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
