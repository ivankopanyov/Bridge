namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VnPool
{
    public VnPool()
    {
        RoomVnPool = new HashSet<RoomVnPool>();
        VnPoolDetails = new HashSet<VnPoolDetails>();
    }

    public string Resort { get; set; }
    public decimal Pool { get; set; }
    public string PoolName { get; set; }
    public string ActiveYn { get; set; }
    public string PoolType { get; set; }
    public string AssignmentRequired { get; set; }
    public decimal AssignmentRule { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ICollection<RoomVnPool> RoomVnPool { get; set; }
    public virtual ICollection<VnPoolDetails> VnPoolDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VnPool>(entity =>
        {
            entity.HasKey(e => new { e.Pool, e.Resort })
                .HasName("VP1_PK");

            entity.ToTable("VN_POOL");

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .IsRequired()
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AssignmentRequired)
                .IsRequired()
                .HasColumnName("ASSIGNMENT_REQUIRED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AssignmentRule)
                .HasColumnName("ASSIGNMENT_RULE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PoolName)
                .IsRequired()
                .HasColumnName("POOL_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PoolType)
                .IsRequired()
                .HasColumnName("POOL_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RoomVnPool)))
				entity.Ignore(e => e.RoomVnPool);

			if (!types.Contains(typeof(VnPoolDetails)))
				entity.Ignore(e => e.VnPoolDetails);
		});
	}
}
