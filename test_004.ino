// LEDのピン番号
int LED = 13;
char data;

void setup() {
  // LEDピンを出力モードに設定
  pinMode(LED, OUTPUT);
  // シリアル通信の準備
  Serial.begin(9600);
}

void loop() {
  while (Serial.available()) {
    data = Serial.read();

    if (data == '1') {
      digitalWrite(LED, HIGH);
    } else if (data == '2') {
      digitalWrite(LED, LOW);
    }
  }

  // 適度に間隔を開ける
  delay(10);
}
