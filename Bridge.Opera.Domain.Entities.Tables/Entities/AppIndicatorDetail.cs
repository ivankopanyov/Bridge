namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppIndicatorDetail
{
    public string IndicatorId { get; set; }
    public string IndicatorCode { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }
    public string DisplayStatus { get; set; }
    public string DisplayValue { get; set; }
    public string Bkcolor { get; set; }
    public string Fgcolor { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? AppServPostDate { get; set; }
    public string AppServProcessMsg { get; set; }
    public string RecCleanYn { get; set; }
    public string Indcolor { get; set; }
    public string DisplayLine1 { get; set; }
    public string DisplayLine2 { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppIndicatorDetail>(entity =>
        {
            entity.HasKey(e => e.IndicatorId)
                .HasName("AIL_PK");

            entity.ToTable("APP_INDICATOR_DETAIL");

            entity.HasIndex(e => new { e.IndicatorCode, e.Resort, e.DeptId, e.DisplayStatus })
                .HasName("APP_IND_DET_UK1")
                .IsUnique();

            entity.Property(e => e.IndicatorId)
                .HasColumnName("INDICATOR_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppServPostDate)
                .HasColumnName("APP_SERV_POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AppServProcessMsg)
                .HasColumnName("APP_SERV_PROCESS_MSG")
                .IsUnicode(false);

            entity.Property(e => e.Bkcolor)
                .HasColumnName("BKCOLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DisplayLine1)
                .HasColumnName("DISPLAY_LINE1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DisplayLine2)
                .HasColumnName("DISPLAY_LINE2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DisplayStatus)
                .HasColumnName("DISPLAY_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayValue)
                .HasColumnName("DISPLAY_VALUE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Fgcolor)
                .HasColumnName("FGCOLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Indcolor)
                .HasColumnName("INDCOLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IndicatorCode)
                .IsRequired()
                .HasColumnName("INDICATOR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecCleanYn)
                .HasColumnName("REC_CLEAN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
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
