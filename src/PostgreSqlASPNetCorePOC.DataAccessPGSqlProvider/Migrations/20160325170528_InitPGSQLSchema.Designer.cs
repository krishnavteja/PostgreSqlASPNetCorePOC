using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PostgreSqlASPNetCorePOC.DataAccessPGSqlProvider;

namespace PostgreSqlASPNetCorePOC.DataAccessPGSqlProvider.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20160325170528_InitPGSQLSchema")]
    partial class InitPGSQLSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.DataEventRecord", b =>
                {
                    b.Property<long>("DataEventRecordId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("SourceInfoId");

                    b.Property<long?>("SourceInfoSourceInfoId");

                    b.Property<DateTime>("Timestamp");

                    b.Property<DateTime>("UpdatedTimestamp");

                    b.HasKey("DataEventRecordId");
                });

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.SourceInfo", b =>
                {
                    b.Property<long>("SourceInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Timestamp");

                    b.Property<DateTime>("UpdatedTimestamp");

                    b.HasKey("SourceInfoId");
                });

            modelBuilder.Entity("PostgreSqlASPNetCorePOC.Entities.DataEventRecord", b =>
                {
                    b.HasOne("PostgreSqlASPNetCorePOC.Entities.SourceInfo")
                        .WithMany()
                        .HasForeignKey("SourceInfoSourceInfoId");
                });
        }
    }
}
