using ProvaWeb2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaWeb2.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
    }
}