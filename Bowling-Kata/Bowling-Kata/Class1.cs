using FluentAssertions;
using System;
using Xunit;

namespace Bowling_Kata
{
    public class ScoringTests
    {
        [Fact]
        public void given_a_frame_with_two_misses_should_return_0()
        {
            var sut = new BowlingScorer();
            var frame = new Frame(0, 0);
            sut.Add(frame);

            sut.Calculate().Should().Be(0);
        }
    }

    public class Frame
    {
        private readonly int _roll1;
        private readonly int _roll2;

        public Frame(int roll1, int roll2)
        {
            _roll1 = roll1;
            _roll2 = roll2;
        }
    }

    public class BowlingScorer
    {
        public BowlingScorer()
        {
        }

        public void Add(Frame frame)
        {
            throw new NotImplementedException();
        }

        public int Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
