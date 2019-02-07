namespace nLauncher
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'nLauncher.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public DbModel() : base("name=Model1")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DbModel>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<AppEntry> AppEntries { get; set; }
         public virtual DbSet<Settings> Settings { get; set; }
    }

    public class AppEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Image1 { get; set; }
        public Byte[] Image2 { get; set; }
    }

    public class Settings
    {
        public int Id { get; set; }
        public int OrderType { get; set; }
        public int ImagesSize { get; set; }
    }
}