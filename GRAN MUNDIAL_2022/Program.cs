// See https://aka.ms/new-console-template for more information

using System;
using System.Net.NetworkInformation;
using System.Reflection;
using GRAN_MUNDIAL_2022;

namespace MUNDIAL
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== SUPER COPA MUNDIAL ==========");
            //Ingresar equipos 
            //Opcion de elegir partidos, equipos

            Console.WriteLine("Equipos:");
            Equipo equipo1 = new Equipo();
            Console.Write("Igresar Nombre del equipo 1: ");
            equipo1.nombre = Console.ReadLine();
            Equipo equipo2 = new Equipo();
            Console.Write("Igresar Nombre del equipo 2: ");
            equipo2.nombre = Console.ReadLine();
            Equipo equipo3 = new Equipo();
            Console.Write("Igresar Nombre del equipo 3: ");
            equipo3.nombre = Console.ReadLine();
            Equipo equipo4 = new Equipo();
            Console.Write("Igresar Nombre del equipo 4: ");
            equipo4.nombre = Console.ReadLine();
            Equipo equipo5 = new Equipo();
            Console.Write("Igresar Nombre del equipo 5: ");
            equipo5.nombre = Console.ReadLine();
            Equipo equipo6 = new Equipo();
            Console.Write("Igresar Nombre del equipo 6: ");
            equipo6.nombre = Console.ReadLine();
            Equipo equipo7 = new Equipo();
            Console.Write("Igresar Nombre del equipo 7: ");
            equipo7.nombre = Console.ReadLine();
            Equipo equipo8 = new Equipo();
            Console.Write("Igresar Nombre del equipo 8: ");
            equipo8.nombre = Console.ReadLine();
            Console.Clear();


            // Validar los partidos ingresados no sean nayor a 4
            int partidostotal1, partidostotal2, partidostotal3, partidostotal4, partidostotal5, partidostotal6, partidostotal7, partidostotal8;
            bool validar, validar1, validar2, validar3, validar4, validar5, validar6, validar7;
            validar = true;
            validar1 = true;
            validar2 = true;
            validar3 = true;
            validar4 = true;
            validar5 = true;
            validar6 = true;
            validar7 = true;


            //CASI GANADORES

            SEMIFINAL semi1 = new SEMIFINAL();
            SEMIFINAL semi2 = new SEMIFINAL();
            SEMIFINAL semi3 = new SEMIFINAL();
            SEMIFINAL semi4 = new SEMIFINAL();

            //EL QUE GANA GANO 

            FINAL final1 = new FINAL();
            FINAL final2 = new FINAL();

            while (validar)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 1");
                Console.Write("Partidos ganados: ");
                equipo1.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo1.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo1.PE = Convert.ToInt16(Console.ReadLine());
                equipo1.etapa = 5;
                Console.WriteLine();
                partidostotal1 = equipo1.PG + equipo1.PP + equipo1.PE;
                if (partidostotal1 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar = true;
                }
                else
                {
                    validar = false;
                }
                Console.Clear();
            }

            while (validar1)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 2");
                Console.Write("Partidos ganados: ");
                equipo2.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo2.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo2.PE = Convert.ToInt16(Console.ReadLine());
                equipo2.etapa = 5;
                Console.WriteLine();
                partidostotal2 = equipo2.PG + equipo2.PP + equipo2.PE;
                if (partidostotal2 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar1 = true;
                }
                else
                {
                    validar1 = false;
                }
                Console.Clear();
            }
            while (validar2)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 3");
                Console.Write("Partidos ganados: ");
                equipo3.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo3.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo3.PE = Convert.ToInt16(Console.ReadLine());
                equipo3.etapa = 5;
                Console.WriteLine();
                partidostotal3 = equipo3.PG + equipo3.PP + equipo3.PE;
                if (partidostotal3 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar2 = true;
                }
                else
                {
                    validar2 = false;
                }
                Console.Clear();
            }
            while (validar3)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 4");
                Console.Write("Partidos ganados: ");
                equipo4.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo4.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo4.PE = Convert.ToInt16(Console.ReadLine());
                equipo4.etapa = 5;
                Console.WriteLine();
                partidostotal4 = equipo4.PG + equipo4.PP + equipo4.PE;
                if (partidostotal4 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar3 = true;
                }
                else
                {
                    validar3 = false;
                }
                Console.Clear();
            }
            //VAMOS DE NUEVO 
            while (validar4)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 5");
                Console.Write("Partidos ganados: ");
                equipo5.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo5.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo5.PE = Convert.ToInt16(Console.ReadLine());
                equipo5.etapa = 5;
                Console.WriteLine();
                partidostotal5 = equipo5.PG + equipo5.PP + equipo5.PE;
                if (partidostotal5 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar1 = true;
                }
                else
                {
                    validar4 = false;
                }
                Console.Clear();
            }
            while (validar5)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 6");
                Console.Write("Partidos ganados: ");
                equipo6.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo6.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo6.PE = Convert.ToInt16(Console.ReadLine());
                equipo6.etapa = 5;
                Console.WriteLine();
                partidostotal6 = equipo6.PG + equipo6.PP + equipo6.PE;
                if (partidostotal6 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar5 = true;
                }
                else
                {
                    validar5 = false;
                }
                Console.Clear();
            }
            while (validar6)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 7");
                Console.Write("Partidos ganados: ");
                equipo7.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo7.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo7.PE = Convert.ToInt16(Console.ReadLine());
                equipo7.etapa = 5;
                Console.WriteLine();
                partidostotal7 = equipo7.PG + equipo7.PP + equipo7.PE;
                if (partidostotal7 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar6 = true;
                }
                else
                {
                    validar6 = false;
                }
                Console.Clear();
            }
            while (validar7)
            {
                Console.WriteLine("Partidos ganados, Empetados y perdidos equipo 7");
                Console.Write("Partidos ganados: ");
                equipo7.PG = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos empatados: ");
                equipo7.PP = Convert.ToInt16(Console.ReadLine());
                Console.Write("Partidos perdidos: ");
                equipo7.PE = Convert.ToInt16(Console.ReadLine());
                equipo7.etapa = 5;
                Console.WriteLine();
                partidostotal7 = equipo7.PG + equipo7.PP + equipo7.PE;
                if (partidostotal7 > 4)
                {
                    Console.WriteLine("Valores Invalidos");
                    Console.ReadKey();
                    Console.Clear();
                    validar7 = true;
                }
                else
                {
                    validar7 = false;
                }
                Console.Clear();
            }

            Console.ReadKey();

            //HAGAMOS UNA CHAMUSCA 
            double calcularPoderDelEquipo(int PG, int PP, int PE, int etapa)
            {
                double poder = ((PG * 0.7) - (PP * 0.2) + (PE * 0.4)) / etapa;
                poder = Math.Round(poder, 3);
                return poder;
            }

            double poderEquipo1 = calcularPoderDelEquipo(equipo1.PG, equipo1.PP, equipo1.PE, equipo1.etapa);
            int golesEquipo1 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo1)
                {
                    golesEquipo1++;
                }

            }

            double poderEquipo2 = calcularPoderDelEquipo(equipo2.PG, equipo2.PP, equipo2.PE, equipo2.etapa);
            int golesEquipo2 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo1)
                {
                    golesEquipo2++;
                }

            }

            Console.WriteLine("CUARTOS DE FINAL " + equipo1.nombre + " - " + equipo2.nombre);

        Comprobar:
            if (golesEquipo1 == golesEquipo2)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo1)
                    {
                        golesEquipo2++;
                    }

                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo2)
                    {
                        golesEquipo1++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto Comprobar;
            }
            else if (golesEquipo1 > golesEquipo2)
            {
                Console.WriteLine("GANADOR " + equipo1.nombre);
                equipo1.etapa++;
                semi1.nombre = equipo1.nombre;
                semi1.PG = equipo1.PG + 1;
                semi1.PP = equipo1.PP;
                semi1.PE = equipo1.PE;
                semi1.etapa = equipo1.etapa;
                //
            }
            else
            {
                Console.WriteLine("GANADOR " + equipo2.nombre);
                equipo1.etapa++;
                semi1.nombre = equipo2.nombre;
                semi1.PG = equipo2.PG + 1;
                semi1.PP = equipo2.PP;
                semi1.PE = equipo2.PE;
                semi1.etapa = equipo2.etapa;
            }
            Console.ReadKey();
            Console.WriteLine();

            //SEGUNDA CHAMUSCA 

            double poderEquipo3 = calcularPoderDelEquipo(equipo3.PG, equipo3.PP, equipo3.PE, equipo3.etapa);
            int golesEquipo3 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo3)
                {
                    golesEquipo3++;
                }
            }
            double poderEquipo4 = calcularPoderDelEquipo(equipo4.PG, equipo4.PP, equipo4.PE, equipo4.etapa);
            int golesEquipo4 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo4)
                {
                    golesEquipo4++;
                }
            }

            Console.WriteLine("CUARTOS DE FINAL " + equipo3.nombre + " - " + equipo4.nombre);

        comprobar1:
            if (golesEquipo3 == golesEquipo4)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo3)
                    {
                        golesEquipo4++;
                    }
                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo4)
                    {
                        golesEquipo3++;
                    }
                }

                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobar1;
            }
            else if (golesEquipo3 > golesEquipo4)
            {
                Console.WriteLine("GANADOR " + equipo3.nombre);
                equipo3.etapa++;
                semi2.nombre = equipo1.nombre;
                semi2.PG = equipo3.PG + 1;
                semi2.PP = equipo3.PP;
                semi2.PE = equipo3.PE;
                semi2.etapa = equipo3.etapa;
                //
            }
            else
            {
                Console.WriteLine("GANADOR " + equipo4.nombre);
                equipo1.etapa++;
                semi2.nombre = equipo4.nombre;
                semi2.PG = equipo4.PG + 1;
                semi2.PP = equipo4.PP;
                semi2.PE = equipo4.PE;
                semi2.etapa = equipo4.etapa;
                // 
            }
            Console.ReadLine();
            Console.WriteLine();

            // CHAMUSCA 3 

            double poderEquipo5 = calcularPoderDelEquipo(equipo5.PG, equipo5.PP, equipo5.PE, equipo5.etapa);
            int golesEquipo5 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo5)
                {
                    golesEquipo5++;
                }
            }
            double poderEquipo6 = calcularPoderDelEquipo(equipo6.PG, equipo6.PP, equipo6.PE, equipo6.etapa);
            int golesEquipo6 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo6)
                {
                    golesEquipo6++;
                }
            }

            Console.WriteLine("CUARTOS DE FINAL " + equipo5.nombre + " - " + equipo6.nombre);

        comprobar2:
            if (golesEquipo5 == golesEquipo6)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo5)
                    {
                        golesEquipo6++;
                    }
                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo6)
                    {
                        golesEquipo5++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobar2;
            }
            else if (golesEquipo5 > golesEquipo6)
            {
                Console.WriteLine("GANADOR " + equipo5.nombre);
                equipo5.etapa++;
                semi3.nombre = equipo5.nombre;
                semi3.PG = equipo5.PG + 1;
                semi3.PP = equipo5.PP;
                semi3.PE = equipo5.PE;
                semi3.etapa = equipo5.etapa;
            }
            else
            {
                Console.WriteLine("GANADOR " + equipo6.nombre);
                equipo6.etapa++;
                semi3.nombre = equipo6.nombre;
                semi3.PG = equipo6.PG + 1;
                semi3.PP = equipo6.PP;
                semi3.PE = equipo6.PE;
                semi3.etapa = equipo6.etapa;
                //
            }
            Console.ReadKey();
            Console.WriteLine();

            // CHAMUSCA 4 

            double poderEquipo7 = calcularPoderDelEquipo(equipo7.PG, equipo7.PP, equipo7.PE, equipo7.etapa);
            int golesEquipo7 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo7)
                {
                    golesEquipo7++;
                }
            }
            double poderEquipo8 = calcularPoderDelEquipo(equipo8.PG, equipo8.PP, equipo8.PE, equipo8.etapa);
            int golesEquipo8 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderEquipo8)
                {
                    golesEquipo8++;
                }
            }

            Console.WriteLine("CUARTOS DE FINAL " + equipo7.nombre + " - " + equipo8.nombre);

        comprobar3:
            if (golesEquipo7 == golesEquipo8)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo7)
                    {
                        golesEquipo8++;
                    }
                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderEquipo8)
                    {
                        golesEquipo7++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobar3;
            }
            else if (golesEquipo7 > golesEquipo8)
            {
                Console.WriteLine("GANADOR " + equipo7.nombre);
                equipo7.etapa++;
                semi4.nombre = equipo7.nombre;
                semi4.PG = equipo7.PG + 1;
                semi4.PP = equipo7.PP;
                semi4.PE = equipo7.PE;
                semi4.etapa = equipo7.etapa;
            }
            else
            {
                Console.WriteLine("GANADOR " + equipo8.nombre);
                equipo8.etapa++;
                semi4.nombre = equipo8.nombre;
                semi4.PG = equipo8.PG + 1;
                semi4.PP = equipo8.PP;
                semi4.PE = equipo8.PE;
                semi4.etapa = equipo8.etapa;
                //
            }
            
            Console.ReadKey();
            Console.Clear();

            //SEMIFINALES 1 MUCHAAAAA

            double calcularPoderDelEquipo2(int PG, int PP, int PE, int etapa)
            {
                double poder = ((PG * 0.7) - (PP * 0.2) + (PE * 0.4)) / etapa;
                poder = Math.Round(poder, 3);
                return poder;
            }
            double poderSemifinal1 = calcularPoderDelEquipo2(semi1.PG, semi1.PP, semi1.PE, semi1.etapa);
            int golesSemifinal1 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderSemifinal1)
                {
                    golesSemifinal1++;
                }
            }

            double poderSemifinal2 = calcularPoderDelEquipo2(semi2.PG, semi2.PP, semi2.PE, semi2.etapa);
            int golesSemifinal2 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderSemifinal2)
                {
                    golesSemifinal1++;
                }
            }

            Console.WriteLine("GANADOR DE LA SEMIFINAL " + semi1.nombre + " - " + semi2.nombre);

        comprobarS1:
            if (golesSemifinal1 == golesSemifinal2)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderSemifinal1)
                    {
                        golesSemifinal1++;
                    }
                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderSemifinal2)
                    {
                        golesSemifinal2++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobarS1;
            }
            else if (golesSemifinal1 > golesSemifinal2)
            {
                Console.WriteLine("GANADOR " + semi1.nombre);
                semi1.etapa++;
                final1.nombre = semi1.nombre;
                final1.PG = semi1.PG + 1;
                final1.PP = semi1.PP;
                final1.PE = semi1.PE;
                final1.etapa = semi1.etapa;
            }
            else
            {
                Console.WriteLine("GANADOR " + semi2.nombre);
                semi2.etapa++;
                final1.nombre = semi2.nombre;
                final1.PG = semi2.PG + 1;
                final1.PP = semi2.PP;
                final1.PE = semi2.PE;
                final1.etapa = semi2.etapa;
                //
            }
            Console.ReadKey();

            //SEMIFINAL 2 MUCHAAAA

            double poderSemifinal3 = calcularPoderDelEquipo2(semi3.PG, semi3.PP, semi3.PE, semi3.etapa);
            int golesSemifinal3 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderSemifinal3)
                {
                    golesSemifinal3++;
                }
            }
            double poderSemifinal4 = calcularPoderDelEquipo2(semi4.PG, semi4.PP, semi4.PE, semi4.etapa);
            int golesSemifinal4 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderSemifinal4)
                {
                    golesSemifinal4++;
                }
            }

            Console.WriteLine("GANADOR DE LA SEMIFINAL " + semi3.nombre + " - " + semi4.nombre);

        comprobarS2:
            if (golesSemifinal1 == golesSemifinal2)
            {
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderSemifinal3)
                    {
                        golesSemifinal3++;
                    }
                }
                for (int i = 1; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderSemifinal4)
                    {
                        golesSemifinal4++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobarS2;
            }
            else if (golesSemifinal3 > golesSemifinal4)
            {
                Console.WriteLine("GANADOR " + semi3.nombre);
                semi3.etapa++;
                final2.nombre = semi3.nombre;
                final2.PG = semi3.PG + 1;
                final2.PP = semi3.PP;
                final2.PE = semi3.PE;
                final2.etapa = semi3.etapa;
            }
            else
            {
                Console.WriteLine("GANADOR " + semi3.nombre);
                semi3.etapa++;
                final2.nombre = semi3.nombre;
                final2.PG = semi3.PG + 1;
                final2.PP = semi3.PP;
                final2.PE = semi3.PE;
                final2.etapa = semi3.etapa;
                //
            }
            Console.ReadKey();

            //LA GRAN FINAL 

            double calcularPoderDelEquipo3(int PG, int PP, int PE, int etapa)
            {
                double poder = ((PG * 0.7) - (PP * 0.2) + (PE * 0.4)) / etapa;
                poder = Math.Round(poder, 3);
                return poder; 
            }
            double poderfinal1 = calcularPoderDelEquipo2(final1.PG, final1.PP, final1.PE, final1.etapa);
            int golesfinal1 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderfinal1)
                {
                    golesfinal1++;
                }
            }
            double poderfinal2 = calcularPoderDelEquipo2(final2.PG, final2.PP, final2.PE, final2.etapa);
            int golesfinal2 = 0;
            for (int i = 1; i < 4; i++)
            {
                Random random = new Random();
                double numeroRandom = random.NextDouble();
                if (numeroRandom < poderfinal2)
                {
                    golesfinal2++;
                }

            }
            Console.WriteLine("==LA GRAN FINAL== " + final1.nombre + " - " + final2.nombre);

            comprobarS4:
            if (golesfinal1 == golesfinal2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderfinal1)
                    {
                        golesfinal1++;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    Random random = new Random();
                    double numeroRandom = random.NextDouble();
                    if (numeroRandom < poderfinal2)
                    {
                        golesfinal2++;
                    }
                }
                Console.WriteLine("EMPATE");
                Console.ReadKey();
                Console.WriteLine("TIEMPOS EXTRA");
                Console.ReadKey();

                goto comprobarS4;
            }
            else if (golesfinal1 > golesfinal2)
            {
                Console.WriteLine("==TENEMOS NUEVOOO CAMPEOOOOOON DEL MUNDO SIIUUU== " + final1.nombre);
            }
            else
            {
                Console.WriteLine("==TENEMOS NUEVOOO CAMPEOOOOOON DEL MUNDO SIIUUU== " + final2.nombre);
                //
            }
            Console.ReadKey();
        }
        
    }
}
