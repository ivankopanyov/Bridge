namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BwiPromoOffersView
{
    public string Promoid { get; set; }
    public string Promotitle { get; set; }
    public string Promocode { get; set; }
    public string Promodesc { get; set; }
    public DateTime? Startdate { get; set; }
    public DateTime? Enddate { get; set; }
    public DateTime? Registrationdate { get; set; }
    public string Termsconditions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BwiPromoOffersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BWI_PROMO_OFFERS_VIEW");

            entity.Property(e => e.Enddate)
                .HasColumnName("ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Promocode)
                .HasColumnName("PROMOCODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Promodesc)
                .HasColumnName("PROMODESC")
                .IsUnicode(false);

            entity.Property(e => e.Promoid)
                .HasColumnName("PROMOID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Promotitle)
                .HasColumnName("PROMOTITLE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Registrationdate)
                .HasColumnName("REGISTRATIONDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Startdate)
                .HasColumnName("STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Termsconditions)
                .HasColumnName("TERMSCONDITIONS")
                .IsUnicode(false);
        });
	}
}
