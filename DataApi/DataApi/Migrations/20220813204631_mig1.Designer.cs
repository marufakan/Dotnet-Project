// <auto-generated />
using DataApi.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220813204631_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DataApi.Currency", b =>
                {
                    b.Property<int>("CurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BanknoteBuying")
                        .HasColumnType("text");

                    b.Property<string>("BanknoteSelling")
                        .HasColumnType("text");

                    b.Property<string>("CrossRateOther")
                        .HasColumnType("text");

                    b.Property<string>("CrossRateUSD")
                        .HasColumnType("text");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("text");

                    b.Property<string>("ForexBuying")
                        .HasColumnType("text");

                    b.Property<string>("ForexSelling")
                        .HasColumnType("text");

                    b.Property<string>("Isim")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("CurrencyID");

                    b.ToTable("Currencies");
                });
#pragma warning restore 612, 618
        }
    }
}
