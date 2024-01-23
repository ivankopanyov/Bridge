namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FinTrxTranslation
{
    public decimal FinDescId { get; set; }
    public string Resort { get; set; }
    public string LanguageCode { get; set; }
    public string Description { get; set; }
    public string TranslatedColumn { get; set; }
    public decimal? ArrangementId { get; set; }
    public string TrxCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual TrxCodeArrangement Arrangement { get; set; }
    public virtual Resort ResortNavigation { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTrxTranslation>(entity =>
        {
            entity.HasKey(e => e.FinDescId)
                .HasName("FTT_PK");

            entity.ToTable("FIN_TRX_TRANSLATION");

            entity.HasIndex(e => e.ArrangementId)
                .HasName("FTT_ARRANGEMENT_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("FTT_TRX_CODE_FK_I");

            entity.HasIndex(e => new { e.LanguageCode, e.ArrangementId, e.Resort })
                .HasName("FTT_ARR_IDX");

            entity.HasIndex(e => new { e.LanguageCode, e.TrxCode, e.Resort })
                .HasName("FTT_TRX_CODE_IDX");

            entity.Property(e => e.FinDescId)
                .HasColumnName("FIN_DESC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranslatedColumn)
                .HasColumnName("TRANSLATED_COLUMN")
                .HasMaxLength(30)
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
	                .WithMany(p => p.FinTrxTranslation)
	                .HasForeignKey(d => d.ArrangementId)
	                .HasConstraintName("FTT_ARRANGEMENT_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.FinTrxTranslation)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("FIN_TRX_TRANS_RESORT_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.FinTrxTranslation)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("FTT_TRX_CODE");
        });
	}
}
