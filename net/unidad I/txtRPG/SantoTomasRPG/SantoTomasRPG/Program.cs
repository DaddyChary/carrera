internal class Program
{
    private static void Main(string[] args)
    {

        string Nombre = string.Empty;
        string Respuesta = string.Empty;
        bool bucle = false;


        do
        {
            int Puntos = 0;
            do
            {

                //"Decoracion"
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                //"Bienvenido ¿desea iniciar el juego?"
                Console.WriteLine("| Bienvenido ¿desea iniciar el juego?                                                 |");
                //"1 Si"
                Console.WriteLine("| 1 Si                                                                                |");
                //"2 Salir
                Console.WriteLine("| 2 Salir                                                                             |");
                //"Ingrese Su Respuesta"
                Console.Write("| Ingrese su respuesta: ");
                Respuesta = Console.ReadLine();
                //Limpiar pantalla
                Console.Clear();
                if (Respuesta == "1" | Respuesta == "2") { break; }
                
            }while (Respuesta != "1" | Respuesta != "2");   


            if (Respuesta == "2")
            {
               Console.WriteLine("+-------------------------------------------------------------------------------------+");
               Console.WriteLine("|                                    Hasta pronto                                     |");
               Console.WriteLine("+-------------------------------------------------------------------------------------+");
               break;
            }

            Console.WriteLine("+-------------------------------------------------------------------------------------+");
            Console.Write("| Empezemos porfavor ingrese su nombre: ");
            Nombre = Console.ReadLine();
            //Si el nombre esta vacio es introducido un nombre automatico
            if (string.IsNullOrEmpty(Nombre))
            {
                Nombre = "Usuario";
            }
            //Limpiar pantalla
            Console.Clear();

            //"Decoracion"
            Console.WriteLine("+-------------------------------------------------------------------------------------+");
            Console.WriteLine("| " + Nombre + " un estudiante de ingeniería en informática del Instituto Santo Tomás, |\n" +
                              "| se enfrenta a diario a desafíos que van más allá de los códigos y los algoritmos.    |\n" +
                              "| Su vida está marcada por decisiones cruciales que pueden llevarlo por                |\n" +
                              "| caminos inesperados, definiendo así su destino en este día                           |\n" +
                              "| lleno de giros impredecibles.                                                        |");
            Console.WriteLine("+-------------------------------------------------------------------------------------+");
            do
            {
  
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| Al despertar, " + Nombre + " se encuentra con el sonido estridente de su alarma,    |\n" +
                                  "| dándose cuenta de su tardanza y la ausencia del autobús escolar.                    |\n" +
                                  "| Ante esta situación, debe decidir rápidamente                                       |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");


                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| 1-. Ejecutar un script para calcular la ruta más rápida hacia la parada del autobús,|\n" +
                                  "|     asumiendo el riesgo de llegar tarde.                                            |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");

                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| 2-. Iniciar sesión en una aplicación de viajes compartidos para solicitar un        |\n" +
                                  "|     vehículo, aunque esto implique sacrificar parte de su presupuesto               |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");

                Console.Write("| Ingrese su respuesta: ");
                Respuesta = Console.ReadLine();
                Console.Clear();
                if (Respuesta == "1" | Respuesta == "2") { break; }
            } while (Respuesta != "1" | Respuesta != "2");
            Console.WriteLine("+-------------------------------------------------------------------------------------+");
            Console.WriteLine("| Una vez en el instituto, "+ Nombre +" se enfrenta a nuevas decisiones                      |");
            Console.WriteLine("+-------------------------------------------------------------------------------------+");

            if (Respuesta == "1")
            {
                Puntos = Puntos + 1;
                do
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Llega tarde a clase y es reprendido por su profesor, lo que desencadena dos opciones|");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 1-. Optimizar su tiempo utilizando técnicas de gestión de proyectos, lo que puede   |\n" +
                                      "|     llevarlo a cometer errores en sus códigos                                       |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 2-. Decidir solicitar ayuda en línea a través de foros de programación y            |\n" +
                                      "|     comunidades de desarrolladores.                                                 |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.Write("| Ingrese su respuesta: ");
                    Respuesta = Console.ReadLine();
                    Console.Clear();

                    if (Respuesta == "1") { Puntos = Puntos + 1; }
                    else { Puntos = Puntos + 3; }

                    if (Respuesta == "1" | Respuesta == "2") { break; }

                } while (Respuesta != "1" | Respuesta != "2");
            }
            else
            {
                Puntos = Puntos + 3;
                do
                {

                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Aunque el autobús llega a tiempo, su amigo lo solicita para un problema personal,   |\n" +
                                      "| forzando a "+Nombre+" a decidir entre ayudar a su amigo o asistir directamente a clase   |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 1-. Opta por ayudar a su amigo, lo que resulta en su llegada tardía a               |\n" +
                                      "|     clase y una posterior sanción                                                   |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 2-. Decide ir directamente a clase, prometiendo asistir a su amigo más tarde        |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.Write("| Ingrese su respuesta: ");
                    Respuesta = Console.ReadLine();
                    Console.Clear();

                    if (Respuesta == "1") { Puntos = Puntos + 3; }
                    else { Puntos = Puntos + 1; }
                    if (Respuesta == "1" | Respuesta == "2") { break; }

                } while (Respuesta != "1" | Respuesta != "2");
            }

            do
            {

                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| Durante el almuerzo, "+Nombre+" recibe una invitación a una fiesta después de clases,    |" +
                                  "| lo que lo enfrenta a dos alternativas                                               |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| 1-. Acepta la invitación, emocionado por la posibilidad de socializar.              |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| 2-. Declina la invitación, optando por concentrarse en sus responsabilidades        |\n" +
                                  "|     académicas                                                                      |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.Write("| Ingrese su respuesta: ");
                Respuesta = Console.ReadLine();
                Console.Clear();

                if (Respuesta == "1" | Respuesta == "2") { break; }

            } while (Respuesta != "1" | Respuesta != "2");

            if (Respuesta == "1")
            {
                Puntos = Puntos + 1;
                do
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 1-. Se queda en la fiesta hasta tarde, lo que lo lleva a perder el último autobús   |\n"+
                                      "|     y a enfrentarse al enojo de sus padres                                          |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 2-. Decide irse temprano de la fiesta, asegurándose de llegar a casa a tiempo       |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.Write("| Ingrese su respuesta: ");
                    Respuesta = Console.ReadLine();
                    Console.Clear();

                    if (Respuesta == "1" | Respuesta == "2") { break; }

                } while (Respuesta != "1" | Respuesta != "2");

                if (Respuesta == "1")
                { 
                    if (Puntos <= 5)
                    {
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| Sus padres están furiosos y lo castigan severamente, lo que lo lleva a replantearse |\n" +
                                          "| sus prioridades y compromisos                                                       |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Puntos = Puntos - 5;
                    }
                    else 
                    { 
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| A pesar de la situación, "+Nombre+" aprende a valorar el tiempo que pasó con sus amigos  |\n" +
                                          "| y decide enfrentar las consecuencias con madurez                                    |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Puntos = Puntos - 1;
                    }
                }
                else
                {
                    if (Puntos >= 6)
                    {
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| Llega a casa sin problemas y se prepara para un nuevo día con más determinación     |\n" +
                                          "| y responsabilidad.                                                                  |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Puntos = Puntos + 5;
                    }
                    else
                    {
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| En el camino de regreso, "+Nombre+" se encuentra con un amigo que necesita ayuda, lo que |\n" +
                                          "| lo lleva a desviarse de su camino y llegar tarde a casa                             |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Puntos = Puntos + - 7;
                    }

                }
            }
            else 
            {
                Puntos = Puntos + 3;
                do
                {

                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Decide que quieres hacer o como sentirte debido a tu desicion anterior              |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 1-. Dedica el tiempo adicional a estudiar y mejora sus habilidades de programación  |"); 
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| 2-. Se siente solo y arrepentido por no socializar, decidiendo buscar proyectos     |\n" +
                                      "|     en línea para colaborar con otros estudiantes de informática.                   |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.Write("| Ingrese su respuesta: ");
                    Respuesta = Console.ReadLine();
                    Console.Clear();

                    if (Respuesta == "1" | Respuesta == "2") { break; }

                } while (Respuesta != "1" | Respuesta != "2");

                if (Respuesta == "1")
                {
                    if (Puntos >= 10)
                    {
                        Puntos = Puntos + 3;
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| Logra un gran avance en su proyecto y recibe el reconocimiento de sus profesores    |\n" +
                                          "| y compañeros                                                                        |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");

                    }
                    else
                    {
                        Puntos = Puntos - 6;
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| Aunque estudia mucho, no logra avanzar tanto como esperaba y se siente frustrado    |\n" +
                                          "| por no alcanzar sus metas                                                           |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    }
                }
                else
                {
                    if (Puntos <= 9)
                    {
                        Puntos = Puntos + 7;
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| Encuentra un proyecto interesante y se involucra activamente, lo que le permite     |\n" +
                                          "| hacer nuevos amigos y mejorar sus habilidades                                       |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    }
                    else
                    {
                        Puntos = Puntos - 5;
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                        Console.WriteLine("| A pesar de sus esfuerzos, no logra conectar con sus compañeros en línea y se        |\n" +
                                          "| siente aún más aislado.                                                             |");
                        Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    }
                }
            }

            if (Nombre == "Usuario")
            {
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| No haz ingresado tu nombre al comienzo del juego, por lo tanto tendras que empezar  |\n" +
                                  "| desde el principio                                                                  |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                bucle= true;
            }
            else
            {
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| Contaremos los puntos para ver cual final haz desbloqueado                          |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                Console.WriteLine("| Tus puntos son "+Puntos+" por lo tanto este es tu final                             |");
                Console.WriteLine("+-------------------------------------------------------------------------------------+");

                if (Puntos <= 10)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Elegiste el camino de la irresponsabilidad, no logras tus metas y                   |\n" +
                                      "| quedas reprobando el curso debido a acontecimientos generados por tus acciones      |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Debido a que reprobaste el curso tienes que empezar todo el juego de nuevo en un    |\n" +
                                      "| nuevo suerte para la proxima                                                        |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("|                                   Game Over                                         |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    bucle = true;
                }
                if (Puntos >= 11)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Eligiste el camino de la responsabilidad por lo tanto apruebas el semestre y tus    |\n" +
                                      "| padres te felicitan y te regalan un auto movil                                      |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Eso demuestra que con esfuerzo y compromiso puedes lograr mas cosas                 |" +
                                      "| que siendo irresponsable                                                            |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    Console.WriteLine("| Felicidades haz ganado un apreton de manos, espero que te gustara el juego          |\n" +
                                      "| hasta la proxima                                                                    |");
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                    break ;
                }
            }
            

        } while (bucle);


    }
}