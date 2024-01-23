namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionTypeSubscription
{
    public ActionTypeSubscription()
    {
        ActionTypeSubscriptionDtls = new HashSet<ActionTypeSubscriptionDtls>();
        ActionTypeSubscriptionWhere = new HashSet<ActionTypeSubscriptionWhere>();
    }

    public string ExtSystemCode { get; set; }
    public string Module { get; set; }
    public string ActionType { get; set; }
    public string UserWhereClause { get; set; }
    public string WhereClause { get; set; }
    public string FullOverlayYn { get; set; }
    public string MandatoryWhereClause { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ActionType ActionTypeNavigation { get; set; }
    public virtual ExtSystems ExtSystemCodeNavigation { get; set; }
    public virtual ICollection<ActionTypeSubscriptionDtls> ActionTypeSubscriptionDtls { get; set; }
    public virtual ICollection<ActionTypeSubscriptionWhere> ActionTypeSubscriptionWhere { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypeSubscription>(entity =>
        {
            entity.HasKey(e => new { e.ExtSystemCode, e.Module, e.ActionType })
                .HasName("EB_PK");

            entity.ToTable("ACTION_TYPE_SUBSCRIPTION");

            entity.HasIndex(e => new { e.Module, e.ActionType })
                .HasName("EB_ATP_IDX");

            entity.Property(e => e.ExtSystemCode)
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FullOverlayYn)
                .HasColumnName("FULL_OVERLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MandatoryWhereClause)
                .HasColumnName("MANDATORY_WHERE_CLAUSE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserWhereClause)
                .HasColumnName("USER_WHERE_CLAUSE")
                .IsUnicode(false);

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .IsUnicode(false);

			if (!types.Contains(typeof(ExtSystems)))
				entity.Ignore(e => e.ExtSystemCodeNavigation);
			else
	            entity.HasOne(d => d.ExtSystemCodeNavigation)
	                .WithMany(p => p.ActionTypeSubscription)
	                .HasForeignKey(d => d.ExtSystemCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EB_EXTSYS_FK");

			if (!types.Contains(typeof(ActionType)))
				entity.Ignore(e => e.ActionTypeNavigation);
			else
	            entity.HasOne(d => d.ActionTypeNavigation)
	                .WithMany(p => p.ActionTypeSubscription)
	                .HasForeignKey(d => new { d.Module, d.ActionType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EB_ATP_FK");
        
			if (!types.Contains(typeof(ActionTypeSubscriptionDtls)))
				entity.Ignore(e => e.ActionTypeSubscriptionDtls);

			if (!types.Contains(typeof(ActionTypeSubscriptionWhere)))
				entity.Ignore(e => e.ActionTypeSubscriptionWhere);
		});
	}
}
