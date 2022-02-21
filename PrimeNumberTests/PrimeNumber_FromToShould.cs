namespace PrimeNumberTests;

#region test data generator
public class TestDataGenerator : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new()
    {
        new object[] { 1, 2, new List<ulong>() { 2 } },
        new object[] { 1, 3, new List<ulong>() { 2, 3 } },
        new object[] { 1, 4, new List<ulong>() { 2, 3 } },
        new object[] { 1, 5, new List<ulong>() { 2, 3, 5 } },
        new object[] { 1, 100, new List<ulong>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 } },
    };

    public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
#endregion

public class PrimeNumberFromToShould
{
    [Theory]
    [ClassData(typeof(TestDataGenerator))]
    public void Return(ulong from, ulong to, List<ulong> expectedReturn) => PrimeNumber.FromTo(from, to).ShouldBe(expectedReturn);
}
