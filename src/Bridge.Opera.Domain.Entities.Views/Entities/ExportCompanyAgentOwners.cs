namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportCompanyAgentOwners
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string BusinessDate { get; set; }
    public decimal ProfileId { get; set; }
    public string Udfc40 { get; set; }
    public string ProfileName { get; set; }
    public string OwnerCode { get; set; }
    public string OwnerName { get; set; }
    public string PrimaryYn { get; set; }
    public string ProfileResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportCompanyAgentOwners>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_COMPANY_AGENT_OWNERS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerName)
                .HasColumnName("OWNER_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileName)
                .HasColumnName("PROFILE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProfileResort)
                .HasColumnName("PROFILE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
