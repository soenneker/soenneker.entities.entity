using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Entities.Entity.Tests;

[Collection("Collection")]
public class EntityTests : FixturedUnitTest
{
    public EntityTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
