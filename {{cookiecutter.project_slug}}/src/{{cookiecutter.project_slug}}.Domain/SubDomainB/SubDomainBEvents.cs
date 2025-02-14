using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents Subdo<mainAEntity
/// </summary>
public class SubDomainBEvent : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public SubDomainBEvent()
    {
        Id = Guid.NewGuid();
        TimeStamp = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="SubDomainBEvent">The updated SubDomainAEntity.</param>
    public void SetProperties(SubDomainBEvent SubDomainBEvent)
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
            yield return new ValidationResult($"{nameof(SubDomainBEvent)}.{nameof(Id)} can't be empty");
        }

        if (TimeStamp == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(SubDomainBEvent)}.{nameof(TimeStamp)} can't be empty");
        }
        
        yield return ValidationResult.Success;
    }

    // NOTE: Add other events
}