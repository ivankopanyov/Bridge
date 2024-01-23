namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CateringExternalReferences
{
    public string Resort { get; set; }
    public decimal CateringEventId { get; set; }
    public string InterfaceId { get; set; }
    public string ExtCateringEventId { get; set; }
    public string ExchangeYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual GemEvent CateringEvent { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringExternalReferences>(entity =>
        {
            entity.HasKey(e => new { e.CateringEventId, e.Resort, e.InterfaceId })
                .HasName("CATEXTREF_PK");

            entity.ToTable("CATERING_EXTERNAL_REFERENCES");

            entity.HasIndex(e => new { e.Resort, e.InterfaceId, e.ExtCateringEventId })
                .HasName("CATEXTREF_RES_INT_EV_UK");

            entity.Property(e => e.CateringEventId)
                .HasColumnName("CATERING_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeYn)
                .HasColumnName("EXCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtCateringEventId)
                .HasColumnName("EXT_CATERING_EVENT_ID")
                .HasMaxLength(100)
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

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.CateringEvent);
			else
	            entity.HasOne(d => d.CateringEvent)
	                .WithMany(p => p.CateringExternalReferences)
	                .HasForeignKey(d => d.CateringEventId)
	                .HasConstraintName("CAT_EXT_REF_FK1");
        });
	}
}
