using Soenneker.Tests.HostedUnit;

namespace Soenneker.Entities.Entity.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EntityTests : HostedUnitTest
{
    public EntityTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
