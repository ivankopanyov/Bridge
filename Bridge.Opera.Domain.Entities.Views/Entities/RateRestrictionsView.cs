namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateRestrictionsView
{
    public DateTime? RateDate { get; set; }
    public string SStatus { get; set; }
    public string AStatus { get; set; }
    public string DStatus { get; set; }
    public string BookMinAdvance { get; set; }
    public string BookMaxAdvance { get; set; }
    public string AMinlos { get; set; }
    public string AMaxlos { get; set; }
    public string SMinlos { get; set; }
    public string SMaxlos { get; set; }
    public string LosRestriction { get; set; }
    public string MinOcc { get; set; }
    public string MaxOcc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateRestrictionsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_RESTRICTIONS_VIEW");

            entity.Property(e => e.AMaxlos)
                .HasColumnName("A_MAXLOS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AMinlos)
                .HasColumnName("A_MINLOS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AStatus)
                .HasColumnName("A_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BookMaxAdvance)
                .HasColumnName("BOOK_MAX_ADVANCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BookMinAdvance)
                .HasColumnName("BOOK_MIN_ADVANCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DStatus)
                .HasColumnName("D_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LosRestriction)
                .HasColumnName("LOS_RESTRICTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MaxOcc)
                .HasColumnName("MAX_OCC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MinOcc)
                .HasColumnName("MIN_OCC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RateDate)
                .HasColumnName("RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SMaxlos)
                .HasColumnName("S_MAXLOS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SMinlos)
                .HasColumnName("S_MINLOS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SStatus)
                .HasColumnName("S_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
