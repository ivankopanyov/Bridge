namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CentralLookupStatDetails
{
    public string Resort { get; set; }
    public string NameType { get; set; }
    public DateTime LookupDate { get; set; }
    public string LookupCriteria { get; set; }
    public string LookupRequestedBy { get; set; }
    public decimal? ProfileFetched { get; set; }
    public decimal? ProcessTime { get; set; }
    public string ErrorYn { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CentralLookupStatDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CENTRAL_LOOKUP_STAT_DETAILS");

            entity.HasIndex(e => e.LookupDate)
                .HasName("CENTRAL_LOOKUP_DETAILS_IND2");

            entity.HasIndex(e => new { e.LookupRequestedBy, e.LookupDate, e.Resort })
                .HasName("CENTRAL_LOOKUP_DETAILS_IND3");

            entity.HasIndex(e => new { e.Resort, e.NameType, e.LookupDate })
                .HasName("CENTRAL_LOOKUP_DETAILS_IND");

            entity.Property(e => e.ErrorYn)
                .HasColumnName("ERROR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LookupCriteria)
                .HasColumnName("LOOKUP_CRITERIA")
                .IsUnicode(false);

            entity.Property(e => e.LookupDate)
                .HasColumnName("LOOKUP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LookupRequestedBy)
                .HasColumnName("LOOKUP_REQUESTED_BY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessTime)
                .HasColumnName("PROCESS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileFetched)
                .HasColumnName("PROFILE_FETCHED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
