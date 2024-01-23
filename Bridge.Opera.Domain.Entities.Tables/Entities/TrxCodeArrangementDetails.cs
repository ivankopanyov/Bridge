namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodeArrangementDetails
{
    public string AddTrxYn { get; set; }
    public decimal ArrangementId { get; set; }
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public decimal? ChildArrangementId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual TrxCodeArrangement Arrangement { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeArrangementDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRX_CODE_ARRANGEMENT_DETAILS");

            entity.HasIndex(e => e.ArrangementId)
                .HasName("TCAD_ARR");

            entity.HasIndex(e => e.ChildArrangementId)
                .HasName("TCAD_CARR");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("TAD_TRX_CODES_FK_I");

            entity.HasIndex(e => new { e.Resort, e.ArrangementId, e.TrxCode, e.ChildArrangementId })
                .HasName("TCAD_IDX2")
                .IsUnique();

            entity.Property(e => e.AddTrxYn)
                .HasColumnName("ADD_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildArrangementId)
                .HasColumnName("CHILD_ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(TrxCodeArrangement)))
				entity.Ignore(e => e.Arrangement);
			else
	            entity.HasOne(d => d.Arrangement)
	                .WithMany()
	                .HasForeignKey(d => d.ArrangementId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TAD_TA_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("TAD_TRX_CODES_FK");
        });
	}
}
