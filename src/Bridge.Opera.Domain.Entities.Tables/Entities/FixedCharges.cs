namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FixedCharges
{
    public decimal FixedChargesId { get; set; }
    public string TrxCode { get; set; }
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public string Frequency { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? ArticleId { get; set; }
    public string DayToExecute { get; set; }
    public DateTime? YearlyFixedCharges { get; set; }
    public string Supplement { get; set; }
    public decimal? RoomNts { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? BeginDateNullable { get; set; }
    public DateTime? EndDateNullable { get; set; }

    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FixedCharges>(entity =>
        {
            entity.ToTable("FIXED_CHARGES");

            entity.HasIndex(e => new { e.Resort, e.AccountCode })
                .HasName("FC_ACCOUNT_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("FIXED_CHARGES_NUK");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("FC_TRX_CODE_FK_I");

            entity.Property(e => e.FixedChargesId)
                .HasColumnName("FIXED_CHARGES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDateNullable)
                .HasColumnName("BEGIN_DATE_NULLABLE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayToExecute)
                .HasColumnName("DAY_TO_EXECUTE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDateNullable)
                .HasColumnName("END_DATE_NULLABLE")
                .HasColumnType("DATE");

            entity.Property(e => e.Frequency)
                .IsRequired()
                .HasColumnName("FREQUENCY")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNts)
                .HasColumnName("ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearlyFixedCharges)
                .HasColumnName("YEARLY_FIXED_CHARGES")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.FixedCharges)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("FC_TRX_CODE_FK");
        });
	}
}
