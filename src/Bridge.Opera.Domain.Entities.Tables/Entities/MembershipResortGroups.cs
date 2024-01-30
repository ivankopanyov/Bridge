namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipResortGroups
{
    public MembershipResortGroups()
    {
        MembershipResortGroupCodes = new HashSet<MembershipResortGroupCodes>();
    }

    public string? MemResortGroup { get; set; }
    public string? Description { get; set; }
    public string? IncludeExclude { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string? BackToBack { get; set; }
    public string? ChainCode { get; set; }

    public virtual ICollection<MembershipResortGroupCodes> MembershipResortGroupCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipResortGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemResortGroup })
                .HasName("MEM_RESORT_GROUPS_PK");

            entity.ToTable("MEMBERSHIP_RESORT_GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemResortGroup)
                .HasColumnName("MEM_RESORT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BackToBack)
                .HasColumnName("BACK_TO_BACK")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncludeExclude)
                .IsRequired()
                .HasColumnName("INCLUDE_EXCLUDE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'I'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(MembershipResortGroupCodes)))
				entity.Ignore(e => e.MembershipResortGroupCodes);
		});
	}
}
