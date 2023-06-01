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
    public partial class Geografia : ContentPage
    {
        public Geografia()
        {
            InitializeComponent();
        }
        async void Re(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private static List<Preguntas> listapreguntas = new List<Preguntas>
        {

            new Preguntas
            {
                Id = 1,
                Quest_ = "¿Cuál es el río más largo de la Península de Ibérica?",
                resp1_ = "El río Tajo",
                resp2_ = "Elrío Miño",
                resp3_ = "El  río Guadiana",
                resp4_ = "Elrío Ebro",
                CorrectoG = "El río Tajo",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "¿Cuál es el país más pequeño del mundo?",
                resp1_ = "Vaticano",
                resp2_ = "Japón",
                resp3_ = "México",
                resp4_= "Rusia",
                CorrectoG = "Vaticano",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "¿Cuántos océanos hay en la Tierra?",
                resp1_= "9",
                resp2_ = "7",
                resp3_ = "8",
                resp4_ = "5",
                CorrectoG = "5",

            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "¿Cuál es el País más grande del mundo?",
                resp1_ = "Rusia",
                resp2_ = "China",
                resp3_ = "Alemania",
                resp4_ = "México",
                CorrectoG = "Rusia",
            },
            new Preguntas
            {
                Id = 5,
                Quest_ = "¿Cuántos estados forman parte de Estados Unidos?",
                resp1_ = "50",
                resp2_ = "135",
                resp3_ = "25",
                resp4_ = "65",
                CorrectoG = "50",
            }
        };
        int point = 1, score = 0;
        string RespuestaCorrectaG;


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
                RespuestaCorrectaG = list.CorrectoG;
            }
            catch (Exception)
            {

            }
            return RespuestaCorrectaG;
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrectaG)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrectaG)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrectaG)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrectaG)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            

        } 
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + "/ 4 puntos.", "OK");
        }
    }
}