namespace {{cookiecutter.project_slug}}.Domain.DomainB;

/// <summary>
/// Represents a query interface that exclusively supports read operations.
/// </summary>
public interface IDomainBQueries
{
    /// <summary>
    /// Gets DomainB based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering DomainB (optional).</param>
    /// <returns>A collection of DomainB matching the specified criteria.</returns>
    Task<IEnumerable<DomainModelB>?> GetAsync(DomainBFilter? filter);

    /// <summary>
    /// Gets DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model B.</param>
    /// <returns>The domain model B with the specified identifier.</returns>
    Task<DomainModelB?> GetByIdAsync(Guid id);
}
