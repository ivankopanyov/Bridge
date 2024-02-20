namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TraceCodes
{
    public TraceCodes()
    {
        BusinessProfile = new HashSet<BusinessProfile>();
    }

    public string? Tracecode { get; set; }
    public string? Tracegroup { get; set; }
    public string? Description { get; set; }
    public string? ChainCode { get; set; }

    public virtual TraceGroups TracegroupNavigation { get; set; }
    public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TraceCodes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.Tracecode })
                .HasName("TRACE_CODES_PK");

            entity.ToTable("TRACE$CODES");

            entity.HasIndex(e => e.Tracegroup)
                .HasName("TC_TG_IDX");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Tracegroup)
                .IsRequired()
                .HasColumnName("TRACEGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(TraceGroups)))
				entity.Ignore(e => e.TracegroupNavigation);
			else
	            entity.HasOne(d => d.TracegroupNavigation)
	                .WithMany(p => p.TraceCodes)
	                .HasForeignKey(d => d.Tracegroup)
	                .HasConstraintName("TRACEC_TG_FK");
        
			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.BusinessProfile);
		});
	}
}
