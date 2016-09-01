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
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveCountOf1_WhenAdding_SamePokemonTwice()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu, 2);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void HaveCountOf2_WhenAdding_TwoDifferentPokemon()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var charmander = PokeCartItemGetter.GetCharmander();
            _pokeCart.AddPokemon(pikachu);
            _pokeCart.AddPokemon(charmander);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void SetValueOf1_WhenAdding_NewPokemon()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pikachu];
            
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetValueOf2_WhenAdding_ExistingPokemon()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu, 2);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pikachu];
            
            Assert.That(result, Is.EqualTo(2));
        }
    }
}