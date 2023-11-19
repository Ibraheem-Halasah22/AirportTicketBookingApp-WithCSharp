using System.ComponentModel.DataAnnotations;

namespace DataModeling.Library;

public abstract class CustomBaseModel
{
    public Guid Id { get; init; }

    public IEnumerable<ValidationResult> GetValidationErrors()
    {
        var context = new ValidationContext(this, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();
        Validator.TryValidateObject(this, context, results, true);
        return results;

    }
    public bool Validate()
    {
        var context = new ValidationContext(this, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(this, context, results, true);
        return isValid;

    }
}