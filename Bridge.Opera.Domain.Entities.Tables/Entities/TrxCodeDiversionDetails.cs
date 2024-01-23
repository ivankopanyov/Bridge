namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodeDiversionDetails
{
    public decimal DiversionId { get; set; }
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual TrxCodeDiversions Diversion { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeDiversionDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRX_CODE_DIVERSION_DETAILS");

            entity.HasIndex(e => e.DiversionId)
                .HasName("TRXDIVD_TRXDIV_FKI");

            entity.Property(e => e.DiversionId)
                .HasColumnName("DIVERSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(TrxCodeDiversions)))
				entity.Ignore(e => e.Diversion);
			else
	            entity.HasOne(d => d.Diversion)
	                .WithMany()
	                .HasForeignKey(d => d.DiversionId)
	                .HasConstraintName("TRXDIVD_TRXDIV_FK");
        });
	}
}
