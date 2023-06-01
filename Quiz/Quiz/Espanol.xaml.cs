using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Espanol : ContentPage
    {

        private static List<Preguntas> listapreguntas = new List<Preguntas>
        {
            
            new Preguntas
            {
                Id = 1,
                Quest_ = "¿Quién es el autor de la frase `Pienso, luego existo`",
                resp1_ = "Platon",
                resp2_ = "Galileo Galilei",
                resp3_ = "Descartes",
                resp4_ = "Sócrates",
                CorrectoE = "Descartes",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "¿Cuál es el grupo de palabras escritas correctamente?",
                resp1_ = "Metamorfosis, extranjero, diversidac, equilivrio",
                resp2_ = "Metamorfosis, extranjero, diversidad, equilibrio",
                resp3_ = "Metamorfosis, extrangero, dibersidad, equilibrio",
                resp4_= "Metamórfosis, eztranjero, divérsidad, ecuilibrio",
                CorrectoE = "Metamorfosis, extranjero, diversidad, equilibrio",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "¿Cuáles son los representantes más destacados de la literatura renacentista?",
                resp1_= "orge Isaac, José Martí, Eduardo Blanco",
                resp2_ = "Leonardo da Vinci, Miguel Angel Buonarroti, Sandro Boticelli",
                resp3_ = "Miguel de Cervantes, William Shakespeare, Luis de Camões.",
                resp4_ = "orge Isaac, José Martí, Eduardo Blanco",
                CorrectoE = "Miguel de Cervantes, William Shakespeare, Luis de Camões.",

            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "¿A quién se le atribuye la frase `Solo sé que no sé nada`?",
                resp1_ = "Sófocles",
                resp2_ = "Salomón",
                resp3_ = "Nietszche",
                resp4_ = "Aristóteles",
                CorrectoE = "Sócrates",
            },
            new Preguntas
            {
                Id = 5,
                Quest_ = "Identifica el enunciado en el que la función de la lengua es poética.",
                resp1_ = "Chopin soñó que estaba muerto en el lago.",
                resp2_ = "Era apenas una niña cuando la vi por primera vez.",
                resp3_ = "A las tres en punto moriría un transeúnte",
                resp4_ = "Las nieves del tiempo platearon mi sien.",
                CorrectoE = "Las nieves del tiempo platearon mi sien.",
            }
        };
        int point = 1, score = 0;
        string RespuestaCorrectaE;
        

        public Espanol()
        {
            InitializeComponent();
        }
        async void Re(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
        public object btnPuntuacion { get; private set; }
        public static List<Preguntas> Listapreguntas { get => listapreguntas; set => listapreguntas = value; }
        public static List<Preguntas> Listapreguntas1 { get => listapreguntas; set => listapreguntas = value; }

        protected void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        private string SetPregunta(int ID)
        {

            Preguntas list = Listapreguntas.Where(a => a.Id == ID).SingleOrDefault();

            try
            {
                lblPregunta.Text = list.Quest_;
                btnresp1.Text = list.resp1_;
                btnresp2.Text = list.resp2_;
                btnresp3.Text = list.resp3_;
                btnresp4.Text = list.resp4_;
                RespuestaCorrectaE = list.CorrectoE;
            }
            catch (Exception)
            {

            }
            return RespuestaCorrectaE;
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrectaE)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrectaE)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrectaE)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrectaE)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btnpuntuacion.IsVisible = true;

        }
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + "/ 5 puntos.", "OK");
        }
    }
}