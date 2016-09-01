using NUnit.Framework;
using Lib;

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
        public void Be5_WhenGiven_GroupOfSize2()
        {
            var result = _pokeCart.GetDiscount(2);
            Assert.That(result, Is.EqualTo(0.05).Within(0.001));
        }

        [Test]
        public void Be10_WhenGiven_GroupOfSize3()
        {
            var result = _pokeCart.GetDiscount(3);
            Assert.That(result, Is.EqualTo(0.10).Within(0.001));
        }

        [Test]
        public void Be15_WhenGiven_GroupOfSize4()
        {
            var result = _pokeCart.GetDiscount(4);
            Assert.That(result, Is.EqualTo(0.15).Within(0.001));
        }

        [Test]
        public void Be25_WhenGiven_GroupOfSize5()
        {
            var result = _pokeCart.GetDiscount(5);
            Assert.That(result, Is.EqualTo(0.25).Within(0.001));
        }

        [Test]
        public void Be30_WhenGiven_GroupOfSize6()
        {
            var result = _pokeCart.GetDiscount(6);
            Assert.That(result, Is.EqualTo(0.30).Within(0.001));
        }

        [Test]
        public void Be35_WhenGiven_GroupOfSize7()
        {
            var result = _pokeCart.GetDiscount(7);
            Assert.That(result, Is.EqualTo(0.35).Within(0.001));
        }

        [Test]
        public void Be35_WhenGiven_GroupOfSize10()
        {
            var result = _pokeCart.GetDiscount(10);
            Assert.That(result, Is.EqualTo(0.35).Within(0.001));
        }
    }
}