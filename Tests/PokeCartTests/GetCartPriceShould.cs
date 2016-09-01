using NUnit.Framework;
using Lib.PokeCart;

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
        public void Be6_WhenGiven_OnePikachu()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu);

            var result = _pokeCart.GetCartPrice();

            Assert.That(result, Is.EqualTo(6.00).Within(0.001));
        }

        [Test]
        public void Be12_WhenGiven_TwoPikachus()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            _pokeCart.AddPokemon(pikachu, 2);

            var result = _pokeCart.GetCartPrice();

            Assert.That(result, Is.EqualTo(12.00).Within(0.001));
        }

        [Test]
        public void Be990_WhenGiven_OnePikachu_AndOneSquirtle()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            _pokeCart.AddPokemon(pikachu);
            _pokeCart.AddPokemon(squirtle);

            var result = _pokeCart.GetCartPrice();

            Assert.That(result, Is.EqualTo(9.90).Within(0.001));
        }

        [Test]
        public void Be1590_WhenGiven_TwoPikachus_AndOneSquirtle()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            _pokeCart.AddPokemon(pikachu, 2);
            _pokeCart.AddPokemon(squirtle);

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(15.90).Within(0.001));
        }

        [Test]
        public void Be1980_WhenGiven_TwoPikachus_AndTwoSquirtles()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            _pokeCart.AddPokemon(pikachu, 2);
            _pokeCart.AddPokemon(squirtle, 2);

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(19.80).Within(0.001));
        }

        [Test]
        public void Be1280_WhenGiven_OnePikachu_AndOneSquirtle_AndOneCharmander()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            var charmander = PokeCartItemGetter.GetCharmander();
            _pokeCart.AddPokemon(pikachu);
            _pokeCart.AddPokemon(squirtle);
            _pokeCart.AddPokemon(charmander);

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(12.80).Within(0.001));
        }

        [Test]
        public void Be1880_WhenGiven_TwoPikachus_AndOneSquirtle_AndOneCharmander()
        {
            var pikachu = PokeCartItemGetter.GetPikachu();
            var squirtle = PokeCartItemGetter.GetSquirtle();
            var charmander = PokeCartItemGetter.GetCharmander();
            _pokeCart.AddPokemon(pikachu, 2);
            _pokeCart.AddPokemon(squirtle);
            _pokeCart.AddPokemon(charmander);

            var result = _pokeCart.GetCartPrice();
            
            Assert.That(result, Is.EqualTo(18.80).Within(0.001));
        }
    }
}