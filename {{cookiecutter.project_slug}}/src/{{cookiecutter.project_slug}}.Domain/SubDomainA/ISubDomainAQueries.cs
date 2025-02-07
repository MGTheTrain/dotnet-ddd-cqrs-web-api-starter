namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a query interface that exclusively supports read operations.
/// </summary>
public interface ISubDomainAQueries
{
    /// <summary>
    /// Gets SubDomainEntityA based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainEntityA matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainEntityA>?> GetAsync(SubDomainAFilter? filter);

    /// <summary>
    /// Gets SubDomainEntityA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA.</param>
    /// <returns>The SubdomainEntityA with the specified identifier.</returns>
    Task<SubDomainEntityA?> GetByIdAsync(Guid id);
}
