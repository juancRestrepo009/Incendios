
#include <Wire.h> 
#include <MMA_7455.h> 

MMA_7455 mySensor = MMA_7455(); 

char xVal, yVal, zVal;

int pin1 = 8;
//int pin2 = 9;

void setup() {
 Serial.begin(9600);
pinMode(pin1,INPUT);
//pinMode(pin2,INPUT);

Serial.begin(9600);
  delay(500);
  /*Serial.println("Datos Acelerometro MMA7455 ");*/
   mySensor.initSensitivity(2);

   mySensor.calibrateOffset(0,0,0); //Uncomment for first try: find offsets
   mySensor.calibrateOffset(-5.0, 13.0, -12.0); //Then Uncomment and use this

}

void loop() {
  if(digitalRead(pin1)==HIGH){
  
  //Serial.println("ON");
  Serial.write(1);
  Serial.flush();
  delay(20);
      
  //}else if(digitalRead(pin2)==HIGH){
  
  //Serial.println("ON");
  //Serial.write(6);
  //Serial.flush();
  //delay(20);
      
  }
  else{
  //Serial.println("OFF");
  Serial.write(0);
  Serial.flush();
  delay(20);
  }
  
  xVal = mySensor.readAxis('x'); 
  yVal = mySensor.readAxis('y'); 
  zVal = mySensor.readAxis('z');

//  Serial.print("X = ");
//  Serial.print(xVal, DEC);
//  Serial.print("Y = ");
//  Serial.print(yVal, DEC);
//  Serial.print("Z = ");
//  Serial.println(zVal, DEC);
//  delay(500);
 
  /*if (xVal < -20) Serial.println("Inclinado a la Izquierda");*/
  /*if (xVal >  20) Serial.println("Inclinado a la Derecha");  */
  if (yVal < -30) /*Serial.println("Inclinado hacia atras")*/Serial.write(2);  
  if (yVal >  30) /*Serial.println("Inclinado hacia adelante")*/Serial.write(3); 
  if (zVal >  10) /*Serial.println("Boca Abajo Der")*/Serial.write(4);   
  if (zVal < -10) /*Serial.println("Boca Abajo Izq")*/Serial.write(5);    
}
