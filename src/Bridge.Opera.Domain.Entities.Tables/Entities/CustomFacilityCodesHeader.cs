namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CustomFacilityCodesHeader
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? FacilityTask { get; set; }
    public string? FacilityCode { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual CustomFacilityTaskHeader CustomFacilityTaskHeader { get; set; }
    public virtual ResortFacilities ResortFacilities { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CustomFacilityCodesHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.FacilityTask, e.FacilityCode })
                .HasName("CUSTOM_FC_HDR_PK");

            entity.ToTable("CUSTOM_FACILITY_CODES_HEADER");

            entity.HasIndex(e => new { e.Resort, e.FacilityCode })
                .HasName("CUST_FC_HDR_RES_FC_FKI");

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

            entity.Property(e => e.FacilityCode)
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortFacilities)))
				entity.Ignore(e => e.ResortFacilities);
			else
	            entity.HasOne(d => d.ResortFacilities)
	                .WithMany(p => p.CustomFacilityCodesHeader)
	                .HasPrincipalKey(p => new { p.Resort, p.FacilityCode })
	                .HasForeignKey(d => new { d.Resort, d.FacilityCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUST_FC_HDR_RES_FC_FK");

			if (!types.Contains(typeof(CustomFacilityTaskHeader)))
				entity.Ignore(e => e.CustomFacilityTaskHeader);
			else
	            entity.HasOne(d => d.CustomFacilityTaskHeader)
	                .WithMany(p => p.CustomFacilityCodesHeader)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId, d.FacilityTask })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUST_FC_HDR_CUST_FT_HDR_FK");
        });
	}
}
