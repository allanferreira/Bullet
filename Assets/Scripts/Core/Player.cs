using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet.Core
{
    public class Player : ScriptableObject
    {
        private int _coins;
        private int _rubies;
        public int Coins => _coins;
        public int Rubies => _rubies;
        public Hero Hero {get; set;}

        public void AddCoins(int coins)
        {
            // nao deve ser possivel adicionar 0 moedas
            if(coins == 0) return;

            _coins += coins;
        }

        public void RemoveCoins(int coins)
        {
            // nao deve ser possivel adicionar 0 moedas
            if(coins == 0) return;

            // nao deve ser possivel remover mais moedas do que o total do jogador
            if(_coins < coins) return;

            _coins -= coins;
        }

        public void AddRubies(int rubies)
        {
            // nao deve ser possivel adicionar 0 moedas
            if(rubies == 0) return;

            _rubies += rubies;
        }

        public void RemoveRubies(int rubies)
        {
            // nao deve ser possivel adicionar 0 moedas
            if(rubies == 0) return;

            // nao deve ser possivel remover mais moedas do que o total do jogador
            if(_rubies < rubies) return;

            _rubies -= rubies;
        }  
    }
}