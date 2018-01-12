#include <Servo.h>

/*
	Arduino:
	long: -2,147,483,648 to 2,147,483,647
*/

String	PressMsg = "";				// a String to hold incoming data
boolean PressCmd_Update = false;	// whether the string is complete
int		Press_ms = 0;

Servo SmartFinger;
const int Angle_Pressed = 45;
const int Angle_Release = 60;

long ExCnt = 0;

void setup()
{
	Serial.begin(9600);
	
	PressMsg.reserve(200);			// reserve 200 bytes for the PressMsg:
	
	SmartFinger.attach(9);			// Pin of Servo
	
	SmartFinger.write(90);			// Init angle
	delay(2000);
	
	Serial.println("Servo Control is ready.");
}

void loop()
{
	if(PressCmd_Update && (Press_ms > 0))
	{
		PressCmd_Update = false;
		
		Serial.print("\t");
		Serial.print(++ExCnt, DEC);
		Serial.print("\t");
		Serial.print(Press_ms, DEC);
		Serial.print("ms\t");
		
		SmartFinger.write(Angle_Pressed);
		delay(Press_ms);
		SmartFinger.write(Angle_Release);
		
		Serial.println("OK");
	}
}

/*
  SerialEvent occurs whenever a new data comes in the hardware serial RX. This
  routine is run between each time loop() runs, so using delay inside loop can
  delay response. Multiple bytes of data may be available.
*/
void serialEvent()
{
	char inChar;
	
	while (Serial.available())
	{
		inChar = (char)Serial.read();
		
		PressMsg += inChar;
		
		if (inChar == '\n')
		{
			Press_ms = PressMsg.toInt();
			
			PressMsg = "";
			PressCmd_Update = true;
		}
	}
}

