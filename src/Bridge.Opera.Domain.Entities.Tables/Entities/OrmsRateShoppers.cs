namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsRateShoppers
{
    public OrmsRateShoppers()
    {
        OrmsRateShopperSch = new HashSet<OrmsRateShopperSch>();
    }

    public string? Resort { get; set; }
    public string? ShopperCode { get; set; }
    public string? ShopperName { get; set; }
    public string? RateshopperUrl { get; set; }
    public string? UserName { get; set; }
    public string? UserPassword { get; set; }
    public string? ResortId { get; set; }
    public string? ActiveYn { get; set; }
    public string? ServiceUrl { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<OrmsRateShopperSch> OrmsRateShopperSch { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRateShoppers>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode })
                .HasName("ORMS_RATE_SP_PK");

            entity.ToTable("ORMS_RATE_SHOPPERS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateshopperUrl)
                .HasColumnName("RATESHOPPER_URL")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ServiceUrl)
                .HasColumnName("SERVICE_URL")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ShopperName)
                .IsRequired()
                .HasColumnName("SHOPPER_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UserPassword)
                .HasColumnName("USER_PASSWORD")
                .HasMaxLength(80)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(OrmsRateShopperSch)))
				entity.Ignore(e => e.OrmsRateShopperSch);
		});
	}
}
