namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BroadcastRules
{
    public string ChainCode { get; set; }
    public string NameType { get; set; }
    public string BroadcastYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ChainCode ChainCodeNavigation { get; set; }
    public virtual NameClass NameTypeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BroadcastRules>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.NameType })
                .HasName("BRE_PK");

            entity.ToTable("BROADCAST_RULES");

            entity.HasIndex(e => e.NameType)
                .HasName("BRE_NCS_FKI");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BroadcastYn)
                .IsRequired()
                .HasColumnName("BROADCAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ChainCode)))
				entity.Ignore(e => e.ChainCodeNavigation);
			else
	            entity.HasOne(d => d.ChainCodeNavigation)
	                .WithMany(p => p.BroadcastRules)
	                .HasForeignKey(d => d.ChainCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BRE_CCE_FK");

			if (!types.Contains(typeof(NameClass)))
				entity.Ignore(e => e.NameTypeNavigation);
			else
	            entity.HasOne(d => d.NameTypeNavigation)
	                .WithMany(p => p.BroadcastRules)
	                .HasForeignKey(d => d.NameType)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BRE_NCS_FK");
        });
	}
}
