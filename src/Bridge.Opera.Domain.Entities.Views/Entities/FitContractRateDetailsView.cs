namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractRateDetailsView
{
    public decimal? RateSetId { get; set; }
    public decimal? ContractId { get; set; }
    public string? Resort { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? Rate1 { get; set; }
    public decimal? Rate2 { get; set; }
    public decimal? Rate3 { get; set; }
    public decimal? Rate4 { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? RateAp { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RoomDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractRateDetailsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_RATE_DETAILS_VIEW");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
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

            entity.Property(e => e.Rate1)
                .HasColumnName("RATE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate2)
                .HasColumnName("RATE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate3)
                .HasColumnName("RATE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate4)
                .HasColumnName("RATE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAp)
                .HasColumnName("RATE_AP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomDescription)
                .HasColumnName("ROOM_DESCRIPTION")
                .HasMaxLength(75)
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
