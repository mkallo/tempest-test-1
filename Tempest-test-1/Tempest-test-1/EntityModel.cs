namespace Tempest_test_1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<EMP> EMPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMP>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.Login)
                .IsUnicode(false);
        }
    }
}
