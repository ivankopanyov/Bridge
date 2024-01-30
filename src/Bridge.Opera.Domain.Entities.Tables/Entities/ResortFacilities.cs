namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortFacilities
{
    public ResortFacilities()
    {
        CustomFacilityCodesHeader = new HashSet<CustomFacilityCodesHeader>();
    }

    public string? Resort { get; set; }
    public string? FacilityCode { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<CustomFacilityCodesHeader> CustomFacilityCodesHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortFacilities>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_FACILITIES");

            entity.HasIndex(e => new { e.Resort, e.FacilityCode })
                .HasName("RESFAC_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityCode)
                .IsRequired()
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESFAC_RES_FK");
        
			if (!types.Contains(typeof(CustomFacilityCodesHeader)))
				entity.Ignore(e => e.CustomFacilityCodesHeader);
		});
	}
}
