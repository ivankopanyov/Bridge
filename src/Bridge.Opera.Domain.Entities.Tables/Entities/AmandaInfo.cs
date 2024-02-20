namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AmandaInfo
{
    public decimal? ResvNameId { get; set; }
    public string? Resort { get; set; }
    public string? AmadeusOfficeCode { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? TravelFileNumber { get; set; }
    public string? CustomerCode { get; set; }
    public string? CustomerName { get; set; }
    public string? SalesType { get; set; }
    public string? Remark { get; set; }
    public string? SalesChannel { get; set; }
    public string? ProductCode { get; set; }
    public string? Agent { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual AmandaOfficeCodes AmadeusOfficeCodeNavigation { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AmandaInfo>(entity =>
        {
            entity.HasKey(e => new { e.ResvNameId, e.Resort, e.AmadeusOfficeCode })
                .HasName("AI_PK");

            entity.ToTable("AMANDA_INFO");

            entity.HasIndex(e => e.AmadeusOfficeCode)
                .HasName("AI_AMANDA_OFFICE_CODES_FKI");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("AI_FK1");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AmadeusOfficeCode)
                .HasColumnName("AMADEUS_OFFICE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Agent)
                .HasColumnName("AGENT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerCode)
                .HasColumnName("CUSTOMER_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductCode)
                .HasColumnName("PRODUCT_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SalesChannel)
                .HasColumnName("SALES_CHANNEL")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SalesType)
                .HasColumnName("SALES_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TravelFileNumber)
                .HasColumnName("TRAVEL_FILE_NUMBER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AmandaOfficeCodes)))
				entity.Ignore(e => e.AmadeusOfficeCodeNavigation);
			else
	            entity.HasOne(d => d.AmadeusOfficeCodeNavigation)
	                .WithMany(p => p.AmandaInfo)
	                .HasForeignKey(d => d.AmadeusOfficeCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AI_AMANDA_OFFICE_CODES_FK");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.AmandaInfo)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AI_RESERVATION_NAME_FK");
        });
	}
}
