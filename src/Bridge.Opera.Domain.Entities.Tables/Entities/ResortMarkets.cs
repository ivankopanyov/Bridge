namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortMarkets
{
    public ResortMarkets()
    {
        RateHeader = new HashSet<RateHeader>();
        RateSet = new HashSet<RateSet>();
    }

    public string MarketCode { get; set; }
    public string Resort { get; set; }
    public string ParentMarketCode { get; set; }
    public string Description { get; set; }
    public int? SellSequence { get; set; }
    public string DisplayColor { get; set; }
    public decimal? ScOrderby { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string PrintGroup { get; set; }

    public virtual MarketGroups MarketGroups { get; set; }
    public virtual ICollection<RateHeader> RateHeader { get; set; }
    public virtual ICollection<RateSet> RateSet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortMarkets>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT$_MARKETS");

            entity.HasIndex(e => new { e.MarketCode, e.Resort })
                .HasName("RESORT$_MARKETS_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.ParentMarketCode, e.Resort })
                .HasName("MARKET_GROUPS_FK_I");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintGroup)
                .HasColumnName("PRINT_GROUP")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScOrderby)
                .HasColumnName("SC_ORDERBY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(MarketGroups)))
				entity.Ignore(e => e.MarketGroups);
			else
	            entity.HasOne(d => d.MarketGroups)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.MarketGroup, p.Resort })
	                .HasForeignKey(d => new { d.ParentMarketCode, d.Resort })
	                .HasConstraintName("MARKET_GROUPS_FK");
        
			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.RateHeader);

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);
		});
	}
}
