using System.ComponentModel.DataAnnotations;

namespace DataModeling.Library.Validators;

public abstract class BaseValidationAttribute: ValidationAttribute
{
    public string Name { get; init; }
}