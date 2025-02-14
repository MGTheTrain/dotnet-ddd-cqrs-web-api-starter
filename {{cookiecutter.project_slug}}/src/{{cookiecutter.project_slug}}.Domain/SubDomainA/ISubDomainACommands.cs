namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a command interface facilitating operations such as writing, modifying, deleting and sending events
/// </summary>
public interface ISubDomainACommands
{
    /// <summary>
    /// Creates new SubDomainAEntity asynchronously.
    /// </summary>
    /// <param name="subDomainAEntity">The SubDomainAEntity to create.</param>
    /// <returns>The created SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> CreateAsync(SubDomainAEntity? subDomainAEntity);

    /// <summary>
    /// Updates existing SubDomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to update.</param>
    /// <param name="subDomainAEntity">The new SubDomainAEntity.</param>
    /// <returns>The updated SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> UpdateByIdAsync(Guid id, SubDomainAEntity? subDomainAEntity);

    /// <summary>
    /// Deletes SubDomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to delete.</param>
    /// <returns>The deleted SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> DeleteByIdAsync(Guid id);
}
