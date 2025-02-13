
namespace Banking.Tests.BusinessClock;

internal class FakeTimeProvider : TimeProvider
{
    private DateTimeOffset fakeTime;

    public FakeTimeProvider(DateTimeOffset fakeTime)
    {
        this.fakeTime = fakeTime;
    }
}