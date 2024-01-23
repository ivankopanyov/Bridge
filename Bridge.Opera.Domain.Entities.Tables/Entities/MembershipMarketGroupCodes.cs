namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipMarketGroupCodes
{
    public string MemMarketGroup { get; set; }
    public string MarketCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipMarketGroups MembershipMarketGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipMarketGroupCodes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemMarketGroup, e.MarketCode })
                .HasName("MMGRP_PK");

            entity.ToTable("MEMBERSHIP_MARKET_GROUP_CODES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemMarketGroup)
                .HasColumnName("MEM_MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(MembershipMarketGroups)))
				entity.Ignore(e => e.MembershipMarketGroups);
			else
	            entity.HasOne(d => d.MembershipMarketGroups)
	                .WithMany(p => p.MembershipMarketGroupCodes)
	                .HasForeignKey(d => new { d.ChainCode, d.MemMarketGroup })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEM_MARKET_GROUP_FK");
        });
	}
}
