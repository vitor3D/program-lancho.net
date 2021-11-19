using System;

class MainClass {
  public static void Main (string[] args) {

   

    int menu=0, x, y, total=0;
    int l1=0, l2=0, l3=0, l4=0;
    int b1=0, b2=0, b3=0, b4=0;
    bool sair=false, sair1=false, sair2=false;
    do{
    Console.WriteLine("MENU PRINCIPAL\n[ 1 ] MESAS\n[ 2 ] COMIDAS\n[ 3 ] CONTA\n[ 0 ] SAIR");
    Console.Write("Escolha a opção desejada:");
    menu=int.Parse(Console.ReadLine());
    Console.Clear();

    switch(menu){
    
      case 1:
      do{
      
      Console.WriteLine("LANCHES\n[ 1 ]MESA 1 \n[ 2 ] MESA 2 \n[ 3 ] MESA 3\n[ 4 ] MESA 4\n[ 0 ] VOLTAR");
      Console.WriteLine("Digite a MESA desejada:");
      x=int.Parse(Console.ReadLine()); 
      Console.WriteLine("\n");
      switch(x){
        
        case 1:
        l1=l1+1;
        break;

        case 2:
        l2=l2+1;
        break;

        case 3:
        l3=l3+1;
        break;

        case 4:
        l4=l4+1;
        break;

        case 0:
        sair1=true;
        break;

        default:
        Console.WriteLine("Opção Inválida!\n");
        break;
        
      }
      }while(sair1!=true);
      Console.Clear();
      break;

  }
}