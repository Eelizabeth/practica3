using System;

namespace herenciaYPolimorfismo
{
  class Principal
	{
		public void Trabajador(){
			Trabajador trabajador= new Trabajador();
			trabajador.nombre = "Felipe Izquierdo";
			trabajador.edad = 28;
			trabajador.codigo = "3443423";
			trabajador.Años = "3";
			trabajador.asisteatrabajar();
			trabajador.cumpleaños();
			
			//Polimorfismo	
			Persona persona = trabajador;
			persona.cumpleaños();
			Console.WriteLine(persona.informacion());
			
		}
		
		public void patron(){
			Patron patron = new Patron();
			patron.nombre = "Mario Rodriguez";
			patron.edad = 30;
			patron.empresa = "3443423";
			patron.años = "Bases de datos";
			patron.nombraAsistencia();
			patron.cumpleaños();
			
			//Polimorfismo	
			Persona persona = patron;
			persona.cumpleaños();
			Console.WriteLine(persona.informacion());
		}
		
		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			programa.Trabajador();
			programa.patron();
			
		}
	}
}
