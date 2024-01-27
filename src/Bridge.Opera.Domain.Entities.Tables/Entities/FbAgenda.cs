namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FbAgenda
{
    public FbAgenda()
    {
        FbAgendaNotes = new HashSet<FbAgendaNotes>();
        FbAgendaResource = new HashSet<FbAgendaResource>();
        FbAgendaRevenue = new HashSet<FbAgendaRevenue>();
    }

    public decimal FbaId { get; set; }
    public string Resort { get; set; }
    public decimal Bookid { get; set; }
    public string FbaName { get; set; }
    public string EvType { get; set; }
    public DateTime FbaDate { get; set; }
    public decimal? FbaDay { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? FbaBudget { get; set; }
    public string RoomType { get; set; }
    public string RoomSetup { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? DownloadDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public decimal? BudgetPerUnit { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public DateTime? FbaEndDate { get; set; }
    public decimal? ExternalFbaId { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual ICollection<FbAgendaNotes> FbAgendaNotes { get; set; }
    public virtual ICollection<FbAgendaResource> FbAgendaResource { get; set; }
    public virtual ICollection<FbAgendaRevenue> FbAgendaRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FbAgenda>(entity =>
        {
            entity.HasKey(e => e.FbaId)
                .HasName("FBA_PK");

            entity.ToTable("FB$AGENDA");

            entity.HasIndex(e => e.EvType)
                .HasName("FBA_ET_FK_IDX");

            entity.HasIndex(e => new { e.Bookid, e.Resort })
                .HasName("FBA_AH_FK_IDX");

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bookid)
                .HasColumnName("BOOKID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BudgetPerUnit)
                .HasColumnName("BUDGET_PER_UNIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalFbaId)
                .HasColumnName("EXTERNAL_FBA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaBudget)
                .HasColumnName("FBA_BUDGET")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaDate)
                .HasColumnName("FBA_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaDay)
                .HasColumnName("FBA_DAY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaEndDate)
                .HasColumnName("FBA_END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaName)
                .IsRequired()
                .HasColumnName("FBA_NAME")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.FbAgenda)
	                .HasForeignKey(d => new { d.Bookid, d.Resort })
	                .HasConstraintName("FBA_AH_FK");
        
			if (!types.Contains(typeof(FbAgendaNotes)))
				entity.Ignore(e => e.FbAgendaNotes);

			if (!types.Contains(typeof(FbAgendaResource)))
				entity.Ignore(e => e.FbAgendaResource);

			if (!types.Contains(typeof(FbAgendaRevenue)))
				entity.Ignore(e => e.FbAgendaRevenue);
		});
	}
}
