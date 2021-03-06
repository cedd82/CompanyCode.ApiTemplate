using FluentNHibernate.Cfg.Db;

using NHibernate.Dialect;
using NHibernate.Driver;

namespace CompanyCode.ApiTemplate.Repository.Ingres.IngresConfiguration
{
    public class IngresOdbcConnection : PersistenceConfiguration<IngresOdbcConnection, OdbcConnectionStringBuilder>
    {
        private IngresOdbcConnection()
        {
            Driver<OdbcDriver>();
        }

        public static IngresOdbcConnection CustomIngress
        {
            get
            {
                IngresOdbcConnection ingresOdbcConnection = new IngresOdbcConnection().Dialect<Ingres9Dialect>();
            #if DEBUG
                ingresOdbcConnection.ShowSql();
                ingresOdbcConnection.FormatSql();
            #endif
                return ingresOdbcConnection;
            }
        }
    }
}