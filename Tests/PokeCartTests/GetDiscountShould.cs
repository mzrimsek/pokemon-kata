using NUnit.Framework;
using Lib.PokeCart;

namespace Tests
{
    [TestFixture]
    public class GetDiscountShould
    {
        private PokeCart _pokeCart;

        [SetUp]
        public void BeforeEach()
        {
            _pokeCart = new PokeCart();
        }

        [Test]
        public void Be0_WhenGiven_GroupOfSize1()
        {
            var result = _pokeCart.GetDiscount(1);
            Assert.That(result, Is.EqualTo(0.0).Within(0.001));
        }

        [Test]
        public void Be10_WhenGiven_GroupOfSize2()
        {
            var result = _pokeCart.GetDiscount(2);
            Assert.That(result, Is.EqualTo(0.10).Within(0.001));
        }

        [Test]
        public void Be20_WhenGiven_GroupOfSize3()
        {
            var result = _pokeCart.GetDiscount(3);
            Assert.That(result, Is.EqualTo(0.20).Within(0.001));
        }
    }
}