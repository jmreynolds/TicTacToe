using System.Reflection;

/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary.Wrappers;

public class AssemblyWrapper : IDisposable
{
    //  Change assembly information settings for your application through either:
    //  - Project->Properties->Application->Assembly Information
    //  - AssemblyInfo.cs

    // CallingConventions this way: 
    // var assembly = new CommonFramework.Core.AssemblyWrapper(System.Reflection.Assembly.GetExecutingAssembly());

    private readonly Assembly _assembly;

    public AssemblyWrapper(Assembly assembly)
    {
        _assembly = assembly;
    }

    public string AssemblyTitle
    {
        get
        {
            var attributes = _assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

            if (attributes.Length > 0)
            {
                var rootAttribute = (AssemblyTitleAttribute)attributes[0];
                if (!rootAttribute.Title.IsNullOrEmpty()) return rootAttribute.Title;
            }
            return _assembly.Location;
            // return Path.GetFileNameWithoutExtension(_assembly.CodeBase);
        }
    }

    public string AssemblyVersion => _assembly.GetName().Version?.ToString() ?? string.Empty;

    public string AssemblyDescription
    {
        get
        {
            var attributes = _assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                var rootAttribute = (AssemblyDescriptionAttribute)attributes[0];
                if (!rootAttribute.Description.IsNullOrEmpty()) return rootAttribute.Description;
            }

            return string.Empty;
        }
    }

    public string AssemblyProduct
    {
        get
        {
            var attributes = _assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);

            if (attributes.Length > 0)
            {
                var rootAttribute = (AssemblyProductAttribute)attributes[0];
                if (!rootAttribute.Product.IsNullOrEmpty()) return rootAttribute.Product;
            }

            return string.Empty;
        }
    }

    public string AssemblyCopyright
    {
        get
        {
            var attributes = _assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

            if (attributes.Length > 0)
            {
                var rootAttribute = (AssemblyCopyrightAttribute)attributes[0];
                if (!rootAttribute.Copyright.IsNullOrEmpty()) return rootAttribute.Copyright;
            }

            return string.Empty;
        }
    }

    public string AssemblyCompany
    {
        get
        {
            var attributes = _assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

            if (attributes.Length > 0)
            {
                var rootAttribute = (AssemblyCompanyAttribute)attributes[0];
                if (!rootAttribute.Company.IsNullOrEmpty()) return rootAttribute.Company;
            }

            return string.Empty;
        }
    }


    #region IDisposable Members

    private bool _disposed; // to detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                /* dummy-up */
            }
            _disposed = true;
        }
        // no base class   base.Dispose(disposing);
    }

    ~AssemblyWrapper()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    #endregion
}