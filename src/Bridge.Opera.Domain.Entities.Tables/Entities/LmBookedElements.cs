namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmBookedElements
{
    public LmBookedElements()
    {
        LmBookedResource = new HashSet<LmBookedResource>();
    }

    public decimal? BookedElId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookedActId { get; set; }
    public string? ActElCode { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Status { get; set; }
    public string? OutletCode { get; set; }
    public DateTime? CancelDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual LmBookedActivity LmBookedActivity { get; set; }
    public virtual ICollection<LmBookedResource> LmBookedResource { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedElements>(entity =>
        {
            entity.HasKey(e => new { e.BookedElId, e.Resort })
                .HasName("LM_BOOKED_ELEMENTS_PK");

            entity.ToTable("LM_BOOKED_ELEMENTS");

            entity.HasIndex(e => new { e.BookedActId, e.Resort, e.BookedElId })
                .HasName("LM_BOOKED_ELEMENTS_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.ActElCode, e.OutletCode })
                .HasName("LM_BOOKED_ELEMENTS_IND");

            entity.HasIndex(e => new { e.BeginTime, e.EndTime, e.Resort, e.BookedElId })
                .HasName("LM_BOOKED_ELEMENTS_IND2");

            entity.Property(e => e.BookedElId)
                .HasColumnName("BOOKED_EL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActElCode)
                .IsRequired()
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(LmBookedActivity)))
				entity.Ignore(e => e.LmBookedActivity);
			else
	            entity.HasOne(d => d.LmBookedActivity)
	                .WithMany(p => p.LmBookedElements)
	                .HasForeignKey(d => new { d.BookedActId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("LM_BOOKED_ELEMENTS_FK");
        
			if (!types.Contains(typeof(LmBookedResource)))
				entity.Ignore(e => e.LmBookedResource);
		});
	}
}
