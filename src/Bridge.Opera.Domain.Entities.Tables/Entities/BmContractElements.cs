namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmContractElements
{
    public BmContractElements()
    {
        BmReservations = new HashSet<BmReservations>();
    }

    public decimal ContractId { get; set; }
    public decimal Seq { get; set; }
    public string Type { get; set; }
    public string ChannelType { get; set; }
    public string Channel { get; set; }
    public string Range { get; set; }
    public decimal? MinRange { get; set; }
    public decimal? MaxRange { get; set; }
    public decimal? Price { get; set; }
    public string Currency { get; set; }
    public string PriceBasedOn { get; set; }
    public string Note { get; set; }
    public string TrxCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string Frequency { get; set; }

    public virtual BmContracts Contract { get; set; }
    public virtual ICollection<BmReservations> BmReservations { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmContractElements>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.Seq })
                .HasName("BMCE_PK");

            entity.ToTable("BM_CONTRACT_ELEMENTS");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRange)
                .HasColumnName("MAX_RANGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinRange)
                .HasColumnName("MIN_RANGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriceBasedOn)
                .HasColumnName("PRICE_BASED_ON")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Range)
                .HasColumnName("RANGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BmContracts)))
				entity.Ignore(e => e.Contract);
			else
	            entity.HasOne(d => d.Contract)
	                .WithMany(p => p.BmContractElements)
	                .HasForeignKey(d => d.ContractId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMCE_BMC_FK");
        
			if (!types.Contains(typeof(BmReservations)))
				entity.Ignore(e => e.BmReservations);
		});
	}
}
