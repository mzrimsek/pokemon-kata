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
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.RemovePokemon(pikachu);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void HaveCountOf0_WhenRemoving_OnlyExistingPokemon()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu);
            _pokeCart.RemovePokemon(pikachu);

            var result = _pokeCart.GetCartContents();

            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void SetValueOf1_WhenRemoving_PokemonWithValueOf2()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu, 2);
            _pokeCart.RemovePokemon(pikachu);

            var cartContents = _pokeCart.GetCartContents();
            var result = cartContents[pikachu];

            Assert.That(result, Is.EqualTo(1));
        }
    }
}