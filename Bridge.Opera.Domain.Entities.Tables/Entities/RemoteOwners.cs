namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RemoteOwners
{
    public decimal RemoteOwnerId { get; set; }
    public string OwnerResort { get; set; }
    public string OwnerCode { get; set; }
    public string OwnerType { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string PrimaryEmail { get; set; }
    public string PrimaryPhone { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RemoteOwners>(entity =>
        {
            entity.HasKey(e => e.RemoteOwnerId)
                .HasName("REMOTE_OWNERS_PK");

            entity.ToTable("REMOTE$OWNERS");

            entity.HasIndex(e => new { e.OwnerResort, e.OwnerCode })
                .HasName("REMOTE_OWNERS_IND1");

            entity.Property(e => e.RemoteOwnerId)
                .HasColumnName("REMOTE_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerResort)
                .IsRequired()
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerType)
                .IsRequired()
                .HasColumnName("OWNER_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryEmail)
                .HasColumnName("PRIMARY_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryPhone)
                .HasColumnName("PRIMARY_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
