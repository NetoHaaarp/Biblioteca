using System;
using System.Collections.Generic;

namespace lslslsls
{
	public class Biblioteca
	{
		public string Nombre{ get;}
		public Biblioteca (string nom)
		{
			Nombre = nom;
		}
		private List<Libro> libros = new List<Libro>();

		public void Agregar(string titulo,string autor, string editorial)
		{
			Libro lib = new Libro (titulo,autor,editorial);
			libros.Add (lib);
			
		}

		public void Mostrar()
		{
			foreach (Libro item in libros) 
			{
				Console.WriteLine ($"{item.Autor}, {item.Titulo}, {item.Editorial}");

			}

		}

		private void Mostrar(int indice)
		{
			Console.WriteLine ($"{libros[indice].Autor}, {libros[indice].Titulo}, {libros[indice].Editorial}");
		}

		public void Consultar(string nombre)
		{
			bool existe = false;

			for (int i = 0; i < libros.Count; i++)
			{
				if (libros [i].Titulo == nombre)
				{
					Console.WriteLine ("libro en existencia");
					Mostrar (i);
					existe = true;
				}
				
			}
			if(!existe)
				Console.WriteLine ("el libro no esta en existencia");
		}


	}
}

