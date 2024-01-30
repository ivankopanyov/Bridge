namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcDc
{
    public string? Resort { get; set; }
    public string? Selector { get; set; }
    public string? DpCode { get; set; }
    public string? Text { get; set; }
    public string? DbfLogo { get; set; }
    public decimal? RowNum { get; set; }
    public string? PostRoute { get; set; }
    public string? LineType { get; set; }
    public string? DialedDigits { get; set; }
    public string? ServingPeriod { get; set; }
    public string? RevenueCenter { get; set; }
    public string? Terminal { get; set; }
    public string? PaymentNumber { get; set; }
    public string? ItemNumber { get; set; }
    public string? Userid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcDc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_DC");

            entity.HasIndex(e => new { e.Resort, e.DbfLogo, e.Selector, e.PostRoute, e.LineType, e.DialedDigits, e.ServingPeriod, e.RevenueCenter, e.Terminal, e.PaymentNumber, e.ItemNumber, e.Userid })
                .HasName("IFC_DC_UK")
                .IsUnique();

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.DialedDigits)
                .HasColumnName("DIALED_DIGITS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DpCode)
                .HasColumnName("DP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemNumber)
                .HasColumnName("ITEM_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LineType)
                .HasColumnName("LINE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PaymentNumber)
                .HasColumnName("PAYMENT_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PostRoute)
                .HasColumnName("POST_ROUTE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueCenter)
                .HasColumnName("REVENUE_CENTER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Selector)
                .HasColumnName("SELECTOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServingPeriod)
                .HasColumnName("SERVING_PERIOD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Userid)
                .HasColumnName("USERID")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
