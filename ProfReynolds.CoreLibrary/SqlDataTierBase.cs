using Microsoft.Data.SqlClient;

/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary;

public class SqlDataTierBase : IDisposable
{
    protected const string NoQueryResponse = "no query response";

    private string _sqlConnectionString = string.Empty;
    public string SqlConnectionString
    {
        get => _sqlConnectionString;
        set
        {
            _sqlConnectionString = value;
            DB = new SqlConnection(_sqlConnectionString);
        }
    }

    public (string dbSource, string dbCatalog) DatabaseSourceAndCatalog
    { 
        get 
        {
            var csb = new SqlConnectionStringBuilder(_sqlConnectionString);
            return (csb.DataSource, csb.InitialCatalog); 
        } 
    }

    public SqlConnection? DB { get; private set; }

    public SqlDataTierBase() { }

    public SqlDataTierBase(string? sqlConnectionString) =>
        SqlConnectionString = sqlConnectionString ?? string.Empty;


    #region IDisposable Implementation

    private bool _disposed;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            // free other managed objects that implement
            // IDisposable only
        }

        // release any unmanaged objects set the object references to null
        DB?.Close();
        DB?.Dispose();

        _disposed = true;
    }

    ~SqlDataTierBase() { Dispose(false); }

    #endregion
}