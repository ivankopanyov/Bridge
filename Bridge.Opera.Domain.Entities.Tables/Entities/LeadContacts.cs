namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LeadContacts
{
    public string Resort { get; set; }
    public decimal LeadId { get; set; }
    public decimal NameId { get; set; }
    public string CommMethod { get; set; }
    public string CommAddress { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string PrimaryYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadContacts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.LeadId, e.NameId })
                .HasName("LEADCON_PK");

            entity.ToTable("LEAD_CONTACTS");

            entity.HasIndex(e => new { e.LeadId, e.Resort })
                .HasName("LEADCON_AH_FK");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LeadId)
                .HasColumnName("LEAD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommAddress)
                .HasColumnName("COMM_ADDRESS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CommMethod)
                .IsRequired()
                .HasColumnName("COMM_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
	                .WithMany(p => p.LeadContacts)
	                .HasForeignKey(d => new { d.LeadId, d.Resort })
	                .HasConstraintName("LEADCON_AH_FK");
        });
	}
}
