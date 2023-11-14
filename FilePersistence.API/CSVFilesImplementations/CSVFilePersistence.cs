using FilePersistence.API.FilesTypesInterfaces;

namespace FilePersistence.API.CSVFilesImplementations;

public class CSVFilePersistence<TId, TEntityType> : ICSVFilePersistence<TId, TEntityType>
{
    private string _filePath;

    public CSVFilePersistence(string path)
    {
        this._filePath = path;
    }
    public void Create(TEntityType entity)
    {
        throw new NotImplementedException();
    }

    public TEntityType ReadById(TId id)
    {
        throw new NotImplementedException();
    }

    public void Update(TId id)
    {
        throw new NotImplementedException();
    }

    public void Delete(TId id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntityType> GetAll()
    {
        throw new NotImplementedException();
    }
}