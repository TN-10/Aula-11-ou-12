using System;
using System.Collections.Generic;

namespace Aula10 {
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : List<IStuff>, IStuff, IHasKarma {



        public float Value {
            get {
                float value = 0;

                foreach (IStuff i in this) {
                    value += i.Value;
                }

                return value;
            }
        }

        public float Weight {
            get {
                float weight = 0;

                foreach (IStuff i in this) {
                    weight += i.Weight;
                }

                return weight;
            }
        }

        public float Karma {
            get {
                float total = 0;
                int cont = 0;

                foreach (IStuff i in this) {

                    if (i is IHasKarma) {
                        total += (i as IHasKarma).Karma;
                        cont++;
                    }
                }

                return total / cont;
            }
        }


        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar
        /// na mochila</param>
        public Bag(int bagSize) : base(bagSize) {

        }

        public override string ToString() {
            return "Nº de items: " + Count + "\nValor total: " + Value +
                "\nPeso total: " + Weight + "\nKarma: " +
                $"{Karma:f2}";
        }
        // NAO E STATIC, DEPENDE DO QUE O BAG TEM. 
        //Estavamos a passar a lista de coisas do Bag para o proprio bag.
        //Se estivessemos no program, por exemplo, aí sim, metíamos "Bag" dentro
        //dos (), ou seja, o sitio onde procurar.
        public bool ContainsItemOfType<T>()
        {
            //Estamos a percorrer as cenas dentro da Bag, daí "this"
            foreach (IStuff i in this)

            {

                if (i is T) return true;

            }

            return false;
        }

        public IEnumerable<T> GetItemsOfType<T>()
                              where T: class, IStuff
        {
            List<T> lst = new List<T>();
            foreach(IStuff i in this)
            {
                if (i is T)
                {
                    lst.Add (i as T);

                }
               
            }
            return lst;
        }
        public IEnumerable<T> BetterGetItemsOfType<T>()
                              where T: IStuff
        {
            foreach (IStuff i in this)
            {
                if (i is T)
                {
                    //Estamos a converter i em T. 
                    yield return (T)i;
                }
            }
        }
    }

            

    }
