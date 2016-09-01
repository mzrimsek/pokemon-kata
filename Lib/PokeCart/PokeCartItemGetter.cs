namespace Lib.PokeCart
{
    public static class PokeCartItemGetter
    {
        public static PokeCartItem GetPikachu()
        {
            return new PokeCartItem
            {
                PokemonName = "Pikachu",
                Price = 6.00
            };
        }

        public static PokeCartItem GetCharmander()
        {
            return new PokeCartItem
            {
                PokemonName = "Charmander",
                Price = 5.00
            };
        }

        public static PokeCartItem GetSquirtle()
        {
            return new PokeCartItem
            {
                PokemonName = "Squirtle",
                Price = 5.00
            };
        }
    }
}