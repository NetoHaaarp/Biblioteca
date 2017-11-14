using System;

namespace lslslsls
{
	public class Libro
	{
		public string Autor{ get;}
		public string Titulo{ get;}
		public string Editorial{ get;}

		public Libro (string titulo,string autor,string edi)
		{
			Autor = autor;
			Titulo = titulo;
			Editorial = edi;
		}
	}
}

