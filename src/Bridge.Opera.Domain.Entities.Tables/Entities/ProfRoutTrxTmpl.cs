namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfRoutTrxTmpl
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public decimal? ArrangementId { get; set; }
    public string? AddTrxYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfRoutTrxTmpl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROF$ROUT_TRX_TMPL");

            entity.HasIndex(e => e.ArrangementId)
                .HasName("PRTT_TCA_FK_I");

            entity.HasIndex(e => e.NameId)
                .HasName("PRTT_NAME_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("PRTT_TRX_CODE_FK_I");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.TrxCode, e.ArrangementId })
                .HasName("PROF_ROUT_TRXTMPL_IDX")
                .IsUnique();

            entity.Property(e => e.AddTrxYn)
                .HasColumnName("ADD_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
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
        });
	}
}
