﻿using CodeWars.Core._4kyu;

namespace CodeWars.UnitTests._4kyu
{
    public class HumanReadableDurationFormatTests
    {
        [Theory]
        [InlineData(0, "now")]
        [InlineData(1, "1 second")]
        [InlineData(62, "1 minute and 2 seconds")]
        [InlineData(120, "2 minutes")]
        [InlineData(3600, "1 hour")]
        [InlineData(3662, "1 hour, 1 minute and 2 seconds")]
        [InlineData(15731080, "182 days, 1 hour, 44 minutes and 40 seconds")]
        [InlineData(132030240, "4 years, 68 days, 3 hours and 4 minutes")]
        [InlineData(205851834, "6 years, 192 days, 13 hours, 3 minutes and 54 seconds")]
        [InlineData(253374061, "8 years, 12 days, 13 hours, 41 minutes and 1 second")]
        [InlineData(242062374, "7 years, 246 days, 15 hours, 32 minutes and 54 seconds")]
        [InlineData(101956166, "3 years, 85 days, 1 hour, 9 minutes and 26 seconds")]
        [InlineData(33243586, "1 year, 19 days, 18 hours, 19 minutes and 46 seconds")]
        public void FormatDuration(int seconds, string expected)
        {
            Assert.Equal(expected, HumanReadableDurationFormat.FormatDuration(seconds));
        }
    }
}
