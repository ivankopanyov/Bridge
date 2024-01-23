namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvAutoAttachDet
{
    public decimal AttachId { get; set; }
    public string Resort { get; set; }
    public string RuleCode { get; set; }
    public string Preference { get; set; }
    public string PreferenceType { get; set; }
    public decimal? ItemId { get; set; }
    public string Product { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string TraceDeptId { get; set; }
    public string TraceText { get; set; }
    public string PromoCode { get; set; }

    public virtual ResvAutoAttachRules R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvAutoAttachDet>(entity =>
        {
            entity.HasKey(e => e.AttachId)
                .HasName("RESV_AUTO_ATT_PK");

            entity.ToTable("RESV_AUTO_ATTACH_DET");

            entity.HasIndex(e => new { e.Resort, e.RuleCode })
                .HasName("RESV_AUTO_ATT_IDX1");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preference)
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .IsRequired()
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TraceDeptId)
                .HasColumnName("TRACE_DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TraceText)
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResvAutoAttachRules)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.ResvAutoAttachDet)
	                .HasForeignKey(d => new { d.Resort, d.RuleCode })
	                .HasConstraintName("RAT_RAE_FK");
        });
	}
}
