namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailFieldList
{
    public MailFieldList()
    {
        MailSelectFields = new HashSet<MailSelectFields>();
    }

    public decimal? ListId { get; set; }
    public decimal? SourceId { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ListCode { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }

    public virtual MailSource Source { get; set; }
    public virtual ICollection<MailSelectFields> MailSelectFields { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailFieldList>(entity =>
        {
            entity.HasKey(e => e.ListId)
                .HasName("MAILFL_PK");

            entity.ToTable("MAIL_FIELD_LIST");

            entity.HasIndex(e => e.ListCode)
                .HasName("MAILFL_LISTCODE_IDX");

            entity.HasIndex(e => e.Resort)
                .HasName("MAILFL_RESORT_IDX");

            entity.HasIndex(e => e.SourceId)
                .HasName("MAILFL_SOURCEID_FK");

            entity.Property(e => e.ListId)
                .HasColumnName("LIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ListCode)
                .HasColumnName("LIST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailFieldList)
	                .HasForeignKey(d => d.SourceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILFL_MAILS_FK");
        
			if (!types.Contains(typeof(MailSelectFields)))
				entity.Ignore(e => e.MailSelectFields);
		});
	}
}
