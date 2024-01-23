namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaExtSystemsVw
{
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal SeqNo { get; set; }
    public decimal? AppUserId { get; set; }
    public string DisplayYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string PmsType { get; set; }
    public string ProdCode { get; set; }
    public string SystemType { get; set; }
    public string LookupYn { get; set; }
    public string BatchBe { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaExtSystemsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_EXT_SYSTEMS_VW");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchBe)
                .HasColumnName("BATCH_BE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .IsRequired()
                .HasColumnName("DISPLAY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LookupYn)
                .IsRequired()
                .HasColumnName("LOOKUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ProdCode)
                .HasColumnName("PROD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
