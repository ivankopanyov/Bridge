namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationItemDetailsVw
{
    public decimal ReservationItemDetailId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal ReservationItemId { get; set; }
    public string ItemType { get; set; }
    public decimal? ItemNumber { get; set; }
    public string ActiveYn { get; set; }
    public string ReasonCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal ItemId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal? Quantity { get; set; }
    public string BraceletRuleCode { get; set; }
    public string DisplayColor { get; set; }
    public string ArticleNumber { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationItemDetailsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_ITEM_DETAILS_VW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BraceletRuleCode)
                .HasColumnName("BRACELET_RULE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
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

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemNumber)
                .HasColumnName("ITEM_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemType)
                .IsRequired()
                .HasColumnName("ITEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationItemDetailId)
                .HasColumnName("RESERVATION_ITEM_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationItemId)
                .HasColumnName("RESERVATION_ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
