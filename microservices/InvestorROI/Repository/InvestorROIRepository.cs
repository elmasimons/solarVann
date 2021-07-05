using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using InvestorROI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace InvestorROI.Repository
{
    public class InvestorROIRepository<T> : IInvestorROIRepository<T> where T : BaseModel
    {
        IConfiguration _config;
        private ILogger<InvestorROIRepository<T>> _logger;

        public InvestorROIRepository(ILogger<InvestorROIRepository<T>> logger, IConfiguration configuration)
        {
            _config = configuration;
            _logger = logger;
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public List<T> GetAll()
        {
            List<T> list;

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration["ConnectionString"];

            using (var conn = OpenConnection(connectionString))
            {
                var querySQL = @"SELECT actor_id, first_name, last_name, last_update FROM public.actor";
                list = conn.Query<T>(querySQL).ToList();
                return list;
            }

        }
    }
}
