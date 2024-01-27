namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HealthCheckMainCategory
{
    public HealthCheckMainCategory()
    {
        HealthCheckSubCategory = new HashSet<HealthCheckSubCategory>();
    }

    public string CategoryCode { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual ICollection<HealthCheckSubCategory> HealthCheckSubCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HealthCheckMainCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryCode)
                .HasName("HC_PK");

            entity.ToTable("HEALTH_CHECK_MAIN_CATEGORY");

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(HealthCheckSubCategory)))
				entity.Ignore(e => e.HealthCheckSubCategory);
		});
	}
}
