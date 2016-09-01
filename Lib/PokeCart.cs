using System;
using System.Collections;
using System.Collections.Generic;

namespace Lib
{
    public class PokeCart
    {
        private readonly double DISCOUNT_RATE = .10;
        private readonly double MAX_DISCOUNT = .20;

        private readonly Dictionary<PokeCartItem, int> _cartContents;

        public PokeCart ()
        {
            _cartContents = new Dictionary<PokeCartItem, int>();
        }

        public Dictionary<PokeCartItem, int> GetCartContents()
        {
            return _cartContents;
        }

        public double GetCartPrice()
        {
            var totalPrice = 0.0;

            while(_cartContents.Count > 0)
            {
                var pokemonGroup = GetPokemonGroup();
                var groupPrice = GetGroupPrice(pokemonGroup);
                totalPrice += groupPrice;
            }
            return totalPrice;
        }

        private double GetGroupPrice(List<PokeCartItem> groupItems)
        {
            var discount = GetDiscount(groupItems.Count);
            var groupPrice = 0.0;
            foreach (var groupItem in groupItems)
            {
                groupPrice += groupItem.Price;
            }
            return groupPrice - (groupPrice * discount);
        }

        public List<PokeCartItem> GetPokemonGroup()
        {
            var pokemonGroup = new List<PokeCartItem>();

            foreach (var cartItem in _cartContents)
            {
                var pokemonName = cartItem.Key;
                pokemonGroup.Add(pokemonName);
            }
            RemovePokemon(pokemonGroup);
            return pokemonGroup;
        }

        public double GetDiscount(int numberOfPokemonInGroup)
        {
            var discount = (numberOfPokemonInGroup - 1) * DISCOUNT_RATE;
            return discount > MAX_DISCOUNT ? MAX_DISCOUNT : discount;
        }
        
        public void AddPokemon(PokeCartItem cartItem)
        {
            var pokemonExists = _cartContents.ContainsKey(cartItem);
            if(pokemonExists)
            {
                var pokemonCount = _cartContents[cartItem];
                _cartContents[cartItem] = pokemonCount + 1;
            }
            else
            {
                _cartContents.Add(cartItem, 1);
            }
        }

        public void AddPokemon(PokeCartItem cartItem, int numberToAdd)
        {
            for (int i = 0; i < numberToAdd; i++)
            {
                AddPokemon(cartItem);
            }
        }

        public void RemovePokemon(PokeCartItem cartItem)
        {
            var pokemonExists = _cartContents.ContainsKey(cartItem);
            if(pokemonExists)
            {
                var pokemonCount = _cartContents[cartItem];
                if(pokemonCount == 1)
                {
                    _cartContents.Remove(cartItem);
                }
                else
                {
                    _cartContents[cartItem] = pokemonCount - 1;
                }
            }
        }

        public void RemovePokemon(List<PokeCartItem> cartItems)
        {
            foreach (var cartItem in cartItems)
            {
                RemovePokemon(cartItem);
            }
        }
    }
}