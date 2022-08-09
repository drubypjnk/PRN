using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace project.Models
{
    public partial class Shop_PRNContext : DbContext
    {
        public Shop_PRNContext()
        {
        }

        public Shop_PRNContext(DbContextOptions<Shop_PRNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Notify> Notifies { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Account__F3DBC5733713A4EC");

                entity.ToTable("Account");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Avartar)
                    .HasColumnType("text")
                    .HasColumnName("avartar");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Account__role_id__6FE99F9F");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("category_name");

                entity.Property(e => e.Images)
                    .HasColumnType("ntext")
                    .HasColumnName("images");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .HasColumnName("content");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__comment__product__05D8E0BE");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__comment__usernam__06CD04F7");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("Note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Note__order_id__02FC7413");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__Note__username__14270015");
            });

            modelBuilder.Entity<Notify>(entity =>
            {
                entity.ToTable("notify");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Backlink)
                    .HasColumnType("ntext")
                    .HasColumnName("backlink");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("content");

                entity.Property(e => e.Image)
                    .HasColumnType("ntext")
                    .HasColumnName("image");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Notifies)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__notify__username__09A971A2");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Freight)
                    .HasColumnType("money")
                    .HasColumnName("freight");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.RequireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("require_date");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ship_address");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ship_city");

                entity.Property(e => e.ShipGender).HasColumnName("ship_gender");

                entity.Property(e => e.ShipMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ship_mobile");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(255)
                    .HasColumnName("ship_name");

                entity.Property(e => e.ShipedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shiped_date");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("money")
                    .HasColumnName("total_price");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__orders__username__4316F928");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK__order_de__022945F617086C47");

                entity.ToTable("order_details");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__order_det__order__49C3F6B7");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__order_det__produ__4AB81AF0");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Brand)
                    .HasMaxLength(250)
                    .HasColumnName("brand");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Describe)
                    .HasColumnType("ntext")
                    .HasColumnName("describe");

                entity.Property(e => e.Feature).HasColumnName("feature");

                entity.Property(e => e.Origin)
                    .HasMaxLength(250)
                    .HasColumnName("origin");

                entity.Property(e => e.OriginalPrice)
                    .HasColumnType("money")
                    .HasColumnName("original_price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .HasColumnName("product_name");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("money")
                    .HasColumnName("sale_price");

                entity.Property(e => e.Thumbnail)
                    .HasMaxLength(250)
                    .HasColumnName("thumbnail");

                entity.Property(e => e.UnitInStock).HasColumnName("unit_in_stock");

                entity.Property(e => e.UnitOnOrder).HasColumnName("unit_on_order");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_category_001");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
