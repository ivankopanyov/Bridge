namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DatamartSyncTypes
{
    public string SyncType { get; set; }
    public string SyncTypeDesc { get; set; }
    public string ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatamartSyncTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DATAMART_SYNC_TYPES");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(37)
                .IsUnicode(false);

            entity.Property(e => e.SyncType)
                .HasColumnName("SYNC_TYPE")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.SyncTypeDesc)
                .HasColumnName("SYNC_TYPE_DESC")
                .IsUnicode(false);
        });
	}
}
