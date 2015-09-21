using System.Configuration;

namespace PolicyMatrix.Configuration
{
    public class PolicyMatrixConfiguration : IPolicyMatrixConfiguration
    {
        public PolicyMatrixConfiguration(string connectionStringName = "policyMatrix")
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringName];

            if (connectionStringSettings == null)
            {
                throw new ConfigurationErrorsException($"There is no connection called {connectionStringName}");
            }

            ConnectionString = connectionStringSettings.ConnectionString;
        }

        public string ConnectionString { get; }
    }
}