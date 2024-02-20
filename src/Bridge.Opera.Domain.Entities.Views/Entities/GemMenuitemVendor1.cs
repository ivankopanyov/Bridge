namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuitemVendor1
{
    public string? Resort { get; set; }
    public decimal? MitId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? Priority { get; set; }
    public string? LeadTime { get; set; }
    public decimal? PurchasePrice { get; set; }
    public decimal? RentalPrice { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemVendor1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENUITEM_VENDOR");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadTime)
                .HasColumnName("LEAD_TIME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PurchasePrice)
                .HasColumnName("PURCHASE_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RentalPrice)
                .HasColumnName("RENTAL_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
