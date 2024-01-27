namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ContractSend
{
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public decimal ContractSendId { get; set; }
    public decimal ToNameId { get; set; }
    public string SendTo { get; set; }
    public string FromEmail { get; set; }
    public decimal? ModuleId { get; set; }
    public string Destination { get; set; }
    public decimal? AddressId { get; set; }
    public string AddressLastStatus { get; set; }
    public DateTime? AddressLastAttempted { get; set; }
    public decimal? AddressSuccessfulTries { get; set; }
    public decimal? FaxId { get; set; }
    public string FaxLastStatus { get; set; }
    public DateTime? FaxLastAttempted { get; set; }
    public decimal? FaxSuccessfulTries { get; set; }
    public decimal? EmailId { get; set; }
    public string EmailLastStatus { get; set; }
    public DateTime? EmailLastAttempted { get; set; }
    public decimal? EmailSuccessfulTries { get; set; }
    public string FailureReason { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContractSend>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentHeaderId, e.Resort, e.ContractSendId })
                .HasName("CONTRACT_SEND_PK");

            entity.ToTable("CONTRACT_SEND");

            entity.HasIndex(e => e.ContractSendId)
                .HasName("CONTRACT_SEND_SENDID_IDX");

            entity.HasIndex(e => e.ModuleId)
                .HasName("CONTRACT_SEND_MODULEID_IDX");

            entity.HasIndex(e => e.ToNameId)
                .HasName("CONTRACT_SEND_NAMEID_IDX");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractSendId)
                .HasColumnName("CONTRACT_SEND_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressLastAttempted)
                .HasColumnName("ADDRESS_LAST_ATTEMPTED")
                .HasColumnType("DATE");

            entity.Property(e => e.AddressLastStatus)
                .HasColumnName("ADDRESS_LAST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressSuccessfulTries)
                .HasColumnName("ADDRESS_SUCCESSFUL_TRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SendTo)
                .IsRequired()
                .HasColumnName("SEND_TO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToNameId)
                .HasColumnName("TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.ContractSend)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("CONTRACT_SEND_AH_FK");
        });
	}
}
