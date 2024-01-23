namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRtyupUpdate
{
    public decimal RtyupId { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public string RoomType { get; set; }
    public decimal RoomRate { get; set; }
    public string RateCode { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Action { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRtyupUpdate>(entity =>
        {
            entity.HasKey(e => e.RtyupId)
                .HasName("GDS_RTYUP_UPDATE_PK");

            entity.ToTable("GDS_RTYUP_UPDATE");

            entity.Property(e => e.RtyupId)
                .HasColumnName("RTYUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .IsRequired()
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
