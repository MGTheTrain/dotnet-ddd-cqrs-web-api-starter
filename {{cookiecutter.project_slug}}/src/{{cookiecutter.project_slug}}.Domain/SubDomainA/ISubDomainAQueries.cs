namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a query interface that exclusively supports read operations
/// </summary>
public interface ISubDomainAQueries
{
    /// <summary>
    /// Gets SubDomainAEntity based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainAEntity matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainAEntity>?> GetAsync(SubDomainAFilter? filter);

    /// <summary>
    /// Gets SubDomainAEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity.</param>
    /// <returns>The SubDomainAEntity with the specified identifier.</returns>
    Task<SubDomainAEntity?> GetByIdAsync(Guid id);
}
