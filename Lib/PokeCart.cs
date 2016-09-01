using System;
using System.Collections;
using System.Collections.Generic;

namespace Lib
{
    public class PokeCart
    {
        private readonly double DISCOUNT_RATE = .05;
        private readonly double MAX_DISCOUNT = .35;
        private readonly double POKEMON_PRICE = 8.0;

        private readonly Dictionary<string, int> _cartContents;

        public PokeCart ()
        {
            _cartContents = new Dictionary<string, int>();
        }

        public Dictionary<string, int> GetCartContents()
        {
            return _cartContents;
        }

        public double GetCartPrice()
        {
            var totalPrice = 0.0;

            while(_cartContents.Count > 0)
            {
                var pokemonGroup = GetPokemonGroup();
                var discount = GetDiscount(pokemonGroup.Count);

                double groupPrice = POKEMON_PRICE * pokemonGroup.Count;
                groupPrice -= groupPrice * discount;

                totalPrice += groupPrice;
            }
            return totalPrice;
        }

        public List<string> GetPokemonGroup()
        {
            var pokemonGroup = new List<string>();

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
            var discount = 0.0;
            if(numberOfPokemonInGroup < 5)
            {
                discount = (numberOfPokemonInGroup - 1) * DISCOUNT_RATE;
            }
            else
            {
                discount = numberOfPokemonInGroup * DISCOUNT_RATE;
            }

            return discount > MAX_DISCOUNT ? MAX_DISCOUNT : discount;
        }
        
        public void AddPokemon(string pokemonName)
        {
            var pokemonExists = _cartContents.ContainsKey(pokemonName);
            if(pokemonExists)
            {
                var pokemonCount = _cartContents[pokemonName];
                _cartContents[pokemonName] = pokemonCount + 1;
            }
            else
            {
                _cartContents.Add(pokemonName, 1);
            }
        }

        public void AddPokemon(string pokemonName, int numberToAdd)
        {
            for (int i = 0; i < numberToAdd; i++)
            {
                AddPokemon(pokemonName);
            }
        }

        public void RemovePokemon(string pokemonName)
        {
            var pokemonExists = _cartContents.ContainsKey(pokemonName);
            if(pokemonExists)
            {
                var pokemonCount = _cartContents[pokemonName];
                if(pokemonCount == 1)
                {
                    _cartContents.Remove(pokemonName);
                }
                else
                {
                    _cartContents[pokemonName] = pokemonCount - 1;
                }
            }
        }

        public void RemovePokemon(List<string> pokemon)
        {
            foreach (var pokemonName in pokemon)
            {
                RemovePokemon(pokemonName);
            }
        }
    }
}