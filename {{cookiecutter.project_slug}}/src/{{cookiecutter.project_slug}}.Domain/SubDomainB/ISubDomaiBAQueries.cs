namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a query interface that exclusively supports read operations.
/// </summary>
public interface ISubDomainBQueries
{
    /// <summary>
    /// Gets SubDomainEntityB based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainEntityB matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainEntityB>?> GetAsync(SubDomainBFilter? filter);

    /// <summary>
    /// Gets SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityB.</param>
    /// <returns>The SubdomainEntityB with the specified identifier.</returns>
    Task<SubDomainEntityB?> GetByIdAsync(Guid id);
}
