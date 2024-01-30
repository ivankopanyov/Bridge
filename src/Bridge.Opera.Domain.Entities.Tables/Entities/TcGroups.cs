namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TcGroups
{
    public TcGroups()
    {
        TcSubgroups = new HashSet<TcSubgroups>();
        TrxClassRelationships = new HashSet<TrxClassRelationships>();
        TrxRoutingInstructions = new HashSet<TrxRoutingInstructions>();
    }

    public string? IndRevenueGp { get; set; }
    public string? TcGroup { get; set; }
    public string? TctClassType1 { get; set; }
    public string? TctClassType2 { get; set; }
    public string? Description { get; set; }
    public string? TcTransactionType { get; set; }
    public string? Class1MandatoryYn { get; set; }
    public string? Class2MandatoryYn { get; set; }
    public string? ResultIncludedInSumArray { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public string? InternalYn { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual TrxClassTypes TctClassType1Navigation { get; set; }
    public virtual TrxClassTypes TctClassType2Navigation { get; set; }
    public virtual ICollection<TcSubgroups> TcSubgroups { get; set; }
    public virtual ICollection<TrxClassRelationships> TrxClassRelationships { get; set; }
    public virtual ICollection<TrxRoutingInstructions> TrxRoutingInstructions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TcGroups>(entity =>
        {
            entity.HasKey(e => new { e.TcGroup, e.Resort })
                .HasName("TC$_GROUPS_PK");

            entity.ToTable("TC$_GROUPS");

            entity.HasIndex(e => e.TctClassType1)
                .HasName("TMG_TCT_CLASS_TYPE1_FK_I");

            entity.HasIndex(e => e.TctClassType2)
                .HasName("TMG_TCT_CLASS_TYPE2_FK_I");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
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

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TcTransactionType)
                .IsRequired()
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TctClassType1)
                .HasColumnName("TCT_CLASS_TYPE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TctClassType2)
                .HasColumnName("TCT_CLASS_TYPE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(TrxClassTypes)))
				entity.Ignore(e => e.TctClassType1Navigation);
			else
	            entity.HasOne(d => d.TctClassType1Navigation)
	                .WithMany(p => p.TcGroupsTctClassType1Navigation)
	                .HasForeignKey(d => d.TctClassType1)
	                .HasConstraintName("TMG_TCT_CLASS_TYPE1");

			if (!types.Contains(typeof(TrxClassTypes)))
				entity.Ignore(e => e.TctClassType2Navigation);
			else
	            entity.HasOne(d => d.TctClassType2Navigation)
	                .WithMany(p => p.TcGroupsTctClassType2Navigation)
	                .HasForeignKey(d => d.TctClassType2)
	                .HasConstraintName("TMG_TCT_CLASS_TYPE2_FK");
        
			if (!types.Contains(typeof(TcSubgroups)))
				entity.Ignore(e => e.TcSubgroups);

			if (!types.Contains(typeof(TrxClassRelationships)))
				entity.Ignore(e => e.TrxClassRelationships);

			if (!types.Contains(typeof(TrxRoutingInstructions)))
				entity.Ignore(e => e.TrxRoutingInstructions);
		});
	}
}
