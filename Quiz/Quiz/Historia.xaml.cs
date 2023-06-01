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
    public partial class Historia : ContentPage
    {
        public Historia()
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
                Quest_ = "¿Cuándo comienza la primera guerra mundial?",
                resp1_ = "1945",
                resp2_ = "1914",
                resp3_ = "1950",
                resp4_ = "1925",
                CorrectoH = "1914",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "¿Cuál es la civilización más antigua del mundo?",
                resp1_ = "mesopotamia",
                resp2_ = "El imperio Jemer",
                resp3_ = "El imperio Aqueménida",
                resp4_= "Los fenicios",
                CorrectoH = "mesopotamia",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "¿De qué país se originó la civilización azteca?",
                resp1_= "China",
                resp2_ = "Japón",
                resp3_ = "México",
                resp4_ = "Estados Unidos",
                CorrectoH = "México",

            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "¿Cuándo sucedió el Holocausto, uno de los eventos más terribles de la historia?",
                resp1_ = "Durante la conquista",
                resp2_ = "Durante la Revolución",
                resp3_ = "Durante la Primera Guerra Mundial",
                resp4_ = "Durante la Segunda Guerra Mundial",
                CorrectoH = "Durante la Segunda Guerra Mundial",
            },
            new Preguntas
            {
                Id = 5,
                Quest_ = "¿Cuándo fue derribado el muro de Berlín?",
                resp1_ = "1991",
                resp2_ = "1989",
                resp3_ = "1990",
                resp4_ = "1980",
                CorrectoH = "1989",
            }
        };
        int point = 1, score = 0;
        string RespuestaCorrectaH;
              
        public object btnpuntuacion { get; private set; }
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
                RespuestaCorrectaH = list.CorrectoH;
            }
            catch (Exception)
            {

            }
            return RespuestaCorrectaH;
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrectaH)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrectaH)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrectaH)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrectaH)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            

        }
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + "/ 5 puntos.", "OK");
        }
    }
}