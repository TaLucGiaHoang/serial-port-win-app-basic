/*
 * Author: Ta Luc Gia Hoang
 * Date: August 8, 2021
 * 
 * This sample code is used to test UART communication
 * It will blink an on-board LED and send LED's state 
 * via UART.
 * 
 * Ability to receive commands from UART then update LED's state
 * 
 * Received commands to switch LED are:
 * "var1:0\r\n"      : Turn LED off
 * "var1:1\r\n"      : Turn LED on
 * "var1:toggle\r\n" : Toggle LED
 */
volatile int state = 0;   // state of on-board LED
unsigned int count = 0;   // count to 15; interval timer (15 * 200 = 3000 ms) 
                          // to toggle LED and send UART
String inputString = "";      // a String to hold incoming data
bool stringComplete = false;  // whether the string is complete
bool sendSerial = false;      // enable to send UART

typedef enum {
  PROCESS_VAR1_TURN_OFF = 0,  // LED on
  PROCESS_VAR1_TURN_ON,       // LED off
  PROCESS_VAR1_TOGGLE,        // LED toggle
  PROCESS_NOT_SUPPORTED,      // Error
} process_type_def;

process_type_def process_id = PROCESS_NOT_SUPPORTED;


static void blinkyLED(int state) {
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
}

static int processMessage(String text) {
  if (text.startsWith("var1:toggle")) { return PROCESS_VAR1_TOGGLE; } 
  else if (text.startsWith("var1:0")) { return PROCESS_VAR1_TURN_OFF; } 
  else if (text.startsWith("var1:1")) { return PROCESS_VAR1_TURN_ON;  }
  else { return PROCESS_NOT_SUPPORTED; }
}

void setup() {
  Serial.begin(115200);

  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW

  // reserve 200 bytes for the inputString:
  inputString.reserve(200);
}

void loop() {
  
  if (stringComplete) {
    // Receive a string from UART
    //
    // (Debug) print the string when a newline arrives:
    //Serial.print("DEBUG> ");Serial.println(inputString);
    
    process_id = processMessage(inputString);
    switch(process_id) {
      case PROCESS_VAR1_TURN_OFF: { state = 0; break;}
      case PROCESS_VAR1_TURN_ON: { state = 1; break;}
      case PROCESS_VAR1_TOGGLE : {
        state == 0 ? state = 1 : state = 0;  // Toggle LED
        break;
      }
      default:{ /* PROCESS_NOT_SUPPORTED */ break;}
    }
    // change LED state base on incoming message
    blinkyLED(state);  // Turn ON/OFF LED

    // feedback PC via UART
    sendSerial = true;

    // Reset variables
    count = 0;  // reset counter
    process_id = PROCESS_NOT_SUPPORTED;
    inputString = "";  // clear the string:
    stringComplete = false;
  } 
  else {
    // Send UART if not receive any data from PC
    // and automaticaclly toggle LED
    count++;
    if( count == 15)
    {
      count = 0;  // reset counter
      // Automatically change state
      state == 0 ? state = 1 : state = 0;  // Toggle LED
      blinkyLED(state);  // Turn ON/OFF LED
      // Periodically response to PC after every 3s ( 3000[ms] = 200 * 15 )
      sendSerial = true;
    }
    delay(200);
    
  }

  if(sendSerial)
  {
    sendSerial = false;
    Serial.print("var1:");Serial.print(state);Serial.print("\r\n");  // LED state
  }
}

/*
  SerialEvent occurs whenever a new data comes in the hardware serial RX. This
  routine is run between each time loop() runs, so using delay inside loop can
  delay response. Multiple bytes of data may be available.
*/
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag so the main loop can
    // do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

