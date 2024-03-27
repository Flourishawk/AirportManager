using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace AirportManager.Models;

public partial class AirportdbContext : DbContext
{
    public AirportdbContext()
    {
    }

    public AirportdbContext(DbContextOptions<AirportdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<Airplane> Airplanes { get; set; }

    public virtual DbSet<AirplaneType> AirplaneTypes { get; set; }

    public virtual DbSet<AirportConstruction> AirportConstructions { get; set; }

    public virtual DbSet<AirportLocation> AirportLocations { get; set; }

    public virtual DbSet<Capacity> Capacities { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Human> Humans { get; set; }

    public virtual DbSet<Passanger> Passangers { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=1234;database=airportdb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.3.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.AirlineId).HasName("PRIMARY");

            entity.ToTable("airline");

            entity.Property(e => e.AirlineId)
                .ValueGeneratedNever()
                .HasColumnName("airline_id");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Airplane>(entity =>
        {
            entity.HasKey(e => new { e.AirplaneId, e.AirlineId, e.AirplaneTypeId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("airplane");

            entity.HasIndex(e => e.AirplaneId, "airplane_id_UNIQUE").IsUnique();

            entity.HasIndex(e => e.AirlineId, "fk_airplane_airline1_idx");

            entity.HasIndex(e => e.AirplaneTypeId, "fk_airplane_airplane_type1_idx");

            entity.HasIndex(e => e.CapacityId, "fk_airplane_capacity1_idx");

            entity.Property(e => e.AirplaneId).HasColumnName("airplane_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.AirplaneTypeId).HasColumnName("airplane_type_id");
            entity.Property(e => e.CapacityId).HasColumnName("capacity_id");

            entity.HasOne(d => d.Airline).WithMany(p => p.Airplanes)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_airplane_airline1");

            entity.HasOne(d => d.AirplaneType).WithMany(p => p.Airplanes)
                .HasForeignKey(d => d.AirplaneTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_airplane_airplane_type1");

            entity.HasOne(d => d.Capacity).WithMany(p => p.Airplanes)
                .HasForeignKey(d => d.CapacityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_airplane_capacity1");
        });

        modelBuilder.Entity<AirplaneType>(entity =>
        {
            entity.HasKey(e => e.AirplaneTypeId).HasName("PRIMARY");

            entity.ToTable("airplane_type");

            entity.Property(e => e.AirplaneTypeId)
                .ValueGeneratedNever()
                .HasColumnName("airplane_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
        });

        modelBuilder.Entity<AirportConstruction>(entity =>
        {
            entity.HasKey(e => new { e.AirportId, e.LocationId, e.AirlineId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("airport_construction");

            entity.HasIndex(e => e.AirportId, "airport_id_UNIQUE").IsUnique();

            entity.HasIndex(e => e.AirlineId, "fk_airport_airline1_idx");

            entity.HasIndex(e => e.LocationId, "fk_airport_airport_location1_idx");

            entity.Property(e => e.AirportId).HasColumnName("airport_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");

            entity.HasOne(d => d.Airline).WithMany(p => p.AirportConstructions)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_airport_airline1");

            entity.HasOne(d => d.Location).WithMany(p => p.AirportConstructions)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_airport_airport_location1");
        });

        modelBuilder.Entity<AirportLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("airport_location");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("location_id");
            entity.Property(e => e.City)
                .HasMaxLength(45)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(45)
                .HasColumnName("country");
            entity.Property(e => e.Latitude)
                .HasMaxLength(45)
                .HasColumnName("latitude");
            entity.Property(e => e.Longtitude)
                .HasMaxLength(45)
                .HasColumnName("longtitude");
        });

        modelBuilder.Entity<Capacity>(entity =>
        {
            entity.HasKey(e => e.CapacityId).HasName("PRIMARY");

            entity.ToTable("capacity");

            entity.Property(e => e.CapacityId)
                .ValueGeneratedNever()
                .HasColumnName("capacity_id");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PRIMARY");

            entity.ToTable("department");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.AirplaneId, "fk_employee_airplane1_idx");

            entity.HasIndex(e => e.DepartmentId, "fk_employee_department1_idx");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("employee_id");
            entity.Property(e => e.AirplaneId).HasColumnName("airplane_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Salary)
                .HasPrecision(10)
                .HasColumnName("salary");
            entity.Property(e => e.Username)
                .HasMaxLength(45)
                .HasColumnName("username");

            entity.HasOne(d => d.Airplane).WithMany(p => p.Employees)
                .HasPrincipalKey(p => p.AirplaneId)
                .HasForeignKey(d => d.AirplaneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employee_airplane1");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employee_department1");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => new { e.FlightId, e.AirlineId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("flight");

            entity.HasIndex(e => e.AirlineId, "fk_flight_airline1_idx");

            entity.HasIndex(e => e.FlightId, "flight_id_UNIQUE").IsUnique();

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("timestamp")
                .HasColumnName("arrival_time");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("timestamp")
                .HasColumnName("departure_time");

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_flight_airline1");

            entity.HasMany(d => d.Airports).WithMany(p => p.Flights)
                .UsingEntity<Dictionary<string, object>>(
                    "ArrivalAirport",
                    r => r.HasOne<AirportConstruction>().WithMany()
                        .HasPrincipalKey("AirportId")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_arrival_airport_airport1"),
                    l => l.HasOne<Flight>().WithMany()
                        .HasPrincipalKey("FlightId")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_arrival_airport_flight1"),
                    j =>
                    {
                        j.HasKey("FlightId", "AirportId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("arrival_airport");
                        j.HasIndex(new[] { "AirportId" }, "fk_arrival_airport_airport1");
                        j.HasIndex(new[] { "FlightId" }, "fk_arrival_airport_flight1_idx");
                        j.IndexerProperty<int>("FlightId").HasColumnName("flight_id");
                        j.IndexerProperty<int>("AirportId").HasColumnName("airport_id");
                    });

            entity.HasMany(d => d.AirportsNavigation).WithMany(p => p.FlightsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartureAirport",
                    r => r.HasOne<AirportConstruction>().WithMany()
                        .HasPrincipalKey("AirportId")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_direction_airport2"),
                    l => l.HasOne<Flight>().WithMany()
                        .HasPrincipalKey("FlightId")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_flight_has_airport_location_flight1"),
                    j =>
                    {
                        j.HasKey("FlightId", "AirportId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("departure_airport");
                        j.HasIndex(new[] { "AirportId" }, "fk_direction_airport2_idx");
                        j.HasIndex(new[] { "FlightId" }, "fk_flight_has_airport_location_flight1_idx");
                        j.IndexerProperty<int>("FlightId").HasColumnName("flight_id");
                        j.IndexerProperty<int>("AirportId").HasColumnName("airport_id");
                    });
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PRIMARY");

            entity.ToTable("gender");

            entity.Property(e => e.GenderId)
                .ValueGeneratedNever()
                .HasColumnName("gender_id");
            entity.Property(e => e.GenderName)
                .HasMaxLength(45)
                .HasColumnName("gender_name");
        });

        modelBuilder.Entity<Human>(entity =>
        {
            entity.HasKey(e => e.HumanId).HasName("PRIMARY");

            entity.ToTable("human");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "fk_human_employee1_idx");

            entity.HasIndex(e => e.GenderId, "fk_human_gender1_idx");

            entity.HasIndex(e => e.PassangerId, "fk_human_passanger1_idx");

            entity.HasIndex(e => e.Telephone, "telephone_UNIQUE").IsUnique();

            entity.Property(e => e.HumanId).HasColumnName("human_id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.GenderId).HasColumnName("gender_id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.PassangerId).HasColumnName("passanger_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");
            entity.Property(e => e.Telephone)
                .HasMaxLength(60)
                .HasColumnName("telephone");

            entity.HasOne(d => d.Employee).WithMany(p => p.Humans)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("fk_human_employee1");

            entity.HasOne(d => d.Gender).WithMany(p => p.Humans)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("fk_human_gender1");

            entity.HasOne(d => d.Passanger).WithMany(p => p.Humans)
                .HasForeignKey(d => d.PassangerId)
                .HasConstraintName("fk_human_passanger1");
        });

        modelBuilder.Entity<Passanger>(entity =>
        {
            entity.HasKey(e => e.PassangerId).HasName("PRIMARY");

            entity.ToTable("passanger");

            entity.Property(e => e.PassangerId).HasColumnName("passanger_id");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PRIMARY");

            entity.ToTable("ticket");

            entity.HasIndex(e => e.PassangerId, "fk_ticket_passanger1_idx");

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("timestamp")
                .HasColumnName("departure_time");
            entity.Property(e => e.ExpirationTime)
                .HasColumnType("timestamp")
                .HasColumnName("expiration_time");
            entity.Property(e => e.PassangerId).HasColumnName("passanger_id");
            entity.Property(e => e.PurchaseTime)
                .HasColumnType("timestamp")
                .HasColumnName("purchase_time");
            entity.Property(e => e.Seat).HasColumnName("seat");

            entity.HasOne(d => d.Passanger).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.PassangerId)
                .HasConstraintName("fk_ticket_passanger1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
