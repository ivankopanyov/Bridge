namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmService
{
    public decimal ServiceId { get; set; }
    public string Resort { get; set; }
    public string ArticleCode { get; set; }
    public string TrxCode { get; set; }
    public string ActCode { get; set; }
    public string ResId { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmService>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.Resort })
                .HasName("LM_SERVICE_PK");

            entity.ToTable("LM_SERVICE");

            entity.HasIndex(e => new { e.ResId, e.Resort })
                .HasName("LM_SERVICE_IND3");

            entity.HasIndex(e => new { e.ActCode, e.Resort, e.ResId })
                .HasName("LM_SERVICE_IND")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.ArticleCode, e.TrxCode })
                .HasName("LM_SERVICE_IND2");

            entity.Property(e => e.ServiceId)
                .HasColumnName("SERVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActCode)
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArticleCode)
                .IsRequired()
                .HasColumnName("ARTICLE_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
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
        });
	}
}
