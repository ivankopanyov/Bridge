namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationConfLetter
{
    public string Resort { get; set; }
    public decimal ResvConfLetterId { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal ToNameId { get; set; }
    public decimal? ModuleId { get; set; }
    public string SendTo { get; set; }
    public decimal? NoOfSuccessfulTries { get; set; }
    public string LastStatus { get; set; }
    public string Destination { get; set; }
    public DateTime? LastTimeAttempted { get; set; }
    public string FailureReason { get; set; }
    public string PersonalizeText { get; set; }
    public string DestinationId { get; set; }
    public string InsertUser { get; set; }
    public string UpdateUser { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? AddressId { get; set; }
    public decimal? FaxId { get; set; }
    public decimal? EmailId { get; set; }
    public string FaxLastStatus { get; set; }
    public DateTime? FaxLastAttempted { get; set; }
    public decimal? FaxSuccessfulTries { get; set; }
    public string EmailLastStatus { get; set; }
    public DateTime? EmailLastAttempted { get; set; }
    public decimal? EmailSuccessfulTries { get; set; }
    public string CustomizeYn { get; set; }
    public decimal? MobileId { get; set; }
    public string SmsLastStatus { get; set; }
    public DateTime? SmsLastAttempted { get; set; }
    public decimal? SmsSuccessfulTries { get; set; }
    public string FromEmail { get; set; }
    public string OptionalEmail { get; set; }

    public virtual AppModules Module { get; set; }
    public virtual ReservationName Res { get; set; }
    public virtual Name ToName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationConfLetter>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ResvConfLetterId })
                .HasName("RESV_CONF_LETTER_PK");

            entity.ToTable("RESERVATION_CONF_LETTER");

            entity.HasIndex(e => e.ModuleId)
                .HasName("RESV_CLTR_APP_MOD_FK_I");

            entity.HasIndex(e => e.ResvConfLetterId)
                .HasName("RESV_CON_LETTER_NDX4");

            entity.HasIndex(e => e.ToNameId)
                .HasName("RESV_CON_LETTER_NDX3");

            entity.HasIndex(e => new { e.ResvNameId, e.ToNameId, e.ModuleId })
                .HasName("RESV_CON_LETTER_NDX2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvConfLetterId)
                .HasColumnName("RESV_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomizeYn)
                .HasColumnName("CUSTOMIZE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailLastAttempted)
                .HasColumnName("EMAIL_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.EmailLastStatus)
                .HasColumnName("EMAIL_LAST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailSuccessfulTries)
                .HasColumnName("EMAIL_SUCCESSFUL_TRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FailureReason)
                .HasColumnName("FAILURE_REASON")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxLastAttempted)
                .HasColumnName("FAX_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.FaxLastStatus)
                .HasColumnName("FAX_LAST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxSuccessfulTries)
                .HasColumnName("FAX_SUCCESSFUL_TRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromEmail)
                .HasColumnName("FROM_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .IsRequired()
                .HasColumnName("INSERT_USER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LastStatus)
                .HasColumnName("LAST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastTimeAttempted)
                .HasColumnName("LAST_TIME_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.MobileId)
                .HasColumnName("MOBILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfSuccessfulTries)
                .HasColumnName("NO_OF_SUCCESSFUL_TRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptionalEmail)
                .HasColumnName("OPTIONAL_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PersonalizeText)
                .HasColumnName("PERSONALIZE_TEXT")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.SendTo)
                .IsRequired()
                .HasColumnName("SEND_TO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SmsLastAttempted)
                .HasColumnName("SMS_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.SmsLastStatus)
                .HasColumnName("SMS_LAST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmsSuccessfulTries)
                .HasColumnName("SMS_SUCCESSFUL_TRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToNameId)
                .HasColumnName("TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .IsRequired()
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(30)
                .IsUnicode(false);

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.Module);
			else
	            entity.HasOne(d => d.Module)
	                .WithMany(p => p.ReservationConfLetter)
	                .HasForeignKey(d => d.ModuleId)
	                .HasConstraintName("APP_MODULES");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.ToName);
			else
	            entity.HasOne(d => d.ToName)
	                .WithMany(p => p.ReservationConfLetter)
	                .HasForeignKey(d => d.ToNameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_CONF_LETTER_FK2");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationConfLetter)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_CONF_LETTER_FK1");
        });
	}
}
