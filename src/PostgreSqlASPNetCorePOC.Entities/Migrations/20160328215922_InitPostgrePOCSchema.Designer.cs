using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PostgreSqlASPNetCorePOC.Entities;

namespace PostgreSqlASPNetCorePOC.Entities.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20160328215922_InitPostgrePOCSchema")]
    partial class InitPostgrePOCSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Notes");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderNumber");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<string>("Status");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderId");

                    b.Property<Guid>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OrderId", "ProductId");
                });

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.OrderDetail", b =>
                {
                    b.HasOne("PostgreSqlASPNetCorePOC.Entities.Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("PostgreSqlASPNetCorePOC.Entities.Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
        }
    }
}
