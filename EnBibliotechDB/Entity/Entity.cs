using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnBibliotechDB.Entity
{
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity4")
        {
        }

        public virtual DbSet<author> author { get; set; }
        public virtual DbSet<Bibliotheck> Bibliotheck { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Publishing_House> Publishing_House { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<Reader_s_Card> Reader_s_Card { get; set; }
        public virtual DbSet<SNP> SNP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<author>()
                .HasMany(e => e.Book)
                .WithRequired(e => e.author)
                .HasForeignKey(e => e.idAuthor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bibliotheck>()
                .HasMany(e => e.Reader_s_Card)
                .WithRequired(e => e.Bibliotheck)
                .HasForeignKey(e => e.idBibliotheck)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.author)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.id_Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Reader)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.id_Person);

            modelBuilder.Entity<Publishing_House>()
                .HasMany(e => e.Book)
                .WithRequired(e => e.Publishing_House)
                .HasForeignKey(e => e.idPublishingHouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reader>()
                .HasOptional(e => e.Reader_s_Card)
                .WithRequired(e => e.Reader);

            modelBuilder.Entity<Reader_s_Card>()
                .HasMany(e => e.Book)
                .WithOptional(e => e.Reader_s_Card)
                .HasForeignKey(e => e.idReadersCard);

            modelBuilder.Entity<SNP>()
                .HasMany(e => e.Person)
                .WithOptional(e => e.SNP)
                .HasForeignKey(e => e.id_SNP);
        }
    }
}
