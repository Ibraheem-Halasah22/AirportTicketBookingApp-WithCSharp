using System.Globalization;
using CsvHelper;

namespace FilePersistence.API.CSVFilesImplementations;

public class CSVDataAccessor<TEntityType>
{
    private string _filePath;

    public CSVDataAccessor(string path)
    {
        this._filePath = path;
    }
    
    public void WriteDataToCsv(IEnumerable<TEntityType> data)
    {
        using var writer = new StreamWriter(this._filePath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(data);
    }

    public IEnumerable<TEntityType> ReadDataFromCsv()
    {
        using var reader = new StreamReader(this._filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<TEntityType>().ToList();
    }
}