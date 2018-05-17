using System;

namespace Aula10 {
    public abstract class ItemWithKarma : IHasKarma {
        private static Random rnd = new Random();
        public virtual float Karma { get; private set; }

        public ItemWithKarma() {
            Karma = (float)rnd.NextDouble() * 20 - 10;
        }

        public ItemWithKarma(float karma) {
            Karma = karma;
        }
    }
}
