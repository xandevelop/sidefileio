namespace Xandevelop.SideFileIO;
using Newtonsoft.Json;

/// <summary>
/// Represents a test suite.
/// </summary>
/// <remarks>
/// Side files contain multiple tests, but not every test will be run - suites represent collections of tests to actually run.
/// </remarks>
public class Suite
{
    /// <summary>
    /// Gets or sets the unique ID for the suite.
    /// </summary>
    [JsonProperty("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the suite.
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets whether the WebDriver session and variables should be reset between test runs.
    /// </summary>
    /// <remarks>
    /// If this is set to true, tests will be non-idempotent, non-isolated and will be difficult to debug, so it is recommended that this be set to false.
    /// </remarks>
    [JsonProperty("persistSession")]
    public bool PersistSession { get; set; }

    /// <summary>
    /// Gets or sets whether tests should be run in parallel when executed from the command line runner.
    /// </summary>
    /// <remarks>
    /// This setting has no effect when running tests in the Selenium IDE replay mode.
    /// </remarks>
    [JsonProperty("parallel")]
    public bool Parallel { get; set; }

    /// <summary>
    /// Gets or sets the allowed timeout for test execution.  Specified in Seconds.
    /// </summary>
    [JsonProperty("timeout")]
    public long Timeout { get; set; }

    /// <summary>
    /// Gets or sets a collection of test Ids that are included in this suite.
    /// </summary>
    [JsonProperty("tests")]
    public List<Guid> Tests { get; set; } = new();
}