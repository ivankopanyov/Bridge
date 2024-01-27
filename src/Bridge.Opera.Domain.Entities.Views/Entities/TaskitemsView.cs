namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaskitemsView
{
    public decimal? TaskitemNumber { get; set; }
    public decimal? TaskCode { get; set; }
    public string TaskDesc { get; set; }
    public string PlantItemCode { get; set; }
    public string PlantItemName { get; set; }
    public DateTime? DueDate { get; set; }
    public string InHouseYn { get; set; }
    public string Frequency { get; set; }
    public string FrequencyDesc { get; set; }
    public string FolderName { get; set; }
    public string FolderDescription { get; set; }
    public string LocationCode { get; set; }
    public string LocationDesc { get; set; }
    public string DeptId { get; set; }
    public string DeptName { get; set; }
    public decimal? MaintainedBy { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? NextMaintDate { get; set; }
    public DateTime? FirstDueDate { get; set; }
    public string Resort { get; set; }
    public string MasterInd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskitemsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TASKITEMS_VIEW");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DeptName)
                .HasColumnName("DEPT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstDueDate)
                .HasColumnName("FIRST_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolderDescription)
                .HasColumnName("FOLDER_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FolderName)
                .HasColumnName("FOLDER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyDesc)
                .HasColumnName("FREQUENCY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InHouseYn)
                .HasColumnName("IN_HOUSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MaintainedBy)
                .HasColumnName("MAINTAINED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterInd)
                .HasColumnName("MASTER_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NextMaintDate)
                .HasColumnName("NEXT_MAINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PlantItemName)
                .HasColumnName("PLANT_ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskDesc)
                .HasColumnName("TASK_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
