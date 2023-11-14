namespace FilePersistence.API;

public interface IFilePersistence<TId, TEntityType>
{
    void Create(TEntityType entity);

    TEntityType ReadById(TId id);

    void Update(TId id);

    void Delete(TId id);

    IEnumerable<TEntityType> GetAll();

}