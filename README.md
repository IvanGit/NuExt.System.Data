# NuExt.System.Data

`NuExt.System.Data` provides a set of extensions for data classes to simplify and enhance database operations. This package is designed to streamline common tasks in database interaction, making it easier to manage and manipulate data within .NET applications.

### Commonly Used Types

- **`System.Data.DalBase`**: Base class for Data Access Layer (DAL) implementations.
- **`System.Data.DataReaderExtensions`**: Provides extension methods for `DataReader` objects.
- **`System.Data.DataRowExtensions`**: Adds extension methods for `DataRow` objects.
- **`System.Data.DataTableExtensions`**: Includes extension methods for `DataTable` objects.
- **`System.Data.DbConverter<TDbConnection>`**: Base class for database converters.
- **`System.Data.IDbContext`**: Interface for database context operations.

### Installation

You can install `NuExt.System.Data` via [NuGet](https://www.nuget.org/):

```sh
dotnet add package NuExt.System.Data
```

Or through the Visual Studio package manager:

1. Go to `Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...`.
2. Search for `NuExt.System.Data`.
3. Click "Install".

### Usage Examples

For comprehensive examples of how to use the package, see samples in the following repository:

- [NuExt.System.Data.SQLite](https://github.com/IvanGit/NuExt.System.Data.SQLite)

### License

Licensed under the MIT License. See the LICENSE file for details.