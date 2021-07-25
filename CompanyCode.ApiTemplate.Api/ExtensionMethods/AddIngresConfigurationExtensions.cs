using System.Diagnostics;

using CompanyCode.ApiTemplate.Common.Configuration;
using CompanyCode.ApiTemplate.Repository.Ingres.Entities;
using CompanyCode.ApiTemplate.Repository.Ingres.IngresConfiguration;

using FluentNHibernate.Cfg;

using Microsoft.Extensions.DependencyInjection;

using NHibernate;
using NHibernate.SqlCommand;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    public static class AddIngresConfigurationExtensions
    {
        public static void AddIngresNHibernateConfiguration(this IServiceCollection services, DatabaseConnections databaseConnections)
        {
            services.AddSingleton(factory =>
            {
            #if DEBUG
                return Fluently
                    .Configure()
                    .Database(IngresOdbcConnection.CustomIngress.ConnectionString(databaseConnections.IngresDatabaseConnection).ShowSql)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AccountCustomerBusinessUnit>())
                    .ExposeConfiguration(c => c.SetInterceptor(new QueryInterceptor()))
                    .BuildConfiguration()
                    .BuildSessionFactory();
            #else
                return Fluently
                    .Configure()
                    .Database(IngresOdbcConnection.CustomIngress.ConnectionString(databaseConnections.IngresDatabaseConnection))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AccountCustomerBusinessUnit>())
                    .BuildConfiguration()
                    .BuildSessionFactory();
            #endif
            });
            services.AddScoped(s => s.GetService<ISessionFactory>().OpenSession());
        }

        private class QueryInterceptor : EmptyInterceptor
        {
            public override SqlString OnPrepareStatement(SqlString sql)
            {
                Debug.WriteLine(sql.ToString());
                return sql;
            }
        }
    }
}