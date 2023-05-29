using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Cuestionario : PreguntasBuilder
    {
        public override void Building(Preguntas p)
        {
            QuestionQuiz.setting_pregunta(p);
        }
    }
}
