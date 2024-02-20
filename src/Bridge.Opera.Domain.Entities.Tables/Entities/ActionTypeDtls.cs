namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionTypeDtls
{
    public ActionTypeDtls()
    {
        ActionTypeSubscriptionDtls = new HashSet<ActionTypeSubscriptionDtls>();
    }

    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }
    public string? UsageContext { get; set; }
    public string? DataElementDatatype { get; set; }
    public decimal? LovSequence { get; set; }
    public string? Xmltagname { get; set; }
    public string? Grpxmltagname { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ActionType ActionTypeNavigation { get; set; }
    public virtual ICollection<ActionTypeSubscriptionDtls> ActionTypeSubscriptionDtls { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypeDtls>(entity =>
        {
            entity.HasKey(e => new { e.Module, e.ActionType, e.DataElement })
                .HasName("BE_SEED_PK");

            entity.ToTable("ACTION_TYPE_DTLS");

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElementDatatype)
                .HasColumnName("DATA_ELEMENT_DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Grpxmltagname)
                .HasColumnName("GRPXMLTAGNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LovSequence)
                .HasColumnName("LOV_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsageContext)
                .HasColumnName("USAGE_CONTEXT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'B'");

            entity.Property(e => e.Xmltagname)
                .HasColumnName("XMLTAGNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ActionType)))
				entity.Ignore(e => e.ActionTypeNavigation);
			else
	            entity.HasOne(d => d.ActionTypeNavigation)
	                .WithMany(p => p.ActionTypeDtls)
	                .HasForeignKey(d => new { d.Module, d.ActionType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BESEED_ATP_FK");
        
			if (!types.Contains(typeof(ActionTypeSubscriptionDtls)))
				entity.Ignore(e => e.ActionTypeSubscriptionDtls);
		});
	}
}
