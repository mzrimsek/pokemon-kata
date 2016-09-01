using NUnit.Framework;
using Lib;

namespace Tests
{
    [TestFixture]
    public class GetPokemonGroupShould
    {
        private PokeCart _pokeCart;

        [SetUp]
        public void BeforeEach()
        {
            _pokeCart = new PokeCart();
        }

        [Test]
        public void HaveCountOf1_WhenGiven_OnePokemon()
        {
            _pokeCart.AddPokemon("Pikachu");
            var result = _pokeCart.GetPokemonGroup();
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveDifferentCounts_WhenGiven_TwoPokemonWithDifferentValues()
        {
            _pokeCart.AddPokemon("Pikachu");
            _pokeCart.AddPokemon("Zubat", 2);

            var firstGroup = _pokeCart.GetPokemonGroup();
            var secondGroup = _pokeCart.GetPokemonGroup();

            Assert.That(firstGroup.Count, Is.EqualTo(2));
            Assert.That(secondGroup.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveDifferentCounts_WhenGiven_ManyPokemonWithDifferentValues()
        {
            _pokeCart.AddPokemon("Pikachu", 2);
            _pokeCart.AddPokemon("Zubat", 3);
            _pokeCart.AddPokemon("Clefairy");
            _pokeCart.AddPokemon("Bulbasaur");

            var firstGroup = _pokeCart.GetPokemonGroup();
            var secondGroup = _pokeCart.GetPokemonGroup();
            var thirdGroup = _pokeCart.GetPokemonGroup();

            Assert.That(firstGroup.Count, Is.EqualTo(4));
            Assert.That(secondGroup.Count, Is.EqualTo(2));
            Assert.That(thirdGroup.Count, Is.EqualTo(1));
        }
    }
}