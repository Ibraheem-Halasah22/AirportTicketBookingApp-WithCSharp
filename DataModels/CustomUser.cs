using DataModeling.Library;

namespace DataModels;

public class CustomUser : CustomBaseModel
{
    public string SSN { get; init; }
    public string Name { get; init; }
}