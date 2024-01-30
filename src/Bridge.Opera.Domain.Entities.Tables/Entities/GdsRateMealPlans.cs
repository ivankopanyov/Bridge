namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateMealPlans
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? MealplanCode { get; set; }
    public string? IncludedYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? GdsHost { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateMealPlans>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort, e.RateCode, e.MealplanCode })
                .HasName("GDS_RATE_MEAL_PLANS_PK");

            entity.ToTable("GDS_RATE_MEAL_PLANS");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MealplanCode)
                .HasColumnName("MEALPLAN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IncludedYn)
                .IsRequired()
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
