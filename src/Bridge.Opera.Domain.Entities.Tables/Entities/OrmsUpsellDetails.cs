namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsUpsellDetails
{
    public string? Resort { get; set; }
    public decimal? HeaderId { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? UpsellAmt { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OrmsUpsellHeader OrmsUpsellHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsUpsellDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.HeaderId, e.RoomCategory })
                .HasName("ORMS_UPSELL_DETAILS_PK");

            entity.ToTable("ORMS_UPSELL_DETAILS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
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

            entity.Property(e => e.UpsellAmt)
                .HasColumnName("UPSELL_AMT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OrmsUpsellHeader)))
				entity.Ignore(e => e.OrmsUpsellHeader);
			else
	            entity.HasOne(d => d.OrmsUpsellHeader)
	                .WithMany(p => p.OrmsUpsellDetails)
	                .HasForeignKey(d => new { d.Resort, d.HeaderId })
	                .HasConstraintName("ORMS_UPSELL_DETAILS_FK1");
        });
	}
}
