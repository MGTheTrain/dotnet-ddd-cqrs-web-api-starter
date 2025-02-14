namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a query interface that exclusively supports read operations
/// </summary>
public interface ISubDomainBQueries
{
    /// <summary>
    /// Gets SubDomainBEntity based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainBEntity matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainBEntity>?> GetAsync(SubDomainBFilter? filter);

    /// <summary>
    /// Gets SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainBEntity.</param>
    /// <returns>The SubDomainBEntity with the specified identifier.</returns>
    Task<SubDomainBEntity?> GetByIdAsync(Guid id);
}
