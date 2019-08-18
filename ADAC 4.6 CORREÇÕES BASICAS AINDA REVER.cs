/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 16/08/2019
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace adasd
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] useraluno=new string[2];
                int[] alunopass=new int[2];            
                useraluno[0]= " ";                                            
                alunopass[0]= 0;
                useraluno[1]= " ";
                alunopass[1]= 0;
                
                string[] userprof=new string[2];
                int[] profpass=new int[2];            
                userprof[0]= " ";                                            
                profpass[0]= 0;
                userprof[1]= " ";
                profpass[1]= 0;
                
        //Vetores de notas em relação a matéria.
        
        double[] notaslogica=new double[2];
                notaslogica[0]= 0;
                notaslogica[1]= 0;
                
        
        double[] notasredes=new double[2];
                notasredes[0]= 0;
                notasredes[1]= 0;
                
        double[] notassisope=new double[2];
                notassisope[0]= 0;
                notassisope[1]= 0;
                
        string mensagemall = "", mensagemprof = "", mensagemaluno = "";
                
                
        inicio:
       
        	Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("Bem Vindo! Como deseja logar? \n1. Administrador \n2. Professor \n3. Aluno");

            int opcao=Convert.ToInt32(Console.ReadLine());
            //Menu de opções para logar 
                switch(opcao)
                {
                    case(1):
                    adm:
                    	Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.Clear();
                        Console.Write("Insira a chave de segurança: "); int admsenha=Convert.ToInt32(Console.ReadLine());
                            if(admsenha==321){
                                Console.Clear();
                                goto adm1;
                            }
                            else
                                Console.Clear();
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine("Chave de acesso inválida \nDeseja tentar novamente ou retornar ao menu?");
                                Console.WriteLine("1. Tentar Novamente \n2. Menu");
                                string admopcao=Console.ReadLine();
                                    if(admopcao=="1"){
                                        goto adm;
                                    }
                                    else
                                        Console.Clear();
                                        goto inicio;
                    case(2):
                    prof:
                    	Console.ForegroundColor= ConsoleColor.Green;
                        Console.Clear();
                        Console.Write("Insira seu Nome: "); string profnome=Console.ReadLine();
                        Console.Write("Insira sua Senha: "); int profsenha=Convert.ToInt32(Console.ReadLine());
                        
                        if ((profsenha == 123) && (profnome == "Rafael")){
                            Console.Clear();
                            goto prof1;}
                             if((profsenha==456)&&(profnome=="Clayton")){
                                Console.Clear();
                                goto prof2;}
                        if((profsenha==profpass[0])&&(profnome==userprof[0])){
                                Console.Clear();
                                goto prof3;}
                        
                             else
                                Console.Clear();
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine("Desculpe senha ou nome inválido \nDeseja tentar novamente ou retornar ao menu?");
                                Console.WriteLine("1. Tentar Novamente \n2. Menu");
                                string profopcao=Console.ReadLine();
                                     if(profopcao=="1"){
                                         goto prof;
                                     }
                                     else
                                         Console.Clear();
                                         goto inicio;
                    case(3):
                    aluno:
                    	Console.ForegroundColor= ConsoleColor.Magenta;
                         Console.Clear();
                         Console.Write("Insira seu login: "); string alunoidentificacao=Console.ReadLine();
                         Console.Write("Insira sua senha: ");int alunosenha=Convert.ToInt32(Console.ReadLine());
                         if((alunoidentificacao==useraluno[0])&&(alunosenha==alunopass[0])){
                                Console.Clear();
                                goto aluno1;}
                         if((alunoidentificacao==useraluno[1])&&(alunosenha==alunopass[1])){
                                 Console.Clear();
                                 goto aluno2;}
                             else
                                Console.Clear();
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine("Desculpe identificação inválida \nDeseja tentar novamente ou retornar ao menu?");
                                Console.WriteLine("1. Tentar Novamente \n2. Menu");
                                string alunoopcao=Console.ReadLine();
                                     if(alunoopcao=="1"){
                                         goto aluno;
                                     }
                                     else
                                         Console.Clear();
                                         goto inicio;
                default:
                Console.WriteLine("Opção inválida, por favor tente novamente");
                Console.ReadKey(true);
                Console.Clear();
                goto inicio;
                }
                
            prof1: //Aba do primeiro professor predefinido "Rafael"
                Console.WriteLine("Bem vindo Rafael \nO que deseja verificar?");
                Console.WriteLine("1. Inserir Notas");
                string prof1op = Console.ReadLine();
                switch(prof1op){
                    case("1"):
                        Console.Clear();
                            Console.WriteLine("Selecione um aluno: \n1. {0} \n2. {1}", useraluno[0], useraluno[1]);
                            string notas1=Console.ReadLine();
                            
                            if(notas1=="1") {
                                Console.Clear();
                                Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[0]);
                                notaslogica[0]=Convert.ToDouble(Console.ReadLine());}
                            
                            
                            if(notas1=="2"){
                                Console.Clear();
                                Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[1]);
                                notaslogica[1]=Convert.ToDouble(Console.ReadLine());}
                            break;  }
                
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine("Deseja sair? \n1. Sim \n2. Não"); string opcaoprof1=Console.ReadLine();
                if(opcaoprof1=="1"){
                Console.Clear();
                goto inicio;
                }
                else
                    Console.Clear();
                    goto prof1;
                    
                    
                    
                    
                    

            prof2: //Aba do segundo professor predefinido "Clayton"
                Console.WriteLine("Bem vindo Clayton \nO que deseja verificar?");
                Console.WriteLine("1. Inserir Notas");
                string prof2op = Console.ReadLine();
                switch (prof2op)
                {
                        case ("1"):{
                        Console.Clear();
                        Console.WriteLine("Selecione um aluno: \n1. {0} \n2. {1}", useraluno[0], useraluno[1]);
                        string opclayt = Console.ReadLine();
                        
                        if(opclayt=="1"){
                            Console.Clear();
                            Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[0]);
                            notasredes[0] = Convert.ToDouble(Console.ReadLine());
                        }
                           if(opclayt=="2"){
                            Console.Clear();
                            Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[1]);
                            notasredes[1] = Convert.ToDouble(Console.ReadLine());}
                        }
                        break;
                }
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine("Deseja sair? \n1. Sim \n2. Não"); string opcaoprof2 = Console.ReadLine();
                if (opcaoprof2 == "1")
                {
                    Console.Clear();
                    goto inicio;
                }
                else
                    Console.Clear();
                    goto prof2;
                    
                    
                    
                    
                    
               prof3:
                    Console.WriteLine("Bem vindo {0} \nO que deseja verificar?", userprof[0]);
                Console.WriteLine("1. Inserir Notas");
                string prof3op = Console.ReadLine();
                switch (prof3op)
                {
                        case ("1"):{
                        Console.Clear();
                        Console.WriteLine("Selecione um aluno: \n1. {0} \n2. {1}", useraluno[0], useraluno[1]);
                        string opcprof3 = Console.ReadLine();
                        
                        if(opcprof3=="1"){
                            Console.Clear();
                            Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[0]);
                            notassisope[0] = Convert.ToDouble(Console.ReadLine());
                        }
                           if(opcprof3=="2"){
                            Console.Clear();
                            Console.WriteLine("Digite a nota que será aplicada para o aluno {0}", useraluno[1]);
                            notassisope[1] = Convert.ToDouble(Console.ReadLine());}
                        }
                        break;
                }
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine("Deseja sair? \n1. Sim \n2. Não"); string opcaoprof3 = Console.ReadLine();
                if (opcaoprof3 == "1")
                {
                    Console.Clear();
                    goto inicio;
                }
                else
                    Console.Clear();
                    goto prof3;
                    
                    
                    
                    
            adm1:// Aba de Admnistrador 
                Console.WriteLine("Bem vindo ao modo ADM \nO que deseja verificar? \n1-Criar um Aluno \n2-Criar um Professor \n3-Enviar mensagem \n4-Sair");
                string opc1=Console.ReadLine();
                
                switch(opc1){
                        
                    case("1")://Criação de alunos
                        Console.Clear();
                        Console.Write("Digite o login do 1º aluno: ");
                            useraluno[0]=Console.ReadLine();
                        Console.Write("Digite a senha do 1º aluno: ");
                            alunopass[0]=Convert.ToInt32(Console.ReadLine());
                         Console.ForegroundColor= ConsoleColor.DarkCyan;

                         
                        Console.WriteLine("Deseja criar mais ou retornar?\n1. Continuar\n2. Retornar");
                            int opcreturn=Convert.ToInt32(Console.ReadLine());
                           
                            if(opcreturn==2){
                                Console.Clear(); 
                                goto inicio;}
                            
                            Console.Clear();
                        Console.Write("Digite o login do 2º aluno: ");
                            useraluno[1]=Console.ReadLine();
                        Console.Write("Digite a senha do 2º aluno: ");
                            alunopass[1]=Convert.ToInt32(Console.ReadLine());
                            
                        Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                        Console.ReadKey(true);
                        Console.Clear(); goto adm1;
                        
                    case("2")://Criação do professor
                        Console.Clear();
                        Console.Write("Digite o login do 1º professor: ");
                            userprof[0]=Console.ReadLine();
                        Console.Write("Digite a senha do 1º professor: ");
                            profpass[0]=Convert.ToInt32(Console.ReadLine());
                            
                        Console.WriteLine("Usuário criado...");
                        Console.ReadKey(true);
                        Console.Clear(); goto adm1;
                    case("3"):
                        Console.Clear();
                        Console.WriteLine("Escolha quem você deseja enviar uma mensagem");
                        Console.WriteLine("1. Todos os usuários \n2. Todos os professores \n3. Todos os alunos");
                        	string mensagemopc = Console.ReadLine();
                        switch (mensagemopc){
                        		
                       	case ("1"):
                        		Console.Clear();
                        Console.WriteLine("Digite a mensagem que deseja enviar a todos os usuários:");
                        mensagemall=Console.ReadLine();
                        break;
                        
                        case ("2"):
                        		Console.Clear();
                        Console.WriteLine("Digite a mensagem que deseja enviar a todos os professores:");
                        mensagemprof=Console.ReadLine();
                        break;
                        
                        case ("3"):
                        		Console.Clear();
                        Console.WriteLine("Digite a mensagem que deseja enviar a todos os alunos:");
                        mensagemaluno=Console.ReadLine(); 
                        break;
                       
                        default:
                        		Console.Clear();
                        Console.WriteLine("Opção selecionada é inválida");
                        mensagemopc = Console.ReadLine();
                        break;
                        }
    	
                        goto adm1;
                        
                    case("4"):
                        Console.Clear();
                        goto inicio;
                        
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida, pressione qualquer tecla para retornar ao menu de ADM");
                        Console.ReadKey(true);
                        Console.Clear();
                          goto adm1;                
                }
                
                
                
                
                
            aluno1: //Aba de primeiro aluno criado pelo ADM
                Console.WriteLine("Bem vindo {0} \nO que deseja verificar?", useraluno[0]);
                Console.WriteLine("1. Notas\n2. Mensagens"); string aluno1notas = Console.ReadLine();
                Console.Clear();
                switch(aluno1notas){
                    case("1"):
                        Console.WriteLine("     Lógica \tRedes \tSistemas");
                        Console.WriteLine("Nti1:  {0}\t {1}\t   {2}", notaslogica[0], notasredes[0], notassisope[0]);
                            break;
                    case("2"):
                            Console.WriteLine("{0}", mensagemall);
                            Console.WriteLine("{0}", mensagemaluno);
                            break;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto inicio;
                
                
                
                
            aluno2: //Aba de primeiro aluno criado pelo ADM
                Console.WriteLine("Bem vindo {0} \nO que deseja verificar?", useraluno[1]);
                Console.WriteLine("1. Notas");string aluno2notas = Console.ReadLine();
                Console.Clear();
                switch(aluno2notas){
                    case("1"):
                        Console.WriteLine("     Lógica \tRedes \tSistemas");
                        Console.WriteLine("Nti1:  {0}\t {1}\t   {2}", notaslogica[1], notasredes[1], notassisope[1]);
                            break;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto inicio;
		}
	}
}