#include <PS2X_lib.h>
#include <PID_v1.h>
#define SPEED_CONST 230

// ENCODERS PINS
#define EFLA 45
#define EFLB 19
#define EFRA 43
#define EFRB 18
#define EBLA 39
#define EBLB 21
#define EBRA 41
#define EBRB 20

// MOTOR PINS
#define MFL1 3
#define MFL2 2
#define MFR1 5
#define MFR2 4
#define MBL1 8
#define MBL2 9
#define MBR1 6
#define MBR2 7

enum State {
  STOP, FWL, FWD, FWR, LEFT, CW, ACW, RIGHT, BWL, BWD, BWR
};

int timeD = 10; //ms

double pwmFL = 0;
double pwmFR = 0;
double pwmBL = 0;
double pwmBR = 0;

double speedFL = 0;
double speedFR = 0;
double speedBL = 0;
double speedBR = 0;

volatile long cntFL = 0;
volatile long cntFR = 0;
volatile long cntBL = 0;
volatile long cntBR = 0;

double SetFL, SetFR, SetBL, SetBR;
double Kp = 2, Ki = 1.5, Kd = 0.5;

PID flPID(&speedFL, &pwmFL, &SetFL, Kp, Ki, Kd, DIRECT);
PID frPID(&speedFR, &pwmFR, &SetFR, Kp, Ki, Kd, DIRECT);
PID blPID(&speedBL, &pwmBL, &SetBL, Kp, Ki, Kd, DIRECT);
PID brPID(&speedBR, &pwmBR, &SetBR, Kp, Ki, Kd, DIRECT);

PS2X ps2x;
int speedPID= 120;
int speedOpen = 100;
State state = STOP;
bool isOpen = true;

void setup() {
  Serial2.begin(9600);   // bluetooth
  pinMode(MFL1, OUTPUT);
  pinMode(MFL2, OUTPUT);
  pinMode(MFR1, OUTPUT);
  pinMode(MFR2, OUTPUT);
  pinMode(MBL1, OUTPUT);
  pinMode(MBL2, OUTPUT);
  pinMode(MBR1, OUTPUT);
  pinMode(MBR2, OUTPUT);
  pinMode(EFLA, INPUT);
  pinMode(EFRA, INPUT);
  pinMode(EBLA, INPUT);
  pinMode(EBRA, INPUT);
  pinMode(EFLB, INPUT);
  attachInterrupt(digitalPinToInterrupt(EFLB), encoderFL, FALLING); 
  attachInterrupt(digitalPinToInterrupt(EFRB), encoderFR, FALLING); 
  attachInterrupt(digitalPinToInterrupt(EBLB), encoderBL, FALLING); 
  attachInterrupt(digitalPinToInterrupt(EBRB), encoderBR, FALLING);
  //setup pins and settings:  GamePad(clock, command, attention, data, Pressures?, Rumble?)
  ps2x.config_gamepad(31,33,35,37, true, true); 
  SetFL = SetFR = SetBL = SetBR = 60;
  flPID.SetMode(AUTOMATIC);
  frPID.SetMode(AUTOMATIC);
  blPID.SetMode(AUTOMATIC);
  brPID.SetMode(AUTOMATIC);
  flPID.SetSampleTime(100);
  frPID.SetSampleTime(100);
  blPID.SetSampleTime(100);
  brPID.SetSampleTime(100);
}

void loop() {
  // joystick control
  ps2x.read_gamepad(false, 0);
  if(ps2x.ButtonPressed(PSB_L3)) {  
    speedOpen = 255 - ps2x.Analog(PSS_RY);
  } else if(ps2x.ButtonPressed(PSB_R3)) {  
    speedOpen = 255 - ps2x.Analog(PSS_LY);
  } else if(ps2x.ButtonPressed(PSB_PAD_RIGHT)) {  
         state = RIGHT;
  } else if(ps2x.ButtonPressed(PSB_BLUE)) {           
         speedOpen = 100;
  } else if(ps2x.ButtonPressed(PSB_GREEN)) {           
         speedOpen = 255;
  } else if(ps2x.ButtonPressed(PSB_PAD_LEFT)) {          
         state = LEFT;
  } else if(ps2x.ButtonPressed(PSB_PAD_DOWN)) {        
         state = BWD;
  } else if(ps2x.ButtonPressed(PSB_PAD_UP)) {            
         state = FWD;
  } else if(ps2x.ButtonPressed(PSB_RED)) {            
         state = CW;
  } else if(ps2x.ButtonPressed(PSB_PINK)) {          
         state = ACW;
  } else if(ps2x.ButtonPressed(PSB_L1)) {            
         state = FWL;
  } else if(ps2x.ButtonPressed(PSB_L2)) {            
         state = BWL;
  } else if(ps2x.ButtonPressed(PSB_R1)) {            
         state = FWR;
  } else if(ps2x.ButtonPressed(PSB_R2)) {            
         state = BWR;
  } else if(ps2x.ButtonReleased(PSB_L1) || 
            ps2x.ButtonReleased(PSB_L2) || 
            ps2x.ButtonReleased(PSB_R1) || 
            ps2x.ButtonReleased(PSB_R2) ||
            ps2x.ButtonReleased(PSB_PINK) ||
            ps2x.ButtonReleased(PSB_RED) ||
            ps2x.ButtonReleased(PSB_PAD_UP) ||
            ps2x.ButtonReleased(PSB_PAD_DOWN) ||
            ps2x.ButtonReleased(PSB_PAD_LEFT) ||
            ps2x.ButtonReleased(PSB_PAD_RIGHT))  {
         state = STOP;
         stop();
  }

  // bluetooth control
  if (Serial2.available() > 0){
    String command = Serial2.readStringUntil('\n');
    if (command == "stop") {
      state = STOP;
      stop();
    } else if (command == "open") {
      isOpen = true; 
    } else if (command[0] == 'P'){ 
      // PID set
      isOpen = false;
      double kp = command.substring(1, 6).toDouble();
      double ki = command.substring(6, 11).toDouble();
      double kd = command.substring(11, 16).toDouble();
      flPID.SetTunings(kp, ki, kd);
      frPID.SetTunings(kp, ki, kd);
      blPID.SetTunings(kp, ki, kd);
      brPID.SetTunings(kp, ki, kd);
    } else if (command == "fwd"){
      state = FWD;
    } else if (command == "back"){
      state = BWD;
    } else if (command == "left"){
      state = LEFT;
    } else if (command == "right"){
      state = RIGHT;
    } else if (command == "fwl") {
      state = FWL;
    } else if (command == "fwr") {
      state = FWR;
    } else if (command == "bwl") {
      state = BWL;
    } else if (command == "bwr") {
      state = BWR;
    } else if (command == "clockwise") {
      state = CW;
    } else if (command == "anticlockwise") {
      state = ACW;
    } else if (isDigit(command[0])) {
      speedPID= map(command.toInt(), 0, 100, 0, SPEED_CONST);
      speedOpen = map(command.toInt(), 0, 100, 0, 255);
    }
  }

   // calculate speed
   long prevFL = cntFL;
   long prevFR = cntFR;
   long prevBL = cntBL;
   long prevBR = cntBR;
   delay(timeD);
   speedFL = abs(cntFL - prevFL) * 10;
   speedFR = abs(cntFR - prevFR) * 10;
   speedBL = abs(cntBL - prevBL) * 10;
   speedBR = abs(cntBR - prevBR) * 10;
   
   
   if (!isOpen){
    // close-loop - with PID
     switch(state){
      case STOP: stop(); break;
      case FWL: diagonalFL(speedPID); break;
      case FWD: forward(speedPID); break;
      case FWR: diagonalFR(speedPID); break;
      case LEFT: left(speedPID); break;
      case CW: clockWise(speedPID); break;
      case ACW: antiClockWise(speedPID); break;
      case RIGHT: right(speedPID); break;
      case BWL: diagonalBL(speedPID); break;
      case BWD: backward(speedPID); break;
      case BWR: diagonalBR(speedPID); break;
     }
   } else {
    // open-loop
    switch(state){
      case STOP: stop(); break;
      case FWL: diagonalFLO(speedOpen); break;
      case FWD: forwardO(speedOpen); break;
      case FWR: diagonalFRO(speedOpen); break;
      case LEFT: leftO(speedOpen); break;
      case CW: clockWiseO(speedOpen); break;
      case ACW: antiClockWiseO(speedOpen); break;
      case RIGHT: rightO(speedOpen); break;
      case BWL: diagonalBLO(speedOpen); break;
      case BWD: backwardO(speedOpen); break;
      case BWR: diagonalBRO(speedOpen); break;
     }
   }
}

void encoderFL(){
  if (digitalRead(EFLA)){
    cntFL--;
   } else {
    cntFL++;
   }
}

void encoderFR(){
  if (digitalRead(EFRA)){
    cntFR++;
   } else {
    cntFR--;
   }
}

void encoderBL(){
  if (digitalRead(EBLA)){
    cntBL--;
   } else {
    cntBL++;
   }
}

void encoderBR(){
  if (digitalRead(EBRA)){
    cntBR++;
   } else {
    cntBR--;
   }
}

void stop(){
  SetFL = SetFR = SetBL = SetBR = 0;
  analogWrite(MFL1, 0);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, 0);
}


void forward(int sp){
  SetFL = SetFR = SetBL = SetBR = sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, ceil(pwmFL));
  analogWrite(MFL2, 0);
  analogWrite(MFR1, ceil(pwmFR));
  analogWrite(MFR2, 0);
  analogWrite(MBL1, ceil(pwmBL));
  analogWrite(MBL2, 0);
  analogWrite(MBR1, ceil(pwmBR));
  analogWrite(MBR2, 0);
}

void backward(int sp){
  SetFL = SetFR = SetBL = SetBR = sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, ceil(pwmFL));
  analogWrite(MFR1, 0);
  analogWrite(MFR2, ceil(pwmFR));
  analogWrite(MBL1, 0);
  analogWrite(MBL2, ceil(pwmBL));
  analogWrite(MBR1, 0);
  analogWrite(MBR2, ceil(pwmBR));
}


void left(int sp){
  SetFL = SetFR = SetBL = SetBR = sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, ceil(pwmFL));
  analogWrite(MFR1, ceil(pwmFR));
  analogWrite(MFR2, 0);
  analogWrite(MBL1, ceil(pwmBL));
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, ceil(pwmBR));
}


void right(int sp){
  SetFL = SetFR = SetBL = SetBR = sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, ceil(pwmFL));
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, ceil(pwmFR));
  analogWrite(MBL1, 0);
  analogWrite(MBL2, ceil(pwmBL));
  analogWrite(MBR1, ceil(pwmBR));
  analogWrite(MBR2, 0);
}

void diagonalFR(int sp){
  SetFL = SetBR = sp;
  flPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, ceil(pwmFL));
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, ceil(pwmBR));
  analogWrite(MBR2, 0);
}


void diagonalFL(int sp){
  SetFR = SetBL = sp;
  frPID.Compute();
  blPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, ceil(pwmFR));
  analogWrite(MFR2, 0);
  analogWrite(MBL1, ceil(pwmBL));
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, 0);
}


void diagonalBL(int sp){
  SetFL = SetBR = sp;
  flPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, ceil(pwmFL));
  analogWrite(MFR1, 0);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, ceil(pwmBR));
}

void diagonalBR(int sp){
  SetFR = SetBL = sp;
  frPID.Compute();
  blPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, ceil(pwmFR));
  analogWrite(MBL1, 0);
  analogWrite(MBL2, ceil(pwmBL));
  analogWrite(MBR1, 0);
  analogWrite(MBR2, 0);
}


void clockWise(int sp){
  SetFL = SetFR = SetBL = SetBR= sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, ceil(pwmFL));
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, ceil(pwmFR));
  analogWrite(MBL1, ceil(pwmBL));
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, ceil(pwmBR));
}

void antiClockWise(int sp){
  SetFL = SetFR = SetBL = SetBR = sp;
  flPID.Compute();
  frPID.Compute();
  blPID.Compute();
  brPID.Compute();
  analogWrite(MFL1, 0);
  analogWrite(MFL2, ceil(pwmFL));
  analogWrite(MFR1, ceil(pwmFR));
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, ceil(pwmBL));
  analogWrite(MBR1, ceil(pwmBR));
  analogWrite(MBR2, 0);
}

void forwardO(int sp){
  analogWrite(MFL1, sp);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, sp);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, sp);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, sp);
  analogWrite(MBR2, 0);
}


void backwardO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, sp);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, sp);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, sp);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, sp);
}


void leftO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, sp);
  analogWrite(MFR1, sp);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, sp);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, sp);
}


void rightO(int sp){
  analogWrite(MFL1, sp);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, sp);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, sp);
  analogWrite(MBR1, sp);
  analogWrite(MBR2, 0);
}

void diagonalFRO(int sp){
  analogWrite(MFL1, sp);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, sp);
  analogWrite(MBR2, 0);
}


void diagonalFLO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, sp);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, sp);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, 0);
}


void diagonalBLO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, sp);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, sp);
}

void diagonalBRO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, sp);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, sp);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, 0);
}


void clockWiseO(int sp){
  analogWrite(MFL1, sp);
  analogWrite(MFL2, 0);
  analogWrite(MFR1, 0);
  analogWrite(MFR2, sp);
  analogWrite(MBL1, sp);
  analogWrite(MBL2, 0);
  analogWrite(MBR1, 0);
  analogWrite(MBR2, sp);
}

void antiClockWiseO(int sp){
  analogWrite(MFL1, 0);
  analogWrite(MFL2, sp);
  analogWrite(MFR1, sp);
  analogWrite(MFR2, 0);
  analogWrite(MBL1, 0);
  analogWrite(MBL2, sp);
  analogWrite(MBR1, sp);
  analogWrite(MBR2, 0);
}
