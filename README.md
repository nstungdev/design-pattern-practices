# Design Pattern

## Creational
1. Builder
2. Prototype
3. Singleton
4. Asbtract Factory
5. Factory method

## Structural
1. **Proxy**\
  Bọc lớp service chính bằng một lớp Proxy cùng *implement* chung *interface* với lớp service chính. Mọi request từ client điều sẽ được lớp Proxy tiếp nhận trước khi Proxy chuyển lại request đó cho lớp service chính.
