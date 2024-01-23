namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTsa07Vw
{
    public string BusinessDate { get; set; }
    public string Resort { get; set; }
    public string Name { get; set; }
    public string Room { get; set; }
    public string GuestLastName { get; set; }
    public string GuestFirstName { get; set; }
    public string ConfirmationNo { get; set; }
    public string InsertDate { get; set; }
    public string InsertTme { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? CashierId { get; set; }
    public string AppUser { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PostedAmount { get; set; }
    public string Currency { get; set; }
    public decimal? UsdRate { get; set; }
    public decimal? UsdPrice { get; set; }
    public string CreateUser { get; set; }
    public string CreateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTsa07Vw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TSA07_VW");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CreateUser)
                .HasColumnName("CREATE_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.InsertTme)
                .HasColumnName("INSERT_TME")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsdPrice)
                .HasColumnName("USD_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsdRate)
                .HasColumnName("USD_RATE")
                .HasColumnType("NUMBER");
        });
	}
}
