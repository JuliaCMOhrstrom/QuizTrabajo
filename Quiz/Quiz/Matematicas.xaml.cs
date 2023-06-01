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
    public partial class Matematicas : ContentPage
    {
        public Matematicas()
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
                Quest_ = "¿Cuál es la representación del número nueve mil treinta y seis?",
                resp1_ = "90036",
                resp2_ = "936",
                resp3_ = "900036",
                resp4_ = "9036",
                CorrectoM = "9036",
            },
           new Preguntas
            {
                Id = 2,
                Quest_ = "¿Si en una carrera vas tres puestos por detrás del vigésimo segundo," +
                " ¿En qué puesto vas??",
                resp1_ = "Decimonoveno",
                resp2_ = "Decimotercero",
                resp3_ = "Decimo",
                resp4_= "Noveno",
                CorrectoG = "Dcimonoveno",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "¿Qué número resulta si divides 56 entre 7?",
                resp1_= "9",
                resp2_ = "7",
                resp3_ = "8",
                resp4_ = "6",
                CorrectoG = "8",

            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "¿Qué cantidad expresa el número romano V?",
                resp1_ = "Diez",
                resp2_ = "Cinco",
                resp3_ = "Uno",
                resp4_ = "Cien",
                CorrectoG = "Cinco",
            },
            new Preguntas
            {
                Id = 5,
                Quest_ = "¿Cuál es el número trigésimo quinto?",
                resp1_ = "35",
                resp2_ = "135",
                resp3_ = "25",
                resp4_ = "65",
                CorrectoG = "35",
            }
        };
        int point = 1, score = 0;
        string RespuestaCorrectaM;

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
                RespuestaCorrectaM = list.CorrectoM;
            }
            catch (Exception)
            {

            }
            return RespuestaCorrectaM;
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrectaM)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrectaM)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrectaM)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrectaM)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
        private void Button5_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrectaM)
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