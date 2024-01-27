namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionTypeSubscriptionWhere
{
    public decimal ClauseId { get; set; }
    public string ExtSystemCode { get; set; }
    public string Module { get; set; }
    public string ActionType { get; set; }
    public string DataElementState { get; set; }
    public string DataElement { get; set; }
    public string Operator { get; set; }
    public string DeValue { get; set; }
    public string Andor { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ActionTypeSubscription ActionTypeSubscription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypeSubscriptionWhere>(entity =>
        {
            entity.HasKey(e => e.ClauseId)
                .HasName("ATSW_PK");

            entity.ToTable("ACTION_TYPE_SUBSCRIPTION_WHERE");

            entity.HasIndex(e => new { e.ExtSystemCode, e.Module, e.ActionType })
                .HasName("AT_EB_FK_I");

            entity.Property(e => e.ClauseId)
                .HasColumnName("CLAUSE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Andor)
                .HasColumnName("ANDOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DataElementState)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT_STATE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'O'");

            entity.Property(e => e.DeValue)
                .HasColumnName("DE_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .IsRequired()
                .HasColumnName("OPERATOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ActionTypeSubscription)))
				entity.Ignore(e => e.ActionTypeSubscription);
			else
	            entity.HasOne(d => d.ActionTypeSubscription)
	                .WithMany(p => p.ActionTypeSubscriptionWhere)
	                .HasForeignKey(d => new { d.ExtSystemCode, d.Module, d.ActionType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AT_EB_FK");
        });
	}
}
