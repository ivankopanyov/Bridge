namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsData
{
    public DateTime OrsDate { get; set; }
    public string Resort { get; set; }
    public string OpenYn { get; set; }
    public decimal? Inventory { get; set; }
    public decimal? MinAmt1 { get; set; }
    public decimal? MinAmt2 { get; set; }
    public decimal? MinAmt3 { get; set; }
    public decimal? MinAmt4 { get; set; }
    public decimal? MinAmt5 { get; set; }
    public decimal? MaxAmt1 { get; set; }
    public decimal? MaxAmt2 { get; set; }
    public decimal? MaxAmt3 { get; set; }
    public decimal? MaxAmt4 { get; set; }
    public decimal? MaxAmt5 { get; set; }
    public decimal? MinAdultCharge { get; set; }
    public decimal? MinChildrenCharge { get; set; }
    public decimal? MaxAdultCharge { get; set; }
    public decimal? MaxChildrenCharge { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsData>(entity =>
        {
            entity.HasKey(e => new { e.OrsDate, e.Resort })
                .HasName("OD_PK");

            entity.ToTable("ORS_DATA");

            entity.Property(e => e.OrsDate)
                .HasColumnName("ORS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inventory)
                .HasColumnName("INVENTORY")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxAdultCharge)
                .HasColumnName("MAX_ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAmt1)
                .HasColumnName("MAX_AMT_1")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxAmt2)
                .HasColumnName("MAX_AMT_2")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxAmt3)
                .HasColumnName("MAX_AMT_3")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxAmt4)
                .HasColumnName("MAX_AMT_4")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxAmt5)
                .HasColumnName("MAX_AMT_5")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaxChildrenCharge)
                .HasColumnName("MAX_CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAdultCharge)
                .HasColumnName("MIN_ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAmt1)
                .HasColumnName("MIN_AMT_1")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MinAmt2)
                .HasColumnName("MIN_AMT_2")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MinAmt3)
                .HasColumnName("MIN_AMT_3")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MinAmt4)
                .HasColumnName("MIN_AMT_4")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MinAmt5)
                .HasColumnName("MIN_AMT_5")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MinChildrenCharge)
                .HasColumnName("MIN_CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenYn)
                .IsRequired()
                .HasColumnName("OPEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
