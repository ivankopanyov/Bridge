namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfUser
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? DeptId { get; set; }
    public string? DeptDesc { get; set; }
    public string? UserName { get; set; }
    public string? UserDesc { get; set; }
    public string? ResortId { get; set; }
    public string? DeptIdKey { get; set; }
    public string? UserNameKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfUser>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_USER");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.DeptDesc)
                .HasColumnName("DEPT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .IsUnicode(false);

            entity.Property(e => e.DeptIdKey)
                .HasColumnName("DEPT_ID_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.UserDesc)
                .HasColumnName("USER_DESC")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UserNameKey)
                .HasColumnName("USER_NAME_KEY")
                .HasMaxLength(60)
                .IsUnicode(false);
        });
	}
}
