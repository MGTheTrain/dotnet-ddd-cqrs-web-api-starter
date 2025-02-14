namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a command interface facilitating operations such as writing, modifying, deleting and sending events
/// </summary>
public interface ISubDomainBCommands
{
    /// <summary>
    /// Creates new SubDomainAEntity asynchronously.
    /// </summary>
    /// <param name="subDomainBEntity">The SubDomainAEntity to create.</param>
    /// <returns>The created SubDomainAEntity.</returns>
    Task<SubDomainBEntity?> CreateAsync(SubDomainBEntity? subDomainBEntity);

    /// <summary>
    /// Updates existing SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to update.</param>
    /// <param name="subDomainBEntity">The new SubDomainAEntity.</param>
    /// <returns>The updated SubDomainAEntity.</returns>
    Task<SubDomainBEntity?> UpdateByIdAsync(Guid id, SubDomainBEntity? subDomainBEntity);

    /// <summary>
    /// Deletes SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to delete.</param>
    /// <returns>The deleted SubDomainAEntity.</returns>
    Task<SubDomainBEntity?> DeleteByIdAsync(Guid id);
}
