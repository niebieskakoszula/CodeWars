namespace CodeWars.UnitTests._4kyu
{
    public class IntervalsTests
    {
        [Fact]
        public void ShouldHandleNullOrEmptyIntervals()
        {
            Assert.Equal(0, Intervals.SumIntervals(null));
            Assert.Equal(0, Intervals.SumIntervals(new (int, int)[0]));
        }
        [Fact]
        public void ShouldAddDisjoinedIntervals()
        {
            Assert.Equal(9, Intervals.SumIntervals(new (int, int)[] { (1, 2), (6, 10), (11, 15) }));
            Assert.Equal(11, Intervals.SumIntervals(new (int, int)[] { (4, 8), (9, 10), (15, 21) }));
            Assert.Equal(7, Intervals.SumIntervals(new (int, int)[] { (-1, 4), (-5, -3) }));
            Assert.Equal(78, Intervals.SumIntervals(new (int, int)[] { (-245, -218), (-194, -179), (-155, -119) }));
        }
        [Fact]
        public void ShouldAddAdjacentIntervals()
        {
            Assert.Equal(54, Intervals.SumIntervals(new (int, int)[] { (1, 2), (2, 6), (6, 55) }));
            Assert.Equal(23, Intervals.SumIntervals(new (int, int)[] { (-2, -1), (-1, 0), (0, 21) }));
        }

        [Fact]
        public void ShouldAddOverlappingIntervals()
        {
            Assert.Equal(7, Intervals.SumIntervals(new (int, int)[] { (1, 4), (7, 10), (3, 5) }));
            Assert.Equal(6, Intervals.SumIntervals(new (int, int)[] { (5, 8), (3, 6), (1, 2) }));
            Assert.Equal(19, Intervals.SumIntervals(new (int, int)[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
        }

        [Fact]
        public void ShouldHandleMixedIntervals()
        {
            Assert.Equal(13, Intervals.SumIntervals(new (int, int)[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
            Assert.Equal(1234, Intervals.SumIntervals(new (int, int)[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
            Assert.Equal(158, Intervals.SumIntervals(new (int, int)[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
        }

        [Fact]
        public void ShouldHandleLargeIntervals()
        {
            Assert.Equal(2_000_000_000, Intervals.SumIntervals(new (int, int)[] { (-1_000_000_000, 1_000_000_000) }));
            Assert.Equal(100_000_030, Intervals.SumIntervals(new (int, int)[] { (0, 20), (-100_000_000, 10), (30, 40) }));
        }
    }
}
