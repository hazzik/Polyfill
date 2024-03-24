partial class PolyfillTests
{
    [Test]
    public void ListAddRangeReadOnlySpan()
    {
        var list = new List<char>();
        list.AddRange("ab".AsSpan());
        Assert.AreEqual('a', list[0]);
        Assert.AreEqual('b', list[1]);
    }

    [Test]
    public void ListCopyToSpan()
    {
        var list = new List<char>
        {
            'a'
        };
        var array = new char[1];
        list.CopyTo(array.AsSpan());
        Assert.AreEqual('a', array[0]);
    }
}
