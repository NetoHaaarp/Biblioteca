using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace lslslsls
{
	class MainClass
	{
		 
		public static void Main (string[] args)
		{
			string tit,aut,edit;
			byte opc =0;

			Console.WriteLine ("inserta nombre de la biblioteca: ");
			Biblioteca biblio = new Biblioteca (Console.ReadLine());

			Console.WriteLine ($"el nombre de la biblioteca es: {biblio.Nombre}");


			do {
				Menu ();
				opc = byte.Parse (Console.ReadLine ());
				switch (opc) {

				case 1:
					Console.WriteLine ("insertar titulo: ");
					tit = Console.ReadLine ();
					Console.WriteLine ("insertar autor: ");
					aut = Console.ReadLine ();
					Console.WriteLine ("insertar editorial: ");
					edit = Console.ReadLine ();
					biblio.Agregar (tit, aut, edit);
					break;

				case 2: 
					Console.WriteLine ("ingresa en nombre del libro a consultar");
					biblio.Consultar (Console.ReadLine ());
					break;

				case 3: 
					biblio.Mostrar ();
					break;

				default:
					Console.WriteLine ("opcion no valida");
					break;

				}

			} while(opc != 0);


		}

		static void Menu()
		{
			Console.WriteLine ("0.- salir");
			Console.WriteLine ("1.- agregar un libro");
			Console.WriteLine ("2.- consultar un libro");
			Console.WriteLine ("3.- mostrar libros");
		}


			
	}
}
