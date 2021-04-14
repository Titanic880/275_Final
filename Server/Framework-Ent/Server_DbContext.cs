using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Quizlet;
using Standards_Final.Users;

namespace Server.Framework_Ent
{
    public class Server_DbContext : DbContext
    {
        public DbSet<Question> Db_Questions { get; set; }
        public DbSet<Quiz> Db_Quizzes { get; set; }
        public DbSet<User> Db_Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("localhost;Database=275Final;User Id=sa;Password=SchoolCont");
        }
    }
}
