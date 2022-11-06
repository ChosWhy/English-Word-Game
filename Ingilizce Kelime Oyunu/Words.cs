using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingilizce_Kelime_Oyunu
{
    internal class Words
    {
        public class BasicWords
        {
            int randomNumber;
            List<LevelOfWords.LevelBasicWords> question = new List<LevelOfWords.LevelBasicWords>()
            {
                new LevelOfWords.LevelBasicWords() {word = "About",meaning = "Hakkında",answerOne = "Yukarısında",answerTwo = "Sonra",answerThree = "Korkmuş" },
                new LevelOfWords.LevelBasicWords() {word = "Above",meaning = "Yukarısında",answerOne = "Yetişkin",answerTwo = "Tekrar",answerThree = "Yaş"},
                new LevelOfWords.LevelBasicWords() {word = "Always",meaning = "Her zaman", answerOne = "Yanıt Vermek",answerTwo = "Hiç",answerThree = "Sık sık"},
                new LevelOfWords.LevelBasicWords() {word = "Band",meaning = "Müzik grubu",answerOne = "Geri",answerTwo = "Plaj",answerThree = "Küvet"},
                new LevelOfWords.LevelBasicWords() {word = "Begin",meaning = "Başlamak",answerOne = "Bitirmek",answerTwo = "Söylemek",answerThree = "Anlatmak"},
                new LevelOfWords.LevelBasicWords() {word = "Boat",meaning = "Tekne",answerOne = "Gemi",answerTwo = "Bot",answerThree = "Vapur"},
                new LevelOfWords.LevelBasicWords() {word = "Business",meaning = "İşletme",answerOne = "Para",answerTwo = "Meşgul",answerThree = "Çalışmak"},
                new LevelOfWords.LevelBasicWords() {word = "Carry",meaning = "Taşımak",answerOne = "İttirmek",answerTwo = "Yapmak",answerThree = "Anlatmak"},
                new LevelOfWords.LevelBasicWords() {word = "Catch",meaning = "Yakalamak",answerOne = "Fırlatmak",answerTwo = "Atamak",answerThree = "Gerilmek"},
                new LevelOfWords.LevelBasicWords() {word = "Chocolate",meaning = "Çikolata",answerOne = "Karamel",answerTwo = "Tatlı",answerThree = "Elma"},
                new LevelOfWords.LevelBasicWords() {word = "Closed",meaning = "Kapalı",answerOne = "Kapatmak",answerTwo = "Kapı",answerThree = "Kapıya"},
                new LevelOfWords.LevelBasicWords() {word = "Come",meaning = "Gelmek",answerOne = "Gitmek",answerTwo = "Getirmek",answerThree = "Germek"},
                new LevelOfWords.LevelBasicWords() {word = "Computer",meaning = "Bilgisayar",answerOne = "Laptop",answerTwo = "Tablet",answerThree = "Mause"},
                new LevelOfWords.LevelBasicWords() {word = "Cow",meaning = "İnek",answerOne = "Keçi",answerTwo = "Tavuk",answerThree = "Martı"},
                new LevelOfWords.LevelBasicWords() {word = "Conversation",meaning = "Sohbet",answerOne = "Anlatmak",answerTwo = "Söylemek",answerThree = "Bakmak"},
                new LevelOfWords.LevelBasicWords() {word = "Daughter",meaning = "Kız Evlat",answerOne = "Oğlan",answerTwo = "Hala",answerThree = "bebek"},
                new LevelOfWords.LevelBasicWords() {word = "Die",meaning = "Ölmek",answerOne = "Bitirmek",answerTwo = "Gelmek",answerThree = "Gitmek"},
                new LevelOfWords.LevelBasicWords() {word = "Different",meaning = "Farklı",answerOne = "İlginç",answerTwo = "Tuhaf",answerThree = "Aynı"},
                new LevelOfWords.LevelBasicWords() {word = "Do",meaning = "Yapmak",answerOne = "Söylemek",answerTwo = "Vurmak",answerThree = "Susturmak"},
                new LevelOfWords.LevelBasicWords() {word = "Dog",meaning = "Köpek",answerOne = "Kedi",answerTwo = "Kuş",answerThree = "Ayı"},
                new LevelOfWords.LevelBasicWords() {word = "Ear",meaning = "Kulak",answerOne = "Vücud",answerTwo = "Kafa",answerThree = "Bacak"},
                new LevelOfWords.LevelBasicWords() {word = "End",meaning = "Son",answerOne = "Sonunda",answerTwo = "Sonlanan",answerThree = "Sarmak"},
                new LevelOfWords.LevelBasicWords() {word = "Famous",meaning = "Ünlü",answerOne = "Yayıncı",answerTwo = "Şarkıcı",answerThree = "Haberci"},
                new LevelOfWords.LevelBasicWords() {word = "Favotite",meaning = "Favori",answerOne = "Sevmek",answerTwo = "En iyisi",answerThree = "İğrenç"},
                new LevelOfWords.LevelBasicWords() {word = "Fine",meaning = "İyi",answerOne = "Güzel",answerTwo = "Peki",answerThree = "Kötü"},
                new LevelOfWords.LevelBasicWords() {word = "Flower",meaning = "Çiçek",answerOne = "Papatya",answerTwo = "Ağaç",answerThree = "Ot"},
                new LevelOfWords.LevelBasicWords() {word = "Friday",meaning = "Cuma",answerOne = "Cumartesi",answerTwo = "Çarşamba",answerThree = "Perşembe"},
                new LevelOfWords.LevelBasicWords() {word = "Game",meaning = "Oyun",answerOne = "Oynamak",answerTwo = "Bakmak",answerThree = "Yürütmek"},
                new LevelOfWords.LevelBasicWords() {word = "Give",meaning = "Vermek",answerOne = "Etmek",answerTwo = "El Atmak",answerThree = "Silmek"},
                new LevelOfWords.LevelBasicWords() {word = "Grass",meaning = "Çim",answerOne = "Toprak",answerTwo = "Kaya Parçası",answerThree = "Çamur"},
                new LevelOfWords.LevelBasicWords() {word = "Holiday",meaning = "Tatil",answerOne = "Kutlamak",answerTwo = "PLaj",answerThree = "Keyif"},
                new LevelOfWords.LevelBasicWords() {word = "Heart",meaning = "Kalp",answerOne = "Akciğer",answerTwo = "Mide",answerThree = "Bağırsak"},
                new LevelOfWords.LevelBasicWords() {word = "Husband",meaning = "Eş",answerOne = "Kadın",answerTwo = "Erkek",answerThree = "Amca"},
                new LevelOfWords.LevelBasicWords() {word = "İmportant",meaning = "Önemli",answerOne = "Bilgi",answerTwo = "Konu",answerThree = "Önemsemek"},
                new LevelOfWords.LevelBasicWords() {word = "İnside",meaning = "İç Taraf",answerOne = "İçerde",answerTwo = "İçi",answerThree = "İçine"},
                new LevelOfWords.LevelBasicWords() {word = "Juice",meaning = "Meyve Suyu",answerOne = "Çay",answerTwo = "Soguk Çay",answerThree = "Sebze"},
                new LevelOfWords.LevelBasicWords() {word = "Kick",meaning = "Tekmelemek",answerOne = "Fırlatmak",answerTwo = "Yumruk Atmak",answerThree = "Vurmak"},
                new LevelOfWords.LevelBasicWords() {word = "Kind",meaning = "Tür",answerOne = "Cins",answerTwo = "Aile",answerThree = "Habitat"},
                new LevelOfWords.LevelBasicWords() {word = "Language",meaning = "Dil",answerOne = "Konusmak",answerTwo = "Yabancı",answerThree = "Aksan"},
                new LevelOfWords.LevelBasicWords() {word = "Late",meaning = "Geçikmek",answerOne = "Sonra",answerTwo = "Önce",answerThree = "Şu an"},
                new LevelOfWords.LevelBasicWords() {word = "Letter",meaning = "Mektup",answerOne = "Kağıt",answerTwo = "Şiir",answerThree = "Hikaye"},
                new LevelOfWords.LevelBasicWords() {word = "Light",meaning = "Hafif",answerOne = "Ağır",answerTwo = "Yukarı",answerThree = "Süzülmek"},
                new LevelOfWords.LevelBasicWords() {word = "Little",meaning = "Küçük",answerOne = "Büyük",answerTwo = "Ortanca",answerThree = "Biraz"},
                new LevelOfWords.LevelBasicWords() {word = "Love",meaning = "Sevmek",answerOne = "Kalp",answerTwo = "Değerli",answerThree = "İyi Hissetmek"},
                new LevelOfWords.LevelBasicWords() {word = "Many",meaning = "Birçok",answerOne = "Bir",answerTwo = "Biraz",answerThree = "Azıcık"},
                new LevelOfWords.LevelBasicWords() {word = "Me",meaning = "Ben",answerOne = "Sen",answerTwo = "O",answerThree = "Bizler"},
                new LevelOfWords.LevelBasicWords() {word = "Meet",meaning = "Karşılaşmak",answerOne = "Bulmak",answerTwo = "Göze Gelmek",answerThree = "Bakışmak"},
                new LevelOfWords.LevelBasicWords() {word = "Minute",meaning = "Dakika",answerOne = "Zaman",answerTwo = "Geçmek",answerThree = "Saniye"},
                new LevelOfWords.LevelBasicWords() {word = "More",meaning = "Daha çok",answerOne = "Daha",answerTwo = "Az",answerThree = "Fazla"},
                new LevelOfWords.LevelBasicWords() {word = "Mouth",meaning = "Ağız",answerOne = "Dağ",answerTwo = "Boşluk",answerThree = "Burun"},
            };
            public object ReturnOfListDataCount()
            {
                return question.Count;
            }
            public void RemoveAtItem()
            {
                question.RemoveAt(randomNumber);
            }
            public void RandomQuestionBuilder()
            {
                Random rnd = new Random();
                randomNumber = rnd.Next(0, question.Count);
            }
            public String SetToWordValue()
            {
                return question[randomNumber].word;
            }
            public String SetToMeaningValue()
            {
                return question[randomNumber].meaning;
            }
            public String SetAnsweroneValue()
            {
                return question[randomNumber].answerOne;
            }
            public String SetAnswerotwoValue()
            {
                return question[randomNumber].answerTwo;
            }
            public String SetAnswerthreeValue()
            {
                return question[randomNumber].answerThree;
            }
        }
    }
}

