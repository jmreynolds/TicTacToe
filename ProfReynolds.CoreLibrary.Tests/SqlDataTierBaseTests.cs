/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary.Tests;


[TestClass]
public record SqlDataTierBaseTests
{
    [TestMethod]
    public void ContractsBaseResponseClassTest()
    {
        SqlDataTierBase sqlDataTierBase = new()
        {
            SqlConnectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=aspnet-Eclipse.MvcApp-epiappdb;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False"
        };

        var databaseSourceAndCatalog = sqlDataTierBase.DatabaseSourceAndCatalog;
        databaseSourceAndCatalog.dbSource.ShouldBe("(localdb)\\MSSQLLocalDB");
        databaseSourceAndCatalog.dbCatalog.ShouldBe("aspnet-Eclipse.MvcApp-epiappdb");
    }

}
