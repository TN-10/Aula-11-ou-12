namespace Aula10 {
    /// <summary>Esta classe representa um jogador num jogo</summary>
    public class Player : IHasWeight, IHasKarma {

        /// <summary>Máximo de items na mochila (variável de classe, constante, implicitamente static)</summary>
        private const int maxBagItems = 6;

        /// <summary>Peso base do jogador (variável de instância, read-only) </summary>
        private readonly float baseWeight;

        /// <summary>Mochila de itens do jogador (variável de instância)</summary>
        public Bag BagOfStuff { get; }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight {
            get {
                // Seria porreiro adicionar o peso de todas as coisas no saco
                return baseWeight + BagOfStuff.Weight;
            }
        }

        public float Karma {
            get {
                return BagOfStuff.Karma;
            }
        }

        /// <summary>Construtor, cria nova instância de jogador</summary>
        /// <param name="baseWeight">Peso base do jogador</param>
        public Player(float baseWeight) {
            this.baseWeight = baseWeight;
            BagOfStuff = new Bag(maxBagItems);
        }

        public override string ToString() {
            return "Peso total: " + $"{Weight:f2} kg" + "\nNº Items: " + 
                $"{BagOfStuff.Count:f2} kg" +
                "\nPercentagem do peso que corresponde à mochila: " +
                $"{BagOfStuff.Weight / Weight:p1}" + "\nKarma: " + 
                $"{Karma:f2}";
        }
    }
}
