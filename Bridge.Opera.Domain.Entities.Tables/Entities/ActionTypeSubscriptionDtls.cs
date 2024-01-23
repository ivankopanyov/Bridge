namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionTypeSubscriptionDtls
{
    public string ExtSystemCode { get; set; }
    public string Module { get; set; }
    public string ActionType { get; set; }
    public string DataElement { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ActionTypeDtls ActionTypeDtls { get; set; }
    public virtual ActionTypeSubscription ActionTypeSubscription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypeSubscriptionDtls>(entity =>
        {
            entity.HasKey(e => new { e.ExtSystemCode, e.Module, e.ActionType, e.DataElement })
                .HasName("EXTDTLS_PK");

            entity.ToTable("ACTION_TYPE_SUBSCRIPTION_DTLS");

            entity.HasIndex(e => new { e.Module, e.ActionType, e.DataElement })
                .HasName("BE_EXTBE_FK_I");

            entity.Property(e => e.ExtSystemCode)
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
	                .WithMany(p => p.ActionTypeSubscriptionDtls)
	                .HasForeignKey(d => new { d.ExtSystemCode, d.Module, d.ActionType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EXTDTLS_EB_FK");

			if (!types.Contains(typeof(ActionTypeDtls)))
				entity.Ignore(e => e.ActionTypeDtls);
			else
	            entity.HasOne(d => d.ActionTypeDtls)
	                .WithMany(p => p.ActionTypeSubscriptionDtls)
	                .HasForeignKey(d => new { d.Module, d.ActionType, d.DataElement })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BE_EXTBE_FK");
        });
	}
}
