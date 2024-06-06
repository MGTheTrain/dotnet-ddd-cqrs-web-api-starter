namespace {{cookiecutter.project_slug}}.Domain.DomainA;

/// <summary>
/// Represents a command interface facilitating operations beyond reading, such as writing, modifying, deleting, and sending events.
/// </summary>
public interface IDomainACommands
{
    /// <summary>
    /// Creates new domain model A asynchronously.
    /// </summary>
    /// <param name="DomainA">The domain model A to create.</param>
    /// <returns>The created domain model A.</returns>
    Task<DomainA?> CreateAsync(DomainA? DomainA);

    /// <summary>
    /// Updates existing DomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model A to update.</param>
    /// <param name="DomainA">The new domain model A.</param>
    /// <returns>The updated domain model A.</returns>
    Task<DomainA?> UpdateByIdAsync(Guid id, DomainA? DomainA);

    /// <summary>
    /// Deletes DomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model A to delete.</param>
    /// <returns>The deleted domain model A.</returns>
    Task<DomainA?> DeleteByIdAsync(Guid id);
}
