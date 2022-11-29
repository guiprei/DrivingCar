class Program {
public class Car {

    public int Velocity = 0;
    public bool Status = false;
    public int opt = -1;

    public virtual void Choise(){
      while (opt != 6 ) {
      opt = -1;    
      Console.WriteLine("--------------------");
      Console.WriteLine("[1] -- ligar");
      Console.WriteLine("[2] -- desligar");
      Console.WriteLine("[3] -- acelerar");
      Console.WriteLine("[4] -- desacelerar");
      Console.WriteLine("[5] -- parar");  
      Console.WriteLine("[6] -- Sair");
      Console.Write("Opção: ");
      opt = Convert.ToInt32(Console.ReadLine());
      if(opt == 1) {
         CarOn();
         GetStatus();
      }
      if(opt == 2) {
         CarOff();
         GetStatus();
      }
      if(opt == 3) {
         VelocityUp();
         GetStatus();
      }
      if(opt == 4) {
         VelocityDown();
         GetStatus();
      }
      if(opt == 5) {
         CarStop();
         GetStatus();
      }
      }
    }
    public void CarOn(){
        if (Status == false && Velocity == 0 ) {
          Status = true;
          Console.WriteLine("------------------------");
          Console.WriteLine("| O carro está ligado! |");
        }
        else{
          Console.WriteLine("---------------------------");
          Console.WriteLine("| O carro já está ligado! |");
        }
    }
    public void CarOff(){
        if (Status == true && Velocity == 0) {
          Status = false;
          Console.WriteLine("--------------------------");
          Console.WriteLine("| O carro está desligado |");
        }
        else{
          Console.WriteLine("-----------------------------");
          Console.WriteLine("| O carro já está desligado |");
        }
      
    }
    public virtual void VelocityUp(){
        if (Status == true && Velocity < 180 ) {
          Velocity += 20;
        }
        if (Velocity == 180) {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("| Velocidade maxima alcançada |"); 
        }
        if(Status == false){
          Console.WriteLine("--------------------------");
          Console.WriteLine("| O carro está desligado |");
      }
    }    
    public void VelocityDown(){
        if (Status == true && Velocity > 0) {
          Velocity -= 20;
        }
        if (Velocity == 0) {
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("| Velocidade minima alcançada - O carro etá parado |"); 
        }
        if(Status == false){
          Console.WriteLine("--------------------------");
          Console.WriteLine("| O carro está desligado |");
        }
      }
    public void CarStop(){
        if(Status == true &&  Velocity > 0){
          Velocity = 0;  
        }
        if(Velocity == 0){
        Console.WriteLine("-----------------------");
          Console.WriteLine("| O carro está parado |");
      }
    }
    public virtual void GetStatus(){
      Console.WriteLine("--------------------");
      Console.WriteLine("| Velocidade: " + Velocity + "Km/hr |");
      if (Status == true)
      {
        Console.WriteLine("----------------");
        Console.WriteLine("| Carro ligado |");
      }
      else {
        Console.WriteLine("-------------------");
        Console.WriteLine("| Carro desligado |");
      }
    }
}
public class Bus : Car{
      public int Passengers = 0;
      public bool Confirm;
      public int Option;
    public override void Choise(){
      while (opt != 6 ) {  
      opt = -1;
      Console.WriteLine("--------------------");
      Console.WriteLine("[0] -- Passageiros");
      Console.WriteLine("[1] -- ligar");
      Console.WriteLine("[2] -- desligar");
      Console.WriteLine("[3] -- acelerar");
      Console.WriteLine("[4] -- desacelerar");
      Console.WriteLine("[5] -- parar");  
      Console.WriteLine("[6] -- Sair");
      Console.Write("Opção: ");
      opt = Convert.ToInt32(Console.ReadLine());
      if(opt == 0) {
         BusPassengers();
         CarOn();
         GetStatus();
      }
      if(opt == 1) {
         CarOn();
         GetStatus();
      }
      if(opt == 2) {
         CarOff();
         GetStatus();
      }
      if(opt == 3) {
         VelocityUp();
         GetStatus();
      }
      if(opt == 4) {
         VelocityDown();
         GetStatus();
      }
      if(opt == 5) {
         CarStop();
         GetStatus();
      }
      }
    }
    public override void VelocityUp(){
        if (Status == true && Velocity < 140 ) {
          Velocity += 20;
        }
        if (Velocity == 140) {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("| Velocidade maxima alcançada |"); 
        }
        if(Status == false){
          Console.WriteLine("--------------------------");
          Console.WriteLine("| O carro está desligado |");
        }
      }
    public void BusPassengers() {
      while (Confirm == false){
        Console.WriteLine("----------------------------");
        Console.Write("Quantos passageiros irão embarcar: ");
        Passengers = Convert.ToInt32(Console.ReadLine());

        if (Passengers <= 30){
          Confirm = true;
        }
        if(Passengers > 30 ) {
          Console.WriteLine("------------------------------------");
          Console.WriteLine("Quantidade de passageiros excedida!");
          Console.WriteLine("Oque Gostaria de fazer? ");
          Console.WriteLine("[1] Deixar com a capacidade maxima  [2] Selecionar outro número de passageiros");
          Console.Write("Opção: ");
          Option = Convert.ToInt32(Console.ReadLine());
        }
        if(Option == 1){
          Passengers = 30;
          Confirm = true;
        }
      }
    }
    public override void GetStatus(){
      Console.WriteLine("--------------------");
      Console.WriteLine("| Passageiros: " + Passengers + " |");
      Console.WriteLine("--------------------");
      Console.WriteLine("| Velocidade: " + Velocity + "Km/hr |");
      if (Status == true)
      {
        Console.WriteLine("----------------");
        Console.WriteLine("| Carro ligado |");
      }
      else {
        Console.WriteLine("-------------------");
        Console.WriteLine("| Carro desligado |");
      }
    }
}
public class Suv : Car {  

        public float Traction = 0;
        public float wheight = 1500;
    public void SuvTraction(){
      Traction = wheight *= Velocity /= 3 ;
    }    
    public override void VelocityUp(){
       
        if (Status == true && Velocity < 220 ) {
          Velocity += 20;
        }
        if (Velocity == 220) {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("| Velocidade maxima alcançada |"); 
        }
        if(Status == false){
          Console.WriteLine("--------------------------");
          Console.WriteLine("| O carro está desligado |");
        }
    }
    
    public override void GetStatus(){
      Console.WriteLine("--------------------");
      Console.WriteLine("| Velocidade: " + Velocity + "Km/hr |");
      Console.WriteLine("-----------------------");
      Console.WriteLine("| Tração: " + Traction + " N |");
      if (Status == true)
      {
        Console.WriteLine("----------------");
        Console.WriteLine("| Carro ligado |");
      }
      else {
        Console.WriteLine("-------------------");
        Console.WriteLine("| Carro desligado |");
      }
    }
}
    public static void Main() {
      int input = 0;

      Car anyCar = new Car();
      Bus anyBus = new Bus();
      Suv anySuv = new Suv();
    while (input != 4){
      Console.WriteLine("Escolha um veiculo abaixo:");
      Console.WriteLine("[1] Carro   [2] Ônibus  [3] Suv [4] Fechar");
      Console.Write("Opção: ");
      input = Convert.ToInt32(Console.ReadLine());
      if (input == 1){
      anyCar.Choise();
      }
      if (input == 2){
      anyBus.Choise();
      }
      if (input == 3){
      anySuv.Choise();
      }
      }
    }

}
