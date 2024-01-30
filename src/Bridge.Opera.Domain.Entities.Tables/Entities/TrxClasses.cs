namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxClasses
{
    public TrxClasses()
    {
        TrxClassRelationships = new HashSet<TrxClassRelationships>();
    }

    public string? Resort { get; set; }
    public string? TclCode { get; set; }
    public string? TctType { get; set; }
    public string? Description { get; set; }
    public string? Class1MandatoryYn { get; set; }
    public string? Class2MandatoryYn { get; set; }
    public string? ResultIncludedInSumArray { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual TrxClassTypes TctTypeNavigation { get; set; }
    public virtual ICollection<TrxClassRelationships> TrxClassRelationships { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxClasses>(entity =>
        {
            entity.HasKey(e => new { e.TclCode, e.Resort })
                .HasName("TRX$_CLASSES_PK");

            entity.ToTable("TRX$_CLASSES");

            entity.HasIndex(e => e.TclCode)
                .HasName("TCL_CODE_UK")
                .IsUnique();

            entity.HasIndex(e => e.TctType)
                .HasName("TRX_CLASSES_N1");

            entity.Property(e => e.TclCode)
                .HasColumnName("TCL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Class1MandatoryYn)
                .HasColumnName("CLASS_1_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Class2MandatoryYn)
                .HasColumnName("CLASS_2_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TctType)
                .IsRequired()
                .HasColumnName("TCT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(TrxClassTypes)))
				entity.Ignore(e => e.TctTypeNavigation);
			else
	            entity.HasOne(d => d.TctTypeNavigation)
	                .WithMany(p => p.TrxClasses)
	                .HasForeignKey(d => d.TctType)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TCL_TCT_FK");
        
			if (!types.Contains(typeof(TrxClassRelationships)))
				entity.Ignore(e => e.TrxClassRelationships);
		});
	}
}
