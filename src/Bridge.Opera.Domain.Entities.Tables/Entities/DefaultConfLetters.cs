namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DefaultConfLetters
{
    public string? OwnerResort { get; set; }
    public string? Resort { get; set; }
    public decimal? GuestConfLetterId { get; set; }
    public decimal? CompanyConfLetterId { get; set; }
    public decimal? AgentConfLetterId { get; set; }
    public decimal? GroupConfLetterId { get; set; }
    public decimal? SourceConfLetterId { get; set; }
    public decimal? ContactConfLetterId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DefaultConfLetters>(entity =>
        {
            entity.HasKey(e => new { e.OwnerResort, e.Resort })
                .HasName("DEFAULT_CONF_LETTERS_PK");

            entity.ToTable("DEFAULT_CONF_LETTERS");

            entity.Property(e => e.OwnerResort)
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentConfLetterId)
                .HasColumnName("AGENT_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyConfLetterId)
                .HasColumnName("COMPANY_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactConfLetterId)
                .HasColumnName("CONTACT_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupConfLetterId)
                .HasColumnName("GROUP_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestConfLetterId)
                .HasColumnName("GUEST_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceConfLetterId)
                .HasColumnName("SOURCE_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
