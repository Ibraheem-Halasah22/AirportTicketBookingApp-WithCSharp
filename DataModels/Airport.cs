using DataModeling.Library;

namespace DataModels;

public class Airport : CustomBaseModel
{
    public string Name { get; init; }
    public Country Location { get; init; }
}