﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Domain.Entities;

namespace GymManagement.Infrastructure.Contexts
{
    public class GymManagementDbContext : DbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) 
            :base(options)
        {

        }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ExerciseProgram> ExercisePrograms { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerContract> WorkerContracts { get; set; }
    }
}