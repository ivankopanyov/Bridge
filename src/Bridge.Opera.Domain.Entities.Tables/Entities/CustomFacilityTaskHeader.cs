namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CustomFacilityTaskHeader
{
    public CustomFacilityTaskHeader()
    {
        CustomFacilityCodesHeader = new HashSet<CustomFacilityCodesHeader>();
    }

    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? FacilityTask { get; set; }
    public decimal? FrequencyDays { get; set; }
    public decimal? Credits { get; set; }
    public decimal? Priority { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ReservationName Res { get; set; }
    public virtual ResortHkTasks ResortHkTasks { get; set; }
    public virtual ICollection<CustomFacilityCodesHeader> CustomFacilityCodesHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CustomFacilityTaskHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.FacilityTask })
                .HasName("CUSTOM_FT_HDR_PK");

            entity.ToTable("CUSTOM_FACILITY_TASK_HEADER");

            entity.HasIndex(e => new { e.Resort, e.FacilityTask })
                .HasName("CUSTOM_FT_HDR_TASKS_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FacilityTask)
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FrequencyDays)
                .HasColumnName("FREQUENCY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortHkTasks)))
				entity.Ignore(e => e.ResortHkTasks);
			else
	            entity.HasOne(d => d.ResortHkTasks)
	                .WithMany(p => p.CustomFacilityTaskHeader)
	                .HasPrincipalKey(p => new { p.Resort, p.TaskCode })
	                .HasForeignKey(d => new { d.Resort, d.FacilityTask })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUSTOM_FT_HDR_TASKS_FK");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.CustomFacilityTaskHeader)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUSTOM_FT_HDR_RESV_FK");
        
			if (!types.Contains(typeof(CustomFacilityCodesHeader)))
				entity.Ignore(e => e.CustomFacilityCodesHeader);
		});
	}
}
