using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public partial class Preguntas
    {
        private int id;
        private string Quest;
        private string resp1;
        private string resp2;
        private string resp3;
        private string resp4;
        private string correctoE;
        private string correctoM;
        private string correctoG;
        private string correctoH;
        private string totalT;


        public new int Id { get { return id; } set { id = value; } }
        public string Quest_ { get { return Quest; } set { Quest = value; } }
        public string resp1_ { get { return resp1; } set { resp1 = value; } }
        public string resp2_ { get { return resp2; } set { resp2 = value; } }
        public string resp3_ { get { return resp3; } set { resp3 = value; } }
        public string resp4_ { get { return resp4; } set { resp4 = value; } }
        public string CorrectoE { get { return correctoE; } set { correctoE = value; } }
        public string CorrectoM { get { return correctoM; } set { correctoM = value; } }
        public string CorrectoG { get { return correctoG; } set { correctoG = value; } }
        public string CorrectoH { get { return correctoH; } set { correctoH = value; } }
        public string TotalT { get { return totalT; } set { totalT = value; } }
        

        public Preguntas(string[] args) { }
        public Preguntas setting_pregunta(Preguntas quest) { return quest; }


    }
}
