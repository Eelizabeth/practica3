using System;
namespace herenciaYPolimorfismo
{
  public class Trabajador : Persona
	{
		public string codigo;
		public string Años;
		
		public Trabajador ()
		{
		}
		
		public void asisteatrabajar(){
			Console.WriteLine("El Trabajador con el código " + this.codigo +" y nombre " + this.nombre  +" se encuentra presente.");
			Console.WriteLine();
		}
		
		public override void cumpleaños(){
			this.edad++;
			Console.WriteLine("Método cumpleaños de la clase .");
			Console.WriteLine();
		}
		
		public override String informacion(){
			return "Información del Trabajador \n" +
				"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"Código :" + this.codigo + "\n" +
					"años trabajando :" + this.Años + "\n";
		}
	}
}


