namespace {{cookiecutter.project_slug}}.Domain.DomainA;

/// <summary>
/// Represents a query interface that exclusively supports read operations.
/// </summary>
public interface IDomainAQueries
{
    /// <summary>
    /// Gets DomainA based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering DomainA (optional).</param>
    /// <returns>A collection of DomainA matching the specified criteria.</returns>
    Task<IEnumerable<DomainA>?> GetAsync(DomainAFilter? filter);

    /// <summary>
    /// Gets DomainA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model A.</param>
    /// <returns>The domain model A with the specified identifier.</returns>
    Task<DomainA?> GetByIdAsync(Guid id);
}
