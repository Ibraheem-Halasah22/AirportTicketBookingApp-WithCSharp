﻿namespace FilePersistence.API;

public interface IFilePersistence<TEntityType>
{
    void AddEntity(TEntityType entity);
    
    IEnumerable<TEntityType> GetAll();

    void UpdateEntity(TEntityType entity);

    void DeleteEntity(TEntityType entity);

}