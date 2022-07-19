int brSlobodniMesta=9;  
int digits [10][8]{
  {0,1,1,1,1,1,1,0}, // digit 0
  {0,0,1,1,0,0,0,0}, // digit 1
  {0,1,1,0,1,1,0,1}, // digit 2
  {0,1,1,1,1,0,0,1}, // digit 3
  {0,0,1,1,0,0,1,1}, // digit 4
  {0,1,0,1,1,0,1,1}, // digit 5
  {0,1,0,1,1,1,1,1}, // digit 6
  {0,1,1,1,0,0,0,0}, // digit 7
  {0,1,1,1,1,1,1,1}, // digit 8
  {0,1,1,1,1,0,1,1}  // digit 9
};
int DS1_pin = 9;
int STCP1_pin =8;
int SHCP1_pin = 7;
int DS1_pin1 = 12;
int STCP1_pin1 =11;
int SHCP1_pin1 = 10;

void setup()    
{    
  Serial.begin(9600);
  pinMode(2, INPUT);    
   for(int i=3;i<=12;i++)
   {
      pinMode(i, OUTPUT);
   }  
}    
void KodZaNAplata(int Digit)
{
// poradi hardverski ogranicuvanjea kodot ke bide edenocifren bro, odnosno redniot broj na vlez
digitalWrite(STCP1_pin,LOW);
    for (int i = 7; i>=0; i--)
   {
    digitalWrite(SHCP1_pin,LOW);
    if (digits[Digit][i]==1) digitalWrite(DS1_pin, LOW); 
    if (digits[Digit][i]==0) digitalWrite(DS1_pin, HIGH);
    digitalWrite(SHCP1_pin,HIGH);
   }
   digitalWrite(STCP1_pin, HIGH);

}
void PrikazSlobodniMesta(int Digit)
{
digitalWrite(STCP1_pin1,LOW);
    for (int i = 7; i>=0; i--)
   {
    digitalWrite(SHCP1_pin1,LOW);
    if (digits[Digit][i]==1) digitalWrite(DS1_pin1, LOW); 
    if (digits[Digit][i]==0) digitalWrite(DS1_pin1, HIGH);
    digitalWrite(SHCP1_pin1,HIGH);
   }
   digitalWrite(STCP1_pin1, HIGH);
}
void otvaranjeVleznaRampa()
{
   KodZaNAplata(9-brSlobodniMesta);
  digitalWrite(3, HIGH);//otvori vlezna rampa
  delay(2000);//pocekaj da se ovori vleznata vrata
  digitalWrite(3,LOW);//stopiraj go otvaranjeto na vratata
  delay(5000);//pocekaj avtomobilot da ja pomina rampata
  digitalWrite(4,HIGH);// pocni so zatvaranje na rampata
  delay(2000);//pocekaj rampata da se zatvoti
  digitalWrite(4,LOW);// prekini so zatvaranje na rampata
  brSlobodniMesta--;// odzemi edno mesto od slobodnite mesta
  PrikazSlobodniMesta(brSlobodniMesta);
  Serial.println(brSlobodniMesta);// abdejtiraj gi slobodnite mesta vo aplikacijata
}
void OptvoriIzleznaRampa()
{
     digitalWrite(5, HIGH);// zapocni so otvaranje na izleznata rampa
     delay(2000);// pocekaj da se otvori celosno
     digitalWrite(5,LOW);// prekin so otvaranje na rampata
}
void ZatvoriIzleznaRampa()
{
  digitalWrite(6, HIGH);//zapocni so zatvaranje na izleznata rampa
   delay(2000);// pocekaj da se zatvori
   digitalWrite(6,LOW);// prekini so zatvaranje
   brSlobodniMesta++;
   PrikazSlobodniMesta(brSlobodniMesta);
  Serial.println(brSlobodniMesta);// abdejtiraj gi slobodnite mesta vo aplikacijata
}
    
void loop()    
{    
PrikazSlobodniMesta(brSlobodniMesta);
  if(digitalRead(2))//ako tasterot za vles e pritisnat
  {
    otvaranjeVleznaRampa();
  }
  char  data=Serial.read();//procitaj informacija od aplikacijata
  switch(data) // reagiraj soodvetno   
  {    
    case 'O':OptvoriIzleznaRampa();    
    break;    
    case 'C':ZatvoriIzleznaRampa();    
    break;    
       
  }    
}