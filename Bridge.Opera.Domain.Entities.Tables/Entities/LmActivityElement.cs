namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmActivityElement
{
    public string ActElCode { get; set; }
    public string Resort { get; set; }
    public string ActType { get; set; }
    public string ActDesc { get; set; }
    public string ActLongDesc { get; set; }
    public string InternalYn { get; set; }
    public string CustomerYn { get; set; }
    public decimal? DefaultDuration { get; set; }
    public decimal? MinDuration { get; set; }
    public decimal? IncrDuration { get; set; }
    public string StatusOnStart { get; set; }
    public decimal? OrderBy { get; set; }
    public string StatusOnEnd { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmActivityElement>(entity =>
        {
            entity.HasKey(e => new { e.ActElCode, e.Resort })
                .HasName("LM_ACTIVITY_EL_PK");

            entity.ToTable("LM_ACTIVITY_ELEMENT");

            entity.Property(e => e.ActElCode)
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActDesc)
                .IsRequired()
                .HasColumnName("ACT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActLongDesc)
                .HasColumnName("ACT_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ActType)
                .IsRequired()
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomerYn)
                .IsRequired()
                .HasColumnName("CUSTOMER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.DefaultDuration)
                .HasColumnName("DEFAULT_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncrDuration)
                .HasColumnName("INCR_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .IsRequired()
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.MinDuration)
                .HasColumnName("MIN_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusOnEnd)
                .HasColumnName("STATUS_ON_END")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusOnStart)
                .HasColumnName("STATUS_ON_START")
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
        });
	}
}
