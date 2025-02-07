using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents SubdomainEntityA information
/// </summary>
public class EventB : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public EventB()
    {
        Id = Guid.NewGuid();
        TimeStamp = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="EventB">The updated SubdomainEntityA.</param>
    public void SetProperties(EventB EventB)
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
            yield return new ValidationResult($"{nameof(EventB)}.{nameof(Id)} can't be empty");
        }

        if (TimeStamp == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(EventB)}.{nameof(TimeStamp)} can't be empty");
        }
        
        yield return ValidationResult.Success;
    }

    // NOTE: Add other events for domain B
}