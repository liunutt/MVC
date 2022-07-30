using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data{


    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        //Dbset --> table
        //Object ของ Movie --> Record
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }

}