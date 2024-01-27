namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SmsDeliveryMethods
{
    public string Resort { get; set; }
    public string Partnerid { get; set; }
    public string ServiceType { get; set; }
    public string ServiceId { get; set; }
    public string UrlName { get; set; }
    public string UrlParameter { get; set; }
    public decimal? MsgTimeout { get; set; }
    public string DelivMethod { get; set; }
    public string ServicePassword { get; set; }
    public string ServiceFormat { get; set; }
    public string ServiceSubject { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SmsDeliveryMethods>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("SMS_DELIVERY_METHODS_PK");

            entity.ToTable("SMS_DELIVERY_METHODS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DelivMethod)
                .HasColumnName("DELIV_METHOD")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MsgTimeout)
                .HasColumnName("MSG_TIMEOUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Partnerid)
                .IsRequired()
                .HasColumnName("PARTNERID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ServiceFormat)
                .HasColumnName("SERVICE_FORMAT")
                .IsUnicode(false);

            entity.Property(e => e.ServiceId)
                .IsRequired()
                .HasColumnName("SERVICE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ServicePassword)
                .HasColumnName("SERVICE_PASSWORD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ServiceSubject)
                .HasColumnName("SERVICE_SUBJECT")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ServiceType)
                .IsRequired()
                .HasColumnName("SERVICE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UrlName)
                .IsRequired()
                .HasColumnName("URL_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UrlParameter)
                .IsRequired()
                .HasColumnName("URL_PARAMETER")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
