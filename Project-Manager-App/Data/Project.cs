namespace Project_Manager_App.Data
{
    public class Project
    {
        private int Id { get; set; }
        private DateTime CreatedAt { get; set; }
        private string Name { get; set; }

        public Project()
        {
            CreatedAt = DateTime.Now;
            Name = "Guest";
        }
    }
}