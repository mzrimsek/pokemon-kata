using NUnit.Framework;
using Lib;

namespace Tests
{
    [TestFixture]
    public class RemovePokemonShould
    {
        private PokeCart _pokeCart;

        [SetUp]
        public void BeforeEach()
        {
            _pokeCart = new PokeCart();
        }

        [Test]
        public void DoNothing_IfPokemon_DoesNotExist()
        {
            _pokeCart.RemovePokemon("Charizard");
            var result = _pokeCart.GetCartContents();
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void HaveCountOf0_WhenRemoving_OnlyExistingPokemon()
        {
            var pokemonName = "Charizard";
            _pokeCart.AddPokemon(pokemonName);
            _pokeCart.RemovePokemon(pokemonName);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void SetValueOf1_WhenRemoving_PokemonWithValueOf2()
        {
            var pokemonName = "Charizard";
            _pokeCart.AddPokemon(pokemonName, 2);
            _pokeCart.RemovePokemon(pokemonName);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pokemonName];

            Assert.That(result, Is.EqualTo(1));
        }
    }
}