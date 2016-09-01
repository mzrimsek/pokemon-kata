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
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu);

            var result = _pokeCart.GetPokemonGroup();
            
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveDifferentCounts_WhenGiven_TwoPokemonWithDifferentValues()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var charmander = PokeCartItemGetter.GetCharmander();
            _pokeCart.AddPokemon(pikachu);
            _pokeCart.AddPokemon(charmander, 2);

            var firstGroup = _pokeCart.GetPokemonGroup();
            var secondGroup = _pokeCart.GetPokemonGroup();

            Assert.That(firstGroup.Count, Is.EqualTo(2));
            Assert.That(secondGroup.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveDifferentCounts_WhenGiven_ManyPokemonWithDifferentValues()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var charmander = PokeCartItemGetter.GetCharmander();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            _pokeCart.AddPokemon(pikachu, 2);
            _pokeCart.AddPokemon(charmander, 3);
            _pokeCart.AddPokemon(squirtle);

            var firstGroup = _pokeCart.GetPokemonGroup();
            var secondGroup = _pokeCart.GetPokemonGroup();
            var thirdGroup = _pokeCart.GetPokemonGroup();

            Assert.That(firstGroup.Count, Is.EqualTo(3));
            Assert.That(secondGroup.Count, Is.EqualTo(2));
            Assert.That(thirdGroup.Count, Is.EqualTo(1));
        }
    }
}