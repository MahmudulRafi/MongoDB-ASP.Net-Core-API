namespace DataAPI.Data
{
    public interface IEmployeeDB
    {
        public string EmployeeCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
