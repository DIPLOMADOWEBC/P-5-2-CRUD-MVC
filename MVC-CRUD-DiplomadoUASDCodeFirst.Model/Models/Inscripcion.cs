﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models
{
    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        public int Semestre { get; set; }
        public virtual Posicion Curso { get; set; }
        public virtual Empleado Estudiante { get; set; }
    }
}
