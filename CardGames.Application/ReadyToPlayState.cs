﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Application
{
    public class ReadyToPlayState : IBlackjackCardGameState
    {
        public void NoMoreRounds(BlackjackGame game)
        {
            throw new NotImplementedException();
        }

        public void AnalyzeHands(BlackjackGame game)
        {
            throw new NotImplementedException();
        }

        public void Ante(BlackjackGame game)
        {
            throw new NotImplementedException();
        }

        public void BeginGame(BlackjackGame game)
        {
            throw new NotImplementedException();
        }

        public void BeginPlay(BlackjackGame game)
        {
            game.ShuffleCards();
            game.State = BlackjackGame.CardsShuffledState;
        }

        public void DealRound(BlackjackGame game)
        {
            throw new NotImplementedException();
        }

        public void RequestCards(BlackjackGame game)
        {
            throw new NotImplementedException();
        }
    }
}
