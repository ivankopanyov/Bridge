namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmActivity
{
    public string? ActCode { get; set; }
    public string? Resort { get; set; }
    public string? ActDesc { get; set; }
    public string? ActType { get; set; }
    public string? ActLongDesc { get; set; }
    public string? CustomerYn { get; set; }
    public string? PostOnEvent { get; set; }
    public decimal? SellInterval { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? MinNoOfPeople { get; set; }
    public decimal? MaxNoOfPeople { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmActivity>(entity =>
        {
            entity.HasKey(e => new { e.ActCode, e.Resort })
                .HasName("LM_ACTY_PK");

            entity.ToTable("LM_ACTIVITY");

            entity.Property(e => e.ActCode)
                .HasColumnName("ACT_CODE")
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

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxNoOfPeople)
                .HasColumnName("MAX_NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinNoOfPeople)
                .HasColumnName("MIN_NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostOnEvent)
                .HasColumnName("POST_ON_EVENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellInterval)
                .HasColumnName("SELL_INTERVAL")
                .HasColumnType("NUMBER");

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
