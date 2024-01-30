namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidPhoneTypesChn
{
    public string? ChainCode { get; set; }
    public string? PhoneType { get; set; }
    public string? Description { get; set; }
    public string? PhoneRole { get; set; }
    public decimal? OrderBy { get; set; }
    public string? CanDeleteYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? SmsAllowedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidPhoneTypesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PHONE_TYPES_CHN");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneRole)
                .IsRequired()
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .IsRequired()
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SmsAllowedYn)
                .HasColumnName("SMS_ALLOWED_YN")
                .HasMaxLength(1)
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
