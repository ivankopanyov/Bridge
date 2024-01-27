namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScActivityDim
{
    public decimal ActId { get; set; }
    public string Resort { get; set; }
    public string ActType { get; set; }
    public string Purpose { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? EndTime { get; set; }
    public DateTime? CompletedDate { get; set; }
    public decimal? Bookid { get; set; }
    public string Bookresort { get; set; }
    public string Bookingname { get; set; }
    public decimal? Contactid { get; set; }
    public string Contactname { get; set; }
    public decimal? Accountid { get; set; }
    public string Accname { get; set; }
    public string PriorityCode { get; set; }
    public string PriorityDesc { get; set; }
    public string Notes { get; set; }
    public string CreatedByUser { get; set; }
    public string AssignedToUser { get; set; }
    public decimal? AssignedToUserid { get; set; }
    public string PrivateYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public string Tracecode { get; set; }
    public string ActClass { get; set; }
    public string Author { get; set; }
    public decimal? Authorid { get; set; }
    public string ContactPhone { get; set; }
    public string ContactFax { get; set; }
    public string ContactEmail { get; set; }
    public string CompletedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScActivityDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_ACTIVITY_DIM");

            entity.Property(e => e.Accname)
                .HasColumnName("ACCNAME")
                .IsUnicode(false);

            entity.Property(e => e.Accountid)
                .HasColumnName("ACCOUNTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActClass)
                .HasColumnName("ACT_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignedToUser)
                .HasColumnName("ASSIGNED_TO_USER")
                .IsUnicode(false);

            entity.Property(e => e.AssignedToUserid)
                .HasColumnName("ASSIGNED_TO_USERID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Author)
                .HasColumnName("AUTHOR")
                .IsUnicode(false);

            entity.Property(e => e.Authorid)
                .HasColumnName("AUTHORID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bookid)
                .HasColumnName("BOOKID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bookingname)
                .HasColumnName("BOOKINGNAME")
                .IsUnicode(false);

            entity.Property(e => e.Bookresort)
                .HasColumnName("BOOKRESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompletedYn)
                .HasColumnName("COMPLETED_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ContactEmail)
                .HasColumnName("CONTACT_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.ContactFax)
                .HasColumnName("CONTACT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.ContactPhone)
                .HasColumnName("CONTACT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.Contactid)
                .HasColumnName("CONTACTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Contactname)
                .HasColumnName("CONTACTNAME")
                .IsUnicode(false);

            entity.Property(e => e.CreatedByUser)
                .HasColumnName("CREATED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriorityDesc)
                .HasColumnName("PRIORITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PrivateYn)
                .HasColumnName("PRIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Purpose)
                .HasColumnName("PURPOSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
