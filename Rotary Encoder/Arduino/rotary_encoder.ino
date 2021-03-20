 #define outputA A0
 #define outputB 15
 #define  BUTTON A1
 #define PIN_5V  A2
 #define PIN_GND  A3
 
 int counter_right = 0; 
  int counter_left = 0; 

 int aState;
 int aLastState;  
bool lastButtonState = 0;
 void setup() { 
   pinMode (outputA,INPUT);
   pinMode (outputB,INPUT);
   
   // BUTTON (A1) is for INPUT
  // Most pin has thier own pull-up resistor.
  // INPUT_PULLUP makes the pin high.
  // a leg of button is connected with this pin and GND
  // when the button is not pressed, the pin reads HIGH signal because of this PULL-UP
  // when the button is pressed, pin is going to be LOW which means "pressed"
   pinMode(BUTTON, INPUT_PULLUP);
     
   pinMode(PIN_5V, OUTPUT);
  digitalWrite(PIN_5V, HIGH);
  pinMode(PIN_GND, OUTPUT);
  digitalWrite(PIN_GND, LOW);
   Serial.begin (9600);
   // Reads the initial state of the outputA
   aLastState = digitalRead(outputA);   
 } 

 void loop() { 
   aState = digitalRead(outputA); // Reads the "current" state of the outputA
   // If the previous and the current state of the outputA are different, that means a Pulse has occured
   if (aState != aLastState){     
     // If the outputB state is different to the outputA state, that means the encoder is rotating clockwise
     if (digitalRead(outputB) != aState) { 
      /*counter_right ++;
      counter_left=0;
      Serial.print(counter_right);
      Serial.print(",");
      Serial.println(counter_left);
*/
      Serial.println("r");
    delay(10);

     } else {
       /*counter_left --;
       counter_right=0;
      Serial.print(counter_right);
      Serial.print(",");
      Serial.println(counter_left);
      */
      Serial.println("l");
    delay(10);

     }
     //Serial.print("Position: ");
    //Serial.print("Position: ");
    //Serial.println(counter);
   } 
   aLastState = aState; // Updates the previous state of the outputA with the current state
//BUTTON

if (digitalRead(BUTTON) == LOW) {

      // and this code checks whether it is edge (HIGH->LOW)
      if (lastButtonState == HIGH) {

        // sends space charac  ter
        //Keyboard.print(" ");
          Serial.print("Button is pressed"); 
          Serial.println(lastButtonState);

      }

      // for checking edge
      lastButtonState = LOW;
    } else {

      // for checking edge
      lastButtonState = HIGH;
    }


   
 }
