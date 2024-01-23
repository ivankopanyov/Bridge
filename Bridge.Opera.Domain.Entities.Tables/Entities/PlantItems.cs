namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PlantItems
{
    public PlantItems()
    {
        PlantItemsAttachments = new HashSet<PlantItemsAttachments>();
        Taskitems = new HashSet<Taskitems>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string PlantItemCode { get; set; }
    public string PlantItemName { get; set; }
    public decimal? ActualYtd { get; set; }
    public decimal? BudgetYtd { get; set; }
    public string TypeCode { get; set; }
    public string LocationCode { get; set; }
    public string Room { get; set; }
    public string ExternalInfo { get; set; }
    public string PmRequiredYn { get; set; }
    public DateTime? LastMaintDate { get; set; }
    public DateTime? NextMaintDueDate { get; set; }
    public decimal? LastMaintTask { get; set; }
    public decimal? NextMaintTask { get; set; }
    public decimal? AttachmentId { get; set; }

    public virtual Locations Locations { get; set; }
    public virtual PlantItemTypes PlantItemTypes { get; set; }
    public virtual ICollection<PlantItemsAttachments> PlantItemsAttachments { get; set; }
    public virtual ICollection<Taskitems> Taskitems { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PlantItems>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PlantItemCode })
                .HasName("PI_PK");

            entity.ToTable("PLANT_ITEMS");

            entity.HasIndex(e => new { e.Resort, e.LocationCode })
                .HasName("PI_LOC1_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TypeCode })
                .HasName("PI_PIT_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ActualYtd)
                .HasColumnName("ACTUAL_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentId)
                .HasColumnName("ATTACHMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetYtd)
                .HasColumnName("BUDGET_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalInfo)
                .HasColumnName("EXTERNAL_INFO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastMaintDate)
                .HasColumnName("LAST_MAINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastMaintTask)
                .HasColumnName("LAST_MAINT_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NextMaintDueDate)
                .HasColumnName("NEXT_MAINT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextMaintTask)
                .HasColumnName("NEXT_MAINT_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlantItemName)
                .IsRequired()
                .HasColumnName("PLANT_ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PmRequiredYn)
                .HasColumnName("PM_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Locations)))
				entity.Ignore(e => e.Locations);
			else
	            entity.HasOne(d => d.Locations)
	                .WithMany(p => p.PlantItems)
	                .HasForeignKey(d => new { d.Resort, d.LocationCode })
	                .HasConstraintName("PI_LOC1_FK");

			if (!types.Contains(typeof(PlantItemTypes)))
				entity.Ignore(e => e.PlantItemTypes);
			else
	            entity.HasOne(d => d.PlantItemTypes)
	                .WithMany(p => p.PlantItems)
	                .HasForeignKey(d => new { d.Resort, d.TypeCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PI_PIT_FK");
        
			if (!types.Contains(typeof(PlantItemsAttachments)))
				entity.Ignore(e => e.PlantItemsAttachments);

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
