namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionType
{
    public ActionType()
    {
        ActionTypeDtls = new HashSet<ActionTypeDtls>();
        ActionTypeMandWhere = new HashSet<ActionTypeMandWhere>();
        ActionTypeSubscription = new HashSet<ActionTypeSubscription>();
        OcrmCampaigns = new HashSet<OcrmCampaigns>();
    }

    public string? Module { get; set; }
    public string? ActionType1 { get; set; }
    public string? UserLogPresentation { get; set; }
    public string? DeImpactWhenYn { get; set; }
    public string? InheritDeFromModule { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<ActionTypeDtls> ActionTypeDtls { get; set; }
    public virtual ICollection<ActionTypeMandWhere> ActionTypeMandWhere { get; set; }
    public virtual ICollection<ActionTypeSubscription> ActionTypeSubscription { get; set; }
    public virtual ICollection<OcrmCampaigns> OcrmCampaigns { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionType>(entity =>
        {
            entity.HasKey(e => new { e.Module, e.ActionType1 })
                .HasName("OCO_888340");

            entity.ToTable("ACTION_TYPE");

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionType1)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeImpactWhenYn)
                .HasColumnName("DE_IMPACT_WHEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.InheritDeFromModule)
                .HasColumnName("INHERIT_DE_FROM_MODULE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserLogPresentation)
                .IsRequired()
                .HasColumnName("USER_LOG_PRESENTATION")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(ActionTypeDtls)))
				entity.Ignore(e => e.ActionTypeDtls);

			if (!types.Contains(typeof(ActionTypeMandWhere)))
				entity.Ignore(e => e.ActionTypeMandWhere);

			if (!types.Contains(typeof(ActionTypeSubscription)))
				entity.Ignore(e => e.ActionTypeSubscription);

			if (!types.Contains(typeof(OcrmCampaigns)))
				entity.Ignore(e => e.OcrmCampaigns);
		});
	}
}
