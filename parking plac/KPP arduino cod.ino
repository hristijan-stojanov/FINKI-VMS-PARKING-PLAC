#include <TM1637Display.h>
#include <Servo.h>
int brSlobodniMesta=200;
int position;
int r;
const int CLK = 2;
const int DIO = 3;
const int CLK1 = 4;
const int DIO1 = 5;
TM1637Display displaySlobodniMesta(CLK, DIO);
TM1637Display code(CLK1, DIO1);
Servo vlez;
Servo izlez;

void setup() {
  Serial.begin(9600);
  displaySlobodniMesta.setBrightness(0x0f);
  code.setBrightness(0x0f);
 // code.clearDisplay();
  vlez.attach(9); 
  izlez.attach(10);
  vlez.write(90);
  izlez.write(90);

}





void otvaranjeIzatvaranjeVleznaRampa()
{
  brSlobodniMesta--;
  displaySlobodniMesta.showNumberDec(brSlobodniMesta);
  r = random(1000, 9999);
  code.showNumberDec(r);
  Serial.print(r); 
  for (position = 90; position <= 180; position += 1) { 
    vlez.write(position);              
    delay(15);                      
  }
  delay(10000);
  for (position = 180; position >= 90; position -= 1) {  
    vlez.write(position);              
    delay(15);                       
  }
  

}
void  OptvoriIzleznaRampa()
{
   for (position = 90; position <= 180; position += 1) { 
    izlez.write(position);              
    delay(15);                      
  }

}
void ZatvoriIzleznaRampa()
{
  brSlobodniMesta++;
  displaySlobodniMesta.showNumberDec(brSlobodniMesta );
  for (position = 180; position >= 90; position -= 1) {  
    izlez.write(position);              
    delay(15);                       
  }

}
void loop()    
{    
displaySlobodniMesta.showNumberDec(brSlobodniMesta);
  if(digitalRead(A2))//ako tasterot za vles e pritisnat
  {
    otvaranjeIzatvaranjeVleznaRampa();
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
