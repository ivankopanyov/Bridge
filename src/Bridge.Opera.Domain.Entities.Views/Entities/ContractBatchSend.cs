namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ContractBatchSend
{
    public string Resort { get; set; }
    public decimal? BlockId { get; set; }
    public string Description { get; set; }
    public string BlockCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string BookStatus { get; set; }
    public string CatStatus { get; set; }
    public DateTime? RmsDecision { get; set; }
    public DateTime? RmsFollowup { get; set; }
    public string Tourcode { get; set; }
    public string TourYn { get; set; }
    public string LeadYn { get; set; }
    public string ContractTo { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }
    public string Address { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    public decimal? ToNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContractBatchSend>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONTRACT_BATCH_SEND");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookStatus)
                .HasColumnName("BOOK_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractTo)
                .HasColumnName("CONTRACT_TO")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.LeadYn)
                .HasColumnName("LEAD_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsDecision)
                .HasColumnName("RMS_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsFollowup)
                .HasColumnName("RMS_FOLLOWUP")
                .HasColumnType("DATE");

            entity.Property(e => e.ToNameId)
                .HasColumnName("TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TourYn)
                .HasColumnName("TOUR_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Tourcode)
                .HasColumnName("TOURCODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
