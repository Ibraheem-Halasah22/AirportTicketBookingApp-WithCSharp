using System.ComponentModel.DataAnnotations;

namespace DataModeling.Library;

public abstract class CustomBaseModel
{
    public Guid Id { get; init; }

    public bool Validate()
    {
        var context = new ValidationContext(this, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(this, context, results, true);
        return isValid;

    }
}