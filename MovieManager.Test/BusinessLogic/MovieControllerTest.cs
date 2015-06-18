using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieManager.BusinessLogic;
using MovieManager.Data.Domains;
using NHibernate.Tool.hbm2ddl;

namespace MovieManager.Test.BusinessLogic
{
    [TestClass]
    public class MovieControllerTest
    {
        private const string ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=moviemanager";

        [TestMethod]
        public void CanCreateMovie()
        {
            //Uses NHibernate to persist data in MySQL
            var configuration = Fluently
                .Configure().Database(MySQLConfiguration.Standard.ConnectionString(ConnectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Movie>())
                .ExposeConfiguration(cfg=> new SchemaUpdate(cfg).Execute(true,true))
                .BuildConfiguration();
            
            var sessionFactory = configuration.BuildSessionFactory();

            var movie = new Movie()
            {
                Country = "Argentina",
                Title = "La historia oficial 1",
                Id = 5
            };

            var movieManager = new MovieController(sessionFactory);
            movieManager.UpdateMovie(movie);

        }
    }
}
