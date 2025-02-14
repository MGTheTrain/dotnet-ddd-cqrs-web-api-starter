using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents SubDomainAEntity
/// </summary>
public class SubDomainAEvent : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public SubDomainAEvent()
    {
        Id = Guid.NewGuid();
        TimeStamp = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="SubDomainAEvent">The updated SubDomainAEntity.</param>
    public void SetProperties(SubDomainAEvent SubDomainAEvent)
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
            yield return new ValidationResult($"{nameof(SubDomainAEvent)}.{nameof(Id)} can't be empty");
        }

        if (TimeStamp == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(SubDomainAEvent)}.{nameof(TimeStamp)} can't be empty");
        }
        
        yield return ValidationResult.Success;
    }

    // NOTE: Add other events
}