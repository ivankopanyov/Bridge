namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortDeliveryMarkups
{
    public string Resort { get; set; }
    public string DeliveryType { get; set; }
    public string MarkupType { get; set; }
    public string MarkupScript { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortDeliveryMarkups>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeliveryType, e.MarkupType })
                .HasName("RDP_PK");

            entity.ToTable("RESORT_DELIVERY_MARKUPS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarkupType)
                .HasColumnName("MARKUP_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarkupScript)
                .HasColumnName("MARKUP_SCRIPT")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
