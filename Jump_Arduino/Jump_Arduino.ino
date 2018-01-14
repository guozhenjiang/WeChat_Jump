#include <Servo.h>

/*
	Arduino:
	int:	-32,768			to	32,767
	long:	-2,147,483,648	to	2,147,483,647
*/

String	PressMsg = "";				// a String to hold incoming data
String	PressMsg_angle_press = "";
String	PressMsg_ms = "";
String	PressMsg_angle_release = "";

boolean PressCmd_Update = false;	// whether the string is complete

Servo SmartFinger;

int Angle_Pressed = 0;
int Press_ms = 0;
int Angle_Release = 0;

long ExCnt = 0;

void setup()
{
	Serial.begin(115200);
	
	PressMsg.reserve(200);			// reserve 200 bytes for the PressMsg:
	
	SmartFinger.attach(9);			// Pin of Servo
	
	SmartFinger.write(90);			// Init angle
	delay(2000);
	
	Serial.println("Servo Control is ready.");
}

void loop()
{
	int split_angle_press;
	int split_ms;
	int split_angle_release;
	
	if(PressCmd_Update)
	{
		PressCmd_Update = false;
		
		split_angle_press = PressMsg.indexOf(',');
		
		if(split_angle_press != -1)
		{
			split_ms = PressMsg.indexOf(',', split_angle_press+1);
			
			if(split_ms != -1)
			{
				split_angle_release = PressMsg.indexOf(',', split_ms+1);
				
				PressMsg_angle_press	= PressMsg.substring(0, split_angle_press);
				PressMsg_ms				= PressMsg.substring(split_angle_press+1, split_ms);
				PressMsg_angle_release	= PressMsg.substring(split_ms+1);
				
				Angle_Pressed = PressMsg_angle_press.toInt();
				Press_ms = PressMsg_ms.toInt();
				Angle_Release = PressMsg_angle_release.toInt();
				
				/*
				Serial.print("PressMsg_angle_press:");
				Serial.println(PressMsg_angle_press);
				
				Serial.print("PressMsg_ms:");
				Serial.println(PressMsg_ms);
				
				Serial.print("PressMsg_angle_release:");
				Serial.println(PressMsg_angle_release);
				*/
				
				if(Press_ms > 0)
				{
					SmartFinger.write(Angle_Pressed);
					delay(Press_ms);
					SmartFinger.write(Angle_Release);
					
					Serial.println("OK");
				}
			}
		}
		
		PressMsg = "";
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
	
	while(Serial.available())
	{
		inChar = (char)Serial.read();
		
		PressMsg += inChar;
		
		if(inChar == '\n')
		{
			PressCmd_Update = true;
		}
	}
}

