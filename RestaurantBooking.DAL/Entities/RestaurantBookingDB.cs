using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RestaurantBooking.DAL.Entities
{
    public partial class RestaurantBookingDB : DbContext
    {
        public RestaurantBookingDB()
            : base("name=RestaurantBookingDB")
        {
        }

        public virtual DbSet<CANCELLATION> CANCELLATIONs { get; set; }
        public virtual DbSet<MENUITEM> MENUITEMs { get; set; }
        public virtual DbSet<RESERVATION> RESERVATIONs { get; set; }
        public virtual DbSet<RESTAURANT> RESTAURANTs { get; set; }
        public virtual DbSet<REVIEW> REVIEWs { get; set; }
        public virtual DbSet<SERVICE> SERVICEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CANCELLATION>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANCELLATION>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEM>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESERVATION>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESERVATION>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

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
                .HasMany(e => e.RESERVATIONs)
                .WithRequired(e => e.RESTAURANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANT>()
                .HasMany(e => e.REVIEWs)
                .WithRequired(e => e.RESTAURANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANT>()
                .HasMany(e => e.SERVICEs)
                .WithRequired(e => e.RESTAURANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REVIEW>()
                .Property(e => e.ID_USER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REVIEW>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE>()
                .Property(e => e.ID_RES)
                .IsFixedLength()
                .IsUnicode(false);

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
                .HasMany(e => e.RESERVATIONs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.REVIEWs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
