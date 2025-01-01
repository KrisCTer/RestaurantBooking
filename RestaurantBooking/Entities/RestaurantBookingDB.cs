using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RestaurantBooking.Entities
{
    public partial class RestaurantBookingDB : DbContext
    {
        public RestaurantBookingDB()
            : base("name=RestaurantBookingDB")
        {
        }

        public virtual DbSet<CANCELLATION> CANCELLATIONs { get; set; }
        public virtual DbSet<MENUITEM> MENUITEMs { get; set; }
        public virtual DbSet<PAYMENT> PAYMENTs { get; set; }
        public virtual DbSet<RESERVATION> RESERVATIONs { get; set; }
        public virtual DbSet<RESTAURANT> RESTAURANTs { get; set; }
        public virtual DbSet<SERVICE> SERVICEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CANCELLATION>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.METHOD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESERVATION>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESERVATION>()
                .HasMany(e => e.CANCELLATIONs)
                .WithRequired(e => e.RESERVATION)
                .HasForeignKey(e => new { e.ID_RESERVATION, e.ID_USER })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESERVATION>()
                .HasMany(e => e.PAYMENTs)
                .WithRequired(e => e.RESERVATION)
                .HasForeignKey(e => new { e.ID_RESERVATION, e.ID_USER })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANT>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESTAURANT>()
                .Property(e => e.PHONE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESTAURANT>()
                .HasMany(e => e.MENUITEMs)
                .WithRequired(e => e.RESTAURANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANT>()
                .HasMany(e => e.SERVICEs)
                .WithRequired(e => e.RESTAURANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICE>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE>()
                .HasMany(e => e.RESERVATIONs)
                .WithRequired(e => e.SERVICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PHONE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.PAYMENTs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.RESERVATIONs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
