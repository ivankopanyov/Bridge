namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmPostingStatusVw
{
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmPostingStatusVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_POSTING_STATUS_VW");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);
        });
	}
}
