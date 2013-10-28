
using System;
using System.Collections;

namespace practica_3
{
	
	       public class Captura
	{
		   public Hashtable tablita;
		   public Captura(){
			
		   this.tablita = new Hashtable();
		}
		    public void Capturar()
		{
		    for (int a=0; a<4; a++){
		    Console.Clear();
		    		
		    variables p = new variables();
			
			Console.WriteLine("Introduzca su codigo: ");
			p.codigo=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su nombre: ");
		    p.nom=Console.ReadLine();
			Console.WriteLine("Introduzca su telefono: ");
			p.tel=int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca su facebook:");
			p.face=Console.ReadLine();
			this.tablita.Add(p.codigo,p);
			System.Console.Clear();
			}
		    }
			
			public void Edit(){
			for(int b=0; b<2; b++){
		    variables ed = new variables();	
		    Console.WriteLine("Codigo para Editar:");
		    ed.codigo=int.Parse(Console.ReadLine());  
		    if(!tablita.ContainsKey(ed.codigo)){
            Console.WriteLine("El codigo no existe");
                 }
		   else{
            ed=(variables)(this.tablita[ed.codigo]);
			Console.WriteLine(" Nombre ");
			Console.WriteLine(ed.nom);
			Console.WriteLine(" Telefono ");
			Console.WriteLine(ed.tel); 
			Console.WriteLine(" Facebook ");
			Console.WriteLine(ed.face);
					
		    Console.WriteLine("Editar Informacion: ");
	        Console.WriteLine("Nombre "); 
	        ed.nom=Console.ReadLine();
		    Console.WriteLine("Telefono ");
	        ed.tel=int.Parse(Console.ReadLine());
	        Console.WriteLine("Facbook ");
	        ed.face=Console.ReadLine();
	        System.Console.Clear();
		    
			System.Console.Clear();
		    	}
		    	
		    }
		    }
	       
			 public void Elimina(){
			 for (int c=0; c<2; c++){
		    		variables elim = new variables();
		    Console.Write("Ingrese el codigo  a Eliminar: ");
		    elim.codigo=int.Parse(Console.ReadLine());
			if(!tablita.ContainsKey(elim.codigo)) {
			
			Console.WriteLine("no existe el codigo");
                 }
                 else{
                 elim=(variables)(this.tablita[elim.codigo]);

	    	Console.Write (" Nombre");
     		Console.WriteLine (elim.nom);	
			Console.Write (" Telefono");
			Console.WriteLine (elim.tel);
			Console.Write (" Facebook");
			Console.WriteLine (elim.face);

			Console.Write ("¿Decea eliminar? Si=1 /No=0  ");
			string op =Console.ReadLine();
						if (op == "s") 
						{
		   
		    Console.WriteLine("La persona se elimino ");
			Console.Clear ();
						}
						else
							Console.WriteLine("Nose elimino");
		    
		    Console.Clear();
					}
				}
		    }
    
			public void Muestra(){
				
			Console.WriteLine("Muestra Informacion: ");
			Console.WriteLine();
			IDictionaryEnumerator en=tablita.GetEnumerator();
			while(en.MoveNext()){
			variables mostrar=(variables)(tablita[en.Key]);
						
            Console.WriteLine(" Codigo ");
			Console.WriteLine(mostrar.codigo);					
			Console.WriteLine(" Nombre ");
			Console.WriteLine(mostrar.nom);
			Console.WriteLine(" Telefono ");
			Console.WriteLine(mostrar.tel);	 
			Console.WriteLine(" Facebook ");
			Console.WriteLine(mostrar.face);
				}
			    }
			public void inicia(){
			this.Capturar();			
			this.Edit();
			this.Elimina();
			this.Muestra();
		
			}
	       }

	       }
		    