/*
 * Author: Ta Luc Gia Hoang
 * Date: August 8, 2021
 * 
 * This sample code is used to test UART communication
 * It will blink an on-board LED and send LED's state 
 * via UART
 */
volatile int state = 0;   // state of on-board LED

void setup() {
  Serial.begin(115200);
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  switch(state) {
    case 0: {
      digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
      break;
    }
    case 1: {
      digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
      break;
    }
    default: {
      break;  // keep previous state
    }
  }

  Serial.print("var1:");Serial.print(state);Serial.print("\r\n");  // LED state
  delay(1000);

  // Change LED state
  state == 0 ? state = 1 : state = 0;
}

