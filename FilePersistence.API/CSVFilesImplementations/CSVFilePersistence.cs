using FilePersistence.API.FilesTypesInterfaces;

namespace FilePersistence.API.CSVFilesImplementations;

public class CSVFilePersistence<TEntityType> : ICSVFilePersistence<TEntityType>
{
    private CSVDataAccessor<TEntityType> _dataSource;

    public CSVFilePersistence(string path)
    {
        this._dataSource = new(path);
    }
    public void AddEntity(TEntityType entity)
    {
        var currentElements = this._dataSource.ReadDataFromCsv();
        
    }

   
    public IEnumerable<TEntityType> GetAll()
    {
        throw new NotImplementedException();
    }

    public void UpdateEntity(TEntityType entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteEntity(TEntityType entity)
    {
        throw new NotImplementedException();
    }
}