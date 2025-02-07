namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a command interface facilitating operations beyond reading, such as writing, modifying, deleting, and sending events.
/// </summary>
public interface ISubDomainBCommands
{
    /// <summary>
    /// Creates new SubdomainEntityA asynchronously.
    /// </summary>
    /// <param name="subDomainEntityB">The SubdomainEntityA to create.</param>
    /// <returns>The created SubdomainEntityA.</returns>
    Task<SubDomainEntityB?> CreateAsync(SubDomainEntityB? subDomainEntityB);

    /// <summary>
    /// Updates existing SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA to update.</param>
    /// <param name="subDomainEntityB">The new SubdomainEntityA.</param>
    /// <returns>The updated SubdomainEntityA.</returns>
    Task<SubDomainEntityB?> UpdateByIdAsync(Guid id, SubDomainEntityB? subDomainEntityB);

    /// <summary>
    /// Deletes SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA to delete.</param>
    /// <returns>The deleted SubdomainEntityA.</returns>
    Task<SubDomainEntityB?> DeleteByIdAsync(Guid id);
}
