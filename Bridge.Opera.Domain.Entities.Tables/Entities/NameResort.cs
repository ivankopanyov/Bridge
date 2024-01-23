namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameResort
{
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string NameTaxType { get; set; }
    public decimal? TaxPerc1 { get; set; }
    public decimal? TaxPerc2 { get; set; }
    public decimal? TaxPerc3 { get; set; }
    public decimal? TaxPerc4 { get; set; }
    public decimal? TaxPerc5 { get; set; }
    public string Actioncode { get; set; }
    public decimal? GuestType { get; set; }
    public string PaymentMethod { get; set; }
    public string AutoPopulateRoutingYn { get; set; }
    public string Priority { get; set; }
    public string RoomsPotential { get; set; }
    public string CompetitionCode { get; set; }
    public DateTime? LastPrivacyPromptDate { get; set; }

    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameResort>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Resort })
                .HasName("NAME_RESORT_PK");

            entity.ToTable("NAME_RESORT");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .IsUnicode(false);

            entity.Property(e => e.AutoPopulateRoutingYn)
                .HasColumnName("AUTO_POPULATE_ROUTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastPrivacyPromptDate)
                .HasColumnName("LAST_PRIVACY_PROMPT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .IsUnicode(false);

            entity.Property(e => e.TaxPerc1)
                .HasColumnName("TAX_PERC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPerc2)
                .HasColumnName("TAX_PERC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPerc3)
                .HasColumnName("TAX_PERC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPerc4)
                .HasColumnName("TAX_PERC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPerc5)
                .HasColumnName("TAX_PERC5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameResort)
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("NAME_RESORT_NAME_FK");
        });
	}
}
