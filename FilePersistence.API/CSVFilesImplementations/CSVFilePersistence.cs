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
        this._dataSource.WriteDataToCsv(currentElements);
            
    }

   
    public IEnumerable<TEntityType> GetAll()
    {
        return this._dataSource.ReadDataFromCsv();
    }

    public void UpdateEntity(TEntityType entity, TEntityType updatedEntity)
    {
        if (!IsEntityExist(entity)) throw new EntityNotFoundException();
        var currentElements = this._dataSource.ReadDataFromCsv().ToList();
        var index = currentElements.FindIndex(item => entity.Equals(item));
        currentElements[index] = updatedEntity;
        this._dataSource.WriteDataToCsv(currentElements);

    }

    public bool IsEntityExist(TEntityType entity)
    {
        return this._dataSource.ReadDataFromCsv().Contains(entity);
    }

    public void DeleteEntity(TEntityType entity)
    {
        if (!IsEntityExist(entity)) throw new EntityNotFoundException();
        var currentElements = this._dataSource.ReadDataFromCsv().ToList();
        currentElements.Remove(entity);
        this._dataSource.WriteDataToCsv(currentElements);

    }
}