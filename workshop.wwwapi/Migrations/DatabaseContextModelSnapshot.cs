﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Appointment", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_patient_id");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("booking");

                    b.HasKey("DoctorId", "PatientId", "Booking")
                        .HasName("PK_appoitment_doctor_patient_booking");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            PatientId = 1,
                            Booking = new DateTime(2022, 4, 6, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            DoctorId = 1,
                            PatientId = 2,
                            Booking = new DateTime(2023, 5, 7, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 1,
                            Booking = new DateTime(2024, 6, 8, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Jimi Trump"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Audrey Hepburn"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Kate Hepburn"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Charles Presley"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Audrey Hendrix"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Donald Trump"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Kate Hepburn"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Kate Hendrix"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Charles Jagger"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Jimi Jagger"
                        },
                        new
                        {
                            Id = 11,
                            FullName = "Oprah Hepburn"
                        },
                        new
                        {
                            Id = 12,
                            FullName = "Charles Winfrey"
                        },
                        new
                        {
                            Id = 13,
                            FullName = "Charles Presley"
                        },
                        new
                        {
                            Id = 14,
                            FullName = "Donald Trump"
                        },
                        new
                        {
                            Id = 15,
                            FullName = "Audrey Winfrey"
                        },
                        new
                        {
                            Id = 16,
                            FullName = "Jimi Hepburn"
                        },
                        new
                        {
                            Id = 17,
                            FullName = "Audrey Winslet"
                        },
                        new
                        {
                            Id = 18,
                            FullName = "Audrey Winslet"
                        },
                        new
                        {
                            Id = 19,
                            FullName = "Kate Middleton"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("medicine_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pain killers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Asthma medicine"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Kate Jagger"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Charles Jagger"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Kate Presley"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Audrey Hepburn"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Barack Middleton"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Mick Trump"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Kate Jagger"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Donald Trump"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Mick Presley"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Mick Trump"
                        },
                        new
                        {
                            Id = 11,
                            FullName = "Kate Winslet"
                        },
                        new
                        {
                            Id = 12,
                            FullName = "Kate Presley"
                        },
                        new
                        {
                            Id = 13,
                            FullName = "Jimi Trump"
                        },
                        new
                        {
                            Id = 14,
                            FullName = "Barack Obama"
                        },
                        new
                        {
                            Id = 15,
                            FullName = "Kate Winfrey"
                        },
                        new
                        {
                            Id = 16,
                            FullName = "Donald Winfrey"
                        },
                        new
                        {
                            Id = 17,
                            FullName = "Audrey Presley"
                        },
                        new
                        {
                            Id = 18,
                            FullName = "Mick Windsor"
                        },
                        new
                        {
                            Id = 19,
                            FullName = "Barack Obama"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("prescription_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_patient_id");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("prescription");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DoctorId = 1,
                            PatientId = 1
                        },
                        new
                        {
                            Id = 2,
                            DoctorId = 2,
                            PatientId = 1
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.PrescriptionMedicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_medicine_id");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_prescription_id");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("MedicineId", "PrescriptionId")
                        .HasName("PK_medicine_prescription");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionMedicines");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            PrescriptionId = 1,
                            Notes = "One a day",
                            Quantity = 20
                        },
                        new
                        {
                            MedicineId = 2,
                            PrescriptionId = 1,
                            Notes = "Use when short of breath",
                            Quantity = 5
                        },
                        new
                        {
                            MedicineId = 2,
                            PrescriptionId = 2,
                            Notes = "Use when short off breath",
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Prescription", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.PrescriptionMedicine", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Medicine", "Medicine")
                        .WithMany("PrescriptionMedicine")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicine")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Medicine", b =>
                {
                    b.Navigation("PrescriptionMedicine");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicine");
                });
#pragma warning restore 612, 618
        }
    }
}
