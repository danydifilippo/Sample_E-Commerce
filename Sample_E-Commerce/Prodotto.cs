using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_E_Commerce
{
    public class Prodotto
    {
        public int Id { get; set; }
        public string NomeProdotto { get; set; }
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        public static List<Prodotto> GetProdotto()
        {
            List<Prodotto> listaprodotti = new List<Prodotto>();

            Prodotto articolo1 = new Prodotto { Id = 1, NomeProdotto = "Impermeabile England-Flag", Immagine = "img/Imp1.png", Descrizione = "Impermeabile per cani modello bandiera inglese, con cinturino adattabile a tutte le misure", Prezzo = 50 };
            Prodotto articolo2 = new Prodotto { Id = 2, NomeProdotto = "Impermeabile Earl-Gray", Immagine = "img/Imp2.png", Descrizione = "Impermeabile elegante per cani, con cinturino adattabile a tutte le misure e colletto antifreddo", Prezzo = 65 };
            Prodotto articolo3 = new Prodotto { Id = 3, NomeProdotto = "Collare Cloud", Immagine = "img/Coll1.png", Descrizione = "Collare per cani modello Cloud in cuoio grigio intrecciato", Prezzo = 37 };
            Prodotto articolo4 = new Prodotto { Id = 4, NomeProdotto = "Collare Pluto", Immagine = "img/Coll2.jpg", Descrizione = "Collare per cani Pluto, modello classico in cuoio", Prezzo = 30 };
            Prodotto articolo5 = new Prodotto { Id = 5, NomeProdotto = "Cuccetta Hunting Peaky", Immagine = "img/Cuccia1.png", Descrizione = "Cuccetta per cani Hunting Peaky, modello Memory-Foam, stile intrecciato, colore grigio-chiaro, misure 60x60", Prezzo = 80 };
            Prodotto articolo6 = new Prodotto { Id = 6, NomeProdotto = "Cuccetta Winter Haze", Immagine = "img/Cuccia2.png", Descrizione = "Cuccetta per cani Winter Haze, modello Memory-Foam, stile impellicciato, colore grigio-chiaro, misure 60x60", Prezzo = 50 };
            Prodotto articolo7 = new Prodotto { Id = 7, NomeProdotto = "Cuccetta Blue Navy", Immagine = "img/Cuccia3.jpg", Descrizione = "Cuccetta per cani Blue Shade, modello Memory-Foam, stile classico, colore blu, misure 60x60", Prezzo = 23 };
            Prodotto articolo8 = new Prodotto { Id = 8, NomeProdotto = "Tappettino CadetBlue", Immagine = "img/tappeto.jpg", Descrizione = "Tappetino stile CadetBlue, antiodore, lavabile in lavatrice", Prezzo = 50 };
            Prodotto articolo9 = new Prodotto { Id = 9, NomeProdotto = "Ciotola DogPrint", Immagine = "img/Ciot2.jpg", Descrizione = "Ciotola per cani, modello French Bulldog", Prezzo = 25 };

            listaprodotti.Add(articolo1);
            listaprodotti.Add(articolo2);
            listaprodotti.Add(articolo3);
            listaprodotti.Add(articolo4);
            listaprodotti.Add(articolo5);
            listaprodotti.Add(articolo6);
            listaprodotti.Add(articolo7);
            listaprodotti.Add(articolo8);
            listaprodotti.Add(articolo9);
            return listaprodotti;
        }

    }
}