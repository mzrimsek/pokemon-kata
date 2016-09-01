using NUnit.Framework;
using Lib;

namespace Tests
{
    [TestFixture]
    public class GetCartPriceShould
    {
        private PokeCart _pokeCart;

        [SetUp]
        public void BeforeEach()
        {
            _pokeCart = new PokeCart();
        }

        [Test]
        public void Be8_WhenGiven_OnePokemon()
        {
            _pokeCart.AddPokemon("Pikachu");
            var result = _pokeCart.GetCartPrice();
            Assert.That(result, Is.EqualTo(8.00).Within(0.001));
        }

        [Test]
        public void Be16_WhenGiven_TwoOfTheSamePokemon()
        {
            _pokeCart.AddPokemon("Pikachu", 2);
            var result = _pokeCart.GetCartPrice();
            Assert.That(result, Is.EqualTo(16.00).Within(0.001));
        }

        [Test]
        public void Be1520_WhenGiven_TwoDifferentPokemon()
        {
            _pokeCart.AddPokemon("Pikachu");
            _pokeCart.AddPokemon("Squirtle");

            var result = _pokeCart.GetCartPrice();

            Assert.That(result, Is.EqualTo(15.20).Within(0.001));
        }

        [Test]
        public void Be2320_WhenGiven_TwoOfTheSamePokemon_AndOneDifferentPokemon()
        {
            _pokeCart.AddPokemon("Pikachu", 2);
            _pokeCart.AddPokemon("Squirtle");

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(23.20).Within(0.001));
        }

        [Test]
        public void Be3040_WhenGiven_TwoOfTwoDifferentPokemon()
        {
            _pokeCart.AddPokemon("Pikachu", 2);
            _pokeCart.AddPokemon("Squirtle", 2);

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(30.40).Within(0.001));
        }

        [Test]
        public void Be2160_WhenGiven_ThreeDifferentPokemon()
        {
            _pokeCart.AddPokemon("Pikachu");
            _pokeCart.AddPokemon("Squirtle");
            _pokeCart.AddPokemon("Charmander");

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(21.60).Within(0.001));
        }

        [Test]
        public void Be2960_WhenGiven_TwoOfOnePokemon_AndOneOfTwoMoreDifferentPokemon()
        {
            _pokeCart.AddPokemon("Pikachu", 2);
            _pokeCart.AddPokemon("Squirtle");
            _pokeCart.AddPokemon("Charmander");

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(29.60).Within(0.001));
        }

        [Test]
        public void Be60_WhenGiven_TwoOfFourDifferentPokemon_AndOneOfTwoMoreDifferentPokemon()
        {
            _pokeCart.AddPokemon("Snorlax");
            _pokeCart.AddPokemon("Zapdos", 2);
            _pokeCart.AddPokemon("Scyther", 2);
            _pokeCart.AddPokemon("Charmander", 2);
            _pokeCart.AddPokemon("Squirtle", 2);
            _pokeCart.AddPokemon("Pikachu");

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(60.00).Within(0.001));
        }
    }
}