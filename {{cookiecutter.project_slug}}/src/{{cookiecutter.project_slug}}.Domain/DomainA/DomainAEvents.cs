using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.DomainA;

/// <summary>
/// Represents domain model A information
/// </summary>
public class EventA : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public EventA()
    {
        Id = Guid.NewGuid();
        TimeStamp = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="EventA">The updated domain model A.</param>
    public void SetProperties(EventA EventA)
    {
        // More attributes
    }

    public Guid Id { get; internal set; } 
    public DateTime TimeStamp { get; internal set; }
    // More attributes
    

    /// <summary>
    /// Validates properties
    /// </summary>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Id == Guid.Empty)
        {
            yield return new ValidationResult($"{nameof(EventA)}.{nameof(Id)} can't be empty");
        }

        if (TimeStamp == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(EventA)}.{nameof(TimeStamp)} can't be empty");
        }
        
        yield return ValidationResult.Success;
    }

    // NOTE: Add other events for domain A
}