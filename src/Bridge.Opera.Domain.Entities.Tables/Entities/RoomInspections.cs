namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomInspections
{
    public RoomInspections()
    {
        RoomInspectionDetails = new HashSet<RoomInspectionDetails>();
    }

    public string Resort { get; set; }
    public decimal RiId { get; set; }
    public decimal RiTemplateId { get; set; }
    public string RiTemplateLocationCode { get; set; }
    public DateTime? RiDate { get; set; }
    public decimal? RiBy { get; set; }
    public string Room { get; set; }

    public virtual SurveyTemplate R { get; set; }
    public virtual Locations RNavigation { get; set; }
    public virtual ICollection<RoomInspectionDetails> RoomInspectionDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomInspections>(entity =>
        {
            entity.HasKey(e => new { e.RiId, e.Resort })
                .HasName("RI_PK");

            entity.ToTable("ROOM_INSPECTIONS");

            entity.HasIndex(e => new { e.Resort, e.RiTemplateId })
                .HasName("RI_SURT_FKI");

            entity.HasIndex(e => new { e.Resort, e.RiTemplateLocationCode })
                .HasName("RI_LOC1_FK_IDX");

            entity.Property(e => e.RiId)
                .HasColumnName("RI_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiBy)
                .HasColumnName("RI_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiDate)
                .HasColumnName("RI_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateLocationCode)
                .HasColumnName("RI_TEMPLATE_LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(SurveyTemplate)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RoomInspections)
	                .HasForeignKey(d => new { d.Resort, d.RiTemplateId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RI_SURT_FK");

			if (!types.Contains(typeof(Locations)))
				entity.Ignore(e => e.RNavigation);
			else
	            entity.HasOne(d => d.RNavigation)
	                .WithMany(p => p.RoomInspections)
	                .HasForeignKey(d => new { d.Resort, d.RiTemplateLocationCode })
	                .HasConstraintName("RI_LOC1_FK");
        
			if (!types.Contains(typeof(RoomInspectionDetails)))
				entity.Ignore(e => e.RoomInspectionDetails);
		});
	}
}
