namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Reasons
{
    public Reasons()
    {
        EmpNonAvail = new HashSet<EmpNonAvail>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string? Resort { get; set; }
    public string? ReasonCode { get; set; }
    public string? Description { get; set; }
    public string? StatusCode { get; set; }

    public virtual StatusCode StatusCodeNavigation { get; set; }
    public virtual ICollection<EmpNonAvail> EmpNonAvail { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Reasons>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ReasonCode })
                .HasName("QMS_REASON_PK");

            entity.ToTable("REASONS");

            entity.HasIndex(e => new { e.Resort, e.StatusCode })
                .HasName("REASON_SC_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .IsRequired()
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(StatusCode)))
				entity.Ignore(e => e.StatusCodeNavigation);
			else
	            entity.HasOne(d => d.StatusCodeNavigation)
	                .WithMany(p => p.Reasons)
	                .HasForeignKey(d => new { d.Resort, d.StatusCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("REASON_SC_FK");
        
			if (!types.Contains(typeof(EmpNonAvail)))
				entity.Ignore(e => e.EmpNonAvail);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
