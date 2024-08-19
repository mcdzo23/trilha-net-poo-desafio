using DesafioPOO.Models;

public abstract class Smartphone
{ 
    public string Numero;
    public string Modelo;
    public string IMEI;
    public int Memoria;

    public void Ligar(){}
    public void ReceberLigacao(){}
    public  void InstalarAplicativo(){}





}
 public class Nokia : Smartphone 
 { public void InstalarAplicativo(){}




 }
 public class Iphone : Smartphone
 {
public void InstalarAplicativo(){}
 }
 
