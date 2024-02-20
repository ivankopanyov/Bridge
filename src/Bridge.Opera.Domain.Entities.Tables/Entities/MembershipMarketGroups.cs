namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipMarketGroups
{
    public MembershipMarketGroups()
    {
        MembershipMarketGroupCodes = new HashSet<MembershipMarketGroupCodes>();
    }

    public string? MemMarketGroup { get; set; }
    public string? Description { get; set; }
    public string? IncludeExclude { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ChainCode { get; set; }

    public virtual ICollection<MembershipMarketGroupCodes> MembershipMarketGroupCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipMarketGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemMarketGroup })
                .HasName("MEM_MARKET_GROUP_PK");

            entity.ToTable("MEMBERSHIP_MARKET_GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemMarketGroup)
                .HasColumnName("MEM_MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncludeExclude)
                .IsRequired()
                .HasColumnName("INCLUDE_EXCLUDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(MembershipMarketGroupCodes)))
				entity.Ignore(e => e.MembershipMarketGroupCodes);
		});
	}
}
