namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateHeaderNegotiatBaseView
{
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? BeginDate { get; set; }
    public string? CaId { get; set; }
    public string? CommissionCode { get; set; }
    public string? DatabaseId { get; set; }
    public DateTime? EndDate { get; set; }
    public string? IfcCreatedYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? NameId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? RateCode { get; set; }
    public string? Resort { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateHeaderNegotiatBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_HEADER_NEGOTIAT_BASE_VIEW");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CaId)
                .HasColumnName("CA_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IfcCreatedYn)
                .HasColumnName("IFC_CREATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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
