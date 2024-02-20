namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsHostCarriers
{
    public string? GdsHost { get; set; }
    public string? GdsCarrier { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? SgaYn { get; set; }

    public virtual GdsHosts GdsHostNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsHostCarriers>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.GdsCarrier })
                .HasName("GDS_HOST_CARRIERS_PK");

            entity.ToTable("GDS_HOST_CARRIERS");

            entity.HasIndex(e => e.GdsCarrier)
                .HasName("GDS_HOST_CARRIERS_IND1");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsCarrier)
                .HasColumnName("GDS_CARRIER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SgaYn)
                .HasColumnName("SGA_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsHosts)))
				entity.Ignore(e => e.GdsHostNavigation);
			else
	            entity.HasOne(d => d.GdsHostNavigation)
	                .WithMany(p => p.GdsHostCarriers)
	                .HasForeignKey(d => d.GdsHost)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_HOST_CARR_GDS_HOSTS_FK");
        });
	}
}
