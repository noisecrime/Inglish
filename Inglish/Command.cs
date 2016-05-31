using System.Collections.Generic;

namespace Inglish
{
    public class Command
    {
        public Command()
        {
            Objects = new List<TokenObject>();
            Subjects = new List<TokenObject>();
            NpcTokens = new List<Token>();
            Adverbs = new List<Token>();
        }

        public IList<Token> Adverbs { get; private set; }
        public Token Verb { get; set; }
        public string Preposition { get; set; }
        public IList<TokenObject> Subjects { get; private set; }
        public IList<TokenObject> Objects { get; private set; }
        public IList<Token> NpcTokens { get; private set; }
    }
}