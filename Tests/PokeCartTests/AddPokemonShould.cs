using NUnit.Framework;
using Lib;

namespace Tests
{
    [TestFixture]
    public class AddPokemonShould
    {
        private PokeCart _pokeCart;

        [SetUp]
        public void BeforeEach()
        {
            _pokeCart = new PokeCart();
        }

        [Test]
        public void HaveCountOf1_WhenAdding_SinglePokemon()
        {
            _pokeCart.AddPokemon("Charizard");
            var result = _pokeCart.GetCartContents();
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveCountOf1_WhenAdding_SamePokemonTwice()
        {
            _pokeCart.AddPokemon("Charizard", 2);
            var result = _pokeCart.GetCartContents();
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveCountOf2_WhenAdding_TwoDifferentPokemon()
        {
            _pokeCart.AddPokemon("Charizard");
            _pokeCart.AddPokemon("Blastoise");

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void SetValueOf1_WhenAdding_NewPokemon()
        {
            var pokemonName = "Charizard";
            _pokeCart.AddPokemon(pokemonName);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pokemonName];
            
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetValueOf2_WhenAdding_ExistingPokemon()
        {
            var pokemonName = "Charizard";
            _pokeCart.AddPokemon(pokemonName, 2);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pokemonName];
            
            Assert.That(result, Is.EqualTo(2));
        }
    }
}