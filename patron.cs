using System;
namespace herenciaYPolimorfismo
{
  public class Patron : Persona
	{
		public string empresa;
		public string años;
		
		public Patron ()
		{
		}
		
		public void nombraAsistencia(){
			Console.WriteLine("El patron  de la empresa" + this.empresa+" y nombre " + this.nombre +" nombra asistencia " + ".");
			Console.WriteLine();
		}
		
		public override void cumpleaños(){
			this.edad++;
			Console.WriteLine("Método cumpleaños de la clase Patron.");
			Console.WriteLine();
		}
		
		public override String informacion(){
			return "Información del patron \n" +
				"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"empresa :" + this.empresa + "\n" +
					"años :" + this.años + "\n";
		}
	}
}
