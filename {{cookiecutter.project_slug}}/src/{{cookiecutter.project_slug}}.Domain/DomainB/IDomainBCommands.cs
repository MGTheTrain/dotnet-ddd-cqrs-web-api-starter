namespace {{cookiecutter.project_slug}}.Domain.DomainB;

/// <summary>
/// Represents a command interface facilitating operations beyond reading, such as writing, modifying, deleting, and sending events.
/// </summary>
public interface IDomainBCommands
{
    /// <summary>
    /// Creates new domain model A asynchronously.
    /// </summary>
    /// <param name="domainModelB">The domain model A to create.</param>
    /// <returns>The created domain model A.</returns>
    Task<DomainModelB?> CreateAsync(DomainModelB? domainModelB);

    /// <summary>
    /// Updates existing DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model A to update.</param>
    /// <param name="domainModelB">The new domain model A.</param>
    /// <returns>The updated domain model A.</returns>
    Task<DomainModelB?> UpdateByIdAsync(Guid id, DomainModelB? domainModelB);

    /// <summary>
    /// Deletes DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model A to delete.</param>
    /// <returns>The deleted domain model A.</returns>
    Task<DomainModelB?> DeleteByIdAsync(Guid id);
}
