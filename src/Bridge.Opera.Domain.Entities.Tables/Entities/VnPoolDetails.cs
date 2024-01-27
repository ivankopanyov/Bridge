namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VnPoolDetails
{
    public VnPoolDetails()
    {
        ReservationVirtual = new HashSet<ReservationVirtual>();
    }

    public string Resort { get; set; }
    public decimal Pool { get; set; }
    public string Virtual { get; set; }
    public string CurrentlyAllocatedYn { get; set; }
    public decimal NoTimesUsed { get; set; }
    public DateTime? LastUsed { get; set; }
    public string LastRoom { get; set; }
    public decimal? PermanentlyAssignedTo { get; set; }

    public virtual VnPool VnPool { get; set; }
    public virtual ICollection<ReservationVirtual> ReservationVirtual { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VnPoolDetails>(entity =>
        {
            entity.HasKey(e => new { e.Virtual, e.Pool, e.Resort })
                .HasName("VPD_PK");

            entity.ToTable("VN_POOL_DETAILS");

            entity.HasIndex(e => new { e.Pool, e.Resort })
                .HasName("VPD_VP_FK_IDX");

            entity.HasIndex(e => new { e.CurrentlyAllocatedYn, e.LastUsed, e.Resort })
                .HasName("VN_POOL_DETAILS_IND1");

            entity.Property(e => e.Virtual)
                .HasColumnName("VIRTUAL#")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrentlyAllocatedYn)
                .IsRequired()
                .HasColumnName("CURRENTLY_ALLOCATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUsed)
                .HasColumnName("LAST_USED")
                .HasColumnType("DATE");

            entity.Property(e => e.NoTimesUsed)
                .HasColumnName("NO_TIMES_USED")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.PermanentlyAssignedTo)
                .HasColumnName("PERMANENTLY_ASSIGNED_TO")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(VnPool)))
				entity.Ignore(e => e.VnPool);
			else
	            entity.HasOne(d => d.VnPool)
	                .WithMany(p => p.VnPoolDetails)
	                .HasForeignKey(d => new { d.Pool, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("VPD_VP_FK");
        
			if (!types.Contains(typeof(ReservationVirtual)))
				entity.Ignore(e => e.ReservationVirtual);
		});
	}
}
