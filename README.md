# Design Pattern

## Creational
1. Builder
2. Prototype
3. Singleton
4. **Asbtract Factory**\
  Tạo ra một lớp có khả năng cung cấp các *instance* cho một nhóm đối tượng có liên quan mà không cần chỉ định các lớp cụ thể.\
![Abstract-Factory-Diagram](/assets/diagrams/abstract-factory-diagram.png "Abstract Factory Class Diagram")
6. Factory method

## Structural
1. **Proxy**\
  Bọc lớp service chính bằng một lớp Proxy cùng *implement* chung *interface* với lớp service chính. Mọi request từ client điều sẽ được lớp Proxy tiếp nhận trước khi Proxy chuyển lại request đó cho lớp service chính.\
![Proxy-Diagram](/assets/diagrams/proxy-diagram.png "Proxy Class Diagram")
2. **Bridge**\
  Chia một lớp lớn, phức tạp thành 2 lớp nhỏ hơn bao gồm (*Abstraction* và *Implemention*). *Abstraction* là lớp có nhiệm vụ đại diện nhận các request từ client và sau đó sẽ gọi phương thức thích hợp từ lớp *Implementation*.\
  ![Bridge-Diagram](/assets/diagrams/bridge-diagram.png "Bridge Class Diagram")
