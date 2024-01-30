namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NumberToSellLimitBaseView
{
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? LimitDate { get; set; }
    public decimal? LimitId { get; set; }
    public decimal? NumberToSell { get; set; }
    public string? OpusCreatedYn { get; set; }
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NumberToSellLimitBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NUMBER_TO_SELL_LIMIT_BASE_VIEW");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LimitDate)
                .HasColumnName("LIMIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LimitId)
                .HasColumnName("LIMIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberToSell)
                .HasColumnName("NUMBER_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpusCreatedYn)
                .HasColumnName("OPUS_CREATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
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
