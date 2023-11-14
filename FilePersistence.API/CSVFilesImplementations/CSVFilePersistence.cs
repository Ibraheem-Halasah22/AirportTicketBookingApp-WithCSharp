using FilePersistence.API.Exceptions;
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
        if (IsEntityExist(entity)) throw new EntityAlreadyExistException();
        var currentElements = this._dataSource.ReadDataFromCsv().ToList();
        currentElements.Add(entity);
    }

   
    public IEnumerable<TEntityType> GetAll()
    {
        throw new NotImplementedException();
    }

    public void UpdateEntity(TEntityType entity)
    {
        throw new NotImplementedException();
    }

    public bool IsEntityExist(TEntityType entity)
    {
        return this._dataSource.ReadDataFromCsv().Contains(entity);
    }

    public void DeleteEntity(TEntityType entity)
    {
        throw new NotImplementedException();
    }
}