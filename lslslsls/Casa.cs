using System;

namespace lslslsls
{
	public class Casa
	{
		public string nombre{ get; set;}
		public string cuarto{ get; set;}
		private string sillones;
		public string fachada;
		public string garage;
		// get -> lectura   set-> escritura
		public Casa(string nombre)
		{
			this.nombre = nombre;
		}
		public Casa()
		{
			
		}
			
	}
}

