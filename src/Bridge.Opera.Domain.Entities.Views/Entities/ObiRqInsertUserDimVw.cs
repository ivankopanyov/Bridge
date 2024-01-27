namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRqInsertUserDimVw
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string DeptId { get; set; }
    public string DeptDesc { get; set; }
    public string UserName { get; set; }
    public string UserDesc { get; set; }
    public string ResortId { get; set; }
    public string DeptIdKey { get; set; }
    public string UserNameKey { get; set; }
    public string AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRqInsertUserDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RQ_INSERT_USER_DIM_VW");

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

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.UserDesc)
                .HasColumnName("USER_DESC")
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.UserNameKey)
                .HasColumnName("USER_NAME_KEY")
                .IsUnicode(false);
        });
	}
}
