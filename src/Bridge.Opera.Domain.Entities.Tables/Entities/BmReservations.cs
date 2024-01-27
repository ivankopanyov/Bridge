namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmReservations
{
    public decimal ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public string ChannelType { get; set; }
    public string Channel { get; set; }
    public DateTime BusinessDateCreated { get; set; }
    public string Year { get; set; }
    public DateTime? ResvInsertDate { get; set; }
    public DateTime Arrival { get; set; }
    public DateTime Departure { get; set; }
    public string RateCode { get; set; }
    public string RoomType { get; set; }
    public string Status { get; set; }
    public decimal ContractId { get; set; }
    public decimal Seq { get; set; }
    public decimal? StatementId { get; set; }
    public decimal? ChannelTrxNo { get; set; }
    public decimal? ChannelTypeTrxNo { get; set; }
    public decimal? UnitPrice { get; set; }
    public string Currency { get; set; }
    public string First { get; set; }
    public string Middle { get; set; }
    public string Last { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? GuestNameId { get; set; }
    public string Range { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string ArNo { get; set; }
    public decimal? NoOfRooms { get; set; }

    public virtual BmContractElements BmContractElements { get; set; }
    public virtual BmAccounts Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmReservations>(entity =>
        {
            entity.HasKey(e => e.ResvNameId)
                .HasName("BMR_PK");

            entity.ToTable("BM_RESERVATIONS");

            entity.HasIndex(e => new { e.ContractId, e.Seq })
                .HasName("BMR_CONT_SEQ");

            entity.HasIndex(e => new { e.NameId, e.Arrival })
                .HasName("BMR_NAME_DATE");

            entity.HasIndex(e => new { e.NameId, e.ChannelType, e.Channel })
                .HasName("BMR_NS");

            entity.HasIndex(e => new { e.NameId, e.Year, e.Channel })
                .HasName("BMR_NAME_YEAR_CHANNEL");

            entity.HasIndex(e => new { e.StatementId, e.ContractId, e.ChannelType, e.Channel })
                .HasName("BMR_STATEMENT");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .IsRequired()
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelTrxNo)
                .HasColumnName("CHANNEL_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChannelType)
                .IsRequired()
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelTypeTrxNo)
                .HasColumnName("CHANNEL_TYPE_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Range)
                .HasColumnName("RANGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvInsertDate)
                .HasColumnName("RESV_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Year)
                .IsRequired()
                .HasColumnName("YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);

			if (!types.Contains(typeof(BmAccounts)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.BmReservations)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMR_BMA_FK");

			if (!types.Contains(typeof(BmContractElements)))
				entity.Ignore(e => e.BmContractElements);
			else
	            entity.HasOne(d => d.BmContractElements)
	                .WithMany(p => p.BmReservations)
	                .HasForeignKey(d => new { d.ContractId, d.Seq })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMR_BMCE_FK");
        });
	}
}
