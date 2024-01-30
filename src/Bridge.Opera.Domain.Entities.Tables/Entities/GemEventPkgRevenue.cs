namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemEventPkgRevenue
{
    public decimal? EventId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? PkgId { get; set; }
    public string? RevType { get; set; }
    public string? RevGroup { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? ActualAttendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? ExpectedCost { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual GemEvent Event { get; set; }
    public virtual GemEventPkg Pkg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEventPkgRevenue>(entity =>
        {
            entity.HasKey(e => new { e.EventId, e.Resort, e.BookId, e.PkgId, e.RevType })
                .HasName("GEPR_PK");

            entity.ToTable("GEM$EVENT_PKG_REVENUE");

            entity.HasIndex(e => e.PkgId)
                .HasName("GEPR_GEP_FK_I");

            entity.HasIndex(e => e.RevType)
                .HasName("GEPR_REVT_FK_I");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.PkgId, e.EventId, e.RevType })
                .HasName("GEPR_RES_BK_PKG_EV_REV")
                .IsUnique();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.GemEventPkgRevenue)
	                .HasForeignKey(d => d.EventId)
	                .HasConstraintName("GEPR_GE_FK");

			if (!types.Contains(typeof(GemEventPkg)))
				entity.Ignore(e => e.Pkg);
			else
	            entity.HasOne(d => d.Pkg)
	                .WithMany(p => p.GemEventPkgRevenue)
	                .HasPrincipalKey(p => p.PkgId)
	                .HasForeignKey(d => d.PkgId)
	                .HasConstraintName("GEPR_GEP_FK");
        });
	}
}
