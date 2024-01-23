namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameVirtual
{
    public string Resort { get; set; }
    public decimal NameId { get; set; }
    public decimal Pool { get; set; }
    public string Virtual { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameVirtual>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Virtual, e.Pool, e.Resort })
                .HasName("NAME_VIRTUAL_PK");

            entity.ToTable("NAME_VIRTUAL#");

            entity.HasIndex(e => new { e.Virtual, e.Pool, e.Resort })
                .HasName("NV_VPD_FK_I");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Virtual)
                .HasColumnName("VIRTUAL#")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
