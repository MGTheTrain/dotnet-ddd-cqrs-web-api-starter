namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a command interface facilitating operations beyond reading, such as writing, modifying, deleting, and sending events.
/// </summary>
public interface ISubDomainACommands
{
    /// <summary>
    /// Creates new SubDomainEntityA asynchronously.
    /// </summary>
    /// <param name="subDomainEntityA">The SubDomainEntityA to create.</param>
    /// <returns>The created SubDomainEntityA.</returns>
    Task<SubDomainEntityA?> CreateAsync(SubDomainEntityA? subDomainEntityA);

    /// <summary>
    /// Updates existing SubDomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainEntityA to update.</param>
    /// <param name="subDomainEntityA">The new SubDomainEntityA.</param>
    /// <returns>The updated SubDomainEntityA.</returns>
    Task<SubDomainEntityA?> UpdateByIdAsync(Guid id, SubDomainEntityA? subDomainEntityA);

    /// <summary>
    /// Deletes SubDomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainEntityA to delete.</param>
    /// <returns>The deleted SubDomainEntityA.</returns>
    Task<SubDomainEntityA?> DeleteByIdAsync(Guid id);
}
